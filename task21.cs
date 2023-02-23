/**/

Console.WriteLine("first point:");

Console.WriteLine("write X:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("write Y:");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("write Z:");
int z1 = int.Parse(Console.ReadLine());


Console.WriteLine("second point:");

Console.WriteLine("write X:");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("write Y:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("write Z:");
int z2 = int.Parse(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
Console.WriteLine(distance);
