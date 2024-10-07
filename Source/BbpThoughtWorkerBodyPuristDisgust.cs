using HarmonyLib;
using RimWorld;
using Verse;

namespace Zig158.BetterBodyPurist
{
    [HarmonyPatch(typeof(ThoughtWorker_BodyPuristDisgust), "CurrentSocialStateInternal")]
    public static class BbpThoughtWorkerBodyPuristDisgust
    {
        static void Postfix(ref ThoughtState __result, ThoughtWorker_BodyPuristDisgust __instance, Pawn p, Pawn other)
        {
            // We only need to check if thought is active. This should save some performance
            if (__result.Active)
            {
                int num = other.health.hediffSet.CountAddedAndImplantedParts();
                __result = num > 0 ? ThoughtState.ActiveAtStage(num - 1) : (ThoughtState) false;
            }
        }
    }
}