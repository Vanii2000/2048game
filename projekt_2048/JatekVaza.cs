using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_2048
{
    abstract class JatekVaza
    {
        public int[,] vaza;


        //Random számot generál két megadott érték között
        public int RandomSzam(int kezdoIndex, int vegIndex)
        {
            Random rnd = new Random();
            return rnd.Next(kezdoIndex, vegIndex);
        }




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
