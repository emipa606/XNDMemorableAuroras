using Verse;

namespace MemorableAuroras;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    static HarmonyPatches()
    {
        MemorableAuroras.HarmonyInstance.PatchAll();
    }
}