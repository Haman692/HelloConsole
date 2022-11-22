int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 14;
int b1 = 5433;
int c1 = 33;
int a2 = 76;
int b2 = 3;
int c2 = 65;
int a3 = 96;
int b3 = 68;
int c3 = 411;

int max1 = max(a1, b1, c1);
int max2 = max(a2, b2, c2);
int max3 = max(a3, b3, c3);
int bigMax = max(max1, max2,max3);
Console.WriteLine(bigMax);