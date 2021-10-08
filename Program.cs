using System;

namespace powertable
{
    class Program
    {
        // cubes is a method thats cubing a integer like 1x1x1
        static int cubes(int x)
        {

            int e = x * x * x;
            return e;

        }
        // squares is a method thats sqauring a integer like 1x1
        static int squares(int x)

        {
            int y = x * x;
            return y;
        }
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Learn your squares and cubes!\n");
                Console.WriteLine("Enter a integer:");
                //this is a integer type with the name variable
                //and user is entering  input to a integer
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed"));
                Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}", "=======", "=======", "======="));



                int count = 1;

                while (count <= number)
                {
                    Console.WriteLine(String.Format("{0,-10} {1,-10} {2,-10}", count, squares(count), cubes(count)));



                    //Console.WriteLine(squares(count));


                    count += 1;


                }
                Console.WriteLine("Continue? (y/n):");
                string restart = Console.ReadLine();
                if (restart == "y" || restart == "Y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;

                }

            }
        }
    }
}