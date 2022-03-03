using System;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Work1 ckr = new Work1();
            ckr.SampleMethod();
            Work1.StaticMethod();
        }
    }
}
