using BepInEx;
using HarmonyLib;

namespace LethalCompanyMusicMod
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class SpotifyMod : BaseUnityPlugin
    {
        private const string modGUID = "SpotTheFy.LethalCompanySpotifyMod";
        private const string modName = "Lethal Company Spotify Mod";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static SpotifyMod Instance; 

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}
