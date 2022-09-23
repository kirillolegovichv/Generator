using RandGenerator;

MakeSequence makeSequence = new MakeSequence();
int[] generatedSeries = makeSequence.makeRandomSequence();

for (int j = 0; j < generatedSeries.Length - 1; j++)
{
    Console.Write($"{generatedSeries[j]} ");
}

Console.WriteLine();
Console.WriteLine($"{generatedSeries.Length}");


