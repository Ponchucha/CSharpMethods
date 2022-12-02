// Нахождение максимума из 9 чисел с использованием функции (метода)
int a = 23;
int b = 98;
int c = 54;
int d = 32;
int e = 22;
int f = 4545;
int g = 9;
int h = 75;
int i = 78;


int max (int arg1, int arg2, int arg3)
{
int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}

/*    int max1 = max (a, b, c);
    Console.WriteLine($"max1 = {max1}");

    int max2 = max (d, e, f);
    Console.WriteLine($"max2 = {max2}");

    int max3 = max (g, h , i);
    Console.WriteLine($"max3 = {max3}");

    int maximum = max (max1, max2, max3);
    Console.WriteLine($"maximum = {maximum}");
*/
int maximum = max (max(a, b, c), max (d, e, f), max (g, h, i));
Console.WriteLine (maximum);


