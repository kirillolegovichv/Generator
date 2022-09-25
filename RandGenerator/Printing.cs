namespace RandGenerator
{
    public class Printing
    {
        public void printArray(int[] currentArray)
        {
            for (int j = 0; j < currentArray.Length - 1; j++)
            {
                Console.Write($"{currentArray[j]} ");
            }
        }
    }
}
