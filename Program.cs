using System;
using System.Runtime.Intrinsics.Arm;

namespace PO_week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Smoothie s1 = new Smoothie(new string[]{"Banana"});
            Console.WriteLine(String.Format("{0:C}", s1.GetCost()));
            Console.WriteLine(String.Format("{0:C}", s1.GetPrice()));
            Console.WriteLine(s1.GetName());

            Smoothie s2 = new Smoothie(new string[]{"Raspberries", "Strawberries", "Blueberries"});
            Console.WriteLine(String.Format("{0:C}", s2.GetCost()));
            Console.WriteLine(String.Format("{0:C}", s2.GetPrice()));
            Console.WriteLine(s2.GetName());
        }
    }
}
