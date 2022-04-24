// Программа, которая принимает на вход координаты точкт (X Y), причем X не равен 0 ,Y не равен 0
// и выдает номер четверти плоскости в которой находится эта точка.

int x, y;
x = -2;
y = 2;

if (x > 0)
{
    if (y > 0)
    {
        System.Console.WriteLine("1-я четверть");
    }
    else 
        System.Console.WriteLine("4-я четверть");
}
else 
    if (y > 0)
    {
        System.Console.WriteLine("2-я четверть");
    }
    else 
        System.Console.WriteLine("3-я четверть");

        //================================
        // 2-й вариант с помощью функции

//        void PrintPlane(double x, double y);
//        if (x > 0)
//{
//    if (y > 0)
//    {
//        System.Console.WriteLine("1-я четверть");
//    }
//    else 
//        System.Console.WriteLine("4-я четверть");
//}
//else 
//    if (y > 0)
//    {
//        System.Console.WriteLine("2-я четверть");
//    }
//    else 
//        System.Console.WriteLine("3-я четверть");
//        void Main (string[] args)
//        {
//            PrintPlane(10, 12);
//            PrintPlane(-10, 12);
//            PrintPlane(-10, -12);
//            PrintPlane(10, -12);
 //       }


