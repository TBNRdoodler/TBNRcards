using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using ClassesManagerReborn;

namespace TBNRcards.Cards.Legionary
{
    public class LegionaryClass : ClassHandler
    {
        internal static string name = "Legionary";

        public override System.Collections.IEnumerator Init()
        {
            UnityEngine.Debug.Log("Regestering: " + name);

            while (!(Legionary.Card && LightningBlocking.Card && ShieldDuplicator.Card)) yield return null;
            ClassesRegistry.Register(Legionary.Card, CardType.Entry);
            ClassesRegistry.Register(LightningBlocking.Card, CardType.Card, Legionary.Card);
            ClassesRegistry.Register(ShieldDuplicator.Card, CardType.Card, Legionary.Card);
            ClassesRegistry.Register(AggressiveBlocking.Card, CardType.Card, Legionary.Card, 2);

        }
    }
}