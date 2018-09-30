using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Main.BLL.Modules.Config
{
    public class MConfig
    {
        private static MConfig instance;

        private JObject configSchema;

        public static MConfig Get() {
            instance = instance ?? new MConfig();
            return instance;
        }

        private MConfig() {
            try {
                StreamReader reader = new StreamReader(Environment.CurrentDirectory + "/config.json");
                configSchema = JObject.Parse(reader.ReadToEnd());
            }
            catch (Exception e) {
                Console.WriteLine("You need to create config.json by copying config.json.example inside project root folder");
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            }
        }

        public string GetDbConnectionString() {
            var host = configSchema.SelectToken("database").Value<string>("host") ?? "localhost";
            var user = configSchema.SelectToken("database").Value<string>("user") ?? "postgres";
            var password = configSchema.SelectToken("database").Value<string>("password") ?? "1234";
            var database = configSchema.SelectToken("database").Value<string>("name") ?? "csharp_modular";
            return $"Host={host};Username={user};Password={password};Database={database}";
        }
    }
}