﻿using System;
using System.Collections.Generic;

namespace listPlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of planets
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // Add Jupiter and Saturn to the list
            planetList.AddRange(new string[] { "Jupiter", "Saturn" });

            // Create another list and add the last two of our planets to this list

            List<string> lastTwoPlanets = new List<string>() { "Neptune", "Pluto" };

            // Comnbine the two list using addRange()
            planetList.AddRange(lastTwoPlanets);
            planetList.Remove("Pluto");

            // Use Insert() to add Earth and Venus to the list in the correct order
            planetList.InsertRange(1, new List<string>() { "Venus", "Earth" });

            // Use add() to add Pluto to the list
            planetList.Add("Pluto");

            planetList.Remove("Pluto");



            // Looping over the all the planets list
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.Write("Here are the planets that have a rocky surface: ");

            // use GetRange() in order to extract the rocky planets into another list
            var rockyPlanets = planetList.GetRange(0, 4);
           


            // Looping over the rocky planets list
            foreach (var rockies in rockyPlanets)
            {
                rockies.Split(" ");
                Console.WriteLine(rockies);
            }



            Console.ReadLine();
        }
    }
}
