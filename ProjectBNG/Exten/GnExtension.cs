using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBNG.Exten
{
    public static class GnExtension
    {
        public static List<T> Clone<T>(this List<T> list)
        {
            List<T> newList;
            newList = list.Select(m=>m).ToList();
            return newList;
        }

    }
}
