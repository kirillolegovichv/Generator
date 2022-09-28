namespace RandGenerator
{
    public class MakeSequence
    {
        Random randomNumber = new Random();
        const int minCount = 20;
        const int maxCount = 100;
        const int minValue = -100;
        const int maxValue = 100;

        public MakeSequence()
        {

        }

        public int[] MakeRandomSequence()
        {
            int count = randomNumber.Next(minCount, maxCount);
            int[] generatedNumbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                generatedNumbers[i] = randomNumber.Next(minValue, maxValue);
            }

            return generatedNumbers;
        }

        public int RandomlyChooseOneOfTwo()
        {
            return randomNumber.Next(0, 2);
        }

        
    }
}
