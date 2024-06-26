﻿using RandomModCompat.Common.APIs;
using RandomModCompat.Core;
using System.Linq;
using Terraria.ModLoader;
using ThoriumMod.Items.Misc;
using ThoriumMod.Items.Tracker;
using ThoriumMod.Items.ZRemoved;

namespace RandomModCompat.Content.Modules;

internal sealed class ThoriumModItemCheckBlacklistModule : CrossModModule<ItemCheckBlacklistAPI>
{
	public override string CrossModName => ModNames.ThoriumMod;

	protected internal override void PostSetupContent()
	{
		// List from wiki: https://thoriummod.wiki.gg/wiki/List_of_items#Unobtainable_items
		API.Add(
			ModContent.ItemType<AngryStatue>(),
			ModContent.ItemType<ArcaneSpike>(),
			ModContent.ItemType<ArtificersExtractor>(),
			ModContent.ItemType<BasicPickaxe>(),
			ModContent.ItemType<DreamPotion>(),
			ModContent.ItemType<TesterEmpowerment>(),
			ModContent.ItemType<GodMode>(),
			ModContent.ItemType<TesterGore>(),
			ModContent.ItemType<HealingDummyStatue>(),
			ModContent.ItemType<LodestoneBuckshot>(),
			ModContent.ItemType<PenguinWand>(),
			ModContent.ItemType<PixelDye>(),
			ModContent.ItemType<TesterProjectile>(),
			ModContent.ItemType<TesterPurity>(),
			ModContent.ItemType<ShameMedal>(),
			ModContent.ItemType<TesterStats>(),
			ModContent.ItemType<SuppressionBullet>(),
			ModContent.ItemType<TesterText>(),
			ModContent.ItemType<TheBareGauntlet>(),
			ModContent.ItemType<TheGauntlet>(),
			ModContent.ItemType<TesterTile>(),
			ModContent.ItemType<StoneBlue>(),
			ModContent.ItemType<StoneGreen>(),
			ModContent.ItemType<StoneOrange>(),
			ModContent.ItemType<StonePurple>(),
			ModContent.ItemType<StoneRed>(),
			ModContent.ItemType<StoneYellow>(),
			ModContent.ItemType<ViscountRequirement>(),

#if TML_2022_09
			ModContent.ItemType<DyingRealityWhisper>(),
			ModContent.ItemType<PenguinWandTrue>(),
			ModContent.ItemType<WeirdMud>(),
#else
			ModContent.ItemType<DestinyWeaver>(),
			ModContent.ItemType<TheTruePenguinWand>(),
#endif

			// ... Plus some others.
			ModContent.ItemType<LichRequirement>(),
			ModContent.ItemType<LichRequirement2>(),
			ModContent.ItemType<LichRequirement3>()
			);
		API.Add(CrossMod.GetContent<RemovedItem>().Select(Selector).ToArray());
	}

	// JIT issues
	private static int Selector(RemovedItem i) => i.Type;
}