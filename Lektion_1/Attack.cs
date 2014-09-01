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
            //ändrar motståndarens hp
            Program.mobHp -= 1;

            if (Program.mobHp < 0)
                FightWin();
            return;
            //return gör så man kommer tillbaka till fighten och får slåss mer
        }
        //samma sak med punch fast med kick istället
        public static void DoKick()
        {
            Program.mobHp -= 2;

            if (Program.mobHp < 0)
                FightWin();
                
            return;
        }

        public static void FightWin()
        {
            Program.ClearConsole();
            Console.WriteLine();
            Console.WriteLine("Vargen dog och du fick {0} Exp.", Program.mobExp);
            Console.WriteLine("Du är nu i level {0}", Program.monsterKills * Program.mobExp / 15 + 1);
            Console.Read();
        }
    }
}
