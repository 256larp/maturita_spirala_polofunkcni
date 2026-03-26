using System;
using System.Windows;
using System.Threading;
using static System.Console;

class Spirala
{
    static void Main()
    {
        SetWindowSize(80, 20);

        int rozhodnuti;
        do
        {
            SetCursorPosition(20, 8);
            WriteLine("1. Modrobila");
            SetCursorPosition(20, 9);
            WriteLine("2. Bilomodra");
            SetCursorPosition(20, 10);
            Write("ZH: ");
            rozhodnuti = Convert.ToInt32(ReadLine());

            SetCursorPosition(20, 11);
            if (rozhodnuti < 1 || rozhodnuti > 2) WriteLine("Neplatne rozhodnuti.");
            ReadLine();
            Clear();
        } while (rozhodnuti < 1 || rozhodnuti > 2);

        Vykresleni(0, 0, 79, 19, 0, rozhodnuti);
        ReadLine();
    }

    static void Vykresleni(int x, int y, int radek, int sloupec, int a, int rozhodnuti)
    {
        do
        {
            if (a % 2 == 0)
            {
                if (rozhodnuti == 1) ForegroundColor = ConsoleColor.Blue;
                else ForegroundColor = ConsoleColor.White;
            }
            else
            {
                if (rozhodnuti == 1) ForegroundColor = ConsoleColor.White;
                else ForegroundColor = ConsoleColor.Blue;
            }

            for (int i = x; i < radek; i++)
            {
                Thread.Sleep(1);
                SetCursorPosition(i, y);
                Write("■");
            }

            for (int i = y; i < sloupec; i++)
            {
                Thread.Sleep(1);
                SetCursorPosition(radek, i);
                Write("■");
            }

            for (int i = radek; i > 0; i--)
            {
                Thread.Sleep(1);
                SetCursorPosition(i, sloupec);
                Write("■");
            }

            for (int i = sloupec; i > 0; i--)
            {
                Thread.Sleep(1);
                SetCursorPosition(x, i);
                Write("■");
            }

            x++;
            y++;
            radek--;
            sloupec--;

            a++;

        } while (a < 10);
    }
}
