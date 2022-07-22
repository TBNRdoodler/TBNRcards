using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using RarityLib;
using TBNRcards.MonoBehaviors;

namespace TBNRcards.MonoBehaviors
{
    public class LightShieldsMono : MonoBehaviour
    {
        public static int LightShields = 0;

        public void Start(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            if (player == null);
        }
        public void Update(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            if (player == null) return;

            block.cdMultiplier = 1-(LightShields/10);
        }
    }
}