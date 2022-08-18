using System;
using System.Collections.Generic;
using System.Text;

namespace StaticAndExtension.Extensions
{
    static class ExtensionsMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 0)
                return false;
            return true;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }

        public static bool IsContainsDigit(this string str)
        {
            foreach (char item in str)
            {
                if (item > 47 && item < 58)
                    return true;
            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Char.ToUpper(str[0]));
            sb.Append(str.Substring(1).ToLower());
            return sb.ToString();
        }

        public static int[] GetValueIndexes(this string str, char ch)
        {
            int[] Arr = new int[0];                 // daha düzgün forma üçün List-lər istifadə etmək yaxşı olar
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    Array.Resize<int>(ref Arr, Arr.Length + 1);
                    Arr[Arr.Length - 1] = i;
                }
            }

            return Arr;
        }
    }
}
