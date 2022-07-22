using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using RarityLib;

namespace TBNRcards.MonoBehaviors
{
    public class LightShieldsMono : MonoBehaviour
    {
        private Player _player;
        private CharacterStatModifiers _stats;
        private Block _block;
        public static int LightShields = 100;

        public void Start(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            if (player == null);
        }
        public void Update(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            if (player == null) return;

            block.cdMultiplier = LightShields;
            //_block.cdMultiplier = 1 - (LightShields / 10);
            //_stats.movementSpeed = 1 - (LightShields / 20);
        }
    }
}
