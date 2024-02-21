using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje1.Classes
{
    public class Order : Guest
    {
        public List<string> FoodItems { get; set; }
        public float Price { get; set; }
    }
}
