using Newtonsoft.Json;
using System.IO;

namespace $safeprojectname$
{
    public class ConfigFile
    {
        #region ConfigVars

        public string PluginName = "$safeprojectname$";
        public bool UseMySQL = false;

        #endregion ConfigVars

        public static ConfigFile Read(string path)
        {
            if (!File.Exists(path))
            {
                ConfigFile config = new ConfigFile();

                File.WriteAllText(path, JsonConvert.SerializeObject(config, Formatting.Indented));
                return config;
            }
            return JsonConvert.DeserializeObject<ConfigFile>(File.ReadAllText(path));
        }
    }
}