using System;

namespace RolePlayingAbilityPrototyping.Participants
{
    public class Opponent : ParticipantBase
    {
        public Opponent(string name, int level) : base(name, level)
        {
        }

        public override double NotPresentValue
        {
            get { return 100.0; }
        }

        public override double Modifier
        {
            get { return 1.0 / Math.Pow(Level, 0.3); }
        }

    }
}