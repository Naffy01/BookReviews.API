using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviews.ConsoleApp
{
    public static class Teacher
    {
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public static string ToTitle(string value, bool isFemale)
        {
            if (isFemale)
            {
                return $"Mrs. {value}";
            }
            return $"Mr. {value}";
        }

        public static string ToTitleExtensionMethod(this string value, bool isFemale)
        {
            if (isFemale)
            {
                return $"Mrs. {value}";
            }
            return $"Mr. {value}";
        }
    }
}
