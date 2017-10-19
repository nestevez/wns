using System;

namespace wns
{
    class Program
    {
        static void Main(string[] args)
        {
            Samurai potato = new Samurai("Potato");
            Samurai sweetpotato = new Samurai("Potato");
            Samurai pweetsotato = new Samurai("Potato");
            Samurai sweet = new Samurai("Potato");
            Ninja nopotato = new Ninja("Potato");
            Wizard watsweetpotato = new Wizard("Potato");
            Ninja nopweetsotato = new Ninja("Potato");
            Wizard watsweet = new Wizard("Potato");
            nopotato.steal(potato);
            nopweetsotato.get_away();
            watsweet.heal();
            watsweetpotato.fireball(sweetpotato);
            Samurai.how_many();
            System.Console.WriteLine(nopotato.health);
            System.Console.WriteLine(potato.health);
            System.Console.WriteLine(nopweetsotato.health);
            System.Console.WriteLine(watsweet.health);
            System.Console.WriteLine(watsweetpotato.health);
            System.Console.WriteLine(sweetpotato.health);
        }
    }
}
