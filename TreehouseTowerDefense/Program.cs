﻿using System;
using System.Collections.Generic;

namespace TreehouseTowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path{
                 new [] {
                 new MapLocation(0, 2, map),
                 new MapLocation(1, 2, map),
                 new MapLocation(2, 2, map),
                 new MapLocation(3, 2, map),
                 new MapLocation(4, 2, map),
                 new MapLocation(5, 2, map),
                 new MapLocation(6, 2, map),
                 new MapLocation(7, 2, map),
                 }

                 };

                MapLocation location = path.GetLocationAt(0);
                if (location != null)
                {
                    Console.WriteLine(location.X + ',' + location.Y);
                }


            }
            catch(Exception)
            {
                Console.WriteLine("That map location is not on the map");
            }
        }
    }
}
