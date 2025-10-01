Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();



int a = 55;
int b = 35;
int sum = a + b;
int minus = a - b;
int multiply = a * b;
int remainder = a % b;
int divide = a / b;
bool vecsie = a > b;
bool rovnake = a == b;
bool vecsieRovnake = a >= b;
bool mensieRovnake = a <= b;
decimal division = a / (decimal)b;

Console.WriteLine($"Suma {a} a {b} je {sum}");
Console.WriteLine($"Rozdiel {a} a {b} je {minus}");
Console.WriteLine($"Nasobok {a} a {b} je {multiply}");
Console.WriteLine($"Zostatok po deleni {a} a {b} je {remainder}");
Console.WriteLine($"Podiel {a} a {b} je {divide}");
Console.WriteLine($"{a} je vacsie ako {b} : {vecsie}");
Console.WriteLine($"{a} je rovnake ako {b} : {rovnake}");
Console.WriteLine($"{a} je vacsie alebo rovnake ako {b} : {vecsieRovnake}");
Console.WriteLine(division);

