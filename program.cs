using System;

namespace PizzaProgram
{
    class Program
    {
        public static double tPrice = 0;

        static string ParsePizzaSize() // Sanitize input
        {
            // Pizza size input
            Console.WriteLine("What Size Pizza Would You Like Today?: ");
            Console.WriteLine("1. Small Size Pizza\n" +
                              "2. Medium Size Pizza\n" +
                              "3. Large Size Pizza\n");
            string input = Console.ReadLine().ToLower();
            string output = ""; // "" = error

            // Number input
            if (input.Contains("1") || input.Contains("small")) { output = "s"; }
            else if (input.Contains("2") || input.Contains("medium")) { output = "m"; }
            else if (input.Contains("3") || input.Contains("large")) { output = "l"; }

            // User has entered something incorrect
            else
            {
                Console.WriteLine("Please Enter A Valid Pizza Size; Please Try Again.. (Press enter to try again)");
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
            if (input.Contains("1") || input.Contains("one")) { output = 1; }
            else if (input.Contains("2") || input.Contains("two")) { output = 2; }
            else if (input.Contains("3") || input.Contains("three")) { output = 3; }
            else if (input.Contains("4") || input.Contains("four")) { output = 4; }

            // User has entered something incorrect
            else
            {
                Console.WriteLine("Please Enter A Valid Toppings Amount; Please Try Again.. (Press enter to try again)");
                Console.ReadLine();
                ParseToppingsAmount();
            }

            return output;
        }

        static string DoBill(double tPrice, string delivChoice)
        {
            string billString = "";
            delivChoice = delivChoice.ToLower();

            // Code
            if (billString == "Y")
            {
                tPrice += 2.50;
            }
            else if (billString == "N")
            {

            }

            return billString;
        }

        static void Main(string[] args)
        {
            // .Write doesn't make a new line after exectution
            Console.Write("Please Enter Your Name: ");
            string uName = Console.ReadLine();

            // Functions return fixed strings
            string pSize = ParsePizzaSize();
            int tAmount = ParseToppingsAmount();

            // Do some madderz maf
            if (pSize == "s") { tPrice += 3.25; }
            else if (pSize == "m") { tPrice += 5.50; }
            else if (pSize == "l") { tPrice += 7.15; }

            // Do sum even more madderz maf ennit
            if (tAmount == 1) { tPrice += 0.75; }
            else if (tAmount == 2) { tPrice += 1.35; }
            else if (tAmount == 3) { tPrice += 2.00; }
            else if (tAmount == 4) { tPrice += 2.50; }

            // Check if user wants it delivered
            Console.Write("And Do You Want That Delivered Or Not? [Y/N]");
            string delivChoice = Console.ReadLine();

            // DoBill(tPrice, delivChoice);
        }
    }
}
