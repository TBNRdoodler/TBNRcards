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
    class Buckler : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            cardInfo.allowMultiple = false;

            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            player.gameObject.GetOrAddComponent<LightShieldsMono>();
            player.gameObject.GetOrAddComponent<LightShieldsOneMono>();
            
            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            Destroy(player.gameObject.GetOrAddComponent<LightShieldsMono>());

            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }

        internal static CardInfo Card = null;

        protected override string GetTitle()
        {
            return "Buckler";
        }
        protected override string GetDescription()
        {
            return "A small, medieval era shield, good for quickly parrying blows";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Per light shield:",
                    amount = "",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Block cooldown",
                    amount = "-10%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Movement speed",
                    amount = "-5%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Light shield",
                    amount = "+1",
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