using ICSharpCode.SharpZipLib.BZip2;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using System.Xml;
using System.Xml.Linq;

namespace Modbot
{
    class Feed
    {
        private string default_url = "http://clientupdate-v6.cursecdn.com/feed/addons/432/v10/";
        private string complete_url = "complete.json.bz2";
        private string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

        public void Start()
        {           
            if(File.Exists("complete.json") == true)
            {
                console("Complete json found! Updates will be performed once an hour.");
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = 3600000;
                timer.Elapsed += timer_Elapsed;
                timer.Start();
                return;
            }

            string complete_content = default_url + complete_url;
            DownloadFiles(complete_content, complete_url);
            Unpack(complete_url, "complete.json");
        }

        public void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            string complete_content = default_url + complete_url;
            DownloadFiles(complete_content, complete_url);
            Unpack(complete_url, "complete.json");
            console("Updated complete.json");
        }

        public void DownloadFiles(string content, string file)
        {
            WebClient client = new WebClient();
            if(File.Exists(file) == true)
            {
                File.Delete(file);
            }
            console("Downloading " + complete_url);
            client.DownloadFile(content, file);
            console("Download Completed");
        }

        public void Unpack(string packedfile, string unpackedfile)
        {
            console("Unpacking");
            using (var f = File.OpenRead(packedfile))
            {
                using(var decompressor = new Ionic.BZip2.BZip2InputStream(f))
                {
                    var f_out = unpackedfile;
                    using (var output = File.Create(f_out))
                    {
                        var buffer = new byte[2048];
                        int n;
                        while ((n = decompressor.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            output.Write(buffer, 0, n);
                        }
                    }
                }
            }
            console("Unpacking Completed");
        }

        public List<string> Search(string text)
        {
            string json = File.ReadAllText(@"complete.json");

            JObject rss = JObject.Parse(json);

            var mod_ids = new List<string>();
            int modcount = 0;
            foreach (JToken token in rss.SelectTokens("data[*].Name"))
            {
                modcount++;
            }

            for (int i = 0; i < modcount; i++)
            {
                string name = ((string)rss["data"][i]["Name"]);
                if (name.Contains(text))
                {
                    mod_ids.Add((string)rss["data"][i]["Id"] + ": "+ (string)rss["data"][i]["Name"]);
                }
            }
            return mod_ids;           
        }

        public void console(string text)
        {
            Console.WriteLine("[Info] [Feed] " + text);
        }       
    }
}
