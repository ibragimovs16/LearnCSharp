using System.Collections;

namespace LearnCSharp.ExtensionMethod
{
    public static class Helper
    {
        public static bool IsEven(this int x) =>
            x % 2 == 0;

        public static bool IsDividedBy(this int x, int y) =>
            x % y == 0;
    }
}