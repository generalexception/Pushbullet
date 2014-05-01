using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;

namespace Pushbullet.Client
{
    public static class PushbulletService
    {
        public static string APIKEY { get; set; }

        private static WebClient AuthenticatedWebClient(string apikey)
        {
            WebClient client = new WebClient();
            string authEncoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(APIKEY + ":"));
            client.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", authEncoded);
            return client;
        }

        public static Devices GetDevices()
        {
            const string URL = "https://api.pushbullet.com/api/devices";

            string devices = AuthenticatedWebClient(APIKEY).DownloadString(URL);
            return JsonConvert.DeserializeObject<Devices>(devices);
        }

        public static PushResponse Push(PushMessage p)
        {
            const string URL = "https://api.pushbullet.com/api/pushes";

            string response = AuthenticatedWebClient(APIKEY).UploadString(URL, p.GetData());
            return JsonConvert.DeserializeObject<PushResponse>(response);
        }

       
    }
}
