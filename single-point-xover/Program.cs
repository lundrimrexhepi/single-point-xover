// See https://aka.ms/new-console-template for more information

var P1 = "1234552";

var P2 = "1111987";


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Generation " + i + " :");
    xover(P1, P2);
}

Console.ReadLine();

void xover (string p1, string p2)
{
    var rand = new Random();
    var randomPoint = rand.Next(0, Math.Max(P1.Length, P2.Length));

    Console.WriteLine("Crossover point is : " + randomPoint);

    var C1 = P1.Substring(0, randomPoint) + P2.Substring(randomPoint);

    var C2 = P2.Substring(0, randomPoint) + P1.Substring(randomPoint);

    Console.WriteLine(C1 + "\n");
    Console.WriteLine(C2 + "\n");
}
