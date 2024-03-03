using System;

namespace _11_Object
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.14159265358979323846243383279m;
            object c = true;
            object d = "안녕하세요.";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
