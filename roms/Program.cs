using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (number < 1 || number > 9000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите число от 1 до 9000. ");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("Нажмите любую клавишу для продолжения");
                    Console.ReadKey();
                }

                string result = "";

                bool thousands = number >= 1000 ? true : false;
                bool hundreds = number >= 100 ? true : false;
                bool tens = number >= 10 ? true : false;

                if (thousands)
                {
                    for (int i = 0; i < number / 1000; i++)
                    {
                        result += "M";
                    }
                }
                if (hundreds)
                {
                    if ((number / 100) % 10 >= 5)
                    {
                        result += "D";
                        for (int i = 0; i < (number / 100) % 10 - 5; i++)
                        {
                            result += "C";
                        }
                    }
                    else
                    {
                        for (int i = 0; i < (number / 100) % 10; i++)
                        {
                            result += "C";
                        }
                    }
                }
                if (tens)
                {
                    if ((number / 10) % 10 >= 5)
                    {
                        result += "L";
                        for (int i = 0; i < (number / 10) % 10 - 5; i++)
                        {
                            result += "X";
                        }
                    }
                    else
                    {
                        for (int i = 0; i < (number / 10) % 10; i++)
                        {
                            result += "X";
                        }
                    }
                }
                if (number % 10 == 1)
                {
                    result += "I";
                }
                if (number % 10 == 2)
                {
                    result += "II";
                }
                if (number % 10 == 3)
                {
                    result += "III";
                }
                if (number % 10 == 4)
                {
                    result += "IV";
                }
                if (number % 10 == 5)
                {
                    result += "V";
                }
                if (number % 10 == 6)
                {
                    result += "VI";
                }
                if (number % 10 == 7)
                {
                    result += "VII";
                }
                if (number % 10 == 8)
                {
                    result += "VIII";
                }
                if (number % 10 == 9)
                {
                    result += "IX";
                }
                Console.WriteLine($"Результат: {result}");
                Console.ReadKey();
            }
        }
    }
}
