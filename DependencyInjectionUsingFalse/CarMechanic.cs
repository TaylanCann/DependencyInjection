using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUsingFalse
{
    public class CarMechanic
    {
        public void changeWheels()
        {
            Nissan350Z nissan350Z = new Nissan350Z();
            nissan350Z.changeWheels();

            ToyotaSupra toyotaSupra = new ToyotaSupra();
            toyotaSupra.changeWheels();
        }

        public void headlightChange()
        {
            Nissan350Z nissan350Z = new Nissan350Z();
            nissan350Z.headlightChange();

            ToyotaSupra toyotaSupra = new ToyotaSupra();
            toyotaSupra.headlightChange();
        }
    }

    public class Car { }

    public class Nissan350Z:Car 
    {
       public void changeWheels() 
        {
            Console.WriteLine("Wheels Changed");
        }

        public void headlightChange() 
        {
            Console.WriteLine("Headlights Changed");
        }
    }

    public class ToyotaSupra : Car
    {
        public void changeWheels()
        {
            Console.WriteLine("WheelsChanged");
        }
        public void headlightChange()
        {
            Console.WriteLine("Headlights Changed");
        }
    }
}
