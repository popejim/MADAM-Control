using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MADAM_Control.Classes
{
    public class Companies
    {
        public string CompName { get; set; }
        public string CompAddrLine1 { get; set; }
        public string CompAddrLine2 { get; set; }
        public string CompAddrLine3 { get; set; }
        public string CompPostcode { get; set; }
        public string CompTelNo { get; set; }
        public IPAddress CompServerIp { get; set; }
        public string CompContactName { get; set; }
        public string CompContactEmail { get; set; }
        public List<Device> DeviceList { get; set; }

    }
}
