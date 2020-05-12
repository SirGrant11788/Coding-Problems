using System;

namespace Coding_Problems
{
    //Given a clock time in hh:mm format, determine, to the nearest degree, the angle between the hour and the minute hands.
    class TimeAngle
    {
        public static void Time()
        {

            int hour = 25, minute = 61;
            while (hour > 24 || minute > 60)
            {
                Console.WriteLine("Enter the time hh:mm");
                string input = Console.ReadLine();
                int.TryParse(input.Remove(2, 3), out hour);
                int.TryParse(input.Remove(0, 3), out minute);
            }
            if (hour > 12 && hour <= 24)
            {
                hour /= 12;
            }

            //angle
            Console.WriteLine("Angle of hour on the clock is: " + 360 / 12 * hour);
            Console.WriteLine("Angle of minute on the clock is: " + 360 / 60 * minute);
            Console.ReadKey();

        }
    }
}
