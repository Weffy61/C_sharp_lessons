int[] array = {11, 58, 21, 13, 4, 35, 61, 17, 58};


int n = array.Length;
int find = 58;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index += 1;
}