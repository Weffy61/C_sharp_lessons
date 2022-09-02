int Max(int arg_1, int arg_2, int arg_3)
{
    int result = arg_1;
    if(arg_2 > result) result = arg_2;
    if(arg_3 > result) result = arg_3;
    return result;
}



int[] array = {11, 21, 131, 41, 15, 61, 17, 81, 19};



int result = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));


Console.WriteLine(result);