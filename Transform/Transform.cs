using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public delegate int doubling(int x);
    public static class Transform 
    {
        public static int[] Map(this int[] a1,doubling expression)
        {
            
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i]=expression(a1[i]);
            }
            return a1;
        }
    }
}
