using System.Xml.Serialization;
int p, g;
Console.WriteLine("Informe o valor de P:");
p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de G:");
g = Convert.ToInt32(Console.ReadLine());

Random r = new Random();
int alice = r.Next(1, p - 1);
int bob = r.Next(1, p - 1);
Console.WriteLine($"Numero escolhido por Alice:{alice}\nNumero escolhido por Bob:{bob}");

int chaveA = Convert.ToInt32(Math.Pow(g, alice) % p);
int chaveB = Convert.ToInt32(Math.Pow(g, bob) % p);
Console.WriteLine($"Alice enviou A = {chaveA} para Bob\nBob envivou B = {chaveB} para Alice");

int kAlice = Convert.ToInt32(Math.Pow(chaveB,alice) % p);
int kBob = Convert.ToInt32(Math.Pow(chaveA,bob) % p);

Console.WriteLine($"Alice encontrou K = {kAlice}\nBob encontrou K = {kBob}");