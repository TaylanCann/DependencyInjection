using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUsingTrue
{
    public class CarMechanic
    {
        private readonly ICarMechanic carMechanic;
        public CarMechanic(ICarMechanic carMechanic)
        {
            this.carMechanic = carMechanic;
        }
        public void ChangedWheels() 
        {
            carMechanic.changeWheels();
        }
        public void ChangedHeadlight()
        {
            carMechanic.headlightChange();
        }
    }
    public interface ICarMechanic
    {
        public void changeWheels();
        public void headlightChange();
    }

    public class Car { }

    public class Nissan350Z : Car, ICarMechanic
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
    public class ToyotaSupra : Car, ICarMechanic
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

}
