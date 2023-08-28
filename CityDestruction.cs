using System;
using System.Collections.Generic;

class Program
{
    // A class to represent a building
    class Building
    {
        public long Health { get; set; } // The current health of the building
        public long ExplosionDamage { get; } // The explosion damage of the building

        // A constructor to initialize the fields
        public Building(long health, long explosionDamage)
        {
            Health = health;
            ExplosionDamage = explosionDamage;
        }
    }

    static void Main()
    {
        // Read the number of test cases
        int testCases = int.Parse(Console.ReadLine());

        // Loop through each test case
        for (int i = 0; i < testCases; i++)
        {
            // Read the number of buildings and the attack damage
            string[] input = Console.ReadLine().Split();
            int buildingsCount = int.Parse(input[0]);
            long attackDamage = long.Parse(input[1]);

            // Read the initial healths and explosion damages of the buildings
            input = Console.ReadLine().Split();
            long[] initialHealths = Array.ConvertAll(input, long.Parse);
            input = Console.ReadLine().Split();
            long[] explosionDamages = Array.ConvertAll(input, long.Parse);

            // Create a list of buildings and add a dummy building at the end
            List<Building> buildings = new List<Building>();
            for (int j = 0; j < buildingsCount; j++)
            {
                buildings.Add(new Building(initialHealths[j], explosionDamages[j]));
            }
            buildings.Add(new Building(0, 0));

            // Create a two-dimensional array to store the minimum number of moves for each building and each type
            long[,] minMoves = new long[buildingsCount + 1, 2];

            // Initialize the array with -1 values
            for (int j = 0; j <= buildingsCount; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    minMoves[j, k] = -1;
                }
            }

            // Print the minimum number of moves for this test case
            Console.WriteLine(GetMinMoves(0, 0, 0, minMoves, buildings, attackDamage));
        }
    }

    // A method to get the minimum number of moves needed to destroy the city from a given building and type
    public static long GetMinMoves(int id, int type, long explosion, long[,] minMoves, List<Building> buildings, long attackDamage)
    {
        // If the last building is reached, return 0
        if (id == buildings.Count - 1)
        {
            return 0;
        }

        // If the result is already computed, return it
        if (minMoves[id, type] > 0)
        {
            return minMoves[id, type];
        }

        // Calculate two possible moves: one that destroys the current building and causes explosion damage to the next one,
        // and one that destroys the current building without causing explosion damage.
        long moveWithExplosion = Math.Max(0, (buildings[id].Health - explosion + attackDamage - 1 - buildings[id + 1].ExplosionDamage) / attackDamage);
        long moveWithoutExplosion = Math.Max(0, (buildings[id].Health - explosion + attackDamage - 1) / attackDamage);

        // Choose the move that minimizes the total number of moves needed to destroy the city from the current building onwards.
        long minimum = Math.Min(moveWithExplosion + GetMinMoves(id + 1, 0, 0, minMoves, buildings, attackDamage),
                                moveWithoutExplosion + GetMinMoves(id + 1, 1, buildings[id].ExplosionDamage, minMoves, buildings, attackDamage));

        // Store and return the result
        minMoves[id, type] = minimum;
        return minimum;
    }
}
