using System;
namespace Module2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //All String Variables and made up a barrie weather report.
            string weatherToday = "Snowy";
            string percentage = "56%";
            string lowtemperature = "-6°C";
            string windcondition = "20 km/h";
            string hightemperature = "-2°C";
            string UVindex = "0.1";

            //Written the string interpolation to display the weather report.
            Console.WriteLine($"Today's forcast in barrie is {weatherToday},the likelihood of condition around barrie are {percentage} with morning's tempature being {hightemperature}, later in the evening going below to {lowtemperature}. The current UV index is {UVindex}, while winds are pulling in around {windcondition}. I'm your morning host zach signing off.");

            //Today's forcast in barrie is Snowy,the likelihood of condition around barrie are 56% with morning's tempature being -2°C, later in the evening going below to -6°C. The current UV index is 0.1, while winds are pulling in around 20 km/h. I'm your morning host zach signing off.

        }
    }
}