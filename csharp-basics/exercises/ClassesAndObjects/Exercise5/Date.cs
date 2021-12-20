using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Date
    {
        private int a_month { get; set; }
        private int a_day{ get; set; }
        private int a_year { get; set; }

        public Date( int day,int month,int year)
        {
            a_month = month;
            a_day = day;
            a_year = year;
        }

        public string DisplayDate()
        {
            return $"{a_month}/{a_day}/{a_year}";
        }
    }
}
