using System;
using static System.Convert;
using System.Threading;

namespace Menu_v1
{
    class MainClass
    {
        //Avr si si funciona tis wea
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int x = 5, c;
            string[] Mn1 = new String[x];
            Console.CursorVisible = false;
            do
            {
                Mn1[0] = "Elige la opcion que mas te convenga";
                Mn1[1] = "Algebra Lineal";
                Mn1[2] = "Qumica";
                Mn1[3] = "Fisica";
                Mn1[4] = "Salir";
                c = Menu(Mn1, x);

                switch (c)
                {
                    case 1:
                        x = 5;
                        string[] Mn2 = new string[x];
                        Mn2[0] = "Elige la opcion que mas te convenga";
                        Mn2[1] = "Incognitas";
                        Mn2[2] = "Vectores";
                        Mn2[3] = "Matrices";
                        Mn2[4] = "Volver";
                        c = Menu(Mn2, x);
                        switch (c)
                        {
                            case 1:
                                Console.WriteLine("Incognitas");
                                break;
                            case 2:
                                break;
                            case 3:
                                x = 4;
                                string[] Mm1 = new string[x];
                                Mm1[0] = "Elige la opcion que mas te convenga";
                                Mm1[1] = "Operaciones con matrices";
                                Mm1[2] = "Determinantes";
                                Mm1[3] = "Volver";
                                c = Menu(Mm1, x);
                                switch (c)
                                {
                                    case 1:
                                        x = 5;
                                        string[] MO = new string[x];
                                        MO[0] = "Elije la opcion que mas te cnovenga";
                                        MO[1] = "Suma";
                                        MO[2] = "Resta";
                                        MO[3] = "Multiplicacion";
                                        MO[4] = "Volver";
                                        c = Menu(MO, x);
                                        Console.Clear();
                                        switch (c)
                                        {
                                            case 1:
                                                int y, z;
                                                Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                  "columnas y filas pueden sumarse");
                                                Console.Write("Cantidad de filas: ");
                                                z = int.Parse(Console.ReadLine());
                                                Console.Write("Cantidad de Columnas: ");
                                                y = int.Parse(Console.ReadLine());
                                                int[,] m = new int[y, z];
                                                for (int i = 0; i < z; i++)
                                                {
                                                    for (int j = 0; j < y; j++)
                                                    {
                                                        Console.SetCursorPosition(2 * j, (i + 6)*2);
                                                        m[j, i] = int.Parse(Console.ReadLine());
                                                    }
                                                }
                                                break;

                                        }
                                        break;
                                    case 2:

                                        break;
                                    case 3:

                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 4:
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        x = 5;
                        string[] Mn3 = new string[x];
                        Mn3[0] = "Elige la opcion que mas te convenga";
                        Mn3[1] = "Balanceo";
                        Mn3[2] = "Configuracion Electronica";
                        Mn3[3] = "Tabla Periodica";
                        Mn3[4] = "Volver";
                        c = Menu(Mn3, x);
                        break;
                    case 3:
                        x = 4;
                        string[] Mn4 = new string[x];
                        Mn4[0] = "Elige la opcion que mas te convenga";
                        Mn4[1] = "MRU";
                        Mn4[2] = "Conversor";
                        Mn4[3] = "Volver";
                        c = Menu(Mn4, x);
                        break;
                    case 4:
                        string[] Mn5 = new string[x];
                        Mn5[0] = "¿Seguro?";
                        Mn5[1] = "Si";
                        Mn5[2] = "No";
                        c = Menu(Mn5, x);
                        switch (c)
                        {
                            case 1:
                                c = x + 1;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            } while (c != x + 1);
            Console.WriteLine("Adios");
        }

        static int Menu(string[] mn, int x)
        {
            int c = 1;
            System.ConsoleKey T = new System.ConsoleKey();
            do
            {
                Console.Clear();
                for (int i = 0; i < x; i++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(mn[i]);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (i == c)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(">" + mn[i]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" " + mn[i]);
                        }
                    }
                }
                T = Console.ReadKey().Key;
                switch (T)
                {
                    case ConsoleKey.UpArrow:
                        c--;
                        if (c >= x || c == 0)
                        {
                            c = x - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        c++;
                        if (c >= x || c == 0)
                        {
                            c = 1;
                        }
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        break;
                }
            } while (T != ConsoleKey.Enter);
            return c;
        }

    }
}