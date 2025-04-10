namespace Week_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Vehicle vehicle = new Vehicle();

            vehicle.move(3,4);
            Console.WriteLine($"{vehicle.location.x},{vehicle.location.y}");

            Car newCar = new Car(6);

            newCar.move(3,4);
            

            newCar.Burnout();

            Motorbike SuzukiGSXR = new Motorbike();
            SuzukiGSXR.Wheelies();


            //data structure, node/variable type, name;
            List<int> Lints = new List<int>();

            //variables we add at end of the list
            Lints.Add(42);
            Lints.Add(69);
            Lints.Add(360);
            //accessing 2nd variable
            Console.WriteLine(Lints[1]);

            //used subclass, need to use baseclass
            List<Motorbike> newList = new List<Motorbike>();
            newList.Add(SuzukiGSXR);
            //newList.Add(newCar);
            //newList.Add(vehicle);
            
            List<Vehicle> newList2 = new List<Vehicle>();
            newList2.Add(SuzukiGSXR);
            newList2.Add(newCar);
            newList2.Add(vehicle);

            List<Car> newList3 = new List<Car>();
            newList3.Add(SuzukiGSXR); //motorbike (design flaw)

        }


    }
}
