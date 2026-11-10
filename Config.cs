using RedLoader;

namespace StackMod;

public static class Config
{
    // Category properties for UI
    public static ConfigCategory stackMod { get; private set; }
    public static ConfigCategory crafting { get; private set; }
    public static ConfigCategory stickRock { get; private set; }
    public static ConfigCategory printing { get; private set; }
    public static ConfigCategory electric { get; private set; }
    public static ConfigCategory meds { get; private set; }
    public static ConfigCategory food { get; private set; }
    public static ConfigCategory animal { get; private set; }
    public static ConfigCategory throwable { get; private set; }
    public static ConfigCategory bodyParts { get; private set; }
    public static ConfigCategory armor { get; private set; }
    public static ConfigCategory ammo { get; private set; }
    public static ConfigCategory plants { get; private set; }
    public static ConfigCategory misc { get; private set; }

    // Main toggle settings
    public static ConfigEntry<bool> InfiniteItems { get; private set; }
    public static ConfigEntry<bool> ItemsOverrideEnable { get; private set; }
    public static ConfigEntry<string> ItemsOverrideStack { get; private set; }

    // Crafting items
    public static ConfigEntry<string> MaxTapeCount { get; private set; }
    public static ConfigEntry<string> MaxClothCount { get; private set; }
    public static ConfigEntry<string> MaxWireCount { get; private set; }
    public static ConfigEntry<string> MaxBatteriesCount { get; private set; }
    public static ConfigEntry<string> MaxRopeCount { get; private set; }
    public static ConfigEntry<string> MaxBoardCount { get; private set; }
    public static ConfigEntry<string> MaxC4Count { get; private set; }
    public static ConfigEntry<string> MaxVodkaCount { get; private set; }
    public static ConfigEntry<string> MaxWatchCount { get; private set; }
    public static ConfigEntry<string> MaxCoinCount { get; private set; }

    // Printing items
    public static ConfigEntry<string> MaxResinCount { get; private set; }
    public static ConfigEntry<string> MaxHookCount { get; private set; }
    public static ConfigEntry<string> MaxMeshCount { get; private set; }
    public static ConfigEntry<string> MaxGpsCaseCount { get; private set; }

    // Sticks & rocks
    public static ConfigEntry<string> MaxStickCount { get; private set; }
    public static ConfigEntry<string> MaxRockCount { get; private set; }
    public static ConfigEntry<string> MaxSmallRockCount { get; private set; }

    // Electricity items
    public static ConfigEntry<string> MaxSolarCount { get; private set; }
    public static ConfigEntry<string> MaxBatteryCount { get; private set; }
    public static ConfigEntry<string> MaxBulbCount { get; private set; }
    public static ConfigEntry<string> MaxRadioCount { get; private set; }

    // Medication
    public static ConfigEntry<string> MaxMedsCount { get; private set; }
    public static ConfigEntry<string> MaxHealthMixCount { get; private set; }
    public static ConfigEntry<string> MaxHealthMixPlusCount { get; private set; }
    public static ConfigEntry<string> MaxEnergyMixCount { get; private set; }
    public static ConfigEntry<string> MaxEnergyMixPlusCount { get; private set; }

    // Food & drinks
    public static ConfigEntry<string> MaxPotCount { get; private set; }
    public static ConfigEntry<string> MaxMeatCount { get; private set; }
    public static ConfigEntry<string> MaxFishCount { get; private set; }
    public static ConfigEntry<string> MaxMreCount { get; private set; }
    public static ConfigEntry<string> MaxEnergyBarCount { get; private set; }
    public static ConfigEntry<string> MaxEnergyDrinkCount { get; private set; }
    public static ConfigEntry<string> MaxCannedFoodCount { get; private set; }
    public static ConfigEntry<string> MaxCatFoodCount { get; private set; }
    public static ConfigEntry<string> MaxRamenCount { get; private set; }
    public static ConfigEntry<string> MaxCrunchieCount { get; private set; }
    public static ConfigEntry<string> MaxOysterCount { get; private set; }
    public static ConfigEntry<string> MaxEggCount { get; private set; }
    public static ConfigEntry<string> MaxSteakBiteCount { get; private set; }
    public static ConfigEntry<string> MaxBaconBiteCount { get; private set; }
    public static ConfigEntry<string> MaxBrainBiteCount { get; private set; }

