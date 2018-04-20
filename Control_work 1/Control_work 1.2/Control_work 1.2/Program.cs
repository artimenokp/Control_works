using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_work_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Str = 5; // Макс.кол-во строк
            int Stb = 5; // Макс. кол-во столбцов
            int[,] array = new int[Str, Stb];

            Console.WriteLine("Введите количество строк массива (не более 5):");
            Str = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов массива (не более 5):");
            Stb = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            for (int i = 0; i < Str; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < Stb; j++)
                {
                    array[i, j] = r.Next(0, 10);
                    Console.Write("{0,3}", array[i, j]);
                    
                }
            }
            Console.WriteLine();
            int KolNulStrok = 0;
            int KolNeNulStrok = 0;
            for (int i =0; i<Str; i++)
            {
                for (int j = 0; j < Stb; j++)
                {
                    if (array[i, j] == 0)
                    {
                        ++KolNulStrok;
                    }
                }
             if (KolNulStrok == 0)
                    {
                        ++KolNeNulStrok;
                    }
                    else
                    {
                        KolNulStrok = 0;
                    }
                   
                }
            
            Console.WriteLine();
            Console.WriteLine("Количество строк, не содержащих ни одного нулевого элемента:  {0}", KolNeNulStrok);
           

            Console.WriteLine();
            int MaxCh = 0;
            int ResaltMaxCh = 0;
            int KolPovtMaxCh = 0;
            for(int i = 0; i < Str; i++)
            {
                for (int j = 0; j<Stb; j++)
                {
                    if (array[i, j]==MaxCh)
                    {
                        KolPovtMaxCh++;
                    }
                    if (array[i, j] > MaxCh)
                    {
                        MaxCh = array[i, j];
                        KolPovtMaxCh = 1;
                    }

                }
                if (KolPovtMaxCh >= 2)
                {
                    ResaltMaxCh = MaxCh;
                }
            }

            Console.WriteLine("Максимальный элемент, встречающийся больше одного раза:  {0}", ResaltMaxCh);
            Console.ReadKey();
        }
    }
}
