using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using GameNetcodeStuff;
using HarmonyLib;

namespace LethalCompanyTemplate.Patches
{
    [HarmonyPatch(typeof(StartOfRound))]
    internal class StartOfRoundOxygenPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void infiniteOxygen(ref float ___drowningTimer) {
            ___drowningTimer = 1f;
        }
    }
}
