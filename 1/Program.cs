List<int> numbers = new List<int>();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < m; i++) 
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
    if(numbers[i] > 0)
    {
        count++;
    }
}
Console.Write("[{0}]", string.Join(", ", numbers));
Console.WriteLine($" --> {count}");
