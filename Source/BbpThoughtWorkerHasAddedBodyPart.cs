using HarmonyLib;
using RimWorld;
using Verse;

namespace Zig158.BetterBodyPurist
{
    [HarmonyPatch(typeof(ThoughtWorker_HasAddedBodyPart), "CurrentStateInternal")]
    public static class BbpThoughtWorkerHasAddedBodyPart
    {
        static void Postfix(ref ThoughtState __result, ThoughtWorker_HasAddedBodyPart __instance, Pawn p)
        {
            // We only need to check if thought is active. This should save some performance
            if (__result.Active)
            {
                int num = p.health.hediffSet.CountAddedAndImplantedParts();
                __result = num > 0 ? ThoughtState.ActiveAtStage(num - 1) : (ThoughtState)false;
            }
        }
    }
}