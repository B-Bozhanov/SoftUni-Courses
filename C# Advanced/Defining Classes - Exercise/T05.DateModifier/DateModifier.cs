using System;
using System.Collections.Generic;
using System.Text;

namespace T05.DateModifier
{
    public static class DateModifier
    {

        public static int DateDiference(string data1, string data2)
        {
            var date1 = DateTime.Parse(data1); 
            var date2 = DateTime.Parse(data2);
            var result = Math.Abs((date1 - date2).Days);
            return result;
        }
    }
}
