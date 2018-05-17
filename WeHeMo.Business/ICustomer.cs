using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeHeMo.DTO;

namespace WeHeMo.Business
{
    public interface ICustomer
    {
        Guid Add(string name, string eMail, string password);
        Guid? Login(string email, string password);
        void Update(Guid customerId, string name, string email, string password);
        DTO_Customer Get_Customer(Guid customerid);
    }
}
