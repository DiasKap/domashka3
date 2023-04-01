Console.WriteLine("Число: ");
int num = int.Parse(Console.ReadLine());
for (int i=1; i < num + 1; i++)
{
    if(i!=num)
{
    Console.Write(Math.Pow(i,3)+ " ");
        }
    else
    {
        
    Console.Write(Math.Pow(i,3)+ " ");
    }

}