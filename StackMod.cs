using RedLoader;
using SonsSdk;
using SUI;

namespace StackMod;

public class StackMod : SonsMod
{
    protected override void OnInitializeMod()
    {
        Config.Init();
    }

    protected override void OnSdkInitialized()
    {
        SettingsRegistry.CreateSettings(this, null, typeof(Config), callback: ApplySettings);
        ApplySettings();
    }

    private static void ApplySettings()
    {
        Stacks.ApplyConfigStacks();

        if (Config.ItemsOverrideEnable.Value)
        {
            Stacks.ApplyOverride();
            return;
        }

        if (Config.InfiniteItems.Value)
        {
            Stacks.InfItems();
            RLog.Msg("Infinite items on!");
            return;
        }

        RLog.Msg("StackMod Config settings applied!");
    }
}