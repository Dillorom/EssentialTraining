using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class SampleArray
    {
        public string[] GroceryList;

        public SampleArray()
        {
            GroceryList = new string[4] { "Milk", "Tomatoes", "Bread", "Butter" };
        }

        public override string ToString()
        {
            return "There are + GroceryList.Length + items, and they are + GroceryList.ToString()";
        }
    }
}
