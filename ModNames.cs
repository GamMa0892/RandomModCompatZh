﻿using Terraria.ModLoader;

namespace RandomModCompat;

/// <summary>
/// Constants for every supported mod name.
/// </summary>
internal static class ModNames
{
	internal const string
		AmuletOfManyMinions = nameof(AmuletOfManyMinions),
		AssortedCrazyThings = nameof(AssortedCrazyThings),
		AutoReroll = nameof(AutoReroll),
		BalloonsExtended = nameof(BalloonsExtended),
		Bangarang = nameof(Bangarang),
		BetterTaxes = nameof(BetterTaxes),
		BossesAsNPCs = nameof(BossesAsNPCs),
		BossChecklist = nameof(BossChecklist),
		BuffDisplay = nameof(BuffDisplay),
		CalamityMod = nameof(CalamityMod),
		CatalystMod = nameof(CatalystMod),
		Census = nameof(Census),
		ClickerClass = nameof(ClickerClass),
		ColoredDamageTypes = nameof(ColoredDamageTypes),
		Consolaria = nameof(Consolaria),
		DBZMODPORT = nameof(DBZMODPORT),
		DialogueTweak = nameof(DialogueTweak),
		Fargowiltas = nameof(Fargowiltas),
		FargowiltasSouls = nameof(FargowiltasSouls),
		FishingReborn = nameof(FishingReborn),
		HEROsMod = nameof(HEROsMod),
		ImprovedTorches = nameof(ImprovedTorches),
		ItemCheckBlacklist = nameof(ItemCheckBlacklist),
		ItReallyMustBe = nameof(ItReallyMustBe),
#if TML_2022_09
		levelplus = nameof(levelplus), 
#else
		levelplus = "LevelPlus", // Gotta love mod renames :)
#endif
		Liber = nameof(Liber),
		MagicStorage = nameof(MagicStorage),
		Mask = nameof(Mask),
		MeleeEffects = nameof(MeleeEffects),
		OrchidMod = nameof(OrchidMod),
		OverpoweredGoldDust = nameof(OverpoweredGoldDust),
		PrimeRework = nameof(PrimeRework),
		RecipeBrowser = nameof(RecipeBrowser),
		Redemption = nameof(Redemption),
		RescueFairies = nameof(RescueFairies),
		ROR2HealthBars = nameof(ROR2HealthBars),
		SlugNPCsEX = nameof(SlugNPCsEX),
		StormDiversMod = nameof(StormDiversMod),
		SummonersAssociation = nameof(SummonersAssociation),
		TerraTyping = nameof(TerraTyping),
		TheConfectionRebirth = nameof(TheConfectionRebirth),
		TheDepths = nameof(TheDepths),
		ThoriumMod = nameof(ThoriumMod),
		UniversalCraft = nameof(UniversalCraft),
		Wikithis = nameof(Wikithis),
		WWeaponScaling = nameof(WWeaponScaling),
		
		// Vanilla support, usually throwing support.
		// "ModLoader" is the name of tModLoader's internal mod, which is always loaded.
		Terraria = nameof(ModLoader),
		Vanilla = Terraria;
}