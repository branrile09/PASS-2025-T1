using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_8
{    //Animal kingdom, minimal detail,
     //not important for demonstration

    internal class _Kingdom
    {
        public string subclass;

        public string kingdomtype;
        public _Kingdom() { }

        public bool CheckIfSick()
        {
            return false;        
        }

        public _Kingdom(string name) { }

    }

    internal class _Animals:_Kingdom
    {

    }

    internal class _Class : _Animals
    {
        
        public string ClassType;
        //key information: https://en.wikipedia.org/wiki/Mammal
        public _Class() { }
    }

   internal class _Genus : _Class 
    {
        public string genusType;       
        public _Genus() { subclass = "genus"; }
        public _Genus(string g, string c) 
        {
            subclass = "genus";
            genusType = g;
            ClassType = c;        
        }

        public void AnimalStuff() { Console.WriteLine("Animals poops"); }
    
    }

    internal class _vegetable:_Kingdom
    {
        public string vegetableType; 
        public _vegetable() { subclass = "Veg";}

        public void vegetableStuff()
        {
            Console.WriteLine("The sentient vegetable expresses concern of a singularity");
        
        }
    
    }







}
