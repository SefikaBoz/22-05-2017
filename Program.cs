# 22-05-2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            List myList = new List();
            myList.Add(3);
           

            int value = (int)myList[0];
            Console.WriteLine(value);

           

            Console.ReadLine();
        }
    }
}
