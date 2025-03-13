namespace Week_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets say Hello!");
            Console.WriteLine("RB waz here");
            
            //Loop types, and when do we use them? 
            //For loop, we use this if we have a specified amount of times we want to loop
            for (int i = 0; i < 10; i++) 
            {
                Thread.Sleep(100);
                Console.WriteLine(i);            
            }
           

            bool tempBool = true;
           

            int j = 1;
            int k = 0;

            bool equalValues = j==k;

            //while loop, evaluate the condition before we run. 
            while (tempBool)
            {

                j++;
                j *= j;


                if (j > 9000)
                {
                    tempBool = false;
                }
                // tempBool = j > 9000;
                Thread.Sleep(10);
                Console.WriteLine(j);

            }

            while (j > 99999999)
            {

                j++;
                j *= j;
                
                Thread.Sleep(10);
                Console.WriteLine(j);

            }

            //we want to do this atleast once, Do while loop
            do { Console.WriteLine("do once!"); } while (false);

            //foreach, useful for lists
            List<int> list = new List<int>();
            foreach (int i in list) { Console.WriteLine(i); }


            //arrays???
            //RB will re-demonstrate how Strings are like Arrays
            string s = "this is a very long string";

            char[] arr = s.ToCharArray();

            char[] charArray = new char[s.Length];

            for (int i = 0; i < s.Length;i++) { charArray[i] = s[i]; Console.WriteLine($"{i}, {s[i]}"); }

            //arrays vs lists vs vectors vs other data structures. (maybe RB does some fully hektik paint skillz)


            // RB demonstrates array

            //single dimensional array
            float[] floats = new float[32];
            //multi-dimensional
            float[][] floats1 = new float[10][];

            //jagged arrays

            // nested looping with multi-dimensional arrays

            int index = 0;
            for (int i = 0; i < 10;i++) 
            {
                floats1[i] = new float[10];    
                for (int l = 0; l < 10; l++)
                {
                    floats1[i][l] = index;                        
                    index++;
                }         
            
            }

            for (int i = 0; i < 10; i++)
            {
                for (int l = 0; l < 10; l++)
                {
                    Console.Write($"{floats1[i][l]},");
                }
                Console.WriteLine();
            }


            // Q&A and HOOK!!!!!


        }
    }
}
