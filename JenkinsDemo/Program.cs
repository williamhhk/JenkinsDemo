using System;
using SimpleInjector;
using System.Linq;

namespace JenkinsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = Enumerable.Range(1, 10).Select((int i) => i * i);
            Console.WriteLine("This is a test");
        }
    }
}
