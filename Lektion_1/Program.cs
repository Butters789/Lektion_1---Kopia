using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_1
{
    class Program
    {
        // Skapar en variabel av datatypen string.
        static string playerName;
        static string mobFight;
        static string playerPunch = "Punch";
        static string playerKick = "Kick";
        static int playerAge;
        static int monsterKills;
        static int mobExp;
        static int playerHp = 10;
        public static int mobHp = 5;

        static void Main(string[] args)
        {
            

            //Läser in namnet.
            
            Console.Write("Vad heter du? ");
            playerName = Console.ReadLine();

            //Läser in åldern.
            Console.Write("Hur gammal är du? ");
            playerAge = Convert.ToInt32(Console.ReadLine()); 

            //Startar historien.
            //Console.WriteLine("Nu börjar äventyret om " + playerName +".")
            Console.WriteLine("Nu börjar äventyret om {0}.", playerName);
            Console.WriteLine("{0} är {1} år gammal.", playerName, playerAge);
            Console.Clear();
            Console.WriteLine("En dag så mötte {0} en farlig varg i skogen.", playerName);
            Console.WriteLine("Vargen som såg så farlig ut var inte alls farlig märkte {0}", playerName);
            Console.WriteLine();
            Console.WriteLine("Vargen sa till {0} jag är den farligaste vargen i hela skogen.", playerName);
            Console.WriteLine("Jag är inte rädd för dig, jag har ju dödat många vargar som du. ");
            Console.WriteLine();
            Console.Write("Hur många vargar har du dödat då? ");
            monsterKills = Convert.ToInt32(Console.ReadLine());

            //Här svarar man hur många vargar man har dödat osv.
            Console.WriteLine("Har du dödat {0} stycken!?", monsterKills);
            Console.WriteLine();
            Console.Write("Hur mycket EXP har du fått från varje? ");
            mobExp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("då är du i level {0}", monsterKills * mobExp / 15);

            Console.WriteLine();
            Console.WriteLine("Vill du slåss mot vargen? Ja/Nej? ");
            mobFight = Console.ReadLine();
            //Här är en flervals fråga, If menar att "om jag säger ja så händer en typ av event" osv.
            if (mobFight == "ja")

            {
                while (mobHp > 0)
                {
                    Console.Clear();
                    Console.WriteLine("*SUPER EPIC BATTLE*");
                    Console.WriteLine();
                    Console.WriteLine("Vargens liv: {0}", mobHp);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Ditt liv: {0}", playerHp);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("[Press Enter]");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("Vargen använder BITE och skadar dig 2 hp");
                    playerHp -= 2;
                    Console.Read();
                    Console.Clear();


                    Console.WriteLine("*SUPER EPIC BATTLE*");
                    Console.WriteLine();
                    Console.WriteLine("Vargens liv: {0}", mobHp);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Ditt liv: {0}", playerHp);
                    Console.WriteLine();
                    Console.WriteLine("Din tur välj attack.");
                    Console.WriteLine();
                    Console.WriteLine("[Press Enter]");
                    Console.Read();
                    Console.Clear();
                    //kollar om mob hp är över 1, om det är under 1 så slutar loopen och man kommer till Tillbaka

                    FirstAttack();
                }

                Console.WriteLine("Tillbaka");
 
            }

            Console.ReadLine();

        }
        //FirstAttack är operationen som man kommer tillbaka till med loopen "While"
        static void FirstAttack()
        {
            Console.WriteLine("*SUPER EPIC BATTLE*");
            Console.WriteLine();
            Console.WriteLine("Vargens liv: {0}", mobHp);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ditt liv: {0}", playerHp);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Vad väljer du?");
            Console.WriteLine("[{0}]-[{1}]", playerPunch, playerKick);
            // String tempAttack gör så om man har "Döpt" den till punch eller kick så kollar den vad man har valt den till och då gör vad den är sätt till
            string tempAttack = Console.ReadLine().ToLower();
            if (tempAttack == "punch")
                Attack.DoPunch();
                //om man skriver "punch" så kommer man in i Attacks classen
            else if (tempAttack == "kick")
                Attack.DoKick();
            else
                {
                    Console.Clear();
                    FirstAttack();
                }
            
                    
        }
    }
}
