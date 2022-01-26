using System;
using System.IO;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new("Bugati", 90);
            car.CrankTunes(true);

            try
            {
                car.Accelerate(1000);
            }
            catch (CarIsDeadException e) 
                when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Wednesday)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
                try
                {
                    FileStream fs = File.Open("C:\\carErrors.txt", FileMode.Open);
                }
                catch (Exception e2)
                {
                    throw new CarIsDeadException(e.Message, e2);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                car.CrankTunes(false);
            }
        }
    }
}
