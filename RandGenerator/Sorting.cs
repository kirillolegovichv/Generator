namespace RandGenerator
{
    public class Sorting
    {
        public void InsertionSort(int[] inputArray)
        {
            int x;
            int j;
            for (int i = 1; i < inputArray.Length; i++)
            {
                x = inputArray[i];
                j = i;
                while (j > 0 && inputArray[j - 1] > x)
                {
                    Swap(inputArray, j, j - 1);
                    j -= 1;
                }
                inputArray[j] = x;
            }
        }

        public int[] MergeSort(int[] inputArray)
        {
            if (inputArray.Length == 1)
                return inputArray;
            int mid_point = inputArray.Length / 2;
            return Merge(MergeSort(inputArray.Take(mid_point).ToArray()), MergeSort(inputArray.Skip(mid_point).ToArray()));
        }

        private int[] Merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b] && b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
                else
                    if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
