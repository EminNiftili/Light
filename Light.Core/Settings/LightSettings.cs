using Light.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Light.Core.Settings
{
    public class LightSettings
    {
        private static LightSettings _instance;
        public static LightSettings Instance
        {
            get
            {
                if (_instance is null)
                    _instance = CreateInstance();
                return _instance;
            }
        }
        public LightSettings()
        {

        }
        private static LightSettings CreateInstance()
        {
            const string directoryName = @"\settings\light.settings.json";
            string finalDirectory = CurrentDirectory + directoryName;
            var json = TextFileReaderHelper.ReadAsStringAsync(finalDirectory).Result;
            return JsonSerializerHelper.Deserialize<LightSettings>(json)!;
        }

        [JsonIgnore]
        public static string CurrentDirectory => AppDomain.CurrentDomain.BaseDirectory;


        public DatabaseSettings DatabaseSetting { get; set; }


        public class DatabaseSettings
        {
            public string ApiDbConnectionString { get; set; }
        }
    }
}
