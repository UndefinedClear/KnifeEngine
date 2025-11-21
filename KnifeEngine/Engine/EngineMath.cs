using System;

namespace KnifeEngine.Engine
{
    public static class EngineMath
    {
        //  "корень из (x2 - x1)^2 + (y2 - y1)^2";

        /// <summary>
        /// Counting Distance between coordinates using Pythagorean Theorem
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns>double</returns>
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            // Counting first brackets
            double first_brackets = x2 - x1;

            // Raising with specific power (^2)
            double pow_x = Math.Pow(first_brackets, 2);

            // Counting second brackets
            double second_brackets = y2 - y1;

            // Raising with specific power (^2)
            double pow_y = Math.Pow(second_brackets, 2);

            // Adddition pow_x and pow_y
            double pre_final = pow_x + pow_y;

            // Counting final Square root of the pre_final
            double final = Math.Sqrt(pre_final);

            // Returning distance
            final = Math.Round(final, 2); // -> to 10.15
            return final;
        }


    }
}
