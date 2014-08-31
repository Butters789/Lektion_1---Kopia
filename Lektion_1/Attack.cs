using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lektion_1
{
    public class Attack
    {
        //Man kommer hit om man skriver "punch" när man väljer attack
        public static void DoPunch()
        {
            Console.Clear();
            Console.Write("Funkar");
            //ändrar motståndarens hp
            Program.mobHp -= 2;
            Console.WriteLine("Motståndarens hp är just nu {0}", Program.mobHp);
            return;   
            //return gör så man kommer tillbaka till fighten och får slåss mer
        }
        //samma sak med punch fast med kick istället
        public static void DoKick()
        {
            Console.Write("Funkar");

            Program.mobHp -= 2;
            Console.WriteLine("Motståndarens hp är just nu {0}", Program.mobHp);
            return;
        }
    }
}
