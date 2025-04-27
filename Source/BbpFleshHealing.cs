using RimWorld;
using Verse;

namespace Zig158.BetterBodyPurist
{
    public class CompProperties_FleshHealing : CompProperties_AbilityEffect
    {
        public CompProperties_FleshHealing()
        {
            this.compClass = typeof(CompAbilityEffect_FleshHealing);
        }
    }

    public class CompAbilityEffect_FleshHealing : CompAbilityEffect
    {
        public override bool Valid(LocalTargetInfo target, bool throwMessages = false)
        {
            Pawn pawn = target.Pawn;
            if (pawn == null)
                return false;

            return HealthUtility.TryGetWorstHealthCondition(pawn, out Hediff _, out BodyPartRecord _);
        }

        public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
        {
            base.Apply(target, dest);
            Pawn pawn = target.Pawn;
            if (pawn == null)
                return;
            TaggedString text = HealthUtility.FixWorstHealthCondition(pawn);
            if (!PawnUtility.ShouldSendNotificationAbout(pawn))
                return;
            Messages.Message((string) text, (LookTargets) (Thing) pawn, MessageTypeDefOf.PositiveEvent);
        }

        public override bool AICanTargetNow(LocalTargetInfo target) => false;
    }
}