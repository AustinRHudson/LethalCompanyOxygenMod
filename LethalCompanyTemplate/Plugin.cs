using BepInEx;
using HarmonyLib;
using LethalCompanyTemplate.Patches;

namespace LethalCompanyTemplate
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class LethalCompanyTemplate : BaseUnityPlugin
    {
        private const string modGUID = "UnlimitedOxygenMod.Guyonetwo";
        private const string modName = "Lethal Company Unlimited Oxygen Mod";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static LethalCompanyTemplate Instance;
        private void Awake()
        {
            if (Instance == null) {
                Instance = this;
            }
            // Plugin startup logic
            Logger.LogInfo($"Plugin {modGUID} is loaded!");

            harmony.PatchAll(typeof(LethalCompanyTemplate));
            harmony.PatchAll(typeof(StartOfRoundOxygenPatch));
        }
    }
}
