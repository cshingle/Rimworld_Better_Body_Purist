using HarmonyLib;
using RimWorld;
using Verse;

namespace Zig158.BetterBodyPurist
{
    [HarmonyPatch(typeof(ThoughtWorker_Precept_HasProsthetic_Social), "ShouldHaveThought")]
    public static class BbpThoughtWorker_Precept_HasProsthetic_Social
    {
        static void Postfix(ref ThoughtState __result, ThoughtWorker_Precept_HasProsthetic_Social __instance, Pawn p, Pawn otherPawn)
        {
            // We only need to check if thought is active. This should save some performance
            if (__result.Active)
            {
                int num = otherPawn.health.hediffSet.CountAddedAndImplantedParts();
                __result = num > 0 ? ThoughtState.ActiveAtStage(num - 1) : (ThoughtState) false;
            }
        }
    }
}