using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meuInteiro = 10;
            double meuDouble =  5.25;
            bool meuBool = true;

            Console.WriteLine(Convert.ToString(meuInteiro));
            Console.WriteLine(Convert.ToDouble(meuInteiro));
            Console.WriteLine(Convert.ToInt32(meuDouble));
        }
    }
}