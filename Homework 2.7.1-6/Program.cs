namespace Homework_2._7._1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie nr.1

            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine("5 i 5 są równe");
            }
            else
            {
                Console.WriteLine("zmienne są różne od siebie");
            }

            Console.WriteLine("--------------------------------------------------------------------");

            //Zadanie nr.2

            Console.WriteLine("Please input number to be checked if it is an even number");
            int number = int.Parse(Console.ReadLine());
            int wynik = number % 2;
            if (wynik != 0)
            {
                Console.WriteLine(number + " is uneven");
            }
            else
            {
                Console.WriteLine(number + " is even");
            }

            Console.WriteLine("--------------------------------------------------------------------");

            // Zadanie nr.3

            Console.WriteLine("Please input number to be checked if it is positive or negative");
            int number1 = int.Parse(Console.ReadLine());
            if (number1 >= 0) 
            {
                Console.WriteLine(number1 + " is positive");
            }
            else
            {
                Console.WriteLine(number1 + " is negative");
            }

            Console.WriteLine("--------------------------------------------------------------------");

            // Zadanie nr.4

            Console.WriteLine("Please enter year to be checked if it is a leap year");
            int number2 = int.Parse(Console.ReadLine());
            int leapYear = number2 % 4;
            if (leapYear == 0) 
            {
                Console.WriteLine(number2 + " is a leap year");
            }
            else
            {
                Console.WriteLine(number2 + "is not a leap year");
            }

            Console.WriteLine("--------------------------------------------------------------------");

            // Zadanie nr.5

            int posel = 21;
            int senator = 30;
            int prezydent = 35;
            int premier = 21;

            Console.WriteLine("Who would you like to become? Choose appriopriate number:");
            Console.WriteLine("1. Member of Parliament");
            Console.WriteLine("2. Senator");
            Console.WriteLine("3. Prime Minister");
            Console.WriteLine("4. President");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (choice ==1 && age >= posel)
            {
                Console.WriteLine("You can become member of Parliament");
            }
            else if (choice == 2 && age >= senator)
            {
                Console.WriteLine("You can become a senator");
            }
            else if (choice == 3 && age >= premier)
            {
                Console.WriteLine("You can become a prime minister");
            }
            else if (choice == 4 && age >= prezydent)
            {
                Console.WriteLine("You can become a president");
            }
            else
            {
                Console.WriteLine("You are too young to overtake this position");
            }

            Console.WriteLine("--------------------------------------------------------------------");

            // Zadanie nr.6

            int dziecko = 120;
            int krasnolud = 150;
            int normal = 190;
            int gigant = 191;

            Console.WriteLine("Please enter your height:");
            int height = int.Parse(Console.ReadLine());

            if (height <= dziecko)
            {
                Console.WriteLine("You are a child");
            }
            else if (height <= krasnolud && height > dziecko)
            {
                Console.WriteLine("You are krasnolud");
            }
            else if (height > krasnolud && height <= normal)
            {
                Console.WriteLine("You are normal");
            }
            else if (height > normal )
            {
                Console.WriteLine("You are gigant");
            }
        }
    }       
}
