using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426_Lab3
{
    public static class IntegerExtension
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nNOW INITIATING PART ONE...");
            PartOne();

            Console.WriteLine("\nNOW INITIATING PART TWO...");
            PartTwo();
        }

        static void PartOne()
        {
            Console.WriteLine("\nPlease enter a number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            string s = i.ToRoman();
            Console.WriteLine($"\nHere is the same number converted to Roman Numerals: {s}");

            Console.WriteLine("\nWould you like to try again?\n(Type 'y' to try again, or any other input to return)");
            char yesOrNo = Convert.ToChar(Console.ReadLine());
            if (yesOrNo == 'y')
                PartOne();
            else
                return;
        }

        public static string ToRoman(this int num)
        {
            if (num < 0)
                return "ERROR! Number is out of the feasible range!";
            if (num >= 1000)
                return "M" + ToRoman(num - 1000);
            if (num >= 900)
                return "CM" + ToRoman(num - 900);
            if (num >= 500)
                return "D" + ToRoman(num - 500);
            if (num >= 400)
                return "CD" + ToRoman(num - 400);
            if (num >= 100)
                return "C" + ToRoman(num - 100);
            if (num >= 90) 
                return "XC" + ToRoman(num - 90);
            if (num >= 50) 
                return "L" + ToRoman(num - 50);
            if (num >= 40) 
                return "XL" + ToRoman(num - 40);
            if (num >= 10) 
                return "X" + ToRoman(num - 10);
            if (num >= 9) 
                return "IX" + ToRoman(num - 9);
            if (num >= 5)
                return "V" + ToRoman(num - 5);
            if (num >= 4)
                return "IV" + ToRoman(num - 4);
            if (num >= 1)
                return "I" + ToRoman(num - 1);
            else
                return "";
        }
        
        static void PartTwo()
        {
            Book b1 = new Book( 50.99m , "978-1492051138" , "C# 8.0 in a Nutshell" , "Jack Smith" );
            Book b2 = new Book( 2.99m , "100-1492051000" , "C#: Advanced Features and Programming Techniques" , "Jill Smith" );
            Software s1 = new Software( 69.99m , "" , "Microsoft 365 Personal" , "16.0.10827" );

            Console.WriteLine($"\nPlease enter the number of copies of \"{b1.description}\" you wish to purchase: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nPlease enter the number of copies of \"{b2.description}\" you wish to purchase: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYou will be spending ${b1.Sell(num1)} on {num1} copies of \"{b1.description}\"" +
                              $"\nand ${b2.Sell(num2)} on {num2} copies of \"{b2.description}\"" +
                              $"\nfor a total of ${(b1.Sell(num1) + b2.Sell(num2))}.\n");

            Console.WriteLine($"\nPlease enter the number of copies of \"{s1.description}\" you wish to purchase: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYou will be spending ${s1.Sell(num3)} on {num3} copies of \"{s1.description}\".\n");

            Console.WriteLine("\nWould you like to try again?\n(Type 'y' to try again, or any other input to return)");
            char yesOrNo = Convert.ToChar(Console.ReadLine());
            if (yesOrNo == 'y')
                PartTwo();
            else
                return;
        }
    }

    public abstract class Product
    {
        public Decimal price;
        public string code;
        public string description;

        public Product(decimal p, string c, string d)
        {
            price = p;
            code = c;
            description = d;
        }
    }

    public interface ISellable
    {
        decimal Sell(int count);
    }

    public class Book : Product, ISellable
    {
        public string author;

        public Book(Decimal p, string c, string d, string a) : base(p, c, d)
        {
            price = p;
            code = c;
            description = d;
            author = a;
        }

        public string toString()
        {
            return ($"Price = {price}" +
                   $"\nCode = {code}" +
                   $"\nDescription = {description}" +
                   $"\nAuthor = {author}");
        }

        public decimal Sell(int count)
        {
            return (count * this.price);
        }
    }

    public class Software : Product, ISellable
    {
        public string propertyVersion;

        public Software(Decimal p, string c, string d, string pv) : base(p, c, d)
        {
            price = p;
            code = c;
            description = d;
            propertyVersion = pv;
        }

        public string toString()
        {
            return ($"Price = {price}" +
                   $"\nCode = {code}" +
                   $"\nDescription = {description}" +
                   $"\nProperty Version = {propertyVersion}");
        }

        public decimal Sell(int count)
        {
            return (count * this.price);
        }
    }
}
