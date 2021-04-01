using System.Collections.Generic;

namespace Modpack_Server_Starter
{
    public class Modpack
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }
        public List<Mods> ModList { get; set; }
    }
}