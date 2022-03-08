using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class FordTruck : RaceCar
    { 
        public FordTruck()
        {
            Name = "Ford Truck";
            TopSpeed = 75;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts with a Vroom!");
        }

        public virtual void Brake()
        {
            Console.WriteLine($"The {Name} sputters and falls to {Position}");
        }
    }
}