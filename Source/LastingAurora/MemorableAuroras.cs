using HarmonyLib;
using Verse;

namespace MemorableAuroras;

public class MemorableAuroras : Mod
{
    public static Harmony HarmonyInstance;

    public MemorableAuroras(ModContentPack content) : base(content)
    {
        HarmonyInstance = new Harmony("XeoNovaDan.MemorableAuroras");
    }
}