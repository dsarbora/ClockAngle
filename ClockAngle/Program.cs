using System;

namespace ClockAngle
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number between 1 and 12");
            int time = int.Parse(Console.ReadLine());
            Clock newClock = new Clock();
            
            if(newClock.CheckAngle(time)>=0)
            {
                Console.WriteLine("At " + time.ToString() + " o'clock, the angular distance between the minute hand and the hour hand is " + newClock.CheckAngle(time).ToString() + " degrees.");
            }
            else
            {
                Console.WriteLine("Please choose an integer between 0 and 12.");
            }
        }
    }
}