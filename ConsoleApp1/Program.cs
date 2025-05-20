// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj pierwsza liczbe");
string a = Console.ReadLine();
Console.WriteLine("Podaj druga liczbe");
string b = Console.ReadLine();
Console.WriteLine("Podaj trzecia liczbe");
string c = Console.ReadLine();

if (int.TryParse(a, out int a1) && int.TryParse(b, out int b1) && int.TryParse(c, out  int c1))
{
    
    int[] liczby = { a1, b1, c1 };
    Array.Sort(liczby);
    if (liczby[0] * liczby[0] + liczby[1] * liczby[1] == liczby[2] * liczby[2])
    {
        Console.WriteLine("Liczby tworza trojke pitagorejska");
    }
    else
    {
        Console.WriteLine("Liczby nie tworza trojki pitagorejskiej");
    }

}
else
{
    Console.WriteLine("Podano zle liczby");
    return;
}
