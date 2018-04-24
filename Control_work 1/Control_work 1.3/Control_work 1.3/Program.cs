using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_work_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку (не более 25 символов):");
            String Str = (Console.ReadLine());
            Str = Str.ToLower();
            Str = Str.Replace(" ", string.Empty);
            int D = Str.Length;
            int H = 0;
            Console.WriteLine();
            Console.WriteLine("Количество символов в строке: {0}", D);
            Console.WriteLine();
            char[] array = Str.ToCharArray();
            List<char> unicsymbols = new List<char>();
            for (int i=0; i <D; i++)
            {
                if (unicsymbols.Contains(array[i]))
                {
                    H++;
                    
                }
                else
                {
                    unicsymbols.Add(array[i]);
                    Console.WriteLine("Строка содержит уникальный символ: {0}",array[i]);
                    Console.WriteLine();
                }

            }
            Console.WriteLine("Общее число уникальных символов: {0}", unicsymbols.Count());
            Console.WriteLine();
            String result = String.Join(", ", unicsymbols);
            Console.WriteLine(result);

           
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
