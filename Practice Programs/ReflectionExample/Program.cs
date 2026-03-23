using System;
using System.Reflection;
using RefletctionClassLibrary;
namespace ReflectionExample
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var obj = new Class1();
            Console.WriteLine(obj.sum(1,2));
            
            Console.WriteLine("All Public Fields");
            Type type = obj.GetType();
            foreach (MemberInfo memberInfo in type.GetFields())
            {
                Console.WriteLine(memberInfo.Name);
            }

            Console.WriteLine("\nAll Public Methods");
            foreach (MemberInfo memberInfo in type.GetMethods())
            {
                Console.WriteLine(memberInfo.Name);
            }
            Console.ReadLine();
        }
    }
}
