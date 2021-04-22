using System;

namespace Nested_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nested Repetition: Submittable Task 
            // Receives User Name
            Console.WriteLine("Please enter your first name: ");
            string name = Console.ReadLine();

                for (int i = 0; i < 10; i++) {
                    Console.WriteLine(name);
                }
            // user picks how many times they want their name to be displayed
            Console.WriteLine("Task 2");
            Console.WriteLine("How many letter 'x' do you want: ");
            int nameNum= int.Parse(Console.ReadLine());

            for (int i = 0; i < nameNum; i++)
            {
                Console.WriteLine(name);
            }
            

            // Exercise 2 Task 1\
            string results;
            for (int i = 1; i <= 5; i++) {
                results = new string('x', i);
                Console.WriteLine(results);
            }
            // Task 2
            for (int i = 1; i >= 1; i--) {
                results = new string('x', i);
                Console.WriteLine(results);
            }


        }
    }
}
