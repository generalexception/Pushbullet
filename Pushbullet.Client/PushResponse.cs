using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pushbullet.Client
{
    public class Data
    {
        public object notification_id { get; set; }
        public object package_name { get; set; }
        public string file_type { get; set; }
        public string file_name { get; set; }
        public string sender_email_normalized { get; set; }
        public object notification_tag { get; set; }
        public string receiver_iden { get; set; }
        public string receiver_email_normalized { get; set; }
        public string title { get; set; }
        public long target_device_id { get; set; }
        public bool dismissed { get; set; }
        public object dismissable { get; set; }
        public string receiver_email { get; set; }
        public int notification_duration { get; set; }
        public string type { get; set; }
        public string body { get; set; }
        public long receiver_id { get; set; }
        public object source_device_id { get; set; }
        public long sender_id { get; set; }
        public string target_device_iden { get; set; }
        public string address { get; set; }
        public bool active { get; set; }
        public string sender_iden { get; set; }
        public object icon { get; set; }
        public string account { get; set; }
        public string owner_iden { get; set; }
        public string name { get; set; }
        public double created { get; set; }
        public string url { get; set; }
        public List<object> items { get; set; }
        public object file_url { get; set; }
        public double modified { get; set; }
        public string sender_email { get; set; }
        public object application_name { get; set; }
        public object source_device_iden { get; set; }
    }

    public class PushResponse
    {
        public object notification_id { get; set; }
        public string iden { get; set; }
        public object package_name { get; set; }
        public string file_type { get; set; }
        public string sender_email_normalized { get; set; }
        public object notification_tag { get; set; }
        public string receiver_iden { get; set; }
        public long id { get; set; }
        public string receiver_email_normalized { get; set; }
        public string title { get; set; }
        public long target_device_id { get; set; }
        public bool dismissed { get; set; }
        public object dismissable { get; set; }
        public string receiver_email { get; set; }
        public int state { get; set; }
        public int notification_duration { get; set; }
        public string file_name { get; set; }
        public long device_id { get; set; }
        public string type { get; set; }
        public string body { get; set; }
        public long receiver_id { get; set; }
        public object source_device_id { get; set; }
        public long sender_id { get; set; }
        public string target_device_iden { get; set; }
        public string address { get; set; }
        public bool active { get; set; }
        public string sender_iden { get; set; }
        public Data data { get; set; }
        public object icon { get; set; }
        public string account { get; set; }
        public string owner_iden { get; set; }
        public string name { get; set; }
        public long created { get; set; }
        public string url { get; set; }
        public List<object> items { get; set; }
        public object file_url { get; set; }
        public long modified { get; set; }
        public string sender_email { get; set; }
        public object application_name { get; set; }
        public object source_device_iden { get; set; }
    }
}
