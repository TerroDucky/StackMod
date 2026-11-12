// This file controlls the logic behind stack sizes, and their IDs 

using RedLoader;
using Sons.Items.Core;
using UnityEngine;

namespace StackMod;

public class Stacks
{
    private const int Max = 999999999;

    public static void InfItems()
    {
        foreach (var item in ItemDatabaseManager.Items)
            item.MaxAmount = Max;
    }

    public static void ApplyOverride()
    {
        if (!int.TryParse(Config.ItemsOverrideStack.Value, out var amount)) return;
        amount = Mathf.Clamp(amount, 1, Max);
        foreach (var item in ItemDatabaseManager.Items)
            item.MaxAmount = amount;
    }

    private static void Apply(ConfigEntry<string> entry, int max, params int[] itemIds) // Applies one config value to one or more item IDs.
    {
        if (!int.TryParse(entry.Value, out var amount)) return;
        amount = Mathf.Clamp(amount, 1, max);

        foreach (var id in itemIds)
        {
            var item = ItemDatabaseManager.ItemById(id);
            if (item != null) // skip if item doesn't exist
            {
                item.MaxAmount = amount;
            }
        }
    }

    public static void ApplyConfigStacks()
    {
        // Crafting items
        Apply(Config.MaxTapeCount, Max, 419);
        Apply(Config.MaxClothCount, Max, 415);
        Apply(Config.MaxWireCount, Max, 418);
        Apply(Config.MaxBatteriesCount, Max, 527);
        Apply(Config.MaxRopeCount, Max, 403);
        Apply(Config.MaxBoardCount, Max, 416);
        Apply(Config.MaxC4Count, Max, 420);
        Apply(Config.MaxVodkaCount, Max, 414);
        Apply(Config.MaxWatchCount, Max, 410);
        Apply(Config.MaxCoinCount, Max, 502);

        // Printing items
        Apply(Config.MaxResinCount, Max, 390);
        Apply(Config.MaxMeshCount, Max, 553);
        Apply(Config.MaxHookCount, Max, 560);
        Apply(Config.MaxGpsCaseCount, Max, 657);

        // Sticks & rocks
        Apply(Config.MaxStickCount, Max, 392);
        Apply(Config.MaxRockCount, Max, 393);
        Apply(Config.MaxSmallRockCount, Max, 476);

        // Electricity items
        Apply(Config.MaxSolarCount, Max, 634);
        Apply(Config.MaxBatteryCount, Max, 661);
        Apply(Config.MaxBulbCount, Max, 635);
        Apply(Config.MaxRadioCount, Max, 590);

        // Medication
        Apply(Config.MaxMedsCount, Max, 437);
        Apply(Config.MaxHealthMixCount, Max, 455);
        Apply(Config.MaxHealthMixPlusCount, Max, 456);
        Apply(Config.MaxEnergyMixCount, Max, 461);
        Apply(Config.MaxEnergyMixPlusCount, Max, 462);

        // Food & drinks
        Apply(Config.MaxPotCount, Max, 517);
        Apply(Config.MaxMeatCount, Max, 433);
        Apply(Config.MaxFishCount, Max, 436);
        Apply(Config.MaxMreCount, Max, 438);
        Apply(Config.MaxEnergyBarCount, Max, 441);
        Apply(Config.MaxEnergyDrinkCount, Max, 439);
        Apply(Config.MaxCannedFoodCount, Max, 434);
        Apply(Config.MaxCatFoodCount, Max, 464);
        Apply(Config.MaxRamenCount, Max, 421);
        Apply(Config.MaxCrunchieCount, Max, 425);
        Apply(Config.MaxOysterCount, Max, 466);
        Apply(Config.MaxEggCount, Max, 401);
        Apply(Config.MaxSteakBiteCount, Max, 570);
        Apply(Config.MaxBaconBiteCount, Max, 571);
        Apply(Config.MaxBrainBiteCount, Max, 569);

        // Animal drops
        Apply(Config.MaxShellCount, Max, 506);
        Apply(Config.MaxHideCount, Max, 472);
        Apply(Config.MaxFeatherCount, Max, 479);
        Apply(Config.MaxAnimalHeadCount, Max, 642, 643, 644, 646, 647, 648, 650, 651, 652);

        // Throwable items
        Apply(Config.MaxMolotovCount, Max, 388);
        Apply(Config.MaxGrenadeCount, Max, 381);
        Apply(Config.MaxBombCount, Max, 417);
        Apply(Config.MaxSpearCount, Max, 474);
        Apply(Config.MaxFlareCount, Max, 440);

        // Body-parts & bones
        Apply(Config.MaxHeadCount, Max, 482);
        Apply(Config.MaxArmCount, Max, 480);
        Apply(Config.MaxLegCount, Max, 481);
        Apply(Config.MaxSkullCount, Max, 430);
        Apply(Config.MaxBonesCount, Max, 405);

        // Armor
        Apply(Config.MaxCreepyArmorCount, Max, 593);
        Apply(Config.MaxBoneArmorCount, Max, 494);
        Apply(Config.MaxSolafiteArmorCount, Max, 727);
        Apply(Config.MaxTechArmorCount, Max, 554);
        Apply(Config.MaxLeafArmorCount, Max, 473);
        Apply(Config.MaxHideArmorCount, Max, 519);

        // Ammunition
        Apply(Config.MaxAmmoCount, Max, 362, 363, 364, 369, 387);
        Apply(Config.MaxZiplineCount, Max, 523);
        Apply(Config.MaxBoltCount, Max, 368);
        Apply(Config.MaxStoneArrowCount, Max, 507);
        Apply(Config.MaxPrintedArrowCount, Max, 618);
        Apply(Config.MaxCarbonArrowCount, Max, 373);

        // Plants & seeds
        Apply(Config.MaxLeafCount, Max, 484);
        Apply(Config.MaxPlantCount, Max, 451, 454, 595, 445, 465, 449, 453, 400, 594, 450, 399, 398, 447, 397, 448, 446, 452);
        Apply(Config.MaxSeedCount, 999, 596, 454, 598, 599, 600, 601, 602, 603, 604, 605, 606, 597);

        // Misc items
        Apply(Config.MaxSolafiteCount, Max, 664);
        Apply(Config.MaxPouchCount, Max, 508);
        Apply(Config.MaxGliderCount, Max, 626);
        Apply(Config.MaxTarpCount, Max, 504);
        Apply(Config.MaxAirTankCount, Max, 469);
        Apply(Config.MaxPaperTargetCount, Max, 518);
        Apply(Config.MaxGolfballCount, Max, 524);
        Apply(Config.MaxCashCount, Max, 496);
    }
}
