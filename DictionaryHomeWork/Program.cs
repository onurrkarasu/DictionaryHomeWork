using System;

namespace DictionaryHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Customer = new MyDictionary<int, string>();
            Customer.Add(101, "Onur");
            Customer.Add(202, "Hasan");
            Customer.Add(303, "Metin");

            Console.WriteLine(Customer.Count);
            Console.WriteLine("--------------");
            foreach (var name in Customer.Values)
            {
                Console.WriteLine(name);
            }

        }
    }
}
