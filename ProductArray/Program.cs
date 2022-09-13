using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProductArray(new int[] { 3, 27, 4, 2 }));
            Console.ReadKey();
        }

        public static int[] ProductArray(int[] array)
        {
            List<int> list = new List<int>();
            foreach (int item in array)
            {
                int res = 1;
                foreach (int b in array)
                {
                    res *= b;
                }
                list.Add(res / item);
            }
            return list.ToArray();
        }

        public static int[] ProductArray1(int[] array)
        {
            var product = array.Aggregate((x, y) => x * y);
            return array.Select(x => product / x).ToArray();
        }

        public static int[] ProductArray2(int[] array)
        {
            return array.Select(i => array.Aggregate((x, y) => x * y) / i).ToArray();
        }
    }
}
