using System;
namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();            
            Console.WriteLine(new ChangeString().build(s));
            Console.ReadKey();
        }
    }
}
