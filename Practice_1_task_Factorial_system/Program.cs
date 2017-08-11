using System;
using System.IO;


namespace Practice_1_task_Factorial_system
{
    public class Program
    {
        private static void Main()
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            string[] s = sr.ReadLine().Split();
            int p = int.Parse(s[0]);//числитель
            int q = int.Parse(s[1]);//знаменатель
            int n = 1;//количество значащих разрядов плюс 1, основание системы
            int[] a = new int[1000];//массив, в котором будут храниться ai (разряды числа в факториальной системе)
            while (p > 0)//выполняем перевод из десятичной системы в факториальную так же, как и в другую позиционную СИ, меняя только ее основание (2, 3, 4...)
                //пока дробь (т.е. ее числитель) не станет равна 0
            {
                n = n + 1;//вычисляем новое основание
                p = n * p;//умножаем дробь (числитель) на новое основание
                a[n]= p / q;//ищем целую часть, записываем ее в массив
                p = p % q;//избавляемся от целой части
            }
            sw.WriteLine(n);//выводим количество значащих разрядов плюс 1
            for (int i = 2; i <= n; i++)
            {
                sw.WriteLine(a[i]);
            }
            sr.Close();
            sw.Close();
        }
    }
}
