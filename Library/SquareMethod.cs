using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class SquareMethod
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">первый аргумент</param>
        /// <param name="b">второй аргумент</param>
        /// <param name="c">третий аргумент</param>
        /// <returns></returns>
        public static string ResultSqrt (double a, double b, double c)
        {
            if (a == 0)
            {
                return "Проверьте введенные значения,а не может быть равно нулю";
            }
           
            var d = (b * b) - 4 * a * c;

            if (d < 0)
            {
                return "Корней нет";
            }

            if (d == 0)
            {
                var i = -b / (2 * a);
                return $"Ответ:{i}" ;
            }

            {
                var x1 = (-b + Math.Sqrt(d)) / (2 * a);
                var x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return $"Ответ: x1 = {x1}, x2 = {x2}";
            }
        }
    }
}
