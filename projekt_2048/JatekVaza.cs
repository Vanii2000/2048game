using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2048
{
    abstract class JatekVaza
    {
        //Mátrix inicializálása
        public int[,] vaza=new int[4,4];

        //Példányosítjuk a Random osztályt, ha nem itt példányosítom mindig azonos random számokat ad a 'szamR' változóra
        public Random rnd = new Random();

        //Random számot generál két megadott érték között
        private int RandomSzam(out int x, out int y) //Visszaadja az x és y koordinátát is
        {
            //Elkészíti a véletlen számot amit feltöltünk a mátrixba
            int szamR = rnd.Next(1,3)*2;
            //A koordinátáknak ad véletlenszerű értéket, megvizsgálja, hogy üres e az adott cella a mátrixban
            do
            {
                x = rnd.Next(1,4);
                y = rnd.Next(1,4);

                if (vaza[x,y]==0)
                {
                    return szamR;
                }
            } while (true);
        }

        //Feltölti a mátrixot
        public void MatrixFeltoltes()
        {
            //Változók
            int osszeg = 0;
            int x, y;

            //Ciklus ami végigfut a mátrixon és összeadja az elemeit
            for (int i = 0; i < vaza.GetLength(0); i++)
            {
                for (int j = 0; j < vaza.GetLength(1); j++)
                {
                    osszeg = osszeg + vaza[i, j];
                }
            }
            //Megvizsgáljuk, hogy üres e a matrix, ha igen két kezdőértéket kap
            if (osszeg==0)
            {
                int szam=RandomSzam(out x,out y);
                vaza[x, y] = szam;

                int szam1 = RandomSzam(out x, out y);
                vaza[x, y] = szam1;
            }
            //Ha nem akkor csak egy számot hozzáad egy üres cellához
            else
            {
                int szam = RandomSzam(out x, out y);
                vaza[x, y] = szam;
            }
        }

        //megnézi, hogy tele van e a tömb

        //Kiírja a mátrixot
        public virtual void VazKiiras()
        {
            for (int i = 0; i < vaza.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < vaza.GetLength(1); j++)
                {
                    if (vaza[i,j]==0)
                    {
                        Console.Write("|   ");
                    }
                    else
                    Console.Write("| {0} ",vaza[i,j]);
                }
                Console.Write("|");
            }
        }

    }
}
