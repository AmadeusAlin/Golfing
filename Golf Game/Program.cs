using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf_Game
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();
            double distanceToCup = 320; //random.Next(200, 900); //Randomising distance to cup
            Console.WriteLine($"There is {distanceToCup} meters between the ball and the cup, Take a swing!");//displaying distance to the cup for player
           
            List<int> numberOfSwings = new List<int>();// declaring list for number of swings taken
            List<double> distancesOfSwings = new List<double>();//declaring list for the distances after each swing
            
            bool keepRunning = true; //declaring boolean for
            while (keepRunning)//while loop to keep program running
            {

                Console.WriteLine("\n");
                Console.WriteLine("Enter the angle for you swing: ");

                int swingAngle = Convert.ToInt32(Console.ReadLine());// Takes input for Angle in Swing

                Console.WriteLine("Enter The strenght of your swing in m/s : ");

                int swingVelocity = Convert.ToInt32(Console.ReadLine());// Takes input for Strength in swing
                double distance;//declaring a variable for distanced traveled from swing

                Swing(swingAngle, swingVelocity, out distance);//calling method to calculate swing
                distancesOfSwings.Add(distance);// saves distance of swing in list of distances from swings
                numberOfSwings.Add(+1);
                distanceToCup = distanceToCup - distance;
                if (distanceToCup <= 0)
                {
                    distanceToCup = distanceToCup * -1;
                    Console.WriteLine($"There is {distanceToCup:N} meters between the ball and the cup, Take a swing!");//displaying distance to the cup for player
                }
                else if (distanceToCup == distanceToCup * 2)
                {

                }
                else
                {
                Console.WriteLine($"There is {distanceToCup:N} meters between the ball and the cup, Take a swing!");//displaying distance to the cup for player
                }


            }

        }

        static double Swing(int angle, int velocity, out double distanceOfSwing)
        {

            double gravity = 9.8;//declaring gravity and giving it value 9.8
            double newAngle = (Math.PI / 180) * angle;
            double distance = Math.Pow(velocity, 2) / gravity * Math.Sin(2 * newAngle);
            Console.WriteLine($"Swing distance = {distance:N} meters");
            distanceOfSwing = distance;
            return distanceOfSwing;
        }



    }
}
