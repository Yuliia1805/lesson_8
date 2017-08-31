using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n = 5;
            int[][] pT = new int[n][];

            for ( int i = 0; i < n; i++)
            {
                pT[i] = new int[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    if(j == 0 | j == 1)
                    {
                        pT[i][j] = 1;
                    }
                    else
                    {
                        pT[i][j] = pT[i-1][j-1] + pT[i-1][j];
                    }
                }
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write(pT[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();*/

            /*int[] mas= { 10, 30, 0, 4, 6, 8, 2, 4, 6 };

            int min = 0;
            int max = 0;
            max = mas[0];
            min = mas[0];
            for(int i = 1; i < mas.Length; i++)
            {
                if(mas[i] < min)
                {
                    min = mas[i];
                }
                if(mas[i] > max)
                {
                    max = mas[i];
                }
            }
            Console.WriteLine("min = {0}, max = {1} ", min, max);

            /*for(int i = 1; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }*/
            /*foreach (int element in mas)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            //sorting
                for(int j = 0; j < mas.Length; j++)
            {
                int k = j;
                min = mas[j];
                for (int i = 1; i < mas.Length; i++)
                {
                    if(mas[i] < min)
                    {
                        min = mas[i];
                        k = i;
                    }
                }
                int a;
                a = mas[j];
                mas[j] = mas[k];
                mas[k] = a;
            }*/


            

            Console.ReadLine();
        }
    }
}
