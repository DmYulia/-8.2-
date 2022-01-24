using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace файловая_система_1
{
    class Program
    {
        static void Main(string[] args)
        {
        Begin:
            Console.Write("Введите полное имя файла: C:\\");
            string username = "C:\\" + Console.ReadLine();
            Random x = new Random();
            try
            {
                using (StreamWriter sw = new StreamWriter(username, false, Encoding.Default))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        double q = x.Next(-1000, 1000);
                        sw.WriteLine(q);
                    }
                }
                double[] mas = new double[10];
                using (StreamReader sr = new StreamReader(username, Encoding.Default))
                {
                    double S = 0;
                    int i = 0;
                    while (i < 10)
                    {
                        S += Convert.ToDouble(sr.ReadLine());
                        i++;
                    }
                    Console.WriteLine($"Сумма чисел в файле = {S}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto Begin;
            }
            Console.ReadLine();
        }
    }
}
