using System;

namespace CustomExaption
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new("Rusty", 20);

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    car.Accelerate(10);
                }
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
        }
    }
}
