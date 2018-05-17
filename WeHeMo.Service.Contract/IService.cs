using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WeHeMo.DTO;

namespace WeHeMo.Service.Contract
{
    [ServiceContract]
  public interface IService
    {
        [OperationContract]
        Guid CustomerAdd(string name, string email, string password);
        [OperationContract]
        Guid? CustomerLogin(string email, string password);
        [OperationContract]
        DTO_Customer CustomerGet(Guid customerid);
        [OperationContract]
        void CustomerUpdate(Guid customerid, string name, string email, string password);
        [OperationContract]
        Guid TestAdd(Guid customerid, string url);
        [OperationContract]
        DTO_Test[] TestList(Guid customerid);
        [OperationContract]
        DTO_Test_Report[] TestGetTestReport(Guid testid);
        [OperationContract]
        void TestDelete(Guid testid);

    }
}
