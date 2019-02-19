using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
   public class Expenses
    {
        //public Expenses(string v, object p1, object p2)
        //{
        //}

        public string Name { get; set; }
        public decimal Cost { get; set; }
        public DateTime IncurredDate { get; set; }

        public override string ToString()
        {
            return $"{Name} {Cost} on {IncurredDate.ToShortDateString()}";
        }
    }
}
