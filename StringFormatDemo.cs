using System;

namespace CSPlayground
{
    public class StringFormatDeom
    {
        static public void ShowFloatNumber()
        {
            double a = 2.0;
            double b = 3.5;
            Console.WriteLine(a);
            Console.WriteLine("{0:F}",a);
            Console.WriteLine("{0:F1}",a);
            Console.WriteLine("{0,5:F1}",a);  // arg0, right align, float
            Console.WriteLine("{0,-5:F1}",a); // arg0, left align, float
        }
    }
}