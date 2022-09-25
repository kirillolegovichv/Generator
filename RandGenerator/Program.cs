using RandGenerator;

MakeSequence makeSequence = new MakeSequence();
Sorting srt = new Sorting();
Printing prnt = new Printing();
int[] generatedSeries = makeSequence.MakeRandomSequence();

prnt.printArray(generatedSeries);

Console.WriteLine();
Console.WriteLine($"{generatedSeries.Length}");

int[] copyGeneratedSeries = new int[generatedSeries.Length];
for (int k = 0; k < generatedSeries.Length; k++)
{
    copyGeneratedSeries[k] = generatedSeries[k];
}

srt.InsertionSort(generatedSeries);

prnt.printArray(generatedSeries);

Console.WriteLine();

copyGeneratedSeries = srt.MergeSort(copyGeneratedSeries);

prnt.printArray(copyGeneratedSeries);
