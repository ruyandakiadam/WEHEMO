using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using WeHeMo.Service.Contract;
using WeHeMo.WCF.Contract;

namespace WeHeMo.Web.Form
{
    public class BasePage : Page
    {
        private ChannelFactory<IService> ServiceFactory { get; set; }
        public IService Service { get; private set; }

        public BasePage()
        {
            var address = new EndpointAddress("http://localhost:13251/Service.svc");
            var basic = new BasicHttpBinding();
            ServiceFactory = new ChannelFactory<IService>(basic, address);
            Service = ServiceFactory.CreateChannel();
        }

        public string CustomerIDStr { get; } = "CustomerID";

        public Guid CustomerID
        {
            get
            {
                if (Session[CustomerIDStr] != null)
                    return new Guid(Session[CustomerIDStr].ToString());
                else
                    return Guid.Empty;
            }
            set
            {
                Session[CustomerIDStr] = value;
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