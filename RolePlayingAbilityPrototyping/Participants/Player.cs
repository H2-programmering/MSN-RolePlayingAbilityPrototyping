using RolePlayingAbilityPrototyping.Spells;
using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingAbilityPrototyping.Participants
{
    public class Player : ParticipantBase
    {
        public Player(string name, int level) : base(name, level)
        {
        }

        public override double NotPresentValue 
        { 
            get { return 0.0; }
        }

        public override double Modifier 
        { 
            get { return Math.Sqrt(Level); }
        }

        public static Player operator +(Player a, Player b)
        {
            Player sumPlayer = new Player("SumPlayer", 1);

            foreach (var st in Spell.SpellTypeList)
            {
                sumPlayer[st] = (a[st] * a.Modifier) + (b[st] * b.Modifier);
            }

            return sumPlayer;
        }

        public static double operator *(Player p, Opponent o)
        {
            double dps = 0;

            foreach (var st in Spell.SpellTypeList)
            {
                dps += ((p[st] * p.Modifier) + (o[st] * o.Modifier)) / 100.0;
            }

            return dps;
        }
    }
}
