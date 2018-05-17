using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using WeHeMo.DTO;


namespace WeHeMo.Business
{
    public class Test : ITest
    {
        public Guid Add(Guid customerid, string url)
        {
            var item = new TEST();

            item.Id = Guid.NewGuid();
            item.CustomerId = customerid;
            item.Url = url;
            item.CreateDate = DateTime.Now;

            using (WeHeMoDataContext dc = new WeHeMoDataContext())
            {
                dc.TESTs.InsertOnSubmit(item);
                dc.SubmitChanges();
            }
            return item.Id;
        }
        public void Delete(Guid testid)
        {
            using (var dc = new WeHeMoDataContext())
            {
                var item = dc.TESTs.Where(c => c.Id == testid).First();
                dc.TESTs.DeleteOnSubmit(item);
                dc.SubmitChanges();
            }
        }
        public DTO_Test[] ListDto(Guid customerid)
        {
            using (var dc = new WeHeMoDataContext())
            {
                return (from t in dc.TESTs
                        join s in dc.STATUS_CODEs on t.StatusCode equals s.Code into sTmp
                        from sResult in sTmp.DefaultIfEmpty() //left join
                        where t.CustomerId == customerid
                        orderby t.CreateDate descending
                        select new DTO_Test
                        {
                            Id = t.Id,
                            Url = t.Url,
                            Code = t.StatusCode,
                            Status = sResult.Description,
                            Succeed = (t.StatusCode == null ? null : (bool?)(t.StatusCode == 200)),    // null ? null default(bool?) or new Nullable<bool?>
                            Date = t.TestDate
                        }).ToArray();
            }
        }
        public Dictionary<Guid, String> List()
        {
            using (var dc = new WeHeMoDataContext())
            {
                return dc.TESTs.Select(c => new { c.Id, c.Url }).ToDictionary(c => c.Id, c => c.Url);
            }
        }
        public DTO_Test_Report[] GetTestReport(Guid testid)
        {
            using (var dc = new WeHeMoDataContext())
            {
                return (from t in dc.TEST_RESULTs
                        join s in dc.STATUS_CODEs on t.StatusCode equals s.Code
                        where t.TestId == testid
                        orderby t.CreateDate descending
                        select new DTO_Test_Report
                        {
                            Description = s.Description,
                            Succeed = t.StatusCode == 200,
                            TestDate = t.CreateDate
                        }).ToArray();
            }
        }
        public void SaveResult(Guid testid, int statuscode)
        {
            using (var dc = new WeHeMoDataContext())
            {
                var test = dc.TESTs.Where(c => c.Id == testid).First();
                // var firstError = test.StatusCode != null && test.StatusCode == 200;
                var sendMail = statuscode != 200 && test.StatusCode != statuscode; //Hata olma durumu test.statuscode!=statuscode
                var successMail = statuscode == 200 && test.StatusCode != 200 && test.StatusCode != null; //Hata sonunda erişim durumu
                var time1 = dc.TEST_RESULTs.Where(c => c.TestId == testid && c.StatusCode == 200).OrderByDescending(c => c.CreateDate).Select(c => c.CreateDate).FirstOrDefault();


                test.StatusCode = statuscode;
                test.TestDate = DateTime.Now;

                var test_result = new TEST_RESULT();
                test_result.Id = Guid.NewGuid();
                test_result.TestId = testid;
                test_result.StatusCode = statuscode;
                test_result.CreateDate = DateTime.Now;
                dc.TEST_RESULTs.InsertOnSubmit(test_result);

                dc.SubmitChanges();

                if (sendMail)
                {
                    var email = dc.TESTs.Where(c => c.Id == testid).Select(c => new { c.Url, c.CUSTOMER.Email }).First();
                    var error = dc.STATUS_CODEs.Where(c => c.Code == statuscode).Select(c => c.Description).First();

                    var client = new SmtpClient();
                    client.Host = "srvm07.trwww.com";
                    client.Port = 587;
                    client.EnableSsl = false;
                    client.Credentials = new NetworkCredential("wehemo@exedra.com.tr", "W3hemomail"); //sunucuda username:password

                    var message = new MailMessage();
                    message.Body = "Sayın Yetkili,<br>" + email.Url + " adresine sahip sayfada sorun tespit edilmiştir.<br>" + "Alınan Hata: <span style:color:red>" + error + "</span><br>WEHEME Team";
                    message.IsBodyHtml = true;
                    message.Subject = "WEHEMO Notification";
                    message.From = new MailAddress("wehemo@exedra.com.tr");
                    message.To.Add("talipturkmentr@gmail.com.tr");
                    client.Send(message);
                }
                if (successMail)
                {
                    var fark = DateTime.Now.Subtract(time1).TotalHours;
                    var email = dc.TESTs.Where(c => c.Id == testid).Select(c => new { c.Url, c.CUSTOMER.Email }).First();
                    var client = new SmtpClient();
                    client.Host = "srvm07.trwww.com";
                    client.Port = 587;
                    client.EnableSsl = false;
                    client.Credentials = new NetworkCredential("wehemo@exedra.com.tr", "W3hemomail");

                    var message = new MailMessage();
                    message.Body = "Sayın Yetkili,<br>" + fark + "saattir erişilemeyen " + email.Url + " adresinize erişim sağlanmıştır.<br>WEHEME Team";
                    message.IsBodyHtml = true;
                    message.Subject = "WEHEMO Notification";
                    message.From = new MailAddress("wehemo@exedra.com.tr"); //Kimden
                    message.To.Add("talipturkmentr@gmail.com.tr");    //Kime "email.email"
                    client.Send(message);

                }
            }
        }
    }
}
