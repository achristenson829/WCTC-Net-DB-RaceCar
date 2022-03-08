using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class BillyBob : Driver
    {
        public BillyBob(RaceCar car) : base(car)
        {
            Name = "Billy Bob";
            SkillLevel = 6;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}