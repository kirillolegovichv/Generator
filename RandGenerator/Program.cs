using RandGenerator;

MakeSequence makeSequence = new MakeSequence();
Sorting srt = new Sorting();
Printing prnt = new Printing();
int[] generatedSeries = makeSequence.MakeRandomSequence();

prnt.printArray(generatedSeries);

switch (makeSequence.RandomlyChooseOneOfTwo())
{
    case 0: 
        srt.InsertionSort(generatedSeries);
        break;
    case 1:
        generatedSeries = srt.MergeSort(generatedSeries);
        break;
}

prnt.printArray(generatedSeries);