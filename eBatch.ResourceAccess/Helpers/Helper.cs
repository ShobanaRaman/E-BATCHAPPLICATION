using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.ResourceAccess
{
    public static class Helper
    {
        public static string FirstCol<T>(this T item)
        {
            var firstparam= item.GetType().GetProperties().FirstOrDefault().Name;
            return firstparam;
        }

    }
}
