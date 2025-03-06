namespace Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //what is your favourite caffeinated beverage?
            Console.WriteLine("Monster Energy drink, RB");
            Console.WriteLine("Dale loves Coffee, DH");
            Console.WriteLine("Green Tea, CC");
            Console.WriteLine("Matcha, KS");
            Console.WriteLine();
            Console.WriteLine("text");


            //standard library, this includes things like basic variables("int, float, bool, string"),
            //Console, random, timer, threading, things that we use includes. 
            //naming conventions: CamelCasing, ScreamSnake, 


            bool pineappleGoesOnPizza = false;
            if (pineappleGoesOnPizza)
            {
                Console.WriteLine("pineapple does go on pizza");

            }
            else if (!pineappleGoesOnPizza)
            {
                Console.WriteLine("pineapple does not go on pizza");
            }

            bool likeCats = false;
            bool likeDogs = false;

            if (likeCats && likeDogs)
            {
                Console.WriteLine("likes both");
            }
            else if (!likeCats && likeDogs)
            {
                Console.WriteLine("likes dogs");
            }
            else if (!likeDogs && likeCats)
            {
                Console.WriteLine("likes dogs");
            }
            else
            {
                Console.WriteLine("depressed because doesnt like doggos or cats");
            }

            //student Bach IT, Bach Software (AI & Gamedev), Diploma, Cybersecurity

            bool bachIT = false;
            bool bachAI = false;
            bool bachGameProg = true;
            bool CyberSecurity = false;

            //use of OR statements
            if (bachIT || bachAI || bachGameProg || CyberSecurity)
            {
                Console.WriteLine("you will do intro to software engineering");
            }


            string newString = "asgbasdgbkasdnikjhasdfhghasfd76";
            bool tempBool = false ;

            //use of Or comparison, complex task on right, evaluate left side first
            if (tempBool || hasNumber(newString))
            {
                Console.WriteLine("has number in the string");

            }
            
            //use of AND Comparison, complex task on right, evaluate left side first
            if (tempBool && hasNumber(newString))
            {
                Console.WriteLine("different text");
            }

            // https://www.w3schools.com/cs/cs_switch.php Switches are superuseful and efficient

            //example for w3 schools ^
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)



        }


        //complex task example
        static bool hasNumber(string s)
        {
            foreach (char c in s) { if (c >= '0' && c <= '9')
                {
                    Console.WriteLine("evaluate");
                    return true;
                }
            ;
            }
            Console.WriteLine("evaluate");
            return false;
        }

    }
}