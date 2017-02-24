using System;

namespace CSPlayground
{
    public class StringFormatDemo
    {
        static public void ShowFloatNumber()
        {
            double a = 2.0;
            double b = 3.5;
            Console.WriteLine(a);          // 2
            Console.WriteLine("{0:F}",a);  // 2.000
            Console.WriteLine("{0:F1}",a); // 2.0
            Console.WriteLine("{0:F2}",a); // 2.0
            Console.WriteLine("{0,5:F1} {1, 5:F2}",a, b);  // arg0, right align, float
            Console.WriteLine("{0,-5:F1}",a); // arg0, left align, float
        }
    }
}