using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class SystemTime
    {
        private static DateTime dateTime;

        public static void Set(DateTime custom)
        {
            dateTime = custom;
        }

        public static void Reset()
        {
            dateTime = DateTime.MinValue;
        }

        public static DateTime Now
        {
            get
            {
                if (dateTime != DateTime.MinValue)
                {
                    return dateTime;
                }
                return DateTime.Now;
            }
        }


    }
}
