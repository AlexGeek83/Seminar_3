// программа, которая по заданному номеру четверти, показывает диапазон
// возможных точек координат в этой четверти (x и y)

//int plane1 = x > 0 to inf;
//int plane1 = x < 0 to -inf;
//int plane1 = y > 0 to inf;
//int plane1 = y < 0 to -inf;

Console.Clear();

System.Console.WriteLine("Введите № четверти");

string plane = Console.ReadLine();
int a = Convert.ToInt32(plane);
if(a == 1)
{
    System.Console.WriteLine("x положительный и y положительный");
}
if(a == 2)
{
    System.Console.WriteLine("x отрицательное и y положительный");
}
if(a == 3)
{
    System.Console.WriteLine("x отрицательное и y отрицательное");
}
if(a == 4)
{
    System.Console.WriteLine("x положительный и y отрицательное");
}