﻿using RandomModCompat.Common.APIs;
using RandomModCompat.Core;
using SlugNPCsEX.NPCs;

namespace RandomModCompat.Content.Modules;

internal sealed class SlugNPCsEXCensusModule : CrossModModule<CensusAPI>
{
	public override string CrossModName => ModNames.SlugNPCsEX;

	protected internal override void PostSetupContent()
	{
		API.TownNPCCondition<AlbinoSlug>("When the Eye of Cthulhu has been defeated");
		API.TownNPCCondition<CryptsSlug>("When the Deerclops has been defeated");
		API.TownNPCCondition<DevourerSlug>("When the Moon Lord has been defeated");
		API.TownNPCCondition<StormSlug>("When Duke Fishron has been defeated");
		API.TownNPCCondition<UniverseSlug>("When the any player is carrying the Zenith");
	}
}