using Verse;
using HarmonyLib;

namespace MemorableAuroras
{

    public class MemorableAuroras : Mod
    {

        public MemorableAuroras(ModContentPack content) : base(content)
        {
            HarmonyInstance = new Harmony("XeoNovaDan.MemorableAuroras");
        }

        public static Harmony HarmonyInstance;

    }

}
