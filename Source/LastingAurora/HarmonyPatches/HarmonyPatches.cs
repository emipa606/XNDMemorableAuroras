using HarmonyLib;
using Verse;

namespace MemorableAuroras;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    static HarmonyPatches()
    {
        new Harmony("XeoNovaDan.MemorableAuroras").PatchAll();
    }
}