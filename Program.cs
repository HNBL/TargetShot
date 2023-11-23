

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shootingTime
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество выстрелов:\t");
            int shoot = int.Parse(Console.ReadLine());
            int point = 0;
            for (int i = 0; i < shoot; i++)
            {
                Console.Write($"Введите координаты х и y {i + 1} выстрела в следующих строках:\n");
                int x = int.Parse(Console.ReadLine()); int y = int.Parse(Console.ReadLine());
                if (Math.Abs(x) <= 1 && Math.Abs(y) <= 1) point = point + 10;
                else if (Math.Abs(x) <= 2 && Math.Abs(y) <= 2) point = point + 5;
            }
            Console.WriteLine("Your result is " + point);
        }
    }
}



//using System;
//using System.Drawing;


//class TargetShot
//{
//    static int Points(int a)

//    {

//        switch (a)
//        {
//            case -1: Console.WriteLine("10 очков "); return 10;

//            case 1: return 10;

//            case 2: return 5;

//            case -2: return 5;

//            default:

//                return 0;

//        }

//    }
//    static void Main(string[] args)
//    {


//        Console.WriteLine("Введи координаты стрельбы ");

//        int x = Convert.ToInt32(Console.ReadLine());
//        int y = Convert.ToInt32(Console.ReadLine());






//        Console.WriteLine("Координаты x {0} \n Координа y {1}",x ,y);



//    } 

//}

