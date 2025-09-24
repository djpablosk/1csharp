Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Aha mas teda " + vek + " rokov.");

Console.WriteLine("Ake je tvoje oblubene jedlo");
 string food = Console.ReadLine();
Console.WriteLine("Tvoje oblubene jedlo je " + food);


