using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using ClassesManagerReborn.Util;
using RarityLib.Utils;
using TBNRcards.MonoBehaviors;

namespace TBNRcards.Cards.Legionary
{
    class LightShieldsBox : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {


            cardInfo.allowMultiple = true;

            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            player.gameObject.GetOrAddComponent<LightShieldsOneMono>();

            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            Destroy(player.gameObject.GetOrAddComponent<LightShieldsOneMono>());

            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }

        internal static CardInfo Card = null;

        protected override string GetTitle()
        {
            return "Light Shields Box";
        }
        protected override string GetDescription()
        {
            return "A small box of lights shields";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Light Shields",
                    amount = "+2",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DestructiveRed;
        }
        public override string GetModName()
        {
            return "TBNRC";
        }
    }
}