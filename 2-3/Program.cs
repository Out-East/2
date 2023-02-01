using System;

namespace MenuExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("1. Мини-игра - Угадай число");
            Console.WriteLine("2. Вывод таблицы умножения");
            Console.WriteLine("3. Выход");
            Console.WriteLine("Ваше действие: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Мини-игра - Угадай число");
                    int Vibor = new Random().Next(1, 10);
                    int Chislo = 0;
                    bool Pravilno = false;

                    Console.WriteLine("Выберите число от 1 до 100:");

                    while (!Pravilno)
                    {
                        int guess = int.Parse(Console.ReadLine());
                        Chislo++;

                        if (guess < Vibor)
                        {
                            Console.WriteLine("Число слишком большое, попробуй ещё");
                        }
                        else if (guess > Vibor)
                        {
                            Console.WriteLine("Число слишком маленько, попробуй ещё");
                        }
                        else
                        {
                            Console.WriteLine("Правильно! Использовано попыток:" + Chislo);
                            Pravilno = true;
                        }
                    }

                    Console.WriteLine("Нажмите что то для выхода:");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Таблица умножения");
                    int stroka = 10;
                    int Stolbez = 10;

                    int[,] table = new int[stroka, Stolbez];

                    for (int i = 0; i < stroka; i++)
                    {
                        for (int j = 0; j < Stolbez; j++)
                        {
                            table[i, j] = (i + 1) * (j + 1);
                        }
                    }

                    Console.WriteLine("Таблица умножения:\n");

                    for (int i = 0; i < stroka; i++)
                    {
                        for (int j = 0; j < Stolbez; j++)
                        {
                            Console.Write(table[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Выход из программы");
                    break;
                default:
                    Console.WriteLine("Такого нет)");
                    break;
            }
        }
    }
}