using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> phones = new MyDictionary<int, string>();
            phones.Add(2222, "Nokia");
            phones.Add(1010, "Samsung");
            phones.Add(2255, "LG");
            phones.Add(2580, "Apple");
            phones.Add(1357, "Sony");

            phones.Show();

        }
    }
}

