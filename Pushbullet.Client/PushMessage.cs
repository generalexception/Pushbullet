using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Pushbullet.Client
{
    public class PushMessage
    {
        public string device_iden { get; set; }
        public IMessageType type { get; set; }

        private int PostItemCount = 0;
        private StringBuilder PostData = new StringBuilder();

        public string GetData()
        {
            AddPostItem("device_iden", device_iden);

            foreach (var item in type.GetPostItems())
            {
                AddPostItem(item.Key, item.Value);
            }

            return PostData.ToString();
        }

        private void AddPostItem(string Name, string Value)
        {
            PostItemCount++;
            PostData.Append((PostItemCount == 1 ? "" : "&") + Name + "=" + HttpUtility.UrlEncode(Value));
        }
    }

    public interface IMessageType
    {
        List<KeyValuePair<string, string>> GetPostItems();
    }

    public class Note : IMessageType
    {
        public string title { get; set; }
        public string body { get; set; }

        public List<KeyValuePair<string, string>> GetPostItems()
        {
            List<KeyValuePair<string, string>> postItems = new List<KeyValuePair<string, string>>();
            postItems.Add(new KeyValuePair<string, string>("type", "note"));
            postItems.Add(new KeyValuePair<string, string>("title", this.title));
            postItems.Add(new KeyValuePair<string, string>("body", this.body));
            return postItems;
        }
    }

    public class Link : IMessageType
    {
        public string title { get; set; }
        public string url { get; set; }

        public List<KeyValuePair<string, string>> GetPostItems()
        {
            List<KeyValuePair<string, string>> postItems = new List<KeyValuePair<string, string>>();
            postItems.Add(new KeyValuePair<string, string>("type", "link"));
            postItems.Add(new KeyValuePair<string, string>("title", this.title));
            postItems.Add(new KeyValuePair<string, string>("url", this.url));
            return postItems;
        }
    }

    public class Address : IMessageType
    {
        public string name { get; set; }
        public string address { get; set; }

        public List<KeyValuePair<string, string>> GetPostItems()
        {
            List<KeyValuePair<string, string>> postItems = new List<KeyValuePair<string, string>>();
            postItems.Add(new KeyValuePair<string, string>("type", "address"));
            postItems.Add(new KeyValuePair<string, string>("name", this.name));
            postItems.Add(new KeyValuePair<string, string>("address", this.address));
            return postItems;
        }
    }

    public class List : IMessageType
    {
        public string title { get; set; }
        public List<string> items { get; set; }

        public List<KeyValuePair<string, string>> GetPostItems()
        {
            List<KeyValuePair<string, string>> postItems = new List<KeyValuePair<string, string>>();
            postItems.Add(new KeyValuePair<string, string>("type", "list"));
            postItems.Add(new KeyValuePair<string, string>("title", this.title));

            foreach (var item in this.items)
            {
                postItems.Add(new KeyValuePair<string, string>("items", item));
            }
            
            return postItems;
        }
    }

    public class File : IMessageType
    {
        public string file { get; set; }

        public List<KeyValuePair<string, string>> GetPostItems()
        {
            throw new System.NotImplementedException();
        }
    }
}
