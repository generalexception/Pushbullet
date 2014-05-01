using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushbullet.Client
{
    public class Extras
    {
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string android_version { get; set; }
        public string sdk_version { get; set; }
        public string app_version { get; set; }
        public string nickname { get; set; }
    }

    public class Device
    {
        public string iden { get; set; }
        public Extras extras { get; set; }
    }

    public class Devices
    {
        public List<Device> devices { get; set; }
    }
}
