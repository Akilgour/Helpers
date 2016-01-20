using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class NullGuard
    {
        public static void Check(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Object reference not set to an instance of an object.");
            }
        }
    }
}
