// Расстояние между двумя точками в 3D пространстве.

Console.WriteLine("Введите координаты точки А");
Console.WriteLine("X:");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("Y:");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Z:");
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.WriteLine("X:");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("Y:");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("Z:");
int bz = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(ax-bx,2)+Math.Pow(ay-by,2)+Math.Pow(az-bz,2));

Console.WriteLine(Math.Round(result,2));