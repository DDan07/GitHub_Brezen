Console.WriteLine("Zadej první číslo: ");
int cislo1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Zadej druhé číslo: ");
int cislo2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (cislo1 == cislo2) Console.WriteLine("Čísla jsou shodá");
else Console.WriteLine($"{Math.Max(cislo1, cislo2)} je větší než {Math.Min(cislo1, cislo2)}");