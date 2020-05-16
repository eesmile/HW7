using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine("Выберите:\n 1 - Сложение. \n 2 - Вычитаниe. \n 3 - Умножить. \n 4 - Делить. \n 5 - Корень из двух");
            switch(Console.ReadLine())
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Введите первое число");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc.Plus(a, b));
                        
                    }
                    catch (Exception error )
                    {
                        Console.WriteLine(error.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Ошибок нет");
                    }
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine("Введите первое число");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc.Minus(a, b));

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Ошибок нет");
                    }
                    break;
                case "3":
                    try
                    {
                        Console.WriteLine("Введите первое число");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc.Multi(a, b));

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Ошибок нет");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
