using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithm
{
    /// <summary>
    /// 1、	一列数的规则如下: 1、1、2、3、5、8、13、21、34...... ，用.net开发平台编写程序求第30位数是多少?
    /// </summary>
    public class Algorithmsort
    {

        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;

            for (int i = 3; i <= n; i++)
            {
                b = checked(a + b);
                a = b - a;
            }
            return b;
        }



        public static string sort(string n)
        {
           string b = Regex.Replace(n, "(?s)(.)(?=.*\\1)", "");
            List<char> list = b.ToList<char>();
            list.Sort();
            b = new string(list.ToArray());
            return b;
        }

    }
}
