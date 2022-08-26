using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Mutluhan", "Yılmaz", "Avcı", "Defne", "Fatoş" };
            List<string> names2 = new List<string> { "Mutluhan", "Yılmaz", "Avcı", "Defne", "Fatoş" };
            names2.Add("Özlem");
            for (int i = 0; i < names2.ToArray().Length; i++)
            {
                Console.WriteLine(names2[i]);
            }
            

        }
    }
}
