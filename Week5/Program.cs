namespace Week5
{
    internal class Program
    {

        //entry point for program
        // void is nothing

        //static = accessibility, return type e.g void, Name of the function e.g 'Main',  argument/paramaters = inputs with data type
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //variables
            string s = "this is a string";
            int i = 0;
            //decimals
            float floaty = 42.0f;
            double dubs = 69;
            bool balls = true;


            bool pineAppleOnPizza = PineAppleOnPizza(false);

            Console.WriteLine(pineAppleOnPizza);

            Console.WriteLine(AddNumbers(7,8));

            float f = AddNumbers(AddNumbers(AddNumbers(7, 8), 8), AddNumbers(8, 9));
            float g = AddNumbers(1,2,3,4); //10
            g = AddNumbers(1,2,3); //return 6
            g = AddNumbers(1, 2, 3,4,5);

            g = MultiplyNumbers(3,6);
            Console.WriteLine(g);

            int lengths = "hello world".Length;            
            Console.WriteLine(lengths);
           
            s = BiggestString("words","sword");
            Console.WriteLine(s);

            i = AddNumbers(1,2,7,9);
            Console.WriteLine(i);
        }

        //accessibility, return type,  name, parameters, 
        static bool PineAppleOnPizza(bool b)
        {
            //b = false;
            return b;  
        }

        static float AddNumbers(float i, float j, float k = 0, float l = 0, float m = 0)
        {
            return i + j + k + l + m ;
        }

        //function overload. 
        static int AddNumbers(int i, int j, int k = 0, int l = 0, int m = 0)
        {
            //return i + j + k + l + m ;
            float f = AddNumbers((float)i, (float)j, (float)k, (float)l,(float)m);
            return (int)f;        
        }

        static float MultiplyNumbers(float i, float j, float k = 1, float l = 1, float m = 1)
        {          
            return i * j * k * l * m;
        }

        static string BiggestString(string s1, string s2)
        { 
            if (s1.Length >= s2.Length) { return s1; }
            else { return s2; }
        }

         








    }
}
