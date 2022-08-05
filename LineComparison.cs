using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonUsingObject
{
    public class LineComparison
    {
        /// <summary>
        /// Lengthes the of line.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        public void LengthOfLine(double x1, double y1, double x2, double y2)
        {
            double lengthOfLine;
            double lengthOfLine1;

            lengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a given Line is: " + lengthOfLine);
        }
           
    }
}