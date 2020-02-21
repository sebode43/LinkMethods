using System;
using System.Linq;

namespace LinkMethods {
    class Program {
        static void Main(string[] args) {
            int[] nbrs2 = {
                3524,    7436,    7815,    8881,    4972,    4964,
                5662,    1106,    7676,    1806,    4933,    5317,
                1557,    9323,    4655,    4389,    2562,    8428,
                1925,    1884,    8738,    9403,    5531,    7826,
                3641,    4690,    8722,    1221,    8818,    3267,
                6533,    9993,    3986,    4129,    5338,    8112,
                5077,    8951,    2729,    2115,    3995,    1948,
                2134,    3439,    7144,    4724,    5282,    3323,
                6405,    2733
            };

            var total = nbrs2.Sum();
            Console.WriteLine(total);

            var total3 = nbrs2.Where(nbrs2 => nbrs2 % 3 == 0).Sum();
            Console.WriteLine($"Numbers divided by 3 = {total3}");


        }
    }
}
