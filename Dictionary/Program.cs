// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

class Program
{
    public enum ResourceType
    {
        Stone,
        Wood,
        Gold
    }
    public static void Main(string[] args)
    {
        // Defining dictionary 
        Dictionary<ResourceType, int> ResourceTypeCapacity = new Dictionary<ResourceType, int>();

        // Defining DIctionary with Custom Pairs
        Dictionary<ResourceType, int> ResourceTypeCapacity2 = new Dictionary<ResourceType, int>
        {
            {ResourceType.Wood, 10},
            {ResourceType.Gold, 30},
            {ResourceType.Stone, 50}
        };


        // Add Pairs
        ResourceTypeCapacity[ResourceType.Stone] = 20;
        ResourceTypeCapacity[ResourceType.Wood] = 30;
        ResourceTypeCapacity.Add(ResourceType.Gold, 40);

        // Remove Pairs
        ResourceTypeCapacity.Remove(ResourceType.Gold);
        // Looping over dictionary
        foreach (KeyValuePair<ResourceType, int> resources in ResourceTypeCapacity)
        {
            Console.WriteLine(resources.Key + " : " + resources.Value);
        }

        // Check if key exists
        if (ResourceTypeCapacity.ContainsKey(ResourceType.Gold))
        {
            Console.WriteLine("Wood resource exists with capacity: " + ResourceTypeCapacity[ResourceType.Wood]);
        }
        else
        {
            Console.WriteLine("Wood resource does not exist");
        }
    }
}