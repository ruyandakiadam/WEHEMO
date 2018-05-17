using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeHeMo.DTO;

namespace WeHeMo.Business
{
    public interface ITest
    {
        Guid Add(Guid customerid, string url);
        void SaveResult(Guid testid, int statuscode);
        Dictionary<Guid, String> List(); //key TestId, Value:url
        void Delete(Guid testid);
        DTO_Test[] ListDto(Guid customerid);
        DTO_Test_Report[] GetTestReport(Guid testid);
    }
}
