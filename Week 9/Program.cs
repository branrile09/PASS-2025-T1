namespace Week_9
{

    public struct secureVariable
    { 
        private float Value;
        public secureVariable(float v)
        {
            Value = v * 42;        
        
        }

        public float FetchValue()
        { 
            return Value / 42;   
        }

        public void AssignValue(float v)
        {
            Value = v * 42;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //python hates divide 0
            //EdgeCase();
            //float f = 3.04f / 0;

            //Console.WriteLine(f);

            //recursionBAD(1);

           // f = recursionGood(9, 9, 0);
            //Console.WriteLine(f);


            //data too big for variables. float point and boolean limitation
            //memory leaks
            //infinte loop, or recursive functions with no exit condition
            //going outside scope of datastructure, e.g Arrays, Lists, Map. Dictionary


            int i = 0;
            secureVariable protectedData = new(0);

            do 
            {

                Console.Clear();
                Console.WriteLine($"Current number:{protectedData.FetchValue()}");
                Console.WriteLine("enter a number");
                string s = Console.ReadLine();

                float i2 = protectedData.FetchValue();

                i2 += (float)int.Parse(s);


                bool b = int.TryParse(s, out i);

                protectedData.AssignValue(i2);
            
            } while (true);


            //bandaind fix
            try
            {
                //try to do some code, 
                //if fails, revert before try, then go to catch
            
            } catch {
                //throw an exception. 
            
            }


        }

        static void EdgeCase()
        {
            //edge case, we give a string, cant parse to intiger, causes crash
            Console.WriteLine("ask for a number");

            string s = Console.ReadLine();
            Console.WriteLine(s);

            int i = int.Parse(s);


            int j = 4;
            int k = i * j;
            Console.WriteLine(k);
        }

        static void recursionBAD(int i)
        {
            Thread.Sleep(100);
            Console.WriteLine(i);
            i *= 2;
            recursionBAD(i);
        }
        static float recursionGood(float i,int depthLimit, int currentDepth)
        {
            currentDepth += 1;
            
            //early exit
            if (depthLimit == currentDepth) 
            {
                return i;
            }

            i += (depthLimit * currentDepth)/ 2;
            Console.WriteLine(i);

            i = recursionGood(i,depthLimit,currentDepth);


            return i;
        }


    }
}
