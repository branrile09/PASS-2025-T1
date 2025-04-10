using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7
{
    public struct location
    {
        public float x;
        public float y;
        public location(float x, float y) 
        { this.x = x; this.y = y; }
    }
    internal class Vehicle
    {
        public string LicensePlate;
        public location location;
        
        public Vehicle() 
        {
            location = new location(0,0);
        }

        public void move(float x, float y) 
        {
            location.y += y;
            location.x += x;        
        }
    }

    internal class Car : Vehicle
    {
        public int tyres = 4;
        protected int regoExpiry; //Days

        public Car() { }

        public Car(int tyres) { this.tyres = tyres; }

        protected void fillupFuel()
        { }

        public void Burnout() {
            Console.WriteLine("you do a hektik burnout!!"); 
            Console.WriteLine("Now you're waiting for a mate");        
        }
    }
    //technical design flaw, motorbike != car
    internal class Motorbike : Car 
    {
        public Motorbike() { tyres = 2; }
        public Motorbike(int t) {            
            //has to have 2,3 or 4 tyres 
            if (t <= 1) 
            { tyres = 2; }
            else if (t > 4) { tyres = 2; }
            else { tyres = t; }
        }
        public void Wheelies()
            { 
            Console.WriteLine("you lose your license");
            regoExpiry = 0;
        }



    }





}
