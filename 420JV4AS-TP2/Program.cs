// Nom ici

using System;

namespace _420JV4AS_TP2
{
    public enum Ore { Copper, Silver, Gold };

    public struct Tile
    {
        public Ore ore;
        public int quality;

        public Tile(Ore o, int q)
        {
            ore = o;
            quality = q;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Question1(Data.Ores1);
            //Question1(Data.Ores2);
            //Question2(Ore.Silver, Data.Tiles);
            //Question2(Ore.Gold, Data.Tiles);
            //Question3(Data.Jagged1);
            //Question3(Data.Jagged2);
            Console.Read();
        }

        static void Question1(Ore[] ores)
        {

            foreach (Ore ore in ores)
            {
                Console.Write(ore + ", ");
            }
            Console.WriteLine();
        }

        static void Question2(Ore ore, Tile[,] tiles)
        {
            int x = 0;
            int y = 0;
            Console.WriteLine(x + ", " + y);
        }

        static void Question3(int[][] ints)
        {
            foreach (int[] int1 in ints)
            {
                foreach (int i in int1)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
