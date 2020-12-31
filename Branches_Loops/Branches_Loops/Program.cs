using System; //importing other librararies to be used

namespace Branches_Loops //used to group and organize code (own package)
{
    class Program
    {
        static void Main(string[] args) //first method -> main method which is the entry point
        {

            //Branches example
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            //Loop example using while
            int counter1 = 0;
            while (counter1 < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter1}");
                counter1++;
            }


            //Loop example using do while
            int counter2 = 10;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);


            //Loop example using for
            //initializer           condition       iterator
            for (int counter3 = 0; counter3 < 10; counter3++)
            {
                Console.WriteLine($"Hello World! The counter is {counter3}");
            }


            // combine branches and loops using fors and if statements.
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0) sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
