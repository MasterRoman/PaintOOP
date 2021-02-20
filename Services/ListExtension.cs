using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintOOP.Services
{
    public static class ListExt 
    {
        public static void undo<T>(this List<T> list)
        {
            if (list.Count!=0)
                list.RemoveAt(list.Count - 1);
          
        }

        public static void redo<T>(this List<T> list)
        {
            
        }

    }
}
