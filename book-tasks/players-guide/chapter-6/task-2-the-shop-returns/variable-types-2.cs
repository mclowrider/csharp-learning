byte q = 32;
sbyte w = -10;
short e = 30_000;
ushort r = 40_000;
int t = 2_000_000_000;
uint y = 4_000_000_000;
long u = 9_000_000_000_000_000_000L;
ulong i = 18_000_000_000_000_000_000UL;
float o = 3.4e37f;
double p = 1.7e300;
decimal z = 7.9e28m;
char x = 'x';
string c = "text";
bool v = true;

Console.WriteLine("These are the initial values of listed variables:" + "\nbyte: " + q +
"\nsbyte: " + w + "\nshort: " + e + "\nushort: " + r + "\nint: " + t + "\nuint: " + y 
+ "\nlong: " + u + "\nulong: " + i + "\nfloat: " + o + "\ndouble: " + p + "\ndecimal: "
+ z + "\nchar: " + x + "\nstring: " + c + "\nbool: " + v);

q = 32-4;
w = -10+2;
e = 30_001;
r = 39_999;
t = 2_000_000_000-123;
y = 4_000_256_256;
u = 8_000_000_000_000_000_000L;
i = 16_666_666_666_666_666_666UL;
o = 3e36f;
p = 1.6e199;
z = 7.9e28m;
x = '1';
c = "1255";
v = false;

Console.WriteLine("\nPress Enter to see an updated list of values ");
Console.ReadLine();

Console.WriteLine("These are the updated values of listed variables:" + "\nbyte: " + q +
"\nsbyte: " + w + "\nshort: " + e + "\nushort: " + r + "\nint: " + t + "\nuint: " + y 
+ "\nlong: " + u + "\nulong: " + i + "\nfloat: " + o + "\ndouble: " + p + "\ndecimal: "
+ z + "\nchar: " + x + "\nstring: " + c + "\nbool: " + v);

int convertedC = Convert.ToInt32(c);

Console.WriteLine("\nConverted 'text' to int: " + convertedC);