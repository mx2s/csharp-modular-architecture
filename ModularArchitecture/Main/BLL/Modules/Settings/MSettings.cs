using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Main.BLL.Modules.Settings
{
    public class MSettings
    {
        private static MSettings instance;

        private JObject configSchema;

        public static MSettings Get() {
            instance = instance ?? new MSettings();
            return instance;
        }

        private MSettings() {
            try {
                StreamReader reader = new StreamReader(Environment.CurrentDirectory + "/config.json");
                configSchema = JObject.Parse(reader.ReadToEnd());
            }
            catch (Exception e) {
                Console.WriteLine("You need to create config.json by copying config.json.example inside project root folder");
                Console.WriteLine(e.Message);
            }
        }
    }
}