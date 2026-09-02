string produktNavn = "Trådløst tastatur";

decimal prisEksklMoms = 799.00m;
decimal momsSats = 0.25m;

decimal momsBeloeb = prisEksklMoms * momsSats;
decimal prisInklMoms = prisEksklMoms + momsBeloeb;

Console.WriteLine("================================");
Console.WriteLine("          PRISBEREGNER"          );
Console.WriteLine("================================");
Console.WriteLine($"Produkt: {produktNavn}");
Console.WriteLine($"Pris ekskl. moms: {prisEksklMoms:N2} kr.");
Console.WriteLine($"Moms: {momsBeloeb:N2} kr.");
Console.WriteLine($"Pris inkl. moms: {prisInklMoms:N2} kr.");
Console.WriteLine("================================");

