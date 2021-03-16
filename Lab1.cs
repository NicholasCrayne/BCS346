using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing Part 1...");
            PartOne();

            Console.WriteLine("Initializing Part 2...");
            PartTwo();

            Console.WriteLine("Initializing Part 3...");
            PartThree();

            Console.WriteLine("Initializing Part 4...");
            PartFour();
        }

        static void PartOne()
        {
            char ch;
            int num;

            Console.WriteLine("Please enter a character: ");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nPlease enter a number between 0 and 10: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num >= 10 || num <= 0)
            {
                Console.WriteLine("\nNumber entered was out of bounds!\n");
                Console.WriteLine("\nPlease enter a number between 0 and 10: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(ch);
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }

        static void PartTwo()
        {
            char ch;
            int num;

            Console.WriteLine("Please enter a character: ");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nPlease enter a number between 0 and 10: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num >= 10 || num <= 0)
            {
                Console.WriteLine("\nNumber entered was out of bounds!\n");
                Console.WriteLine("\nPlease enter a number between 0 and 10: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(ch);
                }
                Console.Write("\n");
            }

            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(ch);
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }

        static void PartThree()
        {
            int num1,num2 = 0,temp;

            Console.WriteLine("Please enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(num1);
            while (num1 != 0)
            {
                temp = num1 % 10;
                num2 = num2 * 10 + temp;
                num1 /= 10;
            }
            Console.WriteLine(num2);

            Console.ReadLine();
        }

        static void PartFour()
        {
            string password;
            bool isValid = true;

            Console.WriteLine("Please enter a password that meets the follwing requirements:");
            Console.WriteLine("\t- Must be between 6 and 15 characters");
            Console.WriteLine("\t- Must contain at least one Uppercase Letter");
            Console.WriteLine("\t- Must contain at least one Lowercase Letter");
            Console.WriteLine("\t- Must contain at least one digit (0 - 9)");
            Console.WriteLine("\t- Must Contain at least one of the following special characters: ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; \" ' ? < > , .");
            password = Console.ReadLine();

            Console.WriteLine("\nNow validating password...\n");

            if ((password.Length >= 6 && password.Length <= 15) == false)
            {
                isValid = false;
            }

            if(true)
            {
                int numCount = 0; 
                for (int i = 0; i <= 9; i++)
                {
                    char check = Convert.ToChar(i);

                    if (password.Contains(check))
                    {
                        numCount = 1;
                    }
                }
                if (numCount == 0)
                {
                    isValid = false;
                }
            }

            if (true)
            {
                int upperCounter = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    char a = Convert.ToChar(password[i]);
                    if (char.IsUpper(a))
                    {
                        upperCounter++;
                    }
                }
                if (upperCounter == 0)
                {
                    isValid = false;
                }
            }

            if (true)
            {
                int lowerCounter = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    char a = Convert.ToChar(password[i]);
                    if (char.IsLower(a))
                    {
                        lowerCounter++;
                    }
                }
                if (lowerCounter == 0)
                {
                    isValid = false;
                }
            }

            if ( !(password.Contains("!")
                || password.Contains("@")
                || password.Contains("#")
                || password.Contains("$")
                || password.Contains("%")
                || password.Contains("^")
                || password.Contains("&")
                || password.Contains("*")
                || password.Contains("(")
                || password.Contains(")")
                || password.Contains("+")
                || password.Contains("-")
                || password.Contains("=")
                || password.Contains("_")
                || password.Contains("-")
                || password.Contains("{")
                || password.Contains("}")
                || password.Contains("[")
                || password.Contains("]")
                || password.Contains(":")
                || password.Contains(";")
                || password.Contains("\"")
                || password.Contains("\'")
                || password.Contains("?")
                || password.Contains("<")
                || password.Contains(">")
                || password.Contains(",")
                || password.Contains(".")))
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Your password was successfully varified!");
            }
            else
            {
                Console.WriteLine("Your password is missing one or more of the requirements!");
                PartFour();
            }

            Console.ReadLine();
        }
    }
}
