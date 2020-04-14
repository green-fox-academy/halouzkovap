using System;

namespace sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Sudoku!");


            int[,] table = new int[9, 9];

            generateFullTable(table);
            printTable(table);
            Console.WriteLine("\n\n\n\n\n");

            int holes = 50;
            punchHolesInTable(table, holes);
            printTable(table);

            int[] holesX = new int[holes];
            int[] holesY = new int[holes];
            findHoles(table, holesX, holesY);

            for (int i = 0; i < holes; i++)
            {
                //Console.WriteLine("Hole " + i + ".: x=" + holesX[i] + ", y=" + holesY[i]);
            }

            /*
            table[3, 3] = 6;
            table[3, 5] = 8;
            table[4, 4] = 7;
            table[7, 3] = 2;
            printTable(table);
            Console.WriteLine(checkRules(table, 3, 3));
            */
        }


        static void findHoles(int[,] table, int[] holesX, int[] holesY)
        {
            int numHoles = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (table[i, j] == 0)
                    {
                        holesX[numHoles] = i;
                        holesY[numHoles] = j;
                        numHoles++;
                    }
                }
            }
        }

        static void punchHolesInTable(int[,] table, int numOfHoles)
        {
            for (int i = 0; i < numOfHoles; i++)
            {
                int x, y;
                do
                {
                    x = random(9);
                    y = random(9);
                } while (table[x, y] == 0);
                table[x, y] = 0;
            }
        }

        static void generateFullTable(int[,] table)
        {
            int countTrialsCells = 0;
            int countTrialsNumbers = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (checkStuck(table, i, j))
                    {
                        //Console.WriteLine("OMG! Time to radical measures!");
                        for (int l = 0; l < 9; l++)
                        {
                            table[i, l] = 0;
                        }
                        i -= 2;
                        break;
                    }
                    else
                    {
                        do
                        {
                            table[i, j] = random(9) + 1;
                            countTrialsNumbers++;
                        } while (!checkRules(table, i, j));

                        //printTable(table);
                    }
                    countTrialsCells++;
                }
            }
            Console.WriteLine("Genration took trials of cells: " + countTrialsCells);
            Console.WriteLine("Genration took trials of numbers: " + countTrialsNumbers);
        }

        static bool checkStuck(int[,] table, int x, int y)
        {
            for (int i = 1; i <= 9; i++)
            {
                table[x, y] = i;
                if (checkRules(table, x, y)) return false;
            }
            return true;
        }

        static bool checkRules(int[,] table, int x, int y)
        {
            if (table[x, y] == 0) return true;
            for (int i = 0; i < 9; i++)
            {
                if (x != i && table[i, y] == table[x, y]) return false;
            }
            for (int i = 0; i < 9; i++)
            {
                if (y != i && table[x, i] == table[x, y]) return false;
            }
            int quadH = x / 3;
            int quadV = y / 3;
            for (int i = 0; i < 3; i++)
            {
                int posX = 3 * quadH + i;
                for (int j = 0; j < 3; j++)
                {
                    int posY = 3 * quadV + j;
                    if (x != posX && y != posY && table[posX, posY] == table[x, y]) return false;
                }
            }
            return true;
        }


        static void printTable(int[,] table)
        {
            Console.WriteLine();
            for (int j = 0; j < 9; j++)
            {
                Console.Write("|---");
            }
            Console.WriteLine("|");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("| " + (table[i, j] == 0 ? " " : table[i, j].ToString()) + " ");
                }
                Console.WriteLine("|");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("|---");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine();
        }

        static int random(int max)
        {
            var rand = new Random();
            return rand.Next() % max;
        }






        static void generateTableOld(int[,] table, int amount)
        {
            if (amount > 81) return;
            for (int i = 0; i < amount; i++)
            {
                while (true)
                {
                    int x = random(9);
                    int y = random(9);
                    if (table[x, y] == 0)
                    {
                        table[x, y] = random(9) + 1;
                        break;
                    }
                }
            }
        }
    }
}
