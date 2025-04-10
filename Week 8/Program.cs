namespace Week_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pretend dataset or something, we need keep track of
            _Animals animals = new _Animals(); //very little info
            _Class @class = new _Class();
            _Genus @genus = new _Genus();

            //constructors arent initialize with correct info
            _Genus dog = new _Genus();
            _Genus cat = new _Genus();
            _Genus penguin = new _Genus();
            _Genus grassHopper = new _Genus();

            _vegetable BobTheSentientPotato = new _vegetable();
            _vegetable TrevTheSentientPotato = new _vegetable();
            _vegetable DoraTheSentientPotato = new _vegetable();
            _vegetable KentTheSentientPotato = new _vegetable();
            
            
            //polymorphism, by changing class from subclass to baseclass
            List<_Kingdom> ListOfPets = new List<_Kingdom>();
            ListOfPets.Add(grassHopper);
            ListOfPets.Add(penguin);
            ListOfPets.Add(dog);
            ListOfPets.Add(cat);
            ListOfPets.Add(BobTheSentientPotato);
            ListOfPets.Add(TrevTheSentientPotato);
            ListOfPets.Add(DoraTheSentientPotato);
            ListOfPets.Add(KentTheSentientPotato);
            //check if sick
            foreach (_Kingdom k in ListOfPets)
            {
                if (k.CheckIfSick())
                {
                    Console.WriteLine("our pets sick");
                }
                else { Console.WriteLine("pet is healthy"); }   
            }


            foreach (_Kingdom k in ListOfPets)
            {
                //checking the subclass type, 
                if (k.subclass == "genus")
                {
                    //casting back to _genus
                    _Genus _ref = (_Genus)k;
                    _ref.AnimalStuff();                      
                }
                else if (k.subclass == "Veg")
                {
                    //casting back to _veg
                    _vegetable _ref = (_vegetable)k;
                    _ref.vegetableStuff();
                }
            }



            Console.WriteLine(ListOfPets[5].GetType());

            _vegetable vegetable = new _vegetable();
            _Kingdom newK = new _vegetable();
            if (ListOfPets[5].GetType() == vegetable.GetType())
            {
                Console.WriteLine("is veg");            
            }
            if (ListOfPets[5].GetType() == newK.GetType())
            {
                Console.WriteLine("is newK");
            }


















        }
    }
}
