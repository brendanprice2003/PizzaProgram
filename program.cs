using System;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace PizzaProgram
{
    class Program
    {
        public int tPrice = 0;

        static string ParsePizzaSize() // Sanitize input
        {
            // Pizza size input
            Console.WriteLine("What Size Pizza Would You Like Today?: ");
            Console.WriteLine("1. Small Size Pizza\n" +
                              "2. Medium Size Pizza\n" +
                              "3. Large Size Pizza\n");
            string input = Console.ReadLine().ToLower();
            string output = "";

            // Number input
            if (input == "1")      { output = "s"; }
            else if (input == "2") { output = "m"; }
            else if (input == "3") { output = "l"; }

            // Text input
            else if (input == "small")  { output = "s"; }
            else if (input == "medium") { output = "m"; }
            else if (input == "large")  { output = "l"; }
            else if (input == "small pizza")  { output = "s"; }
            else if (input == "medium pizza") { output = "m"; }
            else if (input == "large pizza")  { output = "l"; }

            // User has entered something incorrect
            else
            {
                Console.WriteLine("Please Enter A Valid Pizza Size; Try Again.. (Press enter to try again)");
                Console.ReadLine();
                ParsePizzaSize();
            };

            return output;

            // Output doesn't exist?  LAME!!  -\_(._.)_/-
        }

        static int ParseToppingsAmount()
        {
            // Toppings amount input
            Console.WriteLine("How Many Toppings On That Pizza?: ");
            Console.WriteLine("1. One Topping\n" +
                              "2. Two Toppings\n" +
                              "3. Three Toppings\n");
            string input = Console.ReadLine().ToLower();
            int output = 0; // 0 = error

            // Number input
            if (input == "1") { output = 1; }
            else if (input == "2") { output = 2; }
            else if (input == "3") { output = 3; }
            else if (input == "4") { output = 4; }

            // Text input
            else if (input == "one") { output = 1; }
            else if (input == "two") { output = 2; }
            else if (input == "three") { output = 3; }
            else if (input == "four") { output = 4; }
            else if (input == "one topping") { output = 1; }
            else if (input == "two toppping") { output = 2; }
            else if (input == "three topping") { output = 3; }
            else if (input == "four topping") { output = 4; }

            // Alternate text input
            else if (input == "one topping") { output = 1; }
            else if (input == "two toppping") { output = 2; }
            else if (input == "three topping") { output = 3; }
            else if (input == "four topping") { output = 4; }

            return output;
        }

        static void Main(string[] args)
        {
            // .Write doesn't make a new line after exectution
            Console.Write("Please Enter Your Name: ");
            string uName = Console.ReadLine();

            // Functions return fixed strings
            string pSize = ParsePizzaSize();
            int tAmount = ParseToppingsAmount();
        }
    }
}
