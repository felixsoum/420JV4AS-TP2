namespace _420JV4AS_TP2
{
    static class Data
    {
        public static Ore[] Ores1
        {
            get
            {
                return new Ore[] { Ore.Gold, Ore.Silver, Ore.Copper };
            }
        }

        public static Ore[] Ores2
        {
            get
            {
                return new Ore[] { Ore.Copper, Ore.Copper, Ore.Copper, Ore.Silver, Ore.Silver, Ore.Gold };
            }
        }

        public static Tile[,] Tiles
        {
            get
            {
                return new Tile[,]
                {
                    { new Tile(Ore.Copper, 32), new Tile(Ore.Silver, 56) , new Tile(Ore.Copper, 14), new Tile(Ore.Gold, 99) },
                    { new Tile(Ore.Silver, 47), new Tile(Ore.Silver, 34) , new Tile(Ore.Silver, 44), new Tile(Ore.Copper, 21) },
                    { new Tile(Ore.Copper, 1), new Tile(Ore.Silver, 51) , new Tile(Ore.Gold, 78), new Tile(Ore.Copper, 15) },
                    { new Tile(Ore.Copper, 11), new Tile(Ore.Gold, 88) , new Tile(Ore.Gold, 76), new Tile(Ore.Gold, 67) }
                };
            }
        }

        public static int[][] Jagged1
        {
            get
            {
                return new int[][]
                {
                    new int[] {10,12},
                    new int[] {0,2,4,6,8},
                    new int[] {1,3,5,7}
                };
            }
        }

        public static int[][] Jagged2
        {
            get
            {
                return new int[][]
                {
                    new int[] {0,1,2,3,4,5,6,7}, new int[] {7,7,7},
                    new int[] {0,2,4,6,8,0,2,4,6}, new int[] {0,1},
                    new int[] {0,1,2,3,3,5,6,7}, new int[] {8,8,8},
                    new int[] {0,1,2,3,4,5,6,7,8,9}, new int[] {1},
                    new int[] {8,6,4,2,2,4,6}, new int[] {1,2,1,2,1},
                    new int[] {7,6,5,4,3,2}, new int[] {2,1,2,1,2},
                    new int[] {0,1,0,1,0,1,0,1}, new int[] {2,3,5,7},
                };
            }
        }
    }
}
