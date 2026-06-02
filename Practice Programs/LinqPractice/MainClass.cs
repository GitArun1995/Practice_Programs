using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class MainClass
    {
        public static void Main(string[] args)
        {

            SelectAndSelectMany();
            Console.WriteLine();
            WhereExample();
            Console.WriteLine();
            OfTypeExample();
            Console.WriteLine();
            setOperatorsExample();
            Console.ReadLine();
        }

        public static void SelectAndSelectMany()
        {
            List<Department> d = new List<Department>
          {
              new Department
              {
                  Name = "HR",
                  Employees = new List<string>{"Arun", "Kumar" }
              },
              new Department
              {
                  Name ="IT",
                  Employees = new List<string> {"Jhon","Leo" }
              }
          };

            var select = d.Select(x => x.Employees);
            foreach (var item in select)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
            Console.WriteLine();
            var selectMany = d.SelectMany(x => x.Employees);
            foreach(var item in selectMany)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in d)
            {
                Console.Write(item.Name + " -> ");
                Console.WriteLine(string.Join(",", item.Employees));
            }
        }

        public static void WhereExample()
        {
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var newList = numList.Where(x => x % 2 == 0 & x > 10);
            foreach (int item in newList)
            {
                Console.WriteLine(item);
            }
        }

        public static void OfTypeExample()
        {
            List<object> items = new List<object> { 1, 2, "Arun", "Jhon", 4, 5, "Leo", 6, "Jhon", 7, 8, 9, "George" };
            var filteredList = items.OfType<string>();
            var filteredList2 = items.OfType<int>();
            foreach (var item in filteredList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in filteredList2)
            {
                Console.WriteLine(item);
            }
        }

        public static void setOperatorsExample()
        {
            int[] numbers1 = { 1, 2, 3, 3, 4, 5 };
            //int[] numbers2 = { 1, 2, 3, 3, 4, 5 };
            int[] numbers2 = { 4, 5, 6, 7, 8, 9 };
            var res = numbers1.Distinct();
            Console.WriteLine($"Distinct { string.Join(",", res)}");
            var UnionList = numbers1.Union(numbers2);
            Console.WriteLine($"Union {string.Join(",",UnionList)}");
            var IntersectList = numbers1.Intersect(numbers2);
            Console.WriteLine($"Intersect {string.Join(",", IntersectList)}");
            var exceptList = numbers1.Except(numbers2);
            Console.WriteLine($"Except {string.Join(",", exceptList)}");
            var concatenateList = numbers1.Concat(numbers2);
            Console.WriteLine($"Concat: {string.Join(",", concatenateList)}");
            var areEqualList = numbers1.SequenceEqual(numbers2);
            Console.WriteLine(areEqualList);
        }
    }
}
