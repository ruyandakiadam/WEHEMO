using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WeHeMo.Service.WCF;
using WeHeMo.Service.Contract;
using WeHeMo.DTO;
using WeHeMo.Business;

namespace WeHeMo.Service.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public Guid CustomerAdd(string name, string email, string password)
        {
            var customer = new Customer();
            return customer.Add(name, email, password);
        }

        public DTO_Customer CustomerGet(Guid customerid)
        {
            var customer = new Customer();
            return customer.Get_Customer(customerid);
        }

        public Guid? CustomerLogin(string email, string password)
        {
            var customer = new Customer();
            return customer.Login(email, password);
        }

        public void CustomerUpdate(Guid customerid, string name, string email, string password)
        {
            var customer = new Customer();
            customer.Update(customerid, name, email, password);
        }

        public DTO_Test_Report[] TestGetTestReport(Guid testid)
        {
            var test = new Test();
            return test.GetTestReport(testid);
        }

        public Guid TestAdd(Guid customerid, string url)
        {
            var test = new Test();
            return test.Add(customerid, url);
        }

        public void TestDelete(Guid testid)
        {
            var test = new Test();
            test.Delete(testid);
        }

        public DTO_Test[] TestList(Guid customerid)
        {
            var test = new Test();
            return test.ListDto(customerid);
        }
    }
}
