// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
//Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
//является ли он прямоугольным, равнобедренным, равносторонним.

void Triangle (double A, double B, double C)
{
if (A < B + C && B < A + C && C < A + B) 
{
    Console.WriteLine ($"Да, {A}, {B} и {C} являются сторонами треугольника.");

    if ( A == B || B == C || C == A) Console.WriteLine ("Это равнобедренный треугольник");

    if ( A == B && A == C) Console.WriteLine ("Это равносторонний треугольник");

    double P = A + B + C;
    Console.WriteLine ($"Периметр треугольника равен {P}");

    double S = Math.Sqrt (P/2 * (P/2 -A) * (P/2 -B) * (P/2 -C));
    Console.WriteLine ($"Площадь треугольника равна {S}");

    double ugAB = Math.Acos((A*A + B*B - C*C) / (2*A*B)) * 180 / Math.PI;
    Console.WriteLine ($"Угол между сторонами А и В равен {ugAB}°");

    double ugCB = Math.Acos((C*C + B*B - A*A) / (2*C*B)) * 180 / Math.PI;
    Console.WriteLine ($"Угол между сторонами C и В равен {ugCB}°");

    double ugAC = Math.Acos((A*A + C*C - B*B) / (2*A*C)) * 180 / Math.PI;
    Console.WriteLine ($"Угол между сторонами А и В равен {ugAC}°");

    if (ugAB == 90 || ugCB == 90 || ugAC == 90) Console.WriteLine("Это прямоугольный треугольник");
}
else Console.WriteLine("Это не треугольник");
}
Triangle(5 , 4, 3);
