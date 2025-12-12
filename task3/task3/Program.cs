using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Menu = { " New", "Display", "Exit" };
            int x = 0;
            string name="0";
            string salary="0";
            string ID="0";

            for (int i = 0; i < Menu.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(120 / 2, (i + 1) * 9);
                Console.WriteLine(Menu[i]);

            }

            while (true)
            {
           
                ConsoleKeyInfo k = Console.ReadKey();

                if (k.Key == ConsoleKey.DownArrow)
                {
                    x++;
                    if (x == Menu.Length) x = 0;
                }
                else if (k.Key == ConsoleKey.UpArrow)
                {
                    x--;
                    if (x < 0) x = Menu.Length - 1;
                }


                if (x == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(120 / 2, (0 + 1) * 9);
                    Console.WriteLine(Menu[0]);
                    for (int i = 1; i < Menu.Length; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(120 / 2, (i + 1) * 9);
                        Console.WriteLine(Menu[i]);
                    }

                    ConsoleKeyInfo z = Console.ReadKey();
                    if(z.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(120 / 2, ((0 + 1) * 9)+3);
                        Console.WriteLine("enter your name");
                         name = Console.ReadLine();
                        Console.WriteLine("enter your salray");
                         salary = Console.ReadLine();
                        Console.WriteLine("enter your ID");
                         ID = Console.ReadLine();
                        
                        Console.Clear();

                    }
          



                }

                if (x == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(120 / 2, (0 + 1) * 9);
                    Console.WriteLine(Menu[0]);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(120 / 2, (1 + 1) * 9);
                    Console.WriteLine(Menu[1]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(120 / 2, (2 + 1) * 9);
                    Console.WriteLine(Menu[2]);
                    ConsoleKeyInfo z = Console.ReadKey();
                    if (z.Key == ConsoleKey.Enter)
                    {
                        Console.SetCursorPosition(120 / 2, ((1 + 1) * 9) + 3);
                        Console.WriteLine(" your name " + name);
                        Console.WriteLine("your salary ", salary);
                        Console.WriteLine("your ID ", ID);

                        ConsoleKeyInfo w = Console.ReadKey();
                        if (w.Key == ConsoleKey.Escape)
                        {
                            Console.Clear();

                        }






                    }
                }
                if (x == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(120 / 2, (0 + 1) * 9);
                    Console.WriteLine(Menu[0]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(120 / 2, (1 + 1) * 9);
                    Console.WriteLine(Menu[1]);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(120 / 2, (2 + 1) * 9);
                    Console.WriteLine(Menu[2]);
                    ConsoleKeyInfo z = Console.ReadKey();
                    if (z.Key == ConsoleKey.Enter)
                    {
                        break;
                    }





                }




            }
        }
    }
}
