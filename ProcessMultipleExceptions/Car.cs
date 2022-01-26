using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Car
    {
        public const int MaxSpeed = 100;
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        private Radio theMusicBox = new();

        public Car()
        {

        }

        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int  delta)
        {
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");
            }

            if (carIsDead)
            {
                Console.WriteLine($"{PetName} is out of order...");
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;

                    CarIsDeadException ex = new($"{PetName} has overheated!", DateTime.Now, "You have a lead foot");
                    ex.HelpLink = "http://www.carsRus.com";

                    throw ex;
                }
                else
                {
                    Console.WriteLine($"Current speed: {CurrentSpeed}");
                }
            }
        }
    }
}
