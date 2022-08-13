﻿using HarmonyLib;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Settlements;

namespace Coop.GameInterface.Patch.Party
{
    [HarmonyPatch(typeof(PartiesBuyFoodCampaignBehavior), "OnSettlementEntered")]
    internal class PartiesBuyFoodCampaignBehaviorPatch
    {
        private static bool Prefix(ref MobileParty mobileParty, ref Settlement settlement, ref TaleWorlds.CampaignSystem.Hero hero)
        {
            // TODO only allow for server and broadcast when it happens
            return true;
        }
    }
}