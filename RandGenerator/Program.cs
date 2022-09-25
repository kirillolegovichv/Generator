using RandGenerator;

MakeSequence makeSequence = new MakeSequence();
Sorting srt = new Sorting();
Printing prnt = new Printing();
int[] generatedSeries = makeSequence.MakeRandomSequence();
string nameOfSort = "";

prnt.printArray(generatedSeries);

Console.WriteLine();
Console.WriteLine($"{generatedSeries.Length}");

int[] copyGeneratedSeries = new int[generatedSeries.Length];
for (int k = 0; k < generatedSeries.Length; k++)
{
    copyGeneratedSeries[k] = generatedSeries[k];
}


switch (makeSequence.RandomlyChooseOneOfTwo())
{
    case 0: 
        srt.InsertionSort(generatedSeries);
        nameOfSort = "Insertion sort";
        break;
    case 1:
        generatedSeries = srt.MergeSort(generatedSeries);
        nameOfSort = "Merge sort";
        break;
}

prnt.printArray(generatedSeries);
Console.WriteLine(nameOfSort);