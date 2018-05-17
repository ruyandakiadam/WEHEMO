using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeHeMo.DTO;

namespace WeHeMo.Business
{
    public class Customer : ICustomer
    {
        public Guid Add(string name, string eMail, string password)
        {
            var item = new CUSTOMER();

            item.Id = Guid.NewGuid();
            item.Name = name;
            item.Email = eMail;
            item.Password = password;
            item.CreateDate = DateTime.Now;

            using (WeHeMoDataContext dc = new WeHeMoDataContext())
            {
                dc.CUSTOMERs.InsertOnSubmit(item);
                dc.SubmitChanges();
            }
            return item.Id;
        }
        public Guid? Login(string email, string password)
        {
            using (var dc = new WeHeMoDataContext())
            {
                var id = dc.CUSTOMERs.Where(c => c.Email == email && c.Password == password).Select(c => c.Id).FirstOrDefault();

                if (id == default(Guid))
                {
                    return null;
                }
                return id;
            }
        }
        public void Update(Guid customerId, string name, string email, string password)
        {
            using (var dc = new WeHeMoDataContext())
            {
                var item = dc.CUSTOMERs.Where(c => c.Id == customerId).First();
                item.Name = name;
                item.Email = email;
                item.Password = password;
                item.UpdateDate = DateTime.Now;
                dc.SubmitChanges();
            }
        }

        public DTO_Customer Get_Customer(Guid customerid)
        {
            using (var dc = new WeHeMoDataContext())
            {
                return (from t in dc.CUSTOMERs                        
                        where t.Id == customerid
                        select new DTO_Customer
                        {
                            name = t.Name,
                            email = t.Email,
                            password= t.Password
                        }).First();
            }
        }
    }
}
