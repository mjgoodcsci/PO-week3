using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace PO_week3
{
    public class Smoothie
    {
        public string[] ingredient{get;set;}
        public double price{get;set;}

        public Smoothie(string[] ingredients)
        {
            ingredient = ingredients;
            price = 0;
            foreach(string s in ingredient)
            {
                if(s == "Strawberries")
                {
                    price += 1.5;
                }
                if(s == "Banana")
                {
                    price += 0.5;
                }
                if(s == "Mango")
                {
                    price += 2.5;
                }
                if(s == "Blueberries")
                {
                    price += 1.0;
                }
                if(s == "Raspberries")
                {
                    price += 1.0;
                }
                if(s == "Apple")
                {
                    price += 1.75;
                }
                if(s == "Pineapple")
                {
                    price += 3.5;
                }
            }
            
        }

        public double GetCost()
        {
            return price;
        }
        public double GetPrice()
        {
            double temp = Math.Round(price * 1.5, 2);
            return temp;
        }
        public string GetName()
        {
            string[] temp = ingredient;
            Array.Sort(temp);
            string name = "";
            foreach(string s in temp)
            {
                if(s == "Strawberries")
                {
                    name = name + "Strawberry ";
                }
                else if(s == "Blueberries")
                {
                    name = name + "Blueberry ";
                }
                else if(s == "Raspberries")
                {
                    name = name + "Raspberry ";
                }
                else{
                    name = name + s + " ";
                }
            }
            if(ingredient.Count() == 1)
            {
                name = name + "Smoothie";
            }
            else{
                name = name + "Fusion";
            }
            return name;
        }

    }
}