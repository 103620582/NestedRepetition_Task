using System;

namespace NestedRepetition_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("G'day! Please enter your name.");
            string getname = Console.ReadLine();

            int counter = 0;
            int counter2 = 1;

            while (counter<5) {
                counter = counter + 1;
                counter2 = counter;

                while (counter2<10) {
                    Console.Write(getname);
                    counter2 = counter2 + 1;
                }

                Console.Write(getname);

            }

            Console.WriteLine(" ");
            Console.WriteLine("Goodbye"+" "+getname);

        }
    }
}
