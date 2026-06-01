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
            foreach(var item in select)
            {
                foreach(var item2 in item)
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

          Console.ReadLine();
        }
    }
}
