using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class HomeTask22_10
    {
        public static void Main()
        {
            // Task 1
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 12, 14, 15, 35, 46,212,31,14,41,12,74,35 };

            //List<int> evenNumbers = numbers.Where(number => number % 2 == 0).ToList();
            //evenNumbers.ForEach(number => Console.Write(number + " "));
            //Console.WriteLine();

            //List<int> evenNumbers_ = (from number in numbers where number % 2 == 0 select number).ToList();
            //evenNumbers_.ForEach(number => Console.Write(number + " "));


            //Task 2
            //List<int> numbers = new List<int> { 1, 2, 3, -1, -4, -12, 13, 14, 15, 30, -123 };

            //List<int> result = numbers.Where(number => number > 0).ToList();
            //result.ForEach(number => Console.WriteLine(number + " "));


            //Task 3
            //List<int> numbers = new List<int> { 1, 2, 3, -1, -4, -12, 13, 14, 15, 30, -123 };

            //List<int> result = numbers.Select(number => number * number).ToList();
            //result.ForEach(number => { Console.WriteLine(number + " "); });

            // Task 4
            //List<int> numbers = new List<int>() { 1, 2, 3, 1, 2, 3, 4, 6, 2, 4, 1, 4, 4, 5, 6, 2, 4 };

            //var result = numbers.GroupBy(x => x).ToList();
            //result.ForEach(numberGroup => Console.WriteLine($"{numberGroup.Key}: {numberGroup.Count()} "));


            // Task 5
            //string str = Console.ReadLine();
            //var result = str.GroupBy(x => x);
            //foreach (var x in result)
            //{
            //    Console.WriteLine("Character {0}: {1} times", x.Key, x.Count());
            //}

            // Task 6

            //string[] str = { "Sunday", "Monday", "Tuesday","Wednesday", "Thursday", "Friday", "Saturday" };

            //var query = from x in str
            //            select x;
            //foreach ( var x in query )
            //{
            //    Console.WriteLine( x );
            //}

            //Task 7

            //int[] nums = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            //var sum = from x in nums
            //          group x by x into y
            //          select y;

            //foreach (var x in sum)
            //{
            //    Console.WriteLine($"Son: {x.Key} Yigindi: {x.Sum() } sanogi: {x.Count()}");
            //}


            // Task 8

            //string[] str = { "ROME", "LONDON", "NAIROBI",
            //    "CALIFORNIA", "ZURICH", "NEW DELHI",
            //    "AMSTERDAM", "ABU DHABI", "PARIS" };
            //Console.WriteLine("sozni bosh harfini kiriting: ");
            //string str1 = Console.ReadLine().ToUpper();
            //Console.WriteLine("sozning oxirgi harfini kiriting: ");
            //string str2 = Console.ReadLine().ToUpper();

            //var str3 = from str4 in str
            //           where str4.StartsWith(str1) && str4.EndsWith(str2)
            //           select str4;

            //foreach (var item in str3)
            //{
            //    Console.WriteLine(item);
            //}

            // Task 9 

            //List<int> list = new List<int>() { 55, 200 ,740 ,76 ,230, 482,95 };   

            //var son = from x in list
            //          where x >80
            //          select x;

            //foreach (var x in son)
            //{
            //    Console.WriteLine(x);
            //}


            // Task 10

            //List<int> list = new List<int>() { 10,20,30,40,50,60};

            //int son1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //var son = from x in list
            //          where x > son1
            //          select x;

            //foreach (int x in son) 
            //{                
            //    Console.WriteLine(x);
            //}

            // Task 11


            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

            //var son  = from x in list
            //           where x%3 == 0
            //           select x;

            //foreach (var x in son)
            //{
            //    Console.WriteLine(x);
            //}

            // Task 12

            //string text = "Input the string : this IS a STRING";
            //var texts = text.Split(' ');
            //var result = texts.Where(x => String.Equals(x, x.ToUpper()));

            //foreach ( var t in result )
            //{
            //    Console.WriteLine(t);
            //}







        }
    }
}
