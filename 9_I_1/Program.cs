using System;
using System.IO;
namespace _9_I_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите заданную букву: ");
            char a = char.Parse(Console.ReadLine());
            int k = 0;

            foreach (String s in File.ReadAllLines(@"C:\Users\vasbe\Desktop\test.txt"))
            {
                if (s != null && s.Length > 0 && s[0] == a)
                    k++;
            }

            Console.WriteLine("Кол-во строк= " + k);
            Console.ReadKey();
        }
    }
}
