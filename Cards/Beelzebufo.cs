using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace TBNRcards.Cards
{
    class Beelzebufo : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.knockback = -2.5f * Math.Abs(gun.knockback);
            statModifiers.health = .75f;
            gun.gravity = 0f;
            gun.projectileColor = Color.green;
            /*
            GameObject silence = null;
            GameObject.Find("Silence");
            if (silence)
            {
                var silenceGun = 
            }
            */
            
            /*
            GameObject dazzle = null;
            dazzle = GameObject.Find("DazzleBullet");
            if (!dazzle)
            {
                var dazzleCard = UnboundLib.Utils.CardManager.cards.Values.Where((card) => card.cardInfo.cardName.ToLower() == "Dazzle".ToLower()).Select((card) => card.cardInfo).FirstOrDefault();

                var dazzleGun = dazzleCard.gameObject.GetComponent<Gun>();

                dazzle = Instantiate(dazzleGun.objectsToSpawn[0].effect);
                dazzle.name = "DazzleBullet";

                var dazzleEffect = dazzle.GetComponent<StunPlayer>();

                dazzleEffect.time = 2f;
                dazzleEffect.targetPlayer = 1f;
                DelayEvent = .5s;
            }
            gun.objectsToSpawn = new ObjectsToSpawn[] { new ObjectsToSpawn { AddToProjectile = dazzle } };
            */

            cardInfo.allowMultiple = false;
            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            UnityEngine.Debug.Log($"[{TBNRcards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }

        internal static CardInfo Card = null;

        protected override string GetTitle()
        {
            return "Beelzebufo (WIP)";
        }
        protected override string GetDescription()
        {
            return "Demon frog - its lick may one day be... stunning";
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
                    stat = "Knockback",
                    amount = "-150%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Bullet Gravity",
                    amount = "No",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Hp",
                    amount = "-25%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.PoisonGreen;
        }
        public override string GetModName()
        {
            return "TBNRC";
        }
    }
}
