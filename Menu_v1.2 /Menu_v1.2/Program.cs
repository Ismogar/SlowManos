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
                x = 5;
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
                                        x = 6;
                                        string[] MO = new string[x];
                                        int y1 = 1, y2 = 1, z = 1;
                                        int o = 1, cx;
                                        int[,] m1 = new int[y1, z];
                                        int[,] m2 = new int[y1, z];
                                        MO[0] = "Elije la opcion que mas te cnovenga";
                                        MO[1] = "Suma";
                                        MO[2] = "Resta";
                                        MO[3] = "Multiplicacion";
                                        MO[4] = "Division";
                                        MO[5] = "Volver";
                                        c = Menu(MO, x);
                                        Console.Clear();
                                        switch (c)
                                        {
                                            case 1:
                                                Console.CursorVisible = true;
                                                Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                  "columnas y filas pueden sumarse");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write("Cantidad de filas: ");
                                                z = int.Parse(Console.ReadLine());
                                                Console.Write("Cantidad de Columnas: ");
                                                y1 = int.Parse(Console.ReadLine());
                                                m1 = AsignarValorMatriz(y1, z);
                                                m2 = AsignarValorMatriz(y1, z);
                                                EscribirValorMatriz(m1, y1, z, o);
                                                cx = 2 * TamañoNumero(m1, y1, z);
                                                Console.SetCursorPosition(o + (y1 * 2), 4 + (z - 1));
                                                Console.Write("+");
                                                o = (cx * y1) + 3;
                                                EscribirValorMatriz(m2, y1, z, o);
                                                Console.SetCursorPosition(o + (y1 * 2), 4 + (z - 1));
                                                Console.Write("=");
                                                cx = 2 * TamañoNumero(m2, y1, z);
                                                o += (cx * y1) + 3;
                                                for (int i = 0; i < z; i++)
                                                {
                                                    for (int j = 0; j < y1; j++)
                                                    {
                                                        m1[j, i] += m2[j, i];
                                                        EscribirValorMatriz(m1, y1, z, o);
                                                    }
                                                }
                                                Console.CursorVisible = false;
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                Console.CursorVisible = true;
                                                Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                  "columnas y filas pueden restarse");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write("Cantidad de filas: ");
                                                z = int.Parse(Console.ReadLine());
                                                Console.Write("Cantidad de Columnas: ");
                                                y1 = int.Parse(Console.ReadLine());
                                                m1 = AsignarValorMatriz(y1, z);
                                                m2 = AsignarValorMatriz(y1, z);
                                                EscribirValorMatriz(m1, y1, z, o);
                                                cx = 2 * TamañoNumero(m1, y1, z);
                                                Console.SetCursorPosition(o + (y1 * 2), 4 + (z - 1));
                                                Console.Write("-");
                                                o = (cx * y1) + 3;
                                                EscribirValorMatriz(m2, y1, z, o);
                                                Console.SetCursorPosition(o + (y1 * 2), 4 + (z - 1));
                                                Console.Write("=");
                                                cx = 2 * TamañoNumero(m2, y1, z);
                                                o += (cx * y1) + 3;
                                                for (int i = 0; i < z; i++)
                                                {
                                                    for (int j = 0; j < y1; j++)
                                                    {
                                                        m1[j, i] -= m2[j, i];
                                                        EscribirValorMatriz(m1, y1, z, o);
                                                    }
                                                }
                                                Console.CursorVisible = false;
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                int mm;
                                                Console.CursorVisible = true;
                                                Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                  "filas pueden multiplicarse");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write("Cantidad de filas: ");
                                                z = int.Parse(Console.ReadLine());
                                                Console.Write("Cantidad de Columnas de la Primer Matriz: ");
                                                y1 = int.Parse(Console.ReadLine());
                                                m1 = AsignarValorMatriz(y1, z);
                                                Console.SetCursorPosition(0, 3);
                                                Console.Write("Cantidad de Columnas de la Segunda Matriz: ");
                                                y2 = int.Parse(Console.ReadLine());
                                                m2 = AsignarValorMatriz(y2, z);
                                                EscribirValorMatriz(m1, y1, z, o);
                                                cx = 2 * TamañoNumero(m1, y1, z);
                                                Console.SetCursorPosition(o + (y1 * cx), 4 + (z - 1));
                                                Console.Write("X");
                                                o = (cx * y1) + 3;
                                                EscribirValorMatriz(m2, y2, z, o);
                                                Console.SetCursorPosition(o + (y2 * cx), 4 + (z - 1));
                                                Console.Write("=");
                                                cx = 2 * TamañoNumero(m2, y2, z);
                                                o += (cx * y2) + 3;
                                                for (int i = 0; i < z; i++)
                                                {
                                                    mm = 0;
                                                    for (int j = 0; j < y1; j++)
                                                    {
                                                        mm += m1[j, i];
                                                    }
                                                    for (int j = 0; j < y2; j++)
                                                    {
                                                        m2[j, i] *= mm;
                                                    }
                                                    EscribirValorMatriz(m2, y2, z, o);
                                                }
                                                Console.CursorVisible = false;
                                                Console.ReadKey();
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

        static int[,] AsignarValorMatriz(int x, int y)
        {
            int[,] m = new int[x, y];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {

                    Console.SetCursorPosition((3 * j), (i + 2) * 2);
                    m[j, i] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.SetCursorPosition((3 * j), (i + 2) * 2);
                    Console.Write(" ");
                }
            }
            return m;
        }

        static void EscribirValorMatriz(int[,] m, int x, int y, int z)
        {
            int c = 2 * TamañoNumero(m, x, y);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j == 0)
                    {
                        Console.SetCursorPosition(((c * j) + z) - 1, (i + 2) * 2);
                        Console.Write("|");
                        if (i + 1 != y)
                        {
                            Console.SetCursorPosition(((c * j) + z) - 1, ((i + 2) * 2) + 1);
                            Console.Write("|");
                        }
                    }
                    if (j + 1 == x)
                    {
                        Console.SetCursorPosition(((c * j) + z) + 1, (i + 2) * 2);
                        Console.Write("|");
                        if (i + 1 != y)
                        {
                            Console.SetCursorPosition(((c * j) + z) + 1, ((i + 2) * 2) + 1);
                            Console.Write("|");
                        }
                    }
                    Console.SetCursorPosition((c * j) + z, (i + 2) * 2);
                    Console.Write(m[j, i]);
                }
            }
        }

        static int TamañoNumero(int[,] m, int x, int y)
        {
            int c = 0;
            string mS1, mS2;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    for (int k = 0; k < y; k++)
                    {
                        for (int l = 0; l < x; l++)
                        {
                            mS1 = m[j, i].ToString();
                            mS2 = m[l, k].ToString();
                            c = mS1.Length >= mS2.Length ? mS1.Length : mS2.Length;
                        }
                    }
                }
            }
            return c;
        }
    }
}