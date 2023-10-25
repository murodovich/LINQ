using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    public class HomeTask23_10
    {
        public static void Run()
        {
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


            // Task 13

            //List<string> liststr = new List<string>();
            //string tempList = string.Empty;

            //Console.Write("Nechta kiritmoqchisiz: ");
            //int n13 = int.Parse(Console.ReadLine()!);

            //for (int i = 0; i < n13; i++)
            //{
            //    Console.Write("Element[{0}]: ", i);
            //    liststr.Add(Console.ReadLine()!);

            //    //tempList += i == n - 1 ? liststr[i] : liststr[i] + ", ";
            //}

            //var result = String.Join(", ", liststr
            //    .Select(x => x.ToString())
            //    .ToArray());

            //Console.WriteLine(tempList);


            // Task 14

            //Student student = new Student();

            //Console.Write("Nechinchi o'rinni topmoqchisiz: ");
            //int point = int.Parse(Console.ReadLine()!);

            //var students = student.GetAllStudents();

            //var result14 = (from x in students
            //                group x by x.GrPoint into g
            //                orderby g.Key descending
            //                select new
            //                {
            //                    StudentRecord = g.ToList()
            //                }).ToList();

            //result14[point - 1].StudentRecord
            //    .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}",
            //    i.StuId, i.StuName, i.GrPoint));


            // Task 15
            //string[] str = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf",
            //                "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            //var result15 = str.Select(x => Path.GetExtension(x).TrimStart('.').ToLower())
            //.GroupBy(y => y, (fExt, extCtr) => new
            //{
            //    Extension = fExt,
            //    Count = extCtr.Count(),
            //});

            //foreach (var item in result15)
            //{
            //    Console.WriteLine("{0} file: Extension: [{1}]", item.Count, item.Extension);
            //}


            // Task 17
            //List<string> list= new List<string>() { "a", "q", "o", "a", "f", "s" };
            //list.ForEach(x => Console.Write(x + " "));

            //Console.Write("\n\nQaysi harfni o'chirib tashlamoqchisiz: ");
            //string nstr = Console.ReadLine()!;

            //var result17 = list.FirstOrDefault(y => y == nstr);
            //list.Remove(result17!);

            //list.ForEach(x => Console.Write(x + " "));


            // Task 18

            //List<string> lists = new List<string>() { "c", "a", "f", "e", "w", "s" };

            //lists.ForEach(x => Console.Write(x + " "));

            //Console.Write("\n\nQaysi harfni o'chirib tashlamoqchisiz: ");
            //string nstr18 = Console.ReadLine()!;

            //lists.Remove(lists.FirstOrDefault(x => x == nstr18)!);

            //lists.ForEach(x => Console.Write(x + " "));


            // Task 19

            //List<string> list1 = new List<string>() { "c", "a", "f", "e", "w", "s" };

            //list1.ForEach(x => Console.Write(x + " "));

            //Console.Write("\n\nQaysi harfni o'chirib tashlamoqchisiz: ");
            //string nstr19 = Console.ReadLine()!;

            //list1.RemoveAll(x => x == nstr19);

            //list1.ForEach(x => Console.Write(x + " "));

            // Task 20
            //List<string> list2 = new List<string>() { "c", "a", "f", "e", "w", "s" };

            //list2.ForEach(x => Console.Write(x + " "));

            //Console.Write("\n\nQaysi indexni o'chirib tashlamoqchisiz: ");
            //int nstr20 = int.Parse(Console.ReadLine()!);

            //list2.RemoveAt(nstr20!);

            //list2.ForEach(x => Console.Write(x + " "));



            // Task 21

            //List<string> list = new List<string>() {"a","v","s","f","r","q"};

            //var result = from str in list
            //             select str;

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            // Task 23

            //char[] chars = { 'X', 'Y', 'Z' };
            //int[] ints = { 1, 2, 3, 4};

            //var result   = from charss in chars
            //               from i in ints
            //               select new {charss, i};

            //foreach ( var i in ints ) 
            //{
            //    Console.WriteLine(i.ToString());            
            //}


            // Task 24
            /*
            char[] set1 = { 'X', 'Y', 'Z' };
            int[] set2 = { 1, 2, 3 };
            string[] set3 = { "Green", "Pink" };


            var set12CartesianProduct = set1.SelectMany(
                letterList => set2.Select(numList =>
                new { letterList, numList }));

            var cartesianProduct = set12CartesianProduct.SelectMany(
                (set1and2) => set3.Select(colorList =>
                new { set1and2.letterList, set1and2.numList, colorList }));

            foreach (var ProductList in cartesianProduct)
            {
                Console.WriteLine(ProductList);
            }
            */


            // Task 28
            /*
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            IEnumerable<string> cityOrder =
            cities.OrderBy(str => str.Length)
                            .ThenBy(str => str);
            foreach (string city in cityOrder)
                Console.WriteLine(city);

            */


            // Task 29


            /*
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };
            var citySplit = from i in Enumerable.Range(0, cities.Length)
                            group cities[i] by i / 3;

            foreach (var city in citySplit)
                cityView(string.Join(";  ", city.ToArray()));

            static void cityView(string cityMetro)
            {
                Console.WriteLine(cityMetro);
                Console.WriteLine("-- here is a group of cities --\n");
            }*/


            // Task 30

            var nimadur  = (from c  in Student.GetAllStudents()
                           select c.FirstName).Distinct().OrderBy(x => x);

            foreach (var student in nimadur)
            {
                Console.WriteLine(student);
            }
            



        }
    }
}
