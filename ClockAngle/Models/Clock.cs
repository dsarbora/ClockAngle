using System;

namespace ClockAngle
{
    public class Clock
    {
        public int CheckAngle(int time)
        {
            if (time>0 && time<=6)
            {
                return 30*time;
            }
            else
            {
                return 180-(30*(time-6));
            }
        }
    }
}