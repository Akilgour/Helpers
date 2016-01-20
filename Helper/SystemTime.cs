using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class SystemTime
    {
        private static DateTime datetime;

        public static void Reset()
        {
            datetime = DateTime.MinValue;
        }

        public static DateTime Now
        {
            get
            {
                return new DateTime(1983, 8, 27);
            }

        }

        public static void Set(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
