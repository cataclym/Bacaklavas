using System.Reflection;
using KitchenLib;
using KitchenMods;

namespace Bacaklavas
{
    public class Main() : BaseMod(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, "0.0.1", MOD_GAMEVERSION,
        Assembly.GetExecutingAssembly())
    {
        public static readonly string MOD_GUID = "cata.plateup.bacaklavas";
        public static readonly string MOD_NAME = "Bacaklavas";
        public static readonly string MOD_VERSION = "0.0.1";
        public static readonly string MOD_AUTHOR = "Cata";
        public static readonly string MOD_GAMEVERSION = ">=1.1.3";

        public void PostActivate(Mod mod)
        {
            AddGameDataObject<Bacalao>();
            AddGameDataObject<Baklava>();
        }

        public void PreInject() { }

        public void PostInject() { }
    }
}