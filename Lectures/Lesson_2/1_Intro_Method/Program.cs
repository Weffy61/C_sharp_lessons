int Max(int arg_1, int arg_2, int arg_3)
{
    int result = arg_1;
    if(arg_2 > result) result = arg_2;
    if(arg_3 > result) result = arg_3;
    return result;
}


int a1 = 115;
int b1 = 22431;
int c1 = 39;
int a2 = 1232;
int b2 = 231;
int c2 = 31131111;
int a3 = 13;
int b3 = 23;
int c3 = 313;

// int max_1 = Max(a1, b1, c1);
// int max_2 = Max(a2, b2, c2);
// int max_3 = Max(a3, b3, c3);
// int max = Max(max_1, max_2, max_3);

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);