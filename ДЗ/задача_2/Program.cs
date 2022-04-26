// Программа, которая принимает на вход координаты 2-х точек и находит
// расстояние между ними в 3D пространстве
// А(3,6,8); В(2,1,-7), -> 15.84
// А(7,-5,0); В(1,-1,9), -> 11.53

Console.WriteLine("Hello");

double xa = 7;
double ya = -5;
double za = 0;
double xb = 1;
double yb = -1;
double zb = 9;

double S = ((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));  //теорема пифагора
S = Math.Sqrt(S);
System.Console.Write("Расстояние между точками А и В равно = ");
System.Console.WriteLine(S);


