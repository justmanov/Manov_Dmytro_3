using System;
using System.Linq;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arrayOfDictionaries = new Dictionary<int, string>[]
             {
                new Dictionary<int, string>() { {2, "eqweqw"} },
                new Dictionary<int, string>() { {1, "dasda"} },
                new Dictionary<int, string>() { {1, "fdsfd"} },
                new Dictionary<int, string>() { {2, "czxczxczxc"} },
                new Dictionary<int, string>() { {2, "fdsfds"} },
                new Dictionary<int, string>() { {4, "hfghfgh"} },
             };
            foreach (var pair in arrayOfDictionaries)
            {
                foreach(var person in pair)
                {
                    Console.WriteLine($"key: {person.Key}  value: {person.Value}");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("write element index: ");


            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"element : {n} ");
            var vals = arrayOfDictionaries.Where(d => d.ContainsKey(n)).Select(d => d[n]);
            int i=0;
            foreach (var val in arrayOfDictionaries)
            {
                
                if (val.Keys.Contains(n))
                {
                    i++;
                    Console.WriteLine($"Values {val[n]} ");
                }
               
            }
            Console.WriteLine($"Count {i}");
        }
    }
 }