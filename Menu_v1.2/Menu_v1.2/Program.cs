using System;
using static System.Convert;
using System.Threading;

namespace Menu_v1
{
    class EText
    {
        string[] El = {"H","He","Li","Be","B","C","N","O","F","Ne","Na","Mg","Al","Si","P","S","Cl","Ar",""};
        string[] ElNa={};
        int x, X, y, index, k, longitudvec;
        string s;
        public EText(string s, int x, int y)
        {
            this.x = x;
            this.y = y;
            X = 45;
            k = 0;
            this.s = s;
            longitudvec = s.Length;
            index = longitudvec - 1;

        }

        public void ve()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(X, y);
            for (int i = k; i < longitudvec; i++)
            {

                if (i == index)
                {
                    System.Threading.Thread.Sleep(300);

                    char[] carat = new char[10];




                }
                Console.Write(s[i]);
                if (index == k)
                {
                    k++;
                    X++;
                    index = longitudvec;
                }

                index--;

            }


        }
    }
    class MainClass
    {
        int x, X, y, index, k, longitudvec;
        string s;
        static void dibujarescrito(string[] str)
        {
            Console.CursorVisible = true;

            int n = str.Length;

            EText[] ET = new EText[n];
            int x, y;
            x = 15;
            y = 8;
            for (int i = 0; i < n; i++)
            {
                ET[i] = new EText(str[i], x, y + i);
            }
            int ctr = -n;
            foreach (EText et in ET)
            {
                et.ve();
            }
            Console.ReadKey();
            Console.Clear();


        }

        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int x = 5, c;
            string[] Mn1 = new String[x];
            string[] str = { " 00     00  00   000   00   00  000000000 0    0 00   00",
                                              "0  00   00  00  00 00  00   00  000000000 0    0 000 000",
                                              "0  00   00  00 00  000 0000 00     000    0    0 00 0 00  ",
                                              "0  00   00  00 0000000 00 0 00     000    0    0 00   00 ",
                                              "0  0    00  00 00   00 00 0000     000    0    0 00   00 ",
                                              " 00 0   000000 00   00 00  000     000     0000  00   00   "};
            dibujarescrito(str);
            Console.CursorVisible = false;
        MenuPr:
            Mn1[0] = "Elige la opcion que mas te convenga";
            Mn1[1] = "Algebra Lineal";
            Mn1[2] = "Qumica";
            Mn1[3] = "Fisica";
            Mn1[4] = "Salir";
            c = Menu(Mn1, 5);
            switch (c)
            {
                case 1://Algebra Lineal
                    {
                        Console.Clear();
                        str = new string[] {     " 000   00      0 0000 000000 000000  000000     000",
                                         "00 00  00     0       0      00   00 00   00   00 00",
                                         "00000  00     0   000 000000 00   0  00  00    00000",
                                         "00 00  00     0     0 0      00    0 00000     00 00",
                                         "00 00  00     0     0 0      00   00 00  00    00 00",
                                         "00 00  000000  00000  000000 000000  00    00  00 00"};
                        dibujarescrito(str);
                        Console.Clear();
                    MenuAlL:
                        string[] Mn2 = new string[4];
                        Mn2[0] = "Elige la opcion que mas te convenga";
                        Mn2[1] = "Incognitas";
                        Mn2[2] = "Matrices";
                        Mn2[3] = "Volver";
                        // Mn2[4] = "Volver";
                        c = Menu(Mn2, 4);
                        switch (c)
                        {
                            case 1:

                                goto MenuAlL;
                            case 2://Matrices
                                {
                                MenuMa:
                                    string[] Mm1 = new string[7];
                                    Mm1[0] = "Elige la opcion que mas te convenga";
                                    Mm1[1] = "Operaciones con matrices";
                                    Mm1[2] = "Determinantes";
                                    Mm1[3] = "Traspuesta";
                                    Mm1[4] = "Adjunta";
                                    Mm1[5] = "Inversa";
                                    Mm1[6] = "Volver";
                                    c = Menu(Mm1, 7);
                                    Console.Clear();
                                    switch (c)
                                    {
                                        case 1://Operaciones con Matrices
                                            {
                                            MenuMaOp:
                                                string[] MO = new string[6];
                                                int y1 = 1, y2 = 1, z = 1;
                                                int o = 1, cx = 1;
                                                int[,] m1 = new int[y1, z];
                                                int[,] m2 = new int[y1, z];
                                                MO[0] = "Elije la opcion que mas te convenga";
                                                MO[1] = "Suma";
                                                MO[2] = "Resta";
                                                MO[3] = "Multiplicacion";
                                                MO[4] = "Division";
                                                MO[5] = "Volver";
                                                c = Menu(MO, 6);
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
                                                            Console.Write("Cantidad de filas y de columnas: ");
                                                        asignarZ1:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(33, 2);
                                                                z = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarZ1;
                                                            }
                                                            m1 = AsignarValorMatriz(z, z, 4);
                                                            m2 = AsignarValorMatriz(z, z, 4);
                                                            cx = 3 + TamañoNumero(m1, z, z);
                                                            EscribirValorMatriz(m1, z, z, o, 4);
                                                            Console.SetCursorPosition(o + (z * cx), 4 + (z - 1));
                                                            Console.Write("+");
                                                            o = (cx * z) + 3;
                                                            cx = 3 + TamañoNumero(m2, z, z);
                                                            EscribirValorMatriz(m2, z, z, o, 4);
                                                            Console.SetCursorPosition(o + (z * cx), 4 + (z - 1));
                                                            Console.Write("=");
                                                            o += (cx * z) + 3;
                                                            for (int i = 0; i < z; i++)
                                                            {
                                                                for (int j = 0; j < z; j++)
                                                                {
                                                                    m1[j, i] += m2[j, i];
                                                                }
                                                            }
                                                            cx = 3 + TamañoNumero(m1, z, z);
                                                            EscribirValorMatriz(m1, z, z, o, 4);
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
                                                            Console.Write("Cantidad de filas y de columnas: ");
                                                        asignarZ2:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(33, 2);
                                                                z = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 12);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto asignarZ2;
                                                            }
                                                            m1 = AsignarValorMatriz(z, z, 4);
                                                            m2 = AsignarValorMatriz(z, z, 4);
                                                            cx = 2 * TamañoNumero(m1, z, z);
                                                            EscribirValorMatriz(m1, z, z, o, 4);
                                                            Console.SetCursorPosition(o + (z * cx), 4 + (z - 1));
                                                            Console.Write("-");
                                                            o = (cx * z) + 3;
                                                            cx = 2 * TamañoNumero(m2, z, z);
                                                            EscribirValorMatriz(m2, z, z, o, 4);
                                                            Console.SetCursorPosition(o + (z * cx), 4 + (z - 1));
                                                            Console.Write("=");
                                                            o += (cx * z) + 3;
                                                            for (int i = 0; i < z; i++)
                                                            {
                                                                for (int j = 0; j < z; j++)
                                                                {
                                                                    m1[j, i] -= m2[j, i];
                                                                }
                                                            }
                                                            cx = 2 * TamañoNumero(m1, z, z);
                                                            EscribirValorMatriz(m1, z, z, o, 4);
                                                            Console.CursorVisible = false;
                                                            Console.ReadKey();
                                                            goto MenuMaOp;

                                                        }
                                                    case 3://Multiplicacion
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
                                                            EscribirValorMatriz(m1, y1, z, o, 4);
                                                            Console.SetCursorPosition(o + (y1 * cx), 4 + (z - 1));
                                                            Console.Write("X");
                                                            o = (cx * y1) + 3;
                                                            cx = 2 * TamañoNumero(m2, y2, z);
                                                            EscribirValorMatriz(m2, y2, z, o, 4);
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
                                                            EscribirValorMatriz(m2, y2, z, o, 4);
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
                                                            EscribirValorMatriz(m2, 2, 2, 1, 4);
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
                                                            Console.Write("( " + Determinante(m2, 2) + " ) ");
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
                                                            EscribirValorMatriz(m2, 3, 3, 1, 4);
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
                                                            Console.Write("( " + Determinante(m2, 3) + " ) ");
                                                            Console.ReadKey();
                                                            goto MenuMaDe;
                                                        }
                                                    case 3://Matriz NxN
                                                        {
                                                            int nFC;
                                                            Console.WriteLine("Matriz NxN");
                                                            Console.WriteLine("Nota: Solo matrices cuadradas.");
                                                            Console.WriteLine("Numero de filas y de columnas: ");
                                                        AsignarnFC:
                                                            try
                                                            {
                                                                Console.SetCursorPosition(31, 2);
                                                                nFC = int.Parse(Console.ReadLine());
                                                            }
                                                            catch (Exception)
                                                            {
                                                                Console.SetCursorPosition(0, 20);
                                                                Console.Write("ERROR: Introduce un numero");
                                                                goto AsignarnFC;
                                                            }
                                                            int[,] M = new int[nFC, nFC];
                                                            int[,] Maux = new int[nFC, nFC];
                                                            int[,] R = new int[nFC - 1, nFC - 1];
                                                            M = AsignarValorMatriz(nFC, nFC, 3);
                                                            int xm = 0, ym = 0;
                                                            for (int i = 0; i < nFC; i++)
                                                            {
                                                                for (int j = 0; j < nFC; j++)
                                                                {
                                                                    if (M[j, i] == 1)
                                                                    {
                                                                        xm = j;
                                                                        ym = i;
                                                                    }
                                                                }
                                                            }
                                                            for (int i = 0; i < nFC; i++)
                                                            {
                                                                for (int j = 0; j < nFC; j++)
                                                                {
                                                                    Maux[i, j] = (-1 * M[xm, j]) * (M[i, ym] / M[xm, ym]);
                                                                }
                                                            }
                                                            for (int i = 0; i < nFC; i++)
                                                            {
                                                                for (int j = 0; j < nFC; j++)
                                                                {
                                                                    M[i, j] += Maux[i, j];
                                                                }
                                                            }
                                                            goto MenuMaDe;
                                                        }
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
                                                EscribirValorMatriz(Ma1, xm, ym, 1, 4);
                                                em = (ec * xm) + 3;
                                                Console.SetCursorPosition((ec * xm) + 1, ym + 3);
                                                Console.WriteLine(">");
                                                EscribirValorMatriz(MaTra, ym, xm, em, 4);
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
                                                EscribirValorMatriz(MaAd, nFC, nFC, EE, 4);
                                                MaAd = CofactorMatriz(MaAd, nFC);
                                                Console.SetCursorPosition(EE + (nFC * TC), 4 + (nFC - 1));
                                                Console.Write(">");
                                                EE = (TC * nFC) + 3;
                                                TC = 3 + TamañoNumero(MaAd, nFC, nFC);
                                                EscribirValorMatriz(MaAd, nFC, nFC, EE, 4);
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
                            case 3:
                                goto MenuPr;
                            default:
                                break;
                        }
                    }
                    break;
                case 2://Quimica
                    {
                        Console.Clear();

                        str = new string[] {     " 000   0 0  00  00   00 00   0000   000   ",
                                         "0   0  0 0  00  0000000 00  0      00 00  ",
                                         "0   0  0 0  00  00 0 00 00  0      00000  ",
                                         "0   0  0 0  00  00   00 00  0      00 00  ",
                                         "0   0  0 0  00  00   00 00  0      00 00  ",
                                         " 000 0 000  00  00   00 00   0000  00 00  "};
                        dibujarescrito(str);

                        Console.Clear();
                    MenuQu:
                        x = 5;
                        string[] Mn3 = new string[5];
                        Mn3[0] = "Elige la opcion que mas te convenga";
                        Mn3[1] = "Balanceo";
                        Mn3[2] = "Configuracion Electronica";
                        Mn3[3] = "Tabla Periodica";
                        Mn3[4] = "Volver";
                        c = Menu(Mn3, 5);
                        switch (c)
                        {
                            case 1:
                                goto MenuQu;
                            case 2:
                                goto MenuQu;
                            case 3:
                                string ElX;
                                Console.Write("Ingresa el elemento quimico que buscas :");
                                ElX = Console.ReadLine();

                                goto MenuQu;
                            case 4:
                                goto MenuPr;
                            default:
                                break;
                        }
                        break;
                    }
                case 3:    //Fisica
                    {
                        Console.Clear();

                        str = new string[]  {"00000  00   000  00   0000   000   ",
                                          "00     00  0   0 00  0      00 00  ",
                                          "00000  00   0    00  0      00000  ",
                                          "00     00     0  00  0      00 00  ",
                                          "00     00  0   0 00  0      00 00  ",
                                          "00     00   000  00   0000  00 00  "};
                        dibujarescrito(str);
                        Console.Clear();
                    MenuFi:
                        string[] Mn4 = new string[5];
                        Mn4[0] = "Elige la opcion que mas te convenga";
                        Mn4[1] = "MRU";
                        Mn4[2] = "MRUA";
                        Mn4[3] = "Conversor";
                        Mn4[4] = "Volver";
                        c = Menu(Mn4, 5);
                        switch (c)
                        {
                            case 1://MRU
                                Console.Clear();
                                string d, v, t;
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("Ingresa un '?' en la incoginta");
                                Console.SetCursorPosition(50, 3);
                                Console.WriteLine("d = Distancia(m)" + "   v = Velocidad(m/s)" + "  t = Tiempo(seg)");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(3, 3);
                                Console.WriteLine("d = ");
                                Console.SetCursorPosition(7, 3);
                                d = Console.ReadLine();
                                Console.SetCursorPosition(3, 4);
                                Console.WriteLine("v = ");
                                Console.SetCursorPosition(7, 4);
                                v = Console.ReadLine();
                                Console.SetCursorPosition(3, 5);
                                Console.WriteLine("t = ");
                                Console.SetCursorPosition(7, 5);
                                t = Console.ReadLine();
                                if (d == "?")
                                {
                                    Console.SetCursorPosition(13, 4);
                                    d = ((double.Parse(v)) * (double.Parse(t))).ToString();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("d = v x t");
                                    Console.Write(" = ");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("d = " + v + " x " + t);
                                    Console.SetCursorPosition(10, 5);
                                    Console.Write("d = " + d + "m");
                                    Console.ReadKey();
                                }
                                if (v == "?")
                                {
                                    Console.SetCursorPosition(10, 4);
                                    v = ((double.Parse(d)) / (double.Parse(t))).ToString();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("v = d/t");
                                    Console.Write(" = ");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("v = " + d + "/" + t);
                                    Console.SetCursorPosition(10, 5);
                                    Console.Write("v = " + v + "m/s");
                                    Console.ReadKey();
                                }
                                if (t == "?")
                                {
                                    Console.SetCursorPosition(10, 4);
                                    t = ((double.Parse(d)) / (double.Parse(v))).ToString();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("t = d/v");
                                    Console.Write(" = ");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.Write("t = " + d + "/" + v);
                                    Console.SetCursorPosition(10, 5);
                                    Console.Write("t = " + t + "seg");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.SetCursorPosition(10, 4);
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Debes tener almenos una incognita.");
                                }

                                Console.ReadKey();
                                goto MenuFi;
                            case 2:
                                x = 4;
                                string[] MRUA = new string[x];
                            fmrua:
                                MRUA[0] = "Seleccione una opcion";
                                MRUA[1] = "Acelerado";
                                MRUA[2] = "Reterdado";
                                MRUA[3] = "Regresar";
                                c = Menu(MRUA, x);
                                Console.Clear();
                                switch (c)
                                {
                                    case 1:
                                        string Vo, Vf, a;
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine("Ingresa un '?' en la incoginta");
                                        Console.SetCursorPosition(50, 3);
                                        Console.WriteLine("d = Distancia(m)" + "   Vo = Velocidad inicial(m/s)");
                                        Console.SetCursorPosition(50, 4);
                                        Console.WriteLine("Vf = Velocidad Final(m/s)" + "  a = Aceleracion(m/s²)" + "  t = Tiempo(seg)");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.SetCursorPosition(3, 3);
                                        Console.WriteLine("d = ");
                                        Console.SetCursorPosition(7, 3);
                                        d = Console.ReadLine();
                                        Console.SetCursorPosition(3, 4);
                                        Console.WriteLine("Vo = ");
                                        Console.SetCursorPosition(7, 4);
                                        Vo = Console.ReadLine();
                                        Console.SetCursorPosition(3, 5);
                                        Console.WriteLine("Vf = ");
                                        Console.SetCursorPosition(7, 5);
                                        Vf = Console.ReadLine();
                                        Console.SetCursorPosition(3, 6);
                                        Console.WriteLine("a = ");
                                        Console.SetCursorPosition(7, 6);
                                        a = Console.ReadLine();
                                        Console.SetCursorPosition(3, 7);
                                        Console.WriteLine("t = ");
                                        Console.SetCursorPosition(7, 7);
                                        t = Console.ReadLine();
                                        do
                                        {


                                            if (d == "?" && a != "?" && Vo != "?" && t != "?")
                                            {
                                                Console.SetCursorPosition(10, 4);
                                                d = ((double.Parse(Vo) * double.Parse(t)) + ((double.Parse(a) * (double.Parse(t) * double.Parse(t))) / 2)).ToString();

                                            }
                                            if (d == "?" && a == "?" && Vo != "?" && t != "?" && Vf != "?")
                                            {
                                                Console.SetCursorPosition(10, 4);
                                                d = (((double.Parse(Vo)) + (double.Parse(Vf))) / 2).ToString();
                                                d = ((double.Parse(d) * (Double.Parse(t))).ToString());
                                            }
                                            if (Vf == "?" && d == "?" && Vo != "?" && a != "?" && t != "?")
                                            {
                                                Vf = ((Double.Parse(Vo)) + ((double.Parse(a)) * (double.Parse(t)))).ToString();
                                            }
                                            if (Vf == "?" && t == "?" && Vo != "?" && a != "?" && d != "?")
                                            {
                                                Vf = (((Double.Parse(Vo)) * (Double.Parse(Vo))) + (2 * ((Double.Parse(a)) * (double.Parse(d))))).ToString();
                                                Vf = (Math.Pow((Double.Parse(Vf)), 0.5)).ToString();


                                            }
                                        } while (d == "?" && Vo == "?" && Vf == "?" && a == "?" && t == "?");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.SetCursorPosition(0, 10);
                                        Console.WriteLine("d = " + d);
                                        Console.WriteLine("Vf = " + Vf);
                                        Console.WriteLine("Vo = " + Vo);
                                        Console.WriteLine("a = " + a);
                                        Console.WriteLine("t = " + t);
                                        goto fmrua;
                                    case 2:

                                        goto fmrua;
                                    case 3://Convertidor
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        x = 7;
                                        c = 1;
                                        Console.CursorVisible = false;
                                    unidm:
                                        string[] CU = new string[6];
                                        CU[0] = "Elije una opcion";
                                        CU[1] = "Longitud";
                                        CU[2] = "Volumen";
                                        CU[3] = "Masa";
                                        CU[4] = "Temperatura";
                                        CU[5] = "Volver";
                                        c = Menu(CU, 6);
                                        switch (c)
                                        {
                                            case 1:
                                            flo:
                                                Console.CursorVisible = false;
                                                string[] Lo = new string[10];
                                                Lo[0] = "Elije una unidad";
                                                Lo[1] = "Kilometro";
                                                Lo[2] = "Metro";
                                                Lo[3] = "Centimetro";
                                                Lo[4] = "Milimerro";
                                                Lo[5] = "Milla";
                                                Lo[6] = "Yarda";
                                                Lo[7] = "Pie";
                                                Lo[8] = "Pulgada";
                                                Lo[9] = "Volver";
                                                c = Menu(Lo, 10);
                                                Console.Clear();
                                                switch (c)
                                                {
                                                    case 1:
                                                        double lk;
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        lk = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(lk + " Kilometros son: ");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Metro = " + lk * 1000);
                                                        Console.WriteLine("Centimetro = " + lk * 100000);
                                                        Console.WriteLine("Milimetro = " + lk * 1000000);
                                                        Console.WriteLine("Milla = " + lk * 0.621371);
                                                        Console.WriteLine("Yarda = " + lk * 1093.61);
                                                        Console.WriteLine("Pie = " + lk * 3280.84);
                                                        Console.WriteLine("Pulgada = " + lk * 3280.84);
                                                        Console.ReadKey();
                                                        goto flo;
                                                    case 2:
                                                        double m;
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Metros son: ");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Kilometro = " + m * 0.001);
                                                        Console.WriteLine("Centimetro = " + m * 100);
                                                        Console.WriteLine("Milimetro = " + m * 1000);
                                                        Console.WriteLine("Milla = " + m * 0.000621371);
                                                        Console.WriteLine("Yarda = " + m * 1.09361);
                                                        Console.WriteLine("Pie = " + m * 3.28084);
                                                        Console.WriteLine("Pulgada = " + m * 39.3701);
                                                        Console.ReadKey();
                                                        goto flo;
                                                    case 3:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Centimetros son: ");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Kilometro = " + m * 0.00001);
                                                        Console.WriteLine("Metro = " + m * 0.01);
                                                        Console.WriteLine("Milimetro = " + m * 10);
                                                        Console.WriteLine("Milla = " + m * 0.00000621371);
                                                        Console.WriteLine("Yarda = " + m * 0.0109361);
                                                        Console.WriteLine("Pie = " + m * 0.0328084);
                                                        Console.WriteLine("Pulgada = " + m * 0.393701);
                                                        Console.ReadKey();
                                                        goto flo;
                                                    case 4:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Milimetros son: ");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Kilometro = " + m * 0.000001);
                                                        Console.WriteLine("Metro = " + m * 0.001);
                                                        Console.WriteLine("Centimetro = " + m * 0.1);
                                                        Console.WriteLine("Milla = " + m * 0.000000621371);
                                                        Console.WriteLine("Yarda = " + m * 0.00109361);
                                                        Console.WriteLine("Pie = " + m * 0.00328084);
                                                        Console.WriteLine("Pulgada = " + m * 0.0393701);
                                                        Console.ReadKey();
                                                        goto flo;
                                                    case 5:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Millas son: ");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Kilometro = " + m * 1.60934);
                                                        Console.WriteLine("Metro = " + m * 1609.34);
                                                        Console.WriteLine("Centimetro = " + m * 160934);
                                                        Console.WriteLine("Milimetro = " + m * 1609344);
                                                        Console.WriteLine("Yarda = " + m * 1760);
                                                        Console.WriteLine("Pie = " + m * 5280);
                                                        Console.WriteLine("Pulgada = " + m * 63360);
                                                        Console.ReadKey();
                                                        goto flo;
                                                    case 6:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Yardas son: ");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Kilometro = " + m * 0.0009144);
                                                        Console.WriteLine("Metro = " + m * 0.9144);
                                                        Console.WriteLine("Centimetro = " + m * 91.44);
                                                        Console.WriteLine("Milimetro = " + m * 914.4);
                                                        Console.WriteLine("Milla = " + m * 0.000568182);
                                                        Console.WriteLine("Pie = " + m * 3);
                                                        Console.WriteLine("Pulgada = " + m * 36);
                                                        Console.ReadKey();
                                                        goto flo;
                                                    case 7:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Pies son: ");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Kilometro = " + m * 0.0003048);
                                                        Console.WriteLine("Metro = " + m * 0.3048);
                                                        Console.WriteLine("Centimetro = " + m * 30.48);
                                                        Console.WriteLine("Milimetro = " + m * 304.8);
                                                        Console.WriteLine("Milla = " + m * 0.000189394);
                                                        Console.WriteLine("Yarda = " + m * 0.333333);
                                                        Console.WriteLine("Pulgada = " + m * 12);
                                                        Console.ReadKey();
                                                        goto flo;
                                                    case 8:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Pulgadas son: ");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Kilometro = " + m * 0.0000254);
                                                        Console.WriteLine("Metro = " + m * 0.0254);
                                                        Console.WriteLine("Centimetro = " + m * 2.54);
                                                        Console.WriteLine("Milimetro = " + m * 25.4);
                                                        Console.WriteLine("Milla = " + m * 0.00001578);
                                                        Console.WriteLine("Yarda = " + m * 0.0277778);
                                                        Console.WriteLine("Pie = " + m * 0.0833333);
                                                        Console.ReadKey();
                                                        goto flo;
                                                    case 9:
                                                        goto unidm;
                                                }
                                                break;
                                            case 2:
                                            fvo:
                                                Console.CursorVisible = false;
                                                x = 11;
                                                string[] vo = new string[10];
                                                vo[0] = "Elije una opcion";
                                                vo[1] = "Litro";
                                                vo[2] = "Mililitro";
                                                vo[3] = "Metro cubico";
                                                vo[4] = "Onza";
                                                vo[5] = "Pie cubico";
                                                vo[6] = "Pulgada cubica";
                                                vo[7] = "Galón Estadounidense";
                                                vo[8] = "Galón imperia";
                                                vo[9] = "Volver";
                                                c = Menu(vo, 10);
                                                Console.Clear();
                                                switch (c)
                                                {
                                                    case 1:
                                                        Double m;
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresa valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Litros son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Mililitros = " + m * 1000);
                                                        Console.WriteLine("Metro cubicos = " + m * 0.001);
                                                        Console.WriteLine("Onzas = " + m * 33.814);
                                                        Console.WriteLine("Pie cubico = " + m * 0.0353147);
                                                        Console.WriteLine("Pulgada cubica = " + m * 61.0237);
                                                        Console.WriteLine("Galon Estadounidense = " + m * 0.264172);
                                                        Console.WriteLine("Galon imperial = " + m * 0.219969);
                                                        Console.ReadKey();
                                                        goto fvo;
                                                    case 2:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresa valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Mililitros son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Litros = " + m * 0.001);
                                                        Console.WriteLine("Metro cubicos = " + m * 0.000001);
                                                        Console.WriteLine("Onzas = " + m * 0.03814);
                                                        Console.WriteLine("Pie cubico = " + m * 0.000035315);
                                                        Console.WriteLine("Pulgada cubica = " + m * 0.0610237);
                                                        Console.WriteLine("Galon Estadounidense = " + m * 0.000264172);
                                                        Console.WriteLine("Galon imperial = " + m * 0.000219969);
                                                        Console.ReadKey();
                                                        goto fvo;
                                                    case 3:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresa valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Metros cubicos son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Litros = " + m * 1000);
                                                        Console.WriteLine("Mililitros = " + m * 0.000001);
                                                        Console.WriteLine("Onzas = " + m * 33814);
                                                        Console.WriteLine("Pie cubico = " + m * 35.3147);
                                                        Console.WriteLine("Pulgada cubica = " + m * 61023.7);
                                                        Console.WriteLine("Galon Estadounidense = " + m * 264.172);
                                                        Console.WriteLine("Galon imperial = " + m * 219.969);
                                                        Console.ReadKey();
                                                        goto fvo;
                                                    case 4:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresa valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Onzas son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Litros = " + m * 0.0295735);
                                                        Console.WriteLine("Mililitros = " + m * 29.5735);
                                                        Console.WriteLine("Metros cubicos = " + m * 0.00002957);
                                                        Console.WriteLine("Pie cubico = " + m * 0.001044);
                                                        Console.WriteLine("Pulgada cubica = " + m * 1.805);
                                                        Console.WriteLine("Galon Estadounidense = " + m * 0.007813);
                                                        Console.WriteLine("Galon imperial = " + m * 0.006505);
                                                        Console.ReadKey();
                                                        goto fvo;
                                                    case 5:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresa valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Pies cubicos son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Litros = " + m * 28.32);
                                                        Console.WriteLine("Mililitros = " + m * 28316846);
                                                        Console.WriteLine("Metro cubico = " + m * 0.02832);
                                                        Console.WriteLine("Onzas = " + m * 957.5);
                                                        Console.WriteLine("Pulgada cubica = " + m * 1728);
                                                        Console.WriteLine("Galon Estadounidense = " + m * 7.481);
                                                        Console.WriteLine("Galon imperial = " + m * 6.229);
                                                        Console.ReadKey();
                                                        goto fvo;
                                                    case 6:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresa valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Pulgadas cubicas son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Litros = " + m * 0.01639);
                                                        Console.WriteLine("Mililitros = " + m * 16.39);
                                                        Console.WriteLine("Metros cubicos = " + m * 0.00001639);
                                                        Console.WriteLine("Onzas = " + m * 0.5541);
                                                        Console.WriteLine("Pie cubico = " + m * 0.0005787);
                                                        Console.WriteLine("Galon Estadounidense = " + m * 0.004329);
                                                        Console.WriteLine("Galon imperial = " + m * 0.003605);
                                                        Console.ReadKey();
                                                        goto fvo;
                                                    case 7:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresa valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Galones Estadounidenses son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Litros = " + m * 3.785);
                                                        Console.WriteLine("Mililitros = " + m * 3785);
                                                        Console.WriteLine("Metros cubicos = " + m * 0.003785);
                                                        Console.WriteLine("Onzas = " + m * 128);
                                                        Console.WriteLine("Pie cubico = " + m * 0.1337);
                                                        Console.WriteLine("Pulgada cubica = " + m * 231);
                                                        Console.WriteLine("Galon imperial = " + m * 0.8327);
                                                        Console.ReadKey();
                                                        goto fvo;
                                                    case 8:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresa valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Galones Imperiales son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Litros = " + m * 4.546);
                                                        Console.WriteLine("Mililitros = " + m * 4546);
                                                        Console.WriteLine("Metros cubicos = " + m * 0.004546);
                                                        Console.WriteLine("Onzas = " + m * 153.7);
                                                        Console.WriteLine("Pie cubico = " + m * 0.1605);
                                                        Console.WriteLine("Pulgada cubica = " + m * 277.4);
                                                        Console.WriteLine("Galon Estadounidense = " + m * 1.201);
                                                        Console.ReadKey();
                                                        goto fvo;
                                                    case 9:
                                                        goto unidm;

                                                }
                                                break;
                                            case 3:
                                            fma:
                                                Console.CursorVisible = false;
                                                string[] ma = new string[7];
                                                ma[0] = "Elije una opcion";
                                                ma[1] = "Tonelada";
                                                ma[2] = "Kilogramo";
                                                ma[3] = "Gramo";
                                                ma[4] = "Libra";
                                                ma[5] = "Onza";
                                                ma[6] = "Volver";
                                                c = Menu(ma, 7); ;
                                                Console.Clear();
                                                switch (c)
                                                {
                                                    case 1:
                                                        double m;
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Toneladas son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Kilogramos = " + m * 1000);
                                                        Console.WriteLine("Gramos = " + m * 100000);
                                                        Console.WriteLine("Libras = " + m * 2204.62);
                                                        Console.WriteLine("Onzas = " + m * 35274);
                                                        Console.ReadKey();
                                                        goto fma;
                                                    case 2:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Kilogramos son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Toneladas = " + m * 0.001);
                                                        Console.WriteLine("Gramos = " + m * 1000);
                                                        Console.WriteLine("Libras = " + m * 2.20462);
                                                        Console.WriteLine("Onzas = " + m * 35.274);
                                                        Console.ReadKey();
                                                        goto fma;
                                                    case 3:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Gramos son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Toneladas = " + m * 0.000006);
                                                        Console.WriteLine("Kilogramos = " + m * 0.001);
                                                        Console.WriteLine("Libras = " + m * 0.00220432);
                                                        Console.WriteLine("Onzas = " + m * 0.035274);
                                                        Console.ReadKey();
                                                        goto fma;
                                                    case 4:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Libras son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Toneladas = " + m * 0.000453592);
                                                        Console.WriteLine("Kilogramos = " + m * 0.453592);
                                                        Console.WriteLine("Gramos = " + m * 453.592);
                                                        Console.WriteLine("Onzas = " + m * 16);
                                                        Console.ReadKey();
                                                        goto fma;
                                                    case 5:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + " Onzas son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Toneladas = " + m * 0.000002835);
                                                        Console.WriteLine("Kilogramos = " + m * 0.02835);
                                                        Console.WriteLine("Gramos = " + m * 28.35);
                                                        Console.WriteLine("Libras = " + m * 0.0625);
                                                        Console.ReadKey();
                                                        goto fma;
                                                    case 6:
                                                        goto unidm;
                                                }
                                                break;
                                            case 4:
                                            ftem:
                                                Console.CursorVisible = false;
                                                string[] tem = new string[5];
                                                tem[0] = "ELije una opcion";
                                                tem[1] = "Grados Celsius";
                                                tem[2] = "Grados Farenheit";
                                                tem[3] = "Grados Kelvin";
                                                tem[4] = "Volver";
                                                c = Menu(tem, 5);
                                                Console.Clear();
                                                switch (c)
                                                {
                                                    case 1:
                                                        double m;
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + "° Celsius son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Grados Farenheit = " + (m * 9 / 5) + 32);
                                                        Console.WriteLine("Grados Kelvin = " + m + 273.15);
                                                        Console.ReadKey();
                                                        goto ftem;
                                                    case 2:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + "° Farenheit son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Grados Celsius = " + (m - 32) * 5 / 9);
                                                        Console.WriteLine("Grados Kelvin = " + (m - 32) * 5 / 9 + 273.15);
                                                        Console.ReadKey();
                                                        goto ftem;
                                                    case 3:
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Ingresar valor a convertir");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        m = Convert.ToDouble(Console.ReadLine());
                                                        Console.Clear();
                                                        Console.WriteLine(m + "° Kelvin son:");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("Grados Celsius = " + (m - 273.15));
                                                        Console.WriteLine("Grados Farenheit = " + (m - 273.15) * 9 / 5 + 32);
                                                        Console.ReadKey();
                                                        goto ftem;
                                                    case 4:
                                                        goto unidm;
                                                }
                                                goto MenuFi;
                                            case 5:
                                                goto MenuPr;
                                        }
                                        break;
                                }
                                break;
                        }
                    }
                    break;
                case 4://Salir
                    {
                        string[] Mn5 = new string[3];
                        Mn5[0] = "¿Seguro?";
                        Mn5[1] = "Si";
                        Mn5[2] = "No";
                        c = Menu(Mn5, 3);
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
                Console.ForegroundColor = ConsoleColor.Black;
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
            Console.ForegroundColor = ConsoleColor.Gray;
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
                        Console.SetCursorPosition(0, 0 + IM);
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
                    EscribirValorMatriz(m, x, y, 1, IM);
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

        static void EscribirValorMatriz(int[,] m, int x, int y, int z, int IM)
        {
            int c = TamañoNumero(m, x, y);
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
                    R[1, 1] = m[1, 1];
                    R[0, 0] = m[0, 0];
                    R[1, 0] = m[1, 0] * -1;
                    R[0, 1] = m[0, 1] * -1;
                    break;
                default:
                    int[,] coM = new int[x1 - 1, x1 - 1];
                    int c2 = 0, f2 = 0;
                    for (int fX = 0; fX < x1; fX++)
                    {
                        for (int cX = 0; cX < x1; cX++)
                        {
                            c2 = 0;
                            f2 = 0;
                            for (int f1 = 0; f1 < x1; f1++)
                            {
                                for (int c1 = 0; c1 < x1; c1++)
                                {
                                    if (f1 != fX && c1 != cX)
                                    {
                                        coM[c2, f2] = m[c1, f1];
                                        if (c2 < x1 - 2 && f2 <= x1 - 2)
                                        {
                                            c2++;
                                        }
                                        else
                                        {
                                            c2 = 0;
                                            if (f2 < x1 - 2)
                                            {
                                                f2++;
                                            }
                                            else
                                            {
                                                f2 = 0;
                                                c1 = x1;
                                            }
                                        }
                                    }
                                }
                            }
                            R[cX, fX] = Determinante(coM, x1 - 1);
                        }
                    }
                    break;
            }
            for (int i = 0; i < x1; i++)
            {
                for (int j = 0; j < x1; j++)
                {
                    R[i, j] = R[j, i];
                }
            }
            return R;
        }

        static int Determinante(int[,] m, int x)
        {
            int De = 1;
            switch (x)
            {
                case 2:
                    De = (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
                    break;
                case 3:
                    De = (m[0, 0] * m[1, 1] * m[2, 2]) + (m[0, 1] * m[1, 2] * m[2, 0]) + (m[0, 2] * m[1, 0] * m[2, 1]) - (m[0, 2] * m[1, 1] * m[2, 0]) - (m[0, 0] * m[1, 2] * m[2, 1]) - (m[0, 1] * m[1, 0] * m[2, 2]);
                    break;
            }
            return De;
        }
    }
}