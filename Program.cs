namespace Week11Assignment11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            Console.WriteLine("Part 1");
            int[] prices1 = { 7, 1, 5, 3, 6, 4 };
            int[] prices2 = { 7, 6, 4, 3, 1 };

            Console.WriteLine("\nPrice Sample 1:");
            Console.WriteLine(string.Join(", ", prices1));
            Console.WriteLine($"Max Profit: {MaxProfit(prices1)}");

            Console.WriteLine("\nPrice Sample 2:");
            Console.WriteLine(string.Join(", ", prices2));
            Console.WriteLine($"Max Profit: {MaxProfit(prices2)}");
            #endregion

            #region Part 2
            Console.WriteLine("\nPart 2");

            LinkedList list1 = new LinkedList();
            list1.AddFirst(1);
            list1.AddLast(2);
            list1.AddLast(3);
            list1.AddLast(4);
            list1.AddLast(5);

            Console.WriteLine("\nList as provided:");
            list1.Display();
            Console.WriteLine("\nList reversed:");
            list1.Reverse();
            list1.Display(); 
            #endregion
        }

        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            if (prices.Length == 0) //Edge case for if array is empty
            {
                return maxProfit;
            }

            int minPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                int potentialProfit = prices[i] - minPrice; //calculates potential profit for selling at indexed day

                if (potentialProfit > maxProfit) //updates if new max profit is found
                {
                    maxProfit = potentialProfit;
                }

                if (prices[i] < minPrice) //sets current lowest buy price (regardless of profit margin)
                {
                    minPrice = prices[i];
                }
            }

            return maxProfit;
        }
    }
}
