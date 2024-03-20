using HarmonyLib;
using RimWorld;
using Verse;

namespace MemorableAuroras;

public static class Patch_GameCondition_Aurora
{
    [HarmonyPatch(typeof(GameCondition_Aurora), nameof(GameCondition_Aurora.GameConditionTick))]
    public static class GameConditionTick
    {
        public static void Postfix(GameCondition_Aurora __instance)
        {
            // Try to add 'Observed aurora' to all pawns every tick rare interval
            if (GenTicks.TicksGame % GenTicks.TickRareInterval != 0)
            {
                return;
            }

            foreach (var curMap in __instance.AffectedMaps)
            {
                for (var j = 0; j < curMap.mapPawns.AllPawnsSpawnedCount; j++)
                {
                    var pawn = curMap.mapPawns.AllPawnsSpawned[j];
                    if (pawn.needs.mood != null && !pawn.PositionHeld.Roofed(curMap) &&
                        pawn.health.capacities.CapableOf(PawnCapacityDefOf.Sight))
                    {
                        pawn.needs.mood.thoughts.memories.TryGainMemory(
                            (Thought_Memory)ThoughtMaker.MakeThought(MA_ThoughtDefOf.ObservedAurora));
                    }
                }
            }
        }
    }
}