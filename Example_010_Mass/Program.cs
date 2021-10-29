int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//int a1 = 56;
//int b1 = 74;
//int c1 = 86;
//int a2 = 26;
//int b2 = 2432;
//int c2 = 23;
//int a3 = 5456;
//int b3 = 69;
//int c3 = 71;

//               0,  1,  2,  3,    4,  5,   6,   7,  8
int [] array = {56, 74, 86, 26, 2432, 23, 5456, 69, 71};

//array[2] = 12;
//Console.WriteLine(array[2]);

int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
);

//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));


Console.WriteLine(max);