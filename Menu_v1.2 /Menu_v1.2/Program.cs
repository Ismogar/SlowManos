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
        MenuPr:
            x = 5;
            Mn1[0] = "Elige la opcion que mas te convenga";
            Mn1[1] = "Algebra Lineal";
            Mn1[2] = "Qumica";
            Mn1[3] = "Fisica";
            Mn1[4] = "Salir";
            c = Menu(Mn1, x);
            switch (c)
            {
                case 1://Algebra Lineal
                    {
                    MenuAlL:
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
                                goto MenuAlL;
                            case 2:
                                goto MenuAlL;
                            case 3://Matrices
                                {
                                MenuMa:
                                    x = 7;
                                    string[] Mm1 = new string[x];
                                    Mm1[0] = "Elige la opcion que mas te convenga";
                                    Mm1[1] = "Operaciones con matrices";
                                    Mm1[2] = "Determinantes";
                                    Mm1[3] = "Traspuesta";
                                    Mm1[4] = "Adjunta";
                                    Mm1[5] = "Inversa";
                                    Mm1[6] = "Volver";
                                    c = Menu(Mm1, x);
                                    Console.Clear();
                                    switch (c)
                                    {
                                        case 1://Operaciones con Matrices
                                            {
                                            MenuMaOp:
                                                x = 6;
                                                string[] MO = new string[x];
                                                int y1 = 1, y2 = 1, z = 1;
                                                int o = 1, cx = 1;
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
                                                    case 1://Suma
                                                        {
                                                            o = 1;
                                                            Console.CursorVisible = true;
                                                            Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                              "columnas y filas pueden sumarse");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.SetCursorPosition(0, 2);
                                                            Console.Write("Cantidad de filas: ");
                                                        asignarZ1:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(19, 2);
                                                                z = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarZ1;
                                                            }
                                                            Console.SetCursorPosition(0, 3);
                                                            Console.Write("Cantidad de Columnas: ");
                                                        asignarY11:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(22, 3);
                                                                y1 = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarY11;
                                                            }
                                                            m1 = AsignarValorMatriz(y1, z, 4);
                                                            m2 = AsignarValorMatriz(y1, z, 4);
                                                            cx = 3 + TamañoNumero(m1, y1, z);
                                                            EscribirValorMatriz(m1, y1, z, o, cx, 4);
                                                            Console.SetCursorPosition(o + (y1 * cx), 4 + (z - 1));
                                                            Console.Write("+");
                                                            o = (cx * y1) + 3;
                                                            cx = 3 + TamañoNumero(m2, y1, z);
                                                            EscribirValorMatriz(m2, y1, z, o, cx, 4);
                                                            Console.SetCursorPosition(o + (y1 * cx), 4 + (z - 1));
                                                            Console.Write("=");
                                                            o += (cx * y1) + 3;
                                                            for (int i = 0; i < z; i++)
                                                            {
                                                                for (int j = 0; j < y1; j++)
                                                                {
                                                                    m1[j, i] += m2[j, i];
                                                                }
                                                            }
                                                            cx = 3 + TamañoNumero(m1, y1, z);
                                                            EscribirValorMatriz(m1, y1, z, o, cx, 4);
                                                            Console.CursorVisible = false;
                                                            Console.ReadKey();
                                                            goto MenuMaOp;
                                                        }
                                                    case 2://Resta
                                                        {
                                                            Console.CursorVisible = true;
                                                            Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                              "columnas y filas pueden restarse");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.SetCursorPosition(0, 2);
                                                            Console.Write("Cantidad de filas: ");
                                                        asignarZ2:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(18, 2);
                                                                z = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarZ2;
                                                            }
                                                            Console.SetCursorPosition(0, 3);
                                                            Console.Write("Cantidad de Columnas: ");
                                                        asignarY12:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(21, 3);
                                                                y1 = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarY12;
                                                            }
                                                            m1 = AsignarValorMatriz(y1, z, 4);
                                                            m2 = AsignarValorMatriz(y1, z, 4);
                                                            cx = 2 * TamañoNumero(m1, y1, z);
                                                            EscribirValorMatriz(m1, y1, z, o, cx, 4);
                                                            Console.SetCursorPosition(o + (y1 * cx), 4 + (z - 1));
                                                            Console.Write("-");
                                                            o = (cx * y1) + 3;
                                                            cx = 2 * TamañoNumero(m2, y1, z);
                                                            EscribirValorMatriz(m2, y1, z, o, cx, 4);
                                                            Console.SetCursorPosition(o + (y1 * cx), 4 + (z - 1));
                                                            Console.Write("=");
                                                            o += (cx * y1) + 3;
                                                            for (int i = 0; i < z; i++)
                                                            {
                                                                for (int j = 0; j < y1; j++)
                                                                {
                                                                    m1[j, i] -= m2[j, i];
                                                                }
                                                            }
                                                            cx = 2 * TamañoNumero(m1, y1, z);
                                                            EscribirValorMatriz(m1, y1, z, o, cx, 4);
                                                            Console.CursorVisible = false;
                                                            Console.ReadKey();
                                                            goto MenuMaOp;
                                                        }
                                                    case 3://Multipliacion
                                                        {
                                                            int mm;
                                                            Console.CursorVisible = true;
                                                            Console.WriteLine("Nota: Solo las matrice que contengan la misma cantidad de " +
                                                                              "filas pueden multiplicarse");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.SetCursorPosition(0, 2);
                                                            Console.Write("Cantidad de filas: ");
                                                        asignarZ3:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(18, 2);
                                                                z = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarZ3;
                                                            }
                                                            Console.SetCursorPosition(0, 3);
                                                            Console.Write("Cantidad de Columnas: ");
                                                        asignarY13:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(21, 3);
                                                                y1 = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarY13;
                                                            }
                                                            m1 = AsignarValorMatriz(y1, z, 4);
                                                            Console.SetCursorPosition(0, 3);
                                                            Console.Write("Cantidad de Columnas de la Segunda Matriz: ");
                                                        asignarY21:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(42, 3);
                                                                y2 = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarY21;
                                                            }
                                                            m2 = AsignarValorMatriz(y2, z, 4);
                                                            cx = 2 * TamañoNumero(m1, y1, z);
                                                            EscribirValorMatriz(m1, y1, z, o, cx, 4);
                                                            Console.SetCursorPosition(o + (y1 * cx), 4 + (z - 1));
                                                            Console.Write("X");
                                                            o = (cx * y1) + 3;
                                                            cx = 2 * TamañoNumero(m2, y2, z);
                                                            EscribirValorMatriz(m2, y2, z, o, cx, 4);
                                                            Console.SetCursorPosition(o + (y2 * cx), 4 + (z - 1));
                                                            Console.Write("=");
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
                                                            }
                                                            cx = 2 * TamañoNumero(m2, y2, z);
                                                            EscribirValorMatriz(m2, y2, z, o, cx, 4);
                                                            Console.CursorVisible = false;
                                                            Console.ReadKey();
                                                            goto MenuMaOp;
                                                        }
                                                    case 4:
                                                        goto MenuMaOp;
                                                    case 5:
                                                        goto MenuMa;
                                                    default:
                                                        break;
                                                }
                                            }
                                            break;
                                        case 2://Determinante
                                            {
                                            MenuMaDe:
                                                Console.CursorVisible = false;
                                                string[] DE = new string[5];
                                                int[,] m1 = new int[2, 2];
                                                int[,] m2 = new int[2, 2];
                                                DE[0] = "Elije la opcion que mas te convenga";
                                                DE[1] = "2x2";
                                                DE[2] = "3x3";
                                                DE[3] = "NxN";
                                                DE[4] = "Volver";
                                                c = Menu(DE, 5);
                                                Console.Clear();
                                                switch (c)
                                                {
                                                    case 1://Matriz 2x2
                                                        {
                                                            int TC = 1;
                                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                                            Console.Clear();
                                                            int[,] m = new int[2, 2];
                                                            Console.WriteLine("Matriz 2x2 ");
                                                            Console.WriteLine("Para calcular el determinante de una matriz 2x2, tienes que " +
                                                                              "ralizar  la multiplicaciÛn y la resta. En este sentido tenemos " +
                                                                              "que multiplicar los n˙meros que se encuentran en las diagonales y " +
                                                                              "encontrar la diferencia entre ellos.");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.CursorVisible = true;
                                                            m2 = AsignarValorMatriz(2, 2, 4);
                                                            TC = 3 + TamañoNumero(m2, 2, 2);
                                                            EscribirValorMatriz(m2, 2, 2, 1, TC, 4);
                                                            Console.CursorVisible = false;
                                                            Console.SetCursorPosition(3, 10);
                                                            Console.Write("La determinante es :" + ((m2[0, 0] * m2[1, 1]) - (m2[0, 1] * m2[1, 0])));
                                                            Console.SetCursorPosition(15, 4);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write("| " + m2[0, 0]);
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine(" " + m2[0, 1] + " |");
                                                            Console.SetCursorPosition(15, 5);
                                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                                            Console.Write("| " + m2[1, 0]);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine(" " + m2[1, 1] + " |");
                                                            Console.SetCursorPosition(30, 4);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write("( " + m2[0, 0] + " * " + m2[1, 1] + " ) ");
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            Console.Write("- ( " + m2[0, 1] + " * " + m2[1, 0] + " ) ");
                                                            Console.SetCursorPosition(30, 5);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write("( " + m2[0, 0] * m2[1, 1] + " ) ");
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.Write("- ( " + m2[0, 1] * m2[1, 0] + " ) ");
                                                            Console.SetCursorPosition(30, 7);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write("( " + ((m2[0, 0] * m2[1, 1]) - (m2[0, 1] * m2[1, 0])) + " ) ");
                                                            Console.ReadKey();
                                                            goto MenuMaDe;
                                                        }
                                                    case 2://Matriz  3x3
                                                        {
                                                            int TC = 1;
                                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                                            Console.Clear();
                                                            int[,] m = new int[3, 3];
                                                            Console.WriteLine("Matriz 3x3 ");
                                                            Console.WriteLine("Para calcular el determinante de una matriz 3x3, " +
                                                                              "tienes que ralizar  la multiplicaciÛn y la resta. " +
                                                                              "En este sentido tenemos que multiplicar los n˙meros " +
                                                                              "que se encuentran en las diagonales y encontrar la " +
                                                                              "diferencia entre ellos.");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            m2 = AsignarValorMatriz(3, 3, 4);
                                                            TC = 3 + TamañoNumero(m2, 3, 3);
                                                            EscribirValorMatriz(m2, 3, 3, 1, TC, 4);
                                                            Console.CursorVisible = false;

                                                            Console.SetCursorPosition(3, 10);
                                                            Console.Write("La determinante es :" + (m2[0, 0] * m2[1, 1] * m2[2, 2] +
                                                                         m2[0, 1] * m2[1, 2] * m2[2, 0] +
                                                                         m2[0, 2] * m2[1, 0] * m2[2, 1] -
                                                                         m2[0, 2] * m2[1, 1] * m2[2, 0] -
                                                                         m2[0, 0] * m2[1, 2] * m2[2, 1] -
                                                                                                    m2[0, 1] * m2[1, 0] * m2[2, 2]));
                                                            Console.SetCursorPosition(15, 4);
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.Write(" ( ( " + (m2[0, 0] * m2[1, 1] * m2[2, 2]) + " )");
                                                            Console.Write(" + ( " + (m2[0, 1] * m2[1, 2] * m2[2, 0]) + " )");
                                                            Console.Write(" + ( " + (m2[0, 2] * m2[1, 0] * m2[2, 1]) + " )");
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.Write(" - ( " + (m2[0, 2] * m2[1, 1] * m2[2, 0]) + " )");
                                                            Console.Write(" - ( " + (m2[0, 0] * m2[1, 2] * m2[2, 1]) + " )");
                                                            Console.Write(" - ( " + (m2[0, 1] * m2[1, 0] * m2[2, 2]) + " ) )");
                                                            Console.SetCursorPosition(15, 5);
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.Write("( " + (m2[0, 0] * m2[1, 1] * m2[2, 2] +
                                                                         m2[0, 1] * m2[1, 2] * m2[2, 0] +
                                                                         m2[0, 2] * m2[1, 0] * m2[2, 1] -
                                                                         m2[0, 2] * m2[1, 1] * m2[2, 0] -
                                                                         m2[0, 0] * m2[1, 2] * m2[2, 1] -
                                                                                                    m2[0, 1] * m2[1, 0] * m2[2, 2]) + " ) ");
                                                            Console.ReadKey();
                                                        }
                                                        goto MenuMaDe;
                                                    case 3:
                                                        goto MenuMaDe;
                                                    case 4:
                                                        goto MenuMa;
                                                    default:
                                                        break;
                                                }
                                            }
                                            break;
                                        case 3://Traspuesta
                                            {
                                                Console.CursorVisible = true;
                                                int ym, xm, ec, em;
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write("Cantidad de filas: ");
                                            AsignarY:
                                                try
                                                {
                                                    Console.SetCursorPosition(19, 0);
                                                    ym = int.Parse(Console.ReadLine());
                                                }
                                                catch (Exception)
                                                {
                                                    Console.SetCursorPosition(0, 12);
                                                    Console.Write("ERROR: Introduce un numero");
                                                    goto AsignarY;
                                                }
                                                Console.Write("Cantidad de Columnas: ");
                                            AsignarX:
                                                try
                                                {
                                                    Console.SetCursorPosition(23, 1);
                                                    xm = int.Parse(Console.ReadLine());
                                                }
                                                catch (Exception)
                                                {
                                                    Console.SetCursorPosition(0, 12);
                                                    Console.Write("ERROR: Introduce un numero");
                                                    goto AsignarX;
                                                }
                                                int[,] Ma1 = new int[xm, ym];
                                                int[,] MaTra = new int[ym, xm];
                                                Ma1 = AsignarValorMatriz(xm, ym, 4);
                                                Console.CursorVisible = false;
                                                for (int i = 0; i < ym; i++)
                                                {
                                                    for (int j = 0; j < xm; j++)
                                                    {
                                                        MaTra[i, j] = Ma1[j, i];
                                                    }
                                                }
                                                ec = 2 * TamañoNumero(Ma1, xm, ym);
                                                EscribirValorMatriz(Ma1, xm, ym, 1, ec, 4);
                                                em = (ec * xm) + 3;
                                                Console.SetCursorPosition((ec * xm) + 1, ym + 3);
                                                Console.WriteLine(">");
                                                EscribirValorMatriz(MaTra, ym, xm, em, ec, 4);
                                                Console.ReadKey();
                                                goto MenuMa;
                                            }
                                        case 4://Adjunta
                                            {
                                                int nFC, TC, EE = 1;
                                                Console.WriteLine("Solo se puede sacar la adjunta de una matriz cuadrada");
                                                Console.WriteLine("Introduce la cantidad de filas y columnas: ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.CursorVisible = true;
                                            AsignarnFC:
                                                try
                                                {
                                                    Console.SetCursorPosition(43, 1);
                                                    nFC = int.Parse(Console.ReadLine());
                                                }
                                                catch (Exception)
                                                {
                                                    Console.SetCursorPosition(0, 12);
                                                    Console.Write("ERROR: Introduce un numero");
                                                    goto AsignarnFC;
                                                }
                                                int[,] MaAd = new int[nFC, nFC];
                                                MaAd = AsignarValorMatriz(nFC, nFC, 4);
                                                TC = 3 + TamañoNumero(MaAd, nFC, nFC);
                                                EscribirValorMatriz(MaAd, nFC, nFC, EE, TC, 4);
                                                MaAd = CofactorMatriz(MaAd, nFC);
                                                Console.SetCursorPosition(EE + (nFC * TC), 4 + (nFC - 1));
                                                Console.Write(">");
                                                EE = (TC * nFC) + 3;
                                                TC = 3 + TamañoNumero(MaAd, nFC, nFC);
                                                Console.WriteLine(TC);
                                                Console.ReadKey();
                                                EscribirValorMatriz(MaAd, nFC, nFC, EE, TC, 4);
                                                Console.ReadKey();
                                                goto MenuMa;
                                            }
                                        case 5://Inversa
                                            goto MenuMa;
                                        case 6:
                                            goto MenuAlL;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case 4:
                                goto MenuPr;
                            default:
                                break;
                        }
                    }
                    break;
                case 2://Quimica
                    {
                    MenuQu:
                        x = 5;
                        string[] Mn3 = new string[x];
                        Mn3[0] = "Elige la opcion que mas te convenga";
                        Mn3[1] = "Balanceo";
                        Mn3[2] = "Configuracion Electronica";
                        Mn3[3] = "Tabla Periodica";
                        Mn3[4] = "Volver";
                        c = Menu(Mn3, x);
                        switch (c)
                        {
                            case 1:
                                goto MenuQu;
                            case 2:
                                goto MenuQu;
                            case 3:
                                goto MenuQu;
                            case 4:
                                goto MenuPr;
                            default:
                                break;
                        }
                        break;
                    }
                case 3://Fisica
                    {
                    MenuFi:
                        x = 4;
                        string[] Mn4 = new string[x];
                        Mn4[0] = "Elige la opcion que mas te convenga";
                        Mn4[1] = "MRU";
                        Mn4[2] = "Conversor";
                        Mn4[3] = "Volver";
                        c = Menu(Mn4, x);
                        switch (c)
                        {
                            case 1:
                                goto MenuFi;
                            case 2:
                                goto MenuFi;
                            case 3:
                                goto MenuPr;
                        }
                        break;
                    }
                case 4://Salir
                    {
                        string[] Mn5 = new string[x];
                        Mn5[0] = "¿Seguro?";
                        Mn5[1] = "Si";
                        Mn5[2] = "No";
                        c = Menu(Mn5, x);
                        switch (c)
                        {
                            case 2:
                                goto MenuPr;
                            default:
                                break;
                        }
                        break;
                    }
                default:
                    break;
            }
            Console.Clear();
            Console.WriteLine("Adios");
        }

        static int Menu(string[] mn, int x)
        {
            Console.CursorVisible = false;
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

        static int[,] AsignarValorMatriz(int x, int y, int IM)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int TC = 1;
            int[,] m = new int[x, y];
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                MenuFu:
                    try
                    {
                        Console.CursorVisible = true;
                        Console.SetCursorPosition((TC * j) + 1, (i * 2) + IM);
                        m[j, i] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.SetCursorPosition((3 * j), (i * 2) + IM);
                        {
                            Console.Write("                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            ");
                        }
                        Console.SetCursorPosition(0, 12);
                        Console.Write("ERROR: Introduce un numero");
                        goto MenuFu;
                    }
                    Console.SetCursorPosition(0, (i * 2) + IM);
                    {
                        Console.Write("                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            ");
                    }
                    TC = 3 + TamañoNumero(m, x, y);
                    EscribirValorMatriz(m, x, y, 1, TC, IM);
                }
            }
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.SetCursorPosition((TC * j), (i * 2) + IM);
                    {
                        Console.Write("                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            " +
                                      "                                            ");
                    }
                }
            }
            return m;
        }

        static void EscribirValorMatriz(int[,] m, int x, int y, int z, int c, int IM)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j == 0)
                    {
                        Console.SetCursorPosition(((c * j) + z) - 1, (i * 2) + IM);
                        Console.Write("|");
                        if (i + 1 != y)
                        {
                            Console.SetCursorPosition(((c * j) + z) - 1, ((i * 2) + IM) + 1);
                            Console.Write("|");
                        }
                    }
                    if (j + 1 == x)
                    {
                        Console.SetCursorPosition(((c * j) + z) + TamañoNumero(m, x, y), (i * 2) + IM);
                        Console.Write("|");
                        if (i + 1 != y)
                        {
                            Console.SetCursorPosition(((c * j) + z) + TamañoNumero(m, x, y), ((i * 2) + IM) + 1);
                            Console.Write("|");
                        }
                    }
                    Console.SetCursorPosition((c * j) + z, (i * 2) + IM);
                    Console.Write(m[j, i]);
                }
            }
        }

        static int TamañoNumero(int[,] m, int x, int y)
        {
            int c = 1;
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
                            if (mS1.Length > mS2.Length)
                            {
                                c = 1 + mS1.Length;
                            }
                        }
                    }
                }
            }
            return c;
        }

        static int[,] CofactorMatriz(int[,] m, int x1)
        {
            int[,] CoM = new int[x1, x1];
            int[,] R = new int[x1, x1];
            switch (x1)
            {
                case 2:
                    int a;
                    a = m[1, 1];
                    m[1, 1] = m[1, 1];
                    m[0, 0] = a;
                    m[1, 0] *= -1;
                    m[0, 1] *= -1;
                    break;
                case 3:
                    int[,] coM = new int[2, 2];
                    int c2 = 0, f2 = 0;
                    for (int fX = 0; fX < 3; fX++)
                    {
                        for (int cX = 0; cX < 3; cX++)
                        {
                            c2 = 0;
                            f2 = 0;
                            for (int f1 = 0; f1 < 3; f1++)
                            {
                                for (int c1 = 0; c1 < 3; c1++)
                                {
                                    if (f1 != fX && c1 != cX)
                                    {
                                        coM[c2, f2] = m[c1, f1];
                                        if (c2 < 1 && f2 <= 1)
                                        {
                                            c2++;
                                        }
                                        else
                                        {
                                            c2 = 0;
                                            if (f2 < 1)
                                            {
                                                f2++;
                                            }
                                            else
                                            {
                                                f2 = 0;
                                                c1 = 3;
                                            }
                                        }
                                    }
                                }
                            }
                            R[cX, fX] = (coM[0, 0] * coM[1, 1]) - (coM[0, 1] * coM[1, 0]);
                        }
                    }
                    break;
            }
            return R;
        }
    }
}