using System;

namespace _1
{      
    class Program
    {
        static void Main(string[] args)
        {
            int BufferMas = 0;
            int number=0;
                     if (args.Length >= 3 & args.Length % 2 != 0)
            {
                for (int a = 1; a < args.Length; a++)
                {
                    if (args[BufferMas] == args[a])
                    {   Console.WriteLine("Обнаружено совпадение");
                        Environment.Exit(0);
                    }
                    if (a == 4 && args[BufferMas] != args[BufferMas + 1])
                    {   BufferMas++;
                        a = BufferMas;                
                    }}}
            else
            {   Console.WriteLine("vvedeno nepravilnse znachenija");
                Environment.Exit(0);
            }


            int sch = 1;
            int lenght = args.Length;
            int pol = lenght / 2;
            Random rnd = new Random();
            int value = rnd.Next(1, args.Length + 1);






            

            Console.WriteLine("0" + " - " + "Exit");
            foreach (var s in args)
            {
                Console.WriteLine( sch +" - "+ s.ToString());
                sch++;
            }

            Console.WriteLine("Сделайте ваш выбор");
            number =Convert.ToInt32 (Console.ReadLine());
            if (number == 0)
            {
                Environment.Exit(0);
                Console.WriteLine("Игра окончена");
            }

            Console.WriteLine("Vibor igroka  " + number + " -  " + args[number - 1]);
            Console.WriteLine("Vibor Compijutera  " +value+" -  "+args[value-1]);
        }
        

        }
    }