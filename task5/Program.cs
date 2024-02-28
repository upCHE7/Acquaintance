int a = 77;
int b = 5;
int c = 3;
int d = 47;
int e = 4;

int max = a;
if (b > max)
{
    max = b;
}
else max = a;

if (c > max)
{
    max = c;
}
else max = a;

if (d > max)
{
    max = d;
}
else max = a;
if (e > max)
{
    max = e;
}
else max = a;

Console.WriteLine(max);