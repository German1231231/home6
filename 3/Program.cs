Random rand = new Random();
int a = rand.Next(2, 10);

void RandomArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1, 10);
    }
}

int[] array = new int [a];
RandomArray(array);

int sum = 0;

for(int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
{
    int multiplication = array[i] * array[j];
    sum = sum + multiplication;
}

Console.Write("[{0}]", string.Join(", ", array));
Console.WriteLine($" --> {sum}");