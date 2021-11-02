using RolePlayingAbilityPrototyping.Spells;
using System;
using System.Collections.Generic;
using System.Text;

namespace RolePlayingAbilityPrototyping.Participants
{
    public interface IParticipant
    {
        string Name { get; }
        double Modifier { get; }
        int Level { get; }
        Dictionary<SpellType, double> SpellVector { get; }
        double NotPresentValue { get; }
    }
}