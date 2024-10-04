using System;

class Program
{
    static void Main(string[] args)
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("***Demo Design Pattern***");
            Console.WriteLine("1. Demo Factories Method Pattern.");
            Console.WriteLine("2. Demo Abstract Factory Pattern.");
            Console.WriteLine("3. Demo Prototype Pattern.");
            Console.WriteLine("4. Exit");
            try
            {
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Demo1 demo1 = new Demo1();
                        demo1.Run();
                        break;
                    case 2:
                        Demo2 demo2 = new Demo2();
                        demo2.Run();
                        break;
                    case 3:
                         Demo3 demo3 = new Demo3();
                        demo3.Run();
                        break;
                    case 4:
                        check = false;
                        Console.WriteLine("Exit program!!!");
                        break;
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Invalid Input!!! Please re-enter");
            }

        }
        Console.ReadLine();
    }
}