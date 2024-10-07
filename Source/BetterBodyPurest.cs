using RimWorld;
using Verse;

namespace Zig158.BetterBodyPurest
{
    public class ThoughtWorker_HasAddedBodyPart : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn pawn)
        {
             int num = pawn.health.hediffSet.CountAddedAndImplantedParts();
            return num > 0 ? ThoughtState.ActiveAtStage(num - 1) : (ThoughtState)false;
        }
    }
    
    public class ThoughtWorker_BodyPuristDisgust : ThoughtWorker
    {
        protected override ThoughtState CurrentSocialStateInternal(Pawn p, Pawn other)
        {
            if (!p.RaceProps.Humanlike)
                return (ThoughtState) false;
            if (!p.story.traits.HasTrait(TraitDefOf.BodyPurist))
                return (ThoughtState) false;
            if (!RelationsUtility.PawnsKnowEachOther(p, other))
                return (ThoughtState) false;
            if (other.def != p.def)
                return (ThoughtState) false;
            int num = other.health.hediffSet.CountAddedAndImplantedParts();
            return num > 0 ? ThoughtState.ActiveAtStage(num - 1) : (ThoughtState) false;
        }
    }
}