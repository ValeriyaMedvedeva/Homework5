using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;
using Zoo.Animals;
using NLog;

namespace Zoo
{
    class Program
    {
        private static Logger myLog = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            bool flag = true;
            ConsoleKeyInfo opt;
            List<Animal> result = new List<Animal>();
            IMovement movement = null;
            ISound sound = null;
            int n=5;
            Console.WriteLine("В зоопарке есть 5 животных,по очереди сначала выберете их повеение,а затем само животное,в конце будет выведен результат.");
            Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Введите 1,чтобы придать животному способность бегать;");
                    Console.WriteLine("2. Введите 2,чтобы придать животному способность плавать;");
                    Console.WriteLine("3. Введите 3,чтобы придать животному способность летать;");
                    Console.WriteLine("4. Введите 4,чтобы придать животному способность прыгать;");
                    Console.WriteLine(" Для выхода выберите режим Esc,для осуществления повторной операциии нажмите Enter");
                    opt = Console.ReadKey();
                    switch (opt.Key)
                    {
                        case ConsoleKey.D1:
                            movement = new Run();
                            flag = false;
                            break;
                        case ConsoleKey.D2:
                            movement = new Swim();
                            flag = false;
                            break;
                        case ConsoleKey.D3:
                            movement = new Fly();
                            flag = false;
                            break;
                        case ConsoleKey.D4:
                            movement = new Jump();
                            flag = false;
                            break;
                        case ConsoleKey.Escape:
                            Console.WriteLine("\nВы начали клавишу Escape,животное не будет добавлено в зоопарк,так как не выбрано основное поле!");
                            Console.ReadLine();
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("\nНе правильный ввод,пожалуйста,попробуйте еще раз!");
                            Console.ReadLine();
                            break;
                    }
                } while (flag);
                flag = true;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Введите 1,чтобы придать животному способность квакать;");
                    Console.WriteLine("2. Введите 2,чтобы придать животному способность рычать;");
                    Console.WriteLine("3. Введите 3,чтобы придать животному способность мяукать;");
                    Console.WriteLine("4. Введите 4,чтобы придать животному способность кричать;");
                    Console.WriteLine("5. Введите 5,чтобы придать животному способность молчать;");
                    Console.WriteLine(" Для выхода выберите режим Esc,для осуществления повторной операциии нажмите Enter");
                    opt = Console.ReadKey();
                    switch (opt.Key)
                    {
                        case ConsoleKey.D1:
                            sound = new Croak();
                            flag = false;
                            break;
                        case ConsoleKey.D2:
                            sound = new Growl();
                            flag = false;
                            break;
                        case ConsoleKey.D3:
                            sound = new Meow();
                            flag = false;
                            break;
                        case ConsoleKey.D4:
                            sound = new Shout();
                            flag = false;
                            break;
                        case ConsoleKey.D5:
                            sound = new Silent();
                            flag = false;
                            break;
                        case ConsoleKey.Escape:
                            Console.WriteLine("\nВы начали клавишу Escape,животное не будет добавлено в зоопарк,так как не выбрано основное поле!");
                            Console.ReadLine();
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("\nНе правильный ввод,пожалуйста,попробуйте еще раз!");
                            Console.ReadLine();
                            break;
                    };
                } while (flag);
                flag = true;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Введите 1,чтобы придать все выбранные способности кошке;");
                    Console.WriteLine("2. Введите 2,чтобы придать все выбраные способности орлу;");
                    Console.WriteLine("3. Введите 3,чтобы придать все выбраные способности лягушке;");
                    Console.WriteLine("4. Введите 4,чтобы придать все выбраные способности льву;");
                    Console.WriteLine("5. Введите 5,чтобы придать все выбраные способности акуле;");
                    Console.WriteLine(" Для выхода выберите режим Esc,для осуществления повторной операциии нажмите Enter");
                    opt = Console.ReadKey();
                    switch (opt.Key)
                    {
                        case ConsoleKey.D1:
                            try
                            {
                                result.Add(new Cat(movement, sound));
                            }
                            catch (Exceptions ex)
                            {
                                Console.WriteLine("Поведение животного изменено: {0},животное не попадает в зоопарк", ex.Message);
                                Console.ReadLine();
                                myLog.Log(LogLevel.Error, ex.Message);
                            }
                            flag = false;
                            break;
                        case ConsoleKey.D2:
                            try
                            {
                                result.Add(new Eagle(movement, sound));
                            }
                            catch (Exceptions ex)
                            {
                                Console.WriteLine("Поведение животного изменено: {0},животное не попадает в зоопарк", ex.Message);
                                Console.ReadLine();
                                myLog.Log(LogLevel.Error, ex.Message);
                            }
                            flag = false;
                            break;
                        case ConsoleKey.D3:
                            try
                            {
                                result.Add(new Frog(movement, sound));
                            }
                            catch (Exceptions ex)
                            {
                                Console.WriteLine("Поведение животного изменено: {0},животное не попадает в зоопарк", ex.Message);
                                Console.ReadLine();
                                myLog.Log(LogLevel.Error, ex.Message);
                            }
                            flag = false;
                            break;
                        case ConsoleKey.D4:
                            try
                            {
                                result.Add(new Leo(movement, sound));
                            }
                            catch (Exceptions ex)
                            {
                                Console.WriteLine("Поведение животного изменено: {0},животное не попадает в зоопарк", ex.Message);
                                Console.ReadLine();
                                myLog.Log(LogLevel.Error, ex.Message);
                            }
                            flag = false;
                            break;
                        case ConsoleKey.D5:
                            try
                            {
                                result.Add(new Shark(movement, sound));
                            }
                            catch (Exceptions ex)
                            {
                                Console.WriteLine("Поведение животного изменено: {0},животное не попадает в зоопарк", ex.Message);
                                Console.ReadLine();
                                myLog.Log(LogLevel.Error, ex.Message);
                            }
                            flag = false;
                            break;
                        case ConsoleKey.Escape:
                            Console.WriteLine("\nВы начали клавишу Escape,животное не выбрано и не добавлено в зоопарк!");
                            Console.ReadLine();
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("\nНе правильный ввод,пожалуйста,попробуйте еще раз!");
                            Console.ReadLine();
                            break;
                    }
                } while (flag);
            }
            Console.Clear();
            Console.WriteLine("Животные в получившимся зоопарке:");
            foreach (Animal res in result)
            {
                Console.WriteLine(res.nameAnimal);
            }
            Console.ReadLine();
        }
    }
}
