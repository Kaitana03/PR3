using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PR3
{
    public class Lib_9
    {
        public int[,] Func_Input(in int n, in int m)
        {
            int[,] mas = new int[0,0];
            try
            {

                Random rnd = new Random();
                mas = new int[n, m];

                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        int a = rnd.Next(1, 10);
                        mas[i, j] = a;
                    }
                }
                return mas;
            }
            catch (Exception e) 
            {
                MessageBox.Show($"Произошла ошибка.\nКод ошибки{e}");
                return mas;
            }
        }
        
        public void Func_Calc(in int[,] mas, out string maxel)
        {
            maxel = "";
            int max = mas[0, 0];
            
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                        
                    }
                }
                maxel += $"{max} ";
                max = 0;
            }
        }
    }
}
