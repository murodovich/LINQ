namespace LINQ
{
    internal class Queries
    {
        public static void Run()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> query = (from x in numbers
                               select x).Where(x => x % 2 == 0).ToList();
            foreach (int x in query)
            {
                Console.WriteLine(x);
            }
        }
    }
}
