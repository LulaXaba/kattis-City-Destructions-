using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Read the number of buildings
        int n = int.Parse(Console.ReadLine());

        // Read the heights of the buildings
        string[] heights = Console.ReadLine().Split();
        int[] h = new int[n];
        for (int i = 0; i < n; i++)
        {
            h[i] = int.Parse(heights[i]);
        }

        // Read the durabilities of the buildings
        string[] durabilities = Console.ReadLine().Split();
        int[] d = new int[n];
        for (int i = 0; i < n; i++)
        {
            d[i] = int.Parse(durabilities[i]);
        }

        // Create a list to store the indices of the buildings to destroy
        List<int> destroy = new List<int>();

        // Create a variable to store the total height of the remaining buildings
        int remainingHeight = 0;

        // Create a variable to store the height of the last destroyed building
        int lastDestroyedHeight = 0;

        // Loop through the buildings from right to left
        for (int i = n - 1; i >= 0; i--)
        {
            // Check if the current building can be destroyed by the laser beam
            if (d[i] <= lastDestroyedHeight)
            {
                // Add the index of the current building to the list
                destroy.Add(i + 1);

                // Update the height of the last destroyed building
                lastDestroyedHeight = h[i];
            }
            else
            {
                // Add the height of the current building to the total height of the remaining buildings
                remainingHeight += h[i];
            }
        }

        // Reverse the list to get the indices in increasing order
        destroy.Reverse();

        // Print the number of buildings to destroy and their indices
        Console.WriteLine(destroy.Count);
        Console.WriteLine(string.Join(" ", destroy));

        // Print the total height of the remaining buildings
        Console.WriteLine(remainingHeight);
    }
}
