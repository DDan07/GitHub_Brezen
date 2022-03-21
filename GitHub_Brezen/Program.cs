Console.WriteLine("Zadej první číslo: ");
int cislo1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Zadej druhé číslo: ");
int cislo2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine($"{Math.Max(cislo1, cislo2)}, {Math.Min(cislo1, cislo2)}");