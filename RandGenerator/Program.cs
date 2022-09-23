using RandGenerator;

MakeSequence makeSequence = new MakeSequence();
int[] vs = makeSequence.makeRandomSequence();

for (int j = 0; j < vs.Length - 1; j++)
{
    Console.Write($"{vs[j]} ");
}

Console.WriteLine();
Console.WriteLine($"{vs.Length}");