    // Animal drops
    public static ConfigEntry<string> MaxShellCount { get; private set; }
    public static ConfigEntry<string> MaxHideCount { get; private set; }
    public static ConfigEntry<string> MaxAnimalHeadCount { get; private set; }
    public static ConfigEntry<string> MaxFeatherCount { get; private set; }

    // Throwable items
    public static ConfigEntry<string> MaxMolotovCount { get; private set; }
    public static ConfigEntry<string> MaxGrenadeCount { get; private set; }
    public static ConfigEntry<string> MaxBombCount { get; private set; }
    public static ConfigEntry<string> MaxSpearCount { get; private set; }
    public static ConfigEntry<string> MaxFlareCount { get; private set; }

    // Body-parts & bones
    public static ConfigEntry<string> MaxHeadCount { get; private set; }
    public static ConfigEntry<string> MaxArmCount { get; private set; }
    public static ConfigEntry<string> MaxLegCount { get; private set; }
    public static ConfigEntry<string> MaxSkullCount { get; private set; }
    public static ConfigEntry<string> MaxBonesCount { get; private set; }

    // Armor
    public static ConfigEntry<string> MaxCreepyArmorCount { get; private set; }
    public static ConfigEntry<string> MaxBoneArmorCount { get; private set; }
    public static ConfigEntry<string> MaxSolafiteArmorCount { get; private set; }
    public static ConfigEntry<string> MaxTechArmorCount { get; private set; }
    public static ConfigEntry<string> MaxLeafArmorCount { get; private set; }
    public static ConfigEntry<string> MaxHideArmorCount { get; private set; }

    // Ammunition
    public static ConfigEntry<string> MaxAmmoCount { get; private set; }
    public static ConfigEntry<string> MaxZiplineCount { get; private set; }
    public static ConfigEntry<string> MaxStoneArrowCount { get; private set; }
    public static ConfigEntry<string> MaxPrintedArrowCount { get; private set; }
    public static ConfigEntry<string> MaxCarbonArrowCount { get; private set; }
    public static ConfigEntry<string> MaxBoltCount { get; private set; }

    // Plants & seeds
    public static ConfigEntry<string> MaxPlantCount { get; private set; }
    public static ConfigEntry<string> MaxSeedCount { get; private set; }
    public static ConfigEntry<string> MaxLeafCount { get; private set; }

    // Misc items
    public static ConfigEntry<string> MaxSolafiteCount { get; private set; }
    public static ConfigEntry<string> MaxPouchCount { get; private set; }
    public static ConfigEntry<string> MaxGliderCount { get; private set; }
    public static ConfigEntry<string> MaxTarpCount { get; private set; }
    public static ConfigEntry<string> MaxAirTankCount { get; private set; }
    public static ConfigEntry<string> MaxPaperTargetCount { get; private set; }
    public static ConfigEntry<string> MaxGolfballCount { get; private set; }
    public static ConfigEntry<string> MaxCashCount { get; private set; }

    private const string Tooltip = "Minimum is 1, max is 999999999. Only type numbers";

