using System;

namespace wns
{
    public class Samurai : Human
    {
        private static int count;
        public Samurai(string name) : base(name)
        {
            health=200;
            count++;
        }

        public void death_blow(object victim)
        {
            attack(victim);
            if(victim is Human)
            {
                Human actVict = (Human)victim;
                if(actVict.health<50)
                {
                    actVict.health=0;
                }
            }
        }

        public void meditate()
        {
            Samurai temp = new Samurai(name);
            health = temp.health;
        }

        public static void how_many()
        {
            System.Console.WriteLine(count);
        }
    }
}
