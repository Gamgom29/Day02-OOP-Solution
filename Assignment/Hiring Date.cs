using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int Day , int Month , int Year) 
        { 
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
            
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
