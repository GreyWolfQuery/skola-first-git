Console.Write("Zadej hausnumero:");
string input = Console.ReadLine();
int len = input.Length, i;

int[] digits = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

for (i = 0; i < len; ++i)
{
    if (input[i] >= '0' && input[i] <= '9')
    {
        digits[input[i] - '0']++;
    }
}

for (i = 0; i < 10; ++i)
    Console.WriteLine($"Číslice {i} je tam {digits[i]}x");
