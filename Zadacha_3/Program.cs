// программа, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// А (3,6); В (2,1) -> 5,09
// A (7,-5); B (1;-1) -> 7,21

double xa = 3;
double ya = 6;
double xb = 2;
double yb = 1;
double S = ((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb));  //теорема пифагора
S = Math.Sqrt(S);
System.Console.WriteLine("Расстояние между точками А и В равно");
System.Console.WriteLine(S);


