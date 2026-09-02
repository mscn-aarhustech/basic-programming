int alder = 15;

string aldersgruppe;
decimal billetpris;

if (alder >= 0 && alder <= 12)
{
    aldersgruppe = "Barn";
    billetpris = 60.00m;
}
else if (alder >= 13 && alder <= 66)
{
    aldersgruppe = "Voksen";
    billetpris = 120.00m;
}
else
{
    aldersgruppe = "Pensionist";
    billetpris = 75.00m;
}

Console.WriteLine("================================");
Console.WriteLine("       BILLETPRISBEREGNER       ");
Console.WriteLine("================================");
Console.WriteLine($"Alder: {alder} år");
Console.WriteLine($"Aldersgruppe: {aldersgruppe}");
Console.WriteLine($"Billetpris: {billetpris:N2} kr.");
Console.WriteLine("================================");

