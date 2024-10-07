using HarmonyLib;
using Verse;

namespace Zig158.BetterBodyPurist
{
    [StaticConstructorOnStartup]
    public static class BetterBodyPurist
    {
        static BetterBodyPurist()
        {
            harmonyInstance = new Harmony("Zig158.BetterBodyPurist");
            harmonyInstance.PatchAll();
        }

        static Harmony harmonyInstance;
    }
}