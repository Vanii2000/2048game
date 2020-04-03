using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2048
{
    class Program
    {
        static void Main(string[] args)
        {
            //Példányosítások:
            Bekero bekero = new Bekero(); //Bekero osztályhoz
            /*string nevBekero = bekero.ModBe();*/
            string bekeroNevKi;
            bool vNehezseg;

            //Addig kéri a felhasználót, hogy adja meg a nehézséget amíg helyes értéket nem ad meg.
            do
            {
                Console.Clear();
                string bekeroNev=bekero.NehezsegBe();
                vNehezseg=bekero.ModIgaz(bekeroNev, out bekeroNevKi);
                if (!vNehezseg)
                {
                    Console.WriteLine("A nevet elírta kérem próbálja meg újra beírni a kívánt nehézségi szintet!\nNyomjon meg egy gombot!");
                    Console.ReadKey();
                }
            } while (!vNehezseg);
            Console.WriteLine("A név megfelelő! Kezdődik a játék!");

            JatekVaza ja = new JatekVaza();
            ja.VazKiiras();
            Console.ReadKey();
        }
    }
}
