using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2 //Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\Task02.txt";
            Random rand = new Random();
            using (StreamWriter sw = new StreamWriter(path, false)) //создание файла 
            
                for (int i = 0; i < 10; i++)    //создание чисел
                {
                    sw.WriteLine(rand.Next(1,10));
                }
                
            
            int result = 0;
            using (StreamReader sr = new StreamReader(path)) //открытие файла
                for (int i = 0; i < 10; i++)//получение суммы
                {
                result += Convert.ToInt32(sr.ReadLine()); 
                }
            Console.WriteLine(result);
            Console.ReadKey();
                      

        }
    }
}