    public static void Init()
    {
        stackMod = ConfigSystem.CreateFileCategory("StackMod", "stackMod", "StackMod.cfg");
        InfiniteItems = stackMod.CreateEntry<bool>("InfiniteInventory", false, "Infinite items", null);
        ItemsOverrideEnable = stackMod.CreateEntry<bool>("EnableItemsoverride", false, "Enable items override", null);
        ItemsOverrideStack = stackMod.CreateEntry<string>("Itemsoverride", "", "Stack override amount", Tooltip);

        crafting = ConfigSystem.CreateFileCategory("Crafting items", "craftingItems", "StackMod.cfg");
        MaxTapeCount = crafting.CreateEntry<string>("MaxTapeCount", "100", "Set the max amount of duct tape", Tooltip);
        MaxClothCount = crafting.CreateEntry<string>("MaxClothCount", "1000", "Set the max amount of cloth", Tooltip);
        MaxWireCount = crafting.CreateEntry<string>("MaxWireCount", "100", "Set the max amount of wire", Tooltip);
        MaxBatteriesCount = crafting.CreateEntry<string>("MaxBatteriesCount", "6", "Set the max amount of batteries", Tooltip);
        MaxRopeCount = crafting.CreateEntry<string>("MaxRopeCount", "8", "Set the max amount of ropes", Tooltip);
        MaxBoardCount = crafting.CreateEntry<string>("MaxBoardCount", "6", "Set the max amount of circuit boards", Tooltip);
        MaxC4Count = crafting.CreateEntry<string>("MaxC4Count", "3", "Set the max amount of C4 bricks", Tooltip);
        MaxVodkaCount = crafting.CreateEntry<string>("MaxVodkaCount", "6", "Set the max amount of vodka", Tooltip);
        MaxWatchCount = crafting.CreateEntry<string>("MaxWatchCount", "10", "Set the max amount of watches", Tooltip);
        MaxCoinCount = crafting.CreateEntry<string>("MaxCoinCount", "1000", "Set the max amount of coins", Tooltip);

        printing = ConfigSystem.CreateFileCategory("Printing items", "printingItems", "StackMod.cfg");
        MaxResinCount = printing.CreateEntry<string>("MaxResinCount", "1000", "Set the max amount of resin", Tooltip);
        MaxHookCount = printing.CreateEntry<string>("MaxHookCount", "2", "Set the max amount of 3d printed grappling hooks", Tooltip);
        MaxMeshCount = printing.CreateEntry<string>("MaxMeshCount", "10", "Set the max amount of tech meshes", Tooltip);
        MaxGpsCaseCount = printing.CreateEntry<string>("MaxGpsCaseCount", "5", "Set the max amount of 3d printed gps cases", Tooltip);

        stickRock = ConfigSystem.CreateFileCategory("Sticks & rocks", "stickRock", "StackMod.cfg");
        MaxStickCount = stickRock.CreateEntry<string>("MaxStickCount", "20", "Set the max amount of sticks", Tooltip);
        MaxRockCount = stickRock.CreateEntry<string>("MaxRockCount", "10", "Set the max amount of rocks", Tooltip);
        MaxSmallRockCount = stickRock.CreateEntry<string>("MaxSmallRockCount", "30", "Set the max amount of small rocks", Tooltip);

        electric = ConfigSystem.CreateFileCategory("Electricity items", "electricItems", "StackMod.cfg");
        MaxSolarCount = electric.CreateEntry<string>("MaxSolarCount", "3", "Set the max amount of solar panels", Tooltip);
        MaxBatteryCount = electric.CreateEntry<string>("MaxBatteryCount", "3", "Set the max amount of golfcart batteries", Tooltip);
        MaxBulbCount = electric.CreateEntry<string>("MaxBulbCount", "8", "Set the max amount of light bulbs", Tooltip);
        MaxRadioCount = electric.CreateEntry<string>("MaxRadioCount", "1", "Set the max amount of radios", Tooltip);

        meds = ConfigSystem.CreateFileCategory("Medication", "meds", "StackMod.cfg");
        MaxMedsCount = meds.CreateEntry<string>("MaxMedsCount", "6", "Set the max amount of meds", Tooltip);
        MaxHealthMixCount = meds.CreateEntry<string>("MaxHealthMixCount", "3", "Set the max amount of health mixes", Tooltip);
        MaxHealthMixPlusCount = meds.CreateEntry<string>("MaxHealthMixPlusCount", "3", "Set the max amount of health+ mixes", Tooltip);
        MaxEnergyMixCount = meds.CreateEntry<string>("MaxEnergyMixCount", "3", "Set the max amount of energy mixes", Tooltip);
        MaxEnergyMixPlusCount = meds.CreateEntry<string>("MaxEnergyMixPlusCount", "3", "Set the max amount of energy+ mixes", Tooltip);

        food = ConfigSystem.CreateFileCategory("Food & drinks", "foodDrinks", "StackMod.cfg");
        MaxPotCount = food.CreateEntry<string>("MaxPotCount", "1", "Set the max amount of cooking pots", Tooltip);
        MaxMeatCount = food.CreateEntry<string>("MaxMeatCount", "7", "Set the max amount of meat", Tooltip);
        MaxFishCount = food.CreateEntry<string>("MaxFishCount", "3", "Set the max amount of fish", Tooltip);
        MaxMreCount = food.CreateEntry<string>("MaxMreCount", "6", "Set the max amount of MREs", Tooltip);
        MaxEnergyBarCount = food.CreateEntry<string>("MaxEnergyBarCount", "10", "Set the max amount of energy bars", Tooltip);
        MaxEnergyDrinkCount = food.CreateEntry<string>("MaxEnergyDrinkCount", "10", "Set the max amount of energy drinks", Tooltip);
        MaxCannedFoodCount = food.CreateEntry<string>("MaxCannedFoodCount", "6", "Set the max amount of canned food", Tooltip);
        MaxCatFoodCount = food.CreateEntry<string>("MaxCatFoodCount", "1", "Set the max amount of cat food", Tooltip);
        MaxRamenCount = food.CreateEntry<string>("MaxRamenCount", "4", "Set the max amount of ramen noodles", Tooltip);
        MaxCrunchieCount = food.CreateEntry<string>("MaxCrunchieCount", "4", "Set the max amount of crunchie wunchies", Tooltip);
        MaxOysterCount = food.CreateEntry<string>("MaxOysterCount", "5", "Set the max amount of oysters", Tooltip);
        MaxEggCount = food.CreateEntry<string>("MaxEggCount", "4", "Set the max amount of turtle eggs", Tooltip);
        MaxSteakBiteCount = food.CreateEntry<string>("MaxSteakBiteCount", "1", "Set the max amount of steak bites", Tooltip);
        MaxBaconBiteCount = food.CreateEntry<string>("MaxBaconBiteCount", "1", "Set the max amount of bacon bites", Tooltip);
        MaxBrainBiteCount = food.CreateEntry<string>("MaxBrainBiteCount", "1", "Set the max amount of brain bites", Tooltip);

        animal = ConfigSystem.CreateFileCategory("Animal drops", "animalDrops", "StackMod.cfg");
        MaxShellCount = animal.CreateEntry<string>("MaxShellCount", "3", "Set the max amount of shells", Tooltip);
        MaxHideCount = animal.CreateEntry<string>("MaxHideCount", "5", "Set the max amount of hides", Tooltip);
        MaxAnimalHeadCount = animal.CreateEntry<string>("MaxAnimalHeadCount", "1", "Set the max amount of animal heads", Tooltip);
        MaxFeatherCount = animal.CreateEntry<string>("MaxFeatherCount", "1000", "Set the max amount of feathers", Tooltip);

        throwable = ConfigSystem.CreateFileCategory("Throwable items", "throwableItems", "StackMod.cfg");
        MaxMolotovCount = throwable.CreateEntry<string>("MaxMolotovCount", "6", "Set the max amount of molotovs", Tooltip);
        MaxGrenadeCount = throwable.CreateEntry<string>("MaxGrenadeCount", "5", "Set the max amount of grenades", Tooltip);
        MaxBombCount = throwable.CreateEntry<string>("MaxBombCount", "3", "Set the max amount of sticky bombs", Tooltip);
        MaxSpearCount = throwable.CreateEntry<string>("MaxSpearCount", "5", "Set the max amount of spears", Tooltip);
        MaxFlareCount = throwable.CreateEntry<string>("MaxFlareCount", "10", "Set the max amount of flares", Tooltip);

        bodyParts = ConfigSystem.CreateFileCategory("Body-parts & bones", "bodyPartBones", "StackMod.cfg");
        MaxHeadCount = bodyParts.CreateEntry<string>("MaxHeadCount", "1", "Set the max amount of heads", Tooltip);
        MaxArmCount = bodyParts.CreateEntry<string>("MaxArmCount", "2", "Set the max amount of arms", Tooltip);
        MaxLegCount = bodyParts.CreateEntry<string>("MaxLegCount", "2", "Set the max amount of legs", Tooltip);
        MaxSkullCount = bodyParts.CreateEntry<string>("MaxSkullCount", "3", "Set the max amount of skulls", Tooltip);
        MaxBonesCount = bodyParts.CreateEntry<string>("MaxBonesCount", "16", "Set the max amount of bones", Tooltip);

        armor = ConfigSystem.CreateFileCategory("Armor", "armor", "StackMod.cfg");
        MaxCreepyArmorCount = armor.CreateEntry<string>("MaxCreepyArmorCount", "10", "Set the max amount of creepy armor", Tooltip);
        MaxBoneArmorCount = armor.CreateEntry<string>("MaxBoneArmorCount", "10", "Set the max amount of bone armor", Tooltip);
        MaxSolafiteArmorCount = armor.CreateEntry<string>("MaxSolafiteArmorCount", "10", "Set the max amount of solafite armor", Tooltip);
        MaxTechArmorCount = armor.CreateEntry<string>("MaxTechArmorCount", "10", "Set the max amount of tech armor", Tooltip);
        MaxLeafArmorCount = armor.CreateEntry<string>("MaxLeafArmorCount", "10", "Set the max amount of leaf armor", Tooltip);
        MaxHideArmorCount = armor.CreateEntry<string>("MaxHideArmorCount", "10", "Set the max amount of hide armor", Tooltip);

        ammo = ConfigSystem.CreateFileCategory("Ammunition", "ammunition", "StackMod.cfg");
        MaxAmmoCount = ammo.CreateEntry<string>("MaxAmmoCount", "1000", "Set the max amount of all ammo", Tooltip);
        MaxZiplineCount = ammo.CreateEntry<string>("MaxZiplineCount", "4", "Set the max amount of ziplines", Tooltip);
        MaxStoneArrowCount = ammo.CreateEntry<string>("MaxStoneArrowCount", "20", "Set the max amount of stone arrows", Tooltip);
        MaxPrintedArrowCount = ammo.CreateEntry<string>("MaxPrintedArrowCount", "20", "Set the max amount of printed arrows", Tooltip);
        MaxCarbonArrowCount = ammo.CreateEntry<string>("MaxCarbonArrowCount", "20", "Set the max amount of carbon arrows", Tooltip);
        MaxBoltCount = ammo.CreateEntry<string>("MaxBoltCount", "20", "Set the max amount of crossbow bolts", Tooltip);

        plants = ConfigSystem.CreateFileCategory("Plants & seeds", "plantsSeeds", "StackMod.cfg");
        MaxPlantCount = plants.CreateEntry<string>("MaxPlantCount", "20", "Set the max amount of plants", Tooltip);
        MaxSeedCount = plants.CreateEntry<string>("MaxSeedCount", "20", "Set the max amount of seeds", Tooltip);
        MaxLeafCount = plants.CreateEntry<string>("MaxLeafCount", "1000", "Set the max amount of leaves", Tooltip);

        misc = ConfigSystem.CreateFileCategory("Misc items", "miscItems", "StackMod.cfg");
        MaxSolafiteCount = misc.CreateEntry<string>("MaxSolafiteCount", "20", "Set the max amount of solafite", Tooltip);
        MaxPouchCount = misc.CreateEntry<string>("MaxPouchCount", "6", "Set the max amount of skin pouches", Tooltip);
        MaxGliderCount = misc.CreateEntry<string>("MaxGliderCount", "1", "Set the max amount of hang gliders", Tooltip);
        MaxTarpCount = misc.CreateEntry<string>("MaxTarpCount", "4", "Set the max amount of tarps", Tooltip);
        MaxAirTankCount = misc.CreateEntry<string>("MaxAirTankCount", "4", "Set the max amount of air tanks", Tooltip);
        MaxPaperTargetCount = misc.CreateEntry<string>("MaxPaperTargetCount", "50", "Set the max amount of paper targets", Tooltip);
        MaxGolfballCount = misc.CreateEntry<string>("MaxGolfballCount", "50", "Set the max amount of golf balls", Tooltip);
        MaxCashCount = misc.CreateEntry<string>("MaxCashCount", "1000000", "Set the max amount of cash", Tooltip);
    }
}