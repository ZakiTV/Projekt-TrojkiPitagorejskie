using System.Globalization;

Console.WriteLine("Wpisz 1 liczbe");
string number1 = Console.ReadLine();
Console.WriteLine("Wpisz 2 liczbe");
string number2 = Console.ReadLine();
Console.WriteLine("Wpisz 3 liczbe");
string number3 = Console.ReadLine();

int num1;
int num2;
int num3;

bool TryParse(string? input, out int result)
{
    return int.TryParse(input, out result);
}

if (TryParse(number1, out num1) && TryParse(number2, out num2) && TryParse(number3, out num3))
{
    int[] numbers = { num1, num2, num3 };
    Array.Sort(numbers);

    bool isPythagorean = IsPythagorean(num1, num2, num3);
    bool IsPythagorean(int a, int b, int c)
    {
        if(a*a + b * b == c * c)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    if (isPythagorean)
    {
        Console.WriteLine("To jest trojka pitagorejska");
    }
    else
    {
        Console.WriteLine("To nie jest trojka pitagorejska");
    }
}
else
{
    Console.WriteLine("Niepoprawny format liczby");
}