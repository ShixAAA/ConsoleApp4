using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double H, z, s, R, a; //объяление переменных
            //Присваивание значения переменных
            a = 2;
            R = 3;
            //Вычисление промежуточных результатов
            s = Math.PI * Math.Pow(R, 2);
            H = 2 * a;
            //Вычисление результата
            z = Math.PI * R * H + s;
            Console.WriteLine("z={0:##.####}",z);//Округление числа до тысячных
            Console.ReadKey();

        }
    }
}
