using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        delegate void Test(string x);

        static void Main(string[] args)
        {
            Test t;
            t = testApp;
            t += testApp2;
            t += testApp3;

            t("hello");

            Console.ReadLine();
        }

        // static testApp(string)
        static void testApp(string x)
        {
            Console.WriteLine(x);
        }

        static void testApp2(string s)
        {
            Console.WriteLine("New method " + s);
        }

        static void testApp3(string s)
        {
            Console.WriteLine("New method 2: " + s);
        }
    }
}
