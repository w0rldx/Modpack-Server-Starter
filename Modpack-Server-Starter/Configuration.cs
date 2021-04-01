using System.Collections.Generic;

namespace Modpack_Server_Starter
{
    public class Configuration
    {
        public string DownloadLink { get; set; }
        public string Type { get; set; }
        public List<string> ExcludedMods { get; } = new List<string>();
        
    }
}