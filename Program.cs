using System;
using System.Reflection.Metadata;

internal class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        while (x != 4)
        {
            Console.WriteLine("Выберите: \n1 - загадал число \n2 - таблица умножения \n3 - делитель \n4 - завершение");
            x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                d();
            }
            if (x == 2)
            {
                h();
            }
            if (x == 3)
            {
                u();
            }
        }
    }
    static void d()
    {
        Console.Title = "Угадай число";
        Random rand = new Random();
        int secret = rand.Next(100) + 1;
        Console.WriteLine("Я загадал число от 1 до 100");
        int y;
        do
        {
            y = int.Parse(Console.ReadLine());
            if (y == secret)
            {
                Console.WriteLine("Ты Угадал");
            }
            else
            {
                if (y < secret)
                {
                    Console.WriteLine("Число  больше");
                }
                else
                {
                    Console.WriteLine("Число меньше");
                }
            }
        }
        while (y != secret);
    }

    static void h()
    {
        string[,] y = new string[11, 11] { { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "", "" }, };

        for (int m = 1; m < y.GetLength(0); m++)
        {
            for (int n = 1; n < y.GetLength(1); n++)
            {
                Console.Write(y[m, n] + m + "*" + n + "=" + m * n + "\t\t");
            }
            Console.WriteLine();
        }
    }
    static void u()
    {
        Console.Write("Введите число ");
        int y = int.Parse(Console.ReadLine()); 
        for (int i = 1; i <= y; i++)
            if (y % i == 0)
                Console.WriteLine("Число {0} делится без остатка на {1}", y, i);
    }
}