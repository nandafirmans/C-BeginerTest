using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Class.ExtensionMethod
{
    public static class StringExtension
    {
        public static string Shorter(this String target, int cropedNumberLength)
        {
            if (cropedNumberLength < 0)
                throw new ArgumentOutOfRangeException("croppedNumberLength should be more than 0");

            if (cropedNumberLength == 0)
                return " ";

            var words = target.Split(' ');

            if (words.Length <= cropedNumberLength)
                return target;

            return string.Join(" ", words.Take(cropedNumberLength)) + "...";
        }
    }
}
