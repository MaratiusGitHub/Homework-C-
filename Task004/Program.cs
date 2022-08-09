Console.WriteLine("Введите число больше единицы");
int N = Convert.ToInt32(Console.ReadLine());
int x = 2;
if (N > 1) 
{
    while (x <= N)
    {
        if (x % 2 == 0)
            Console.WriteLine(x);
        x++;
    }
} 
else
{
    Console.WriteLine("Число меньше единицы");
}