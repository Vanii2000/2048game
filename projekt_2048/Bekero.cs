using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2048
{
    public class Bekero
    {

        //Változóink az adott osztályhoz:

        //A nehézségi szint neve, a switchBe() metódus utána dolgozik vele, ez alapján kapjuk meg a játék vázát
        public string nevBe;
      
        //Levezényli a nehézségi fok bekérését, és visszaadja a felhasználó által beírt stringet
        public string NehezsegBe()
        {
            Console.WriteLine("Üdvözlöm! Kérem válassza ki, hogy milyen módban kíván játszani!(A kívánt játékmódot a neve alapján adja meg!)");
            Console.WriteLine("1.Normál\n2.Nehéz\n3.New game+\n");

            Console.Write("Írja be a kívánt nehézségi szintet: ");
            string nevKi = Console.ReadLine();
            return nevKi;
        }

        //Bekéri a felhasználótól a nevet. Nagybetűsre állítja így mindegy, hogy kis vagy nagybetűvel írta e be.
        public bool ModIgaz(string nevIgaz, out string nevIgazKi)
        { 
            if (nevIgaz.ToUpper() == "NORMÁL" || nevIgaz.ToUpper() == "NEHÉZ" || nevIgaz.ToUpper() == "NEW GAME +" || nevIgaz.ToUpper() == "NEWGAME+" || nevIgaz.ToUpper() == "NEW GAME+")
            {
                nevIgazKi = nevIgaz;
                return true;
            }
            else {nevIgazKi = null; return false; }
        }
  
        //A megadott mód alapján visszaasja azt az értéket amivel a program utána dolgozni tud, hogy kiválassza a megfelelő mátrixot és, hogy meddig menjen a játék
        public int SwitchBe()
        {
            switch (nevBe)
            {
                case "NORMÁL":
                    return 1; break;
                case "NEHÉZ":
                    return 2; break;
                case "NEW GAME +":
                    return 3; break;
                case "NEWGAME+":
                    return 3; break;
                case "NEW GAME+":
                    return 3; break;
                default:
                    return 0; break;
            }
        }
    }

}
