 // -- CODE RUNNER BELOW --
//onecompiler.com/csharp/

using System;

namespace ArrayCollection
{
    public class CollectionHandler
    {
        public int[] Numbers { get; set; } = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public string[] Strings { get; set; } = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        public void SumNumberCollection()
        {
            int sum = SumCollection(Numbers);
            Console.WriteLine($"Sum of Numbers collection: {sum}");
        }

        public void SumStringCollection()
        {
            int sum = SumCollection(Strings);
            Console.WriteLine($"Sum of Strings collection: {sum}");
        }

        public void SummAllCollection()
        {
            int totalSum = SumCollection(Numbers) + SumCollection(Strings);
            Console.WriteLine($"Sum of all collections: {totalSum}");
        }

        private int SumCollection(int[] collection)
        {
            int sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }

        private int SumCollection(string[] collection)
        {
            int sum = 0;
            foreach (var item in collection)
            {
                sum += int.Parse(item);
            }
            return sum;
        }
    }

    class Program
    {
        static void Main()
        {
            var collectionHandler = new CollectionHandler();
            collectionHandler.SumNumberCollection();
            collectionHandler.SumStringCollection();
            collectionHandler.SummAllCollection();
        }
    }
}
