using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace Modbot
{
    class Program
    {
        string version = "1.0.2";

        private static LoginService.ClientLoginServiceClient loginService = new LoginService.ClientLoginServiceClient("BinaryHttpsClientLoginServiceEndpoint");
        private static AddOnService.AddOnServiceClient addOnService = new AddOnService.AddOnServiceClient("BinaryHttpAddOnServiceEndpoint");

        static void Main(string[] args)
        {
            new Program().Start();            
        }

        private DiscordClient _client;

        public void Start()
        {
            Feed f = new Feed();

            f.Start();

            // Curse Login
            // var username = ""
            // var password = ""

            // First you must authenticate if successful, the response will contain the authentication token
            var loginResponse = loginService.Login(new LoginService.LoginRequest()
            {
                Username = username,
                Password = password
            });

            // If login succeeds, the Status will be Success and the Session will contain the authentication token
            // If login fails, the Status will contain the reason
            if (loginResponse.Status != LoginService.AuthenticationStatus.Success)
            {
                Console.WriteLine("Login failed: {0}", loginResponse.Status);
                return;
            }

            // An authentication token must be created from the login response and added to the SOAP headers
            // for every request to the addon service. One easy way to do this is by adding an endpoint behavior.
            var token = new AuthenticationToken()
            {
                Token = loginResponse.Session.Token,
                UserID = loginResponse.Session.UserID
            };
            addOnService.ChannelFactory.Endpoint.Behaviors.Add(new AuthTokenExtension(token));

            _client = new DiscordClient(x =>
            {
                x.AppName = "Eva";
                x.AppUrl = "http://colocraft.net/";
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            _client.UsingCommands(x =>
            {
                x.PrefixChar = '-';
                x.AllowMentionPrefix = true;
                x.HelpMode = HelpMode.Public;
            });

            // Discord Bot Token
            // var discordtoken = ""

            Commands();
            
            _client.ExecuteAndWait(async () => 
            {
                await _client.Connect(discordtoken, TokenType.Bot);
            });
        }

        public void Commands()
        {
            var cService = _client.GetService<CommandService>();

            cService.CreateCommand("version")
                .Description("Returns bot version")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Bot version: " + version);
                });

            cService.CreateCommand("search")
                .Description("Search for mod IDs by name")
                .Parameter("text", ParameterType.Unparsed)
                .Do(async (e) =>
                {
                    Feed f = new Feed();
                    string searchtext = e.GetArg("text");

                    IList<string> modids = new List<string>();

                    int y = 0;
                    foreach (var id in f.Search(searchtext))
                    {
                        modids.Add(id);
                        y = y + 1;
                    }
                    await e.Channel.SendMessage("You searched for " + searchtext + " found " + y + " results");

                    string modids_cleaned = string.Join(", \n", modids);

                    if (modids.Count < 1)
                    {
                        return;
                    }
                    else
                    {
                        await e.Channel.SendMessage("```" + modids_cleaned + "```");
                    }
                });

            cService.CreateCommand("find")
                .Parameter("modid", ParameterType.Required)
                .Parameter("arg", ParameterType.Optional)
                .Description("Example: -find 64578 description | Parameters: description, files, changelog")
                .Do(async (e) =>
                {
                    int x = Convert.ToInt32(e.Args[0]);
                  
                    if (e.GetArg("arg") == "")
                    {
                        string result = GetAddoninfo(x);
                        await e.Channel.SendMessage(result);
                    }

                    else if (e.GetArg("arg") == "description")
                    {                      
                        var addOn = addOnService.GetAddOn(x);
                        var description = addOnService.GetAddOnDescription(addOn.Id);
                        string cleaned = RemoveTags(description);
                        await e.Channel.SendMessage("```" + cleaned + "```");
                    }

                    else if (e.GetArg("arg") == "files")
                    {                  
                        var addOn = addOnService.GetAddOn(x);
                        var files = addOn.LatestFiles;
                        var allfiles = addOnService.GetAllFilesForAddOn(addOn.Id);
                        int total = 0;

                        foreach (var f in allfiles)
                        {
                            total = total + 1;
                        }

                        await e.Channel.SendMessage("```Total Files Found: " + total + "```");

                        foreach (var f in files)
                        {
                            string mod = string.Format("```Latest File: {0}, {1}, {2}, {3}, Status: {4}```", f.Id, f.FileDate, f.FileName, f.DownloadURL, f.ReleaseType);
                            await e.Channel.SendMessage(mod);
                        }
                    }

                    else if(e.GetArg("arg") == "changelog")
                    {
                        var addOn = addOnService.GetAddOn(x);
                        var files = addOn.LatestFiles;

                        foreach (var f in files)
                        {
                            var changelog = addOnService.GetChangeLog(addOn.Id, f.Id);
                            string cleaned = RemoveTags(changelog);
                            await e.Channel.SendMessage("```" + f.FileName + " - "+ Environment.NewLine + cleaned + "```");     
                        }
                    }
                });
        }

        public void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine($"[{e.Severity}] [{e.Source}] {e.Message}");
        }              
   
        public string GetAddoninfo(int id)
        {
            var addOn = addOnService.GetAddOn(id);
            var authors = addOn.Authors;
            var categories = addOn.Categories;

            IList<string> author_names = new List<string>();
            IList<string> categorie_names = new List<string>();

            foreach (var a in authors)
            {
                author_names.Add(a.Name);
            }

            foreach(var a in categories)
            {
                categorie_names.Add(a.Name);
            }

            string authornames_joined = string.Join(", ", author_names);
            string categorienames_joined = string.Join(", ", categorie_names);

            string modinfo = string.Format
                ("```Addon: ID: {0}\nName: {1}\nSummary: {2}\nAuthors: {3} \nUrl: {4} \nCategories: {5} \nDownloads: {6}```", 
                addOn.Id, addOn.Name, addOn.Summary, authornames_joined, addOn.WebSiteURL, categorienames_joined, addOn.DownloadCount);
            return modinfo;
        }

        public static string RemoveTags(string html)
        {
            var virgin = Regex.Replace(html, @"<[^>]+>|&nbsp;|&mdash;", "").Trim();
            var notanymore = Regex.Replace(virgin, @"\s{2,}", " ");
            return notanymore;
        }
    }
}
