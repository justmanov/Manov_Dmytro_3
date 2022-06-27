using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write your text: ");
            string myString = Console.ReadLine();
            Console.WriteLine(myString);
            List<string> list = new List<string>();

            string[] splittedStringArray = myString.Split(' ');

            foreach (string stringInArray in splittedStringArray)
            {
                list.Add(stringInArray);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            int range = list.Count;
            Console.WriteLine($"range of list:  { range} ");
            Console.Write("write element index: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"element : {n} ");
            Console.WriteLine($"element is : {list[n]} ");
            Console.WriteLine();
            Console.WriteLine("1 - left, 2 - right");
            int status1 = 1;
            while (status1 != 0)
            {
                char choose1 = Console.ReadKey(true).KeyChar;
                switch (choose1)
                {
                    case '1': 
                            for (int i = list.Count -1; i < list.Capacity; i--)
                            {
                                if (i<=n && i>=0)
                                {
                                    Console.WriteLine(list[i]);
                                }

                            }
                                
                       status1 = 0;
                        break;
                    case '2':
                            for (int i = 0; i < list.Count; i++)
                                if (i >= n)
                                {
                                    Console.WriteLine(list[i]);
                                }
                        status1 = 0;
                        break;
                    default: Console.WriteLine("You haven`t chosen correctly, try again"); break;
                }
            };
        }

    }
}