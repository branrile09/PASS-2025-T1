

namespace PASS_2025_T1
{
    internal class Program
    {
        //Our main function. this is our entry point for the code. 
        static void Main(string[] args)
        {
            //program starts at line 12, 
            //leave a hello message
            Console.WriteLine("RB waz here!!");
            Console.WriteLine("Hello this is Angelina");
            Console.WriteLine("I am called Brigid Ah Reum");
            Console.WriteLine("hello this is willy");
            Console.WriteLine("Hello from Queensland");

            //variable types
            int newInt = 5;
            char newChar = 'c';
            string newString = "stringy string";
            double newDecimals1 = 0.001;
            float newDecimals2 = 3.0f;
            long newDecimals3 = 12;
            bool newBool = true;
            
            
            //interactions

            Console.WriteLine(newInt);
            Console.WriteLine(newChar);
            Console.WriteLine(newString);
            Console.WriteLine(newDecimals1);

            int newOutput = newInt + 7; //sum of 2 intigers
            Console.WriteLine(newOutput);

            //newOutput = newDecimals1 + newDecimals2; doesnt work because of 2 different data types

            float floaty = (float)newDecimals1 * newDecimals2; //casting
            newString = floaty.ToString();  

            //string concatination
            Console.WriteLine($"multiplication of 2 decimals: {newString}");
            newString = $"multiplication of 2 decimals: {newString}";

            //string interaction (iterating through a string)
            char newchar = newString[7]; //tenth character
            Console.WriteLine(newchar);

            //booleans 
            newBool = newInt == 4; //comparing values using '=='
            Console.WriteLine(newBool);
            newBool = newInt == 5;
            Console.WriteLine(newBool);




;        }

    }
}
