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

namespace Modbot
{
    class Program
    {
        string version = "1.0.0";

        private static LoginService.ClientLoginServiceClient loginService = new LoginService.ClientLoginServiceClient("BinaryHttpsClientLoginServiceEndpoint");
        private static AddOnService.AddOnServiceClient addOnService = new AddOnService.AddOnServiceClient("BinaryHttpAddOnServiceEndpoint");

        static void Main(string[] args)
        {

            new Program().Start();

        }

        private DiscordClient _client;

        public void Start()
        {
            // Curse Username/Password
            var username = "username";
            var password = "password";

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

            // Bot Token
            var discordtoken = "";
         
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

            cService.CreateCommand("lookup")
                .Description("Look up Minecraft mods by ID")
                .Parameter("text", ParameterType.Multiple)
                .Do(async (e) =>
               {
                   StringBuilder output = new StringBuilder();

                   int x = Convert.ToInt32(e.Args[0]);

                   var addOn = addOnService.GetAddOn(x);
                   var files = addOnService.GetAllFilesForAddOn(addOn.Id);

                   if (e.Args[0] == string.Empty)
                   {
                       await e.Channel.SendMessage("You must supply a modID");
                   }
                   else
                   {
                       string result = GetAddon(x);
                       await e.Channel.SendMessage(result);
                   }

                   if(e.Args[1] == "files")
                   {
                       
                       foreach (var f in files)
                       {
                           string modinfo = string.Format("File: {0}, {1}, {2}, {3}", f.Id, f.FileDate, f.FileName, f.DownloadURL);
                           await e.Channel.SendMessage(modinfo);
                       }                      
                   }
               });
        }

        public void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine($"[{e.Severity}] [{e.Source}] {e.Message}");
        }              
   

        public string GetAddon(int id)
        {
            var addOn = addOnService.GetAddOn(id);
            string modinfo = string.Format("Addon: {0}, {1}, {2}", addOn.Id, addOn.Name, addOn.Summary);
            return modinfo;
        }
    }
}
