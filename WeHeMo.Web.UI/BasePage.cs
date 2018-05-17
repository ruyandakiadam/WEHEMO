using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using WeHeMo.Service.Contract;

namespace WeHeMo.Web.UI
{
    public class BasePage : Page
    {
        private ChannelFactory<IService> ServiceFactory { get; set; }

        public IService Service { get; private set; }

        public BasePage()
        {
            var address = new EndpointAddress("http://localhost:52781/Service.svc");
            var binding = new BasicHttpBinding();
            ServiceFactory = new ChannelFactory<IService>(binding, address);
            Service = ServiceFactory.CreateChannel();
        }

        public string CustomerIDstr { get; } = "CustomerID";

        public string TestIDstr { get; } = "TestID";

        public Guid TestID
        {
            get
            {
                if (Session[TestIDstr] != null)
                    return new Guid(Session[TestIDstr].ToString());
                else
                    return Guid.Empty;
            }
            set
            {
                Session[TestIDstr] = value;
            }
        }
        public Guid CustomerID
        {
            get
            {
                if (Session[CustomerIDstr] != null)
                    return new Guid(Session[CustomerIDstr].ToString());
                else
                    return Guid.Empty;
            }

            set
            {
                Session[CustomerIDstr] = value;
            }
        }
        public override void Dispose()
        {
            ServiceFactory.Close();
            ServiceFactory = null;
            base.Dispose();
        }
    }
}