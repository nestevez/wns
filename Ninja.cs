using System;

namespace wns
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            dexterity = 175;
        }

        public void steal(object victim)
        {
            attack(victim);
            health+=10;
        }

        public void get_away()
        {
            health-=15;
        }
    }
}
