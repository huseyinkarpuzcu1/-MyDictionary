using System;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mydictionary<string> dictionary = new Mydictionary<string>();
            dictionary.Add("Engin");


            foreach (var item in dictionary.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
