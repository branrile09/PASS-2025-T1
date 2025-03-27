using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;


namespace Week_6
{
    public struct driversLicense
    {
        //variables
    
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int newNumber = 5;
            newNumber.ToString();
            int i = newNumber.CompareTo(5);

            //Console.WriteLine(i);


            Person newPerson = new Person();
            Person newPerson2 = new Person(32,"DALE",1000);

            Console.WriteLine(newPerson.name);
            Console.WriteLine(newPerson2.name);

            newPerson.go4Walk(5000);
            newPerson2.go4Walk(10.5f);


            newPerson.askForMoney(30);
            newPerson2.askForMoney(30);


            //check list
            //1. variables & interaction,  = 5-9
            //2. if/else/switch (operators, complexity precedence) = 5-10
            //3. loops, 4 types and when to use them = 7

            //4. arrays, standard and multi-dimensional[]

            //declare
            int[] ints = new int[5]; //declare, all values are null
            int[] Ints = { 1, 2, 3 }; //declare array size based on values, this case would be 3
            ints[3] = 1;
           // Console.WriteLine(ints[3]);
           // Console.WriteLine();

            //5. functions, returns, overloads, param vs args, default params
            //

            //6. Objects. 
        }


    }

    public class Wallet
    {
        float moneyz = 32.5f;
        public Wallet(float moneyz)
        {
            this.moneyz = moneyz;
        }
        public Wallet()
        {            
        }
        public float getMoney(float m)
        {
            if (m <= moneyz)
            {
                moneyz -= m;
                return m;
            }
            else {
                //say hell no, not giving moneyz
                //return 0;

                //gives as much as possible
                float M = moneyz;
                moneyz = 0;
                return M;
            }      
        }

        public float checkMoney()
        {
            return moneyz;
        }

    }


    public class Person
    {
        //variables
        Wallet myMoneyz;
        int SSN;
        public string name;

        //default constructor
        public Person() 
        {
            myMoneyz = new Wallet();
            SSN = 1;
            name = "BOB";
            Console.WriteLine(SSN);
        }
        //overloaded constructor takes args for params
        public Person(int ssn, string name, float m)
        {
            myMoneyz = new Wallet(m);
            SSN = ssn;
            this.name = name;
            Console.WriteLine(SSN);
        }

        //functions
        public void go4Walk(float km)
        {
            Console.WriteLine($"{name} goes for a walk {km}kms");
        }

        public float askForMoney(float m)
        {
            if (name == "BOB")
            {
                //bob is stingy
                Console.WriteLine("HELL NO!");
                return 0;            
            }
            else if (name == "DALE")
            {                
                //Dale is kind and generous
                float M = myMoneyz.getMoney(m);
                Console.WriteLine($"{name} gives ${M}");
                M = myMoneyz.checkMoney();
                Console.WriteLine($"{name} has ${M} left"); 

                return M; 
            }
            return 0;
        
        
        }

    }
}
