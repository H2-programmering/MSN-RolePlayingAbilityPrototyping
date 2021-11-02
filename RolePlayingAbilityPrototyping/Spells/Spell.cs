using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RolePlayingAbilityPrototyping.Spells
{
    public class Spell
    {
        public static IEnumerable<SpellType> SpellTypeList
        {
            get { return Enum.GetValues(typeof(SpellType)).Cast<SpellType>();  }
        }
    }
}
