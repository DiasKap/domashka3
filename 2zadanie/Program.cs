Console.Write("Enter X-coordinate A: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Enter Y-coordinate A: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Enter C-coordinate A: ");
double c1 = double.Parse(Console.ReadLine());
Console.Write("Enter X-coordinate B: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Enter Y-coordinate B: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Enter Y-coordinate B: ");
double c2 = double.Parse(Console.ReadLine());

Console.Write(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((c1-c2),2)));