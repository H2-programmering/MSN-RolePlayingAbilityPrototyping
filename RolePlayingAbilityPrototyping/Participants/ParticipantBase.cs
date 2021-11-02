using RolePlayingAbilityPrototyping.Spells;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingAbilityPrototyping.Participants
{
    public abstract class ParticipantBase : IParticipant, IEnumerable<Tuple<SpellType, double>>
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Dictionary<SpellType, double> SpellVector { get; set; }
        public abstract double Modifier { get; set; }
        public abstract double NotPresentValue { get; set; }

        protected ParticipantBase(string name, int level)
        {
            Name = name;
            Level = level;
            SpellVector = new Dictionary<SpellType, double>();
        }

        public double this[SpellType spellType]
        {
            get { return SpellVector[spellType] != 0 ? SpellVector[spellType] : NotPresentValue; }
        }

        public IEnumerator<Tuple<SpellType, double>> GetEnumerator()
        {
            foreach (var spellType in Spell.SpellTypeList)
            {
                yield return new Tuple<SpellType, double>(spellType, this[spellType] * Modifier);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
