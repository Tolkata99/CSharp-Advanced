using System;
using System.Collections.Generic;
using System.Text;

namespace DataModificer
{
    public class DateModifier
    {

        public int DataBetween(string first,string second)
        {
            DateTime start = DateTime.Parse(first);
            DateTime end = DateTime.Parse(second);

            int totalDays = (int)(start - end).TotalDays;
            
            return Math.Abs(totalDays);
        }
    }
}
