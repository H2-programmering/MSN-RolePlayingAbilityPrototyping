using RolePlayingAbilityPrototyping.Participants;
using RolePlayingAbilityPrototyping.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RolePlayingAbilityPrototyping
{
    public class Arena
    {
        public void Battle()
        {
            #region Create Players
            Player pA = new Player("Allux", 3);
            pA[SpellType.AcidRain] = 50;
            pA[SpellType.Armadeddon] = 30;
            pA[SpellType.FireBall] = 20;

            Player pB = new Player("Beth", 5);
            pB[SpellType.AcidRain] = 100;
            pB[SpellType.Armadeddon] = 300;
            pB[SpellType.FireBall] = 20;

            Player pC = new Player("Cypher", 3);
            pC[SpellType.AcidRain] = 100;
            pC[SpellType.Armadeddon] = 300;
            pC[SpellType.FireBall] = 20;

            Player pD = new Player("Dilter", 3);
            pD[SpellType.AcidRain] = 100;
            pD[SpellType.Armadeddon] = 300;
            pD[SpellType.FireBall] = 20;

            Player pE = new Player("Allux", 3);
            pE[SpellType.AcidRain] = 100;
            pE[SpellType.Armadeddon] = 300;
            pE[SpellType.FireBall] = 20;
            #endregion

            #region Adding and Printing Players
            PrintParticipant(pA);
            PrintParticipant(pB);

            Player pAB = pA + pB;
            PrintParticipant(pAB);
            #endregion

            #region Create and Print a Boss
            Opponent oA = new Opponent("Victor", 25);

            oA[SpellType.AcidRain] = 40;
            oA[SpellType.Armadeddon] = 50;
            oA[SpellType.FireBall] = 60;
            oA[SpellType.IceStorm] = 70;
            oA[SpellType.LavaBall] = 80;
            oA[SpellType.ThunderBolt] = 90;

            PrintParticipant(oA);
            #endregion

            #region Calculate and Print DPS (Two players vs. Opponent)
            var dps2 = pAB * oA;

            Console.WriteLine($"{new string('=', 20)}");
            Console.WriteLine($"DPS (two players) --> {dps2:F2}");
            #endregion

            #region Calculate and Print DPS (Five players vs. Opponent)
            var dps5 = (pA + pB + pC + pD + pE) * oA;

            Console.WriteLine($"{new string('=', 20)}");
            Console.WriteLine($"DPS (five players) --> {dps5:F2}");
            #endregion
        }

        private void PrintParticipant(ParticipantBase aParticiant)
        {
            Console.WriteLine();
            Console.WriteLine(aParticiant.Name);
            Console.WriteLine("Original values in SpellVector:");

            foreach (var spellType in Spell.SpellTypeList.OrderBy(p => p.ToString()))
            {
                Console.WriteLine($"{spellType,-12} --> " + "{aParticiant[spellType]:F2}");
            }

            Console.WriteLine("Modified values in SpellVector:");

            foreach (var pair in aParticiant.OrderBy(p => p.ToString()))
            {
                Console.WriteLine($"{pair.Item1, -12} --> {pair.Item2:F2}");
            }
        }
    }
}
