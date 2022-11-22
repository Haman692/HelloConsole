int[] array = { 1, 12, 3, 422, 82, 51, 6, 37, 82 };

int n = array.Length;
int find = 82;
int index = 0;
while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}