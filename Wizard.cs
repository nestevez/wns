using System;

namespace wns
{
    public class Wizard : Human
    {
        private Random rand = new Random();
        public Wizard(string name) : base(name,3,25,3,50)
        {}

        public void heal()
        {
            health += intelligence*10;
        }

        public void fireball(object victim)
        {
            if(victim is Human)
            {
                Human actualVictim = (Human)victim;
                actualVictim.health-= rand.Next(20,51);
            }
        }
    }
}
