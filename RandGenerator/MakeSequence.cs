using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandGenerator
{
    public class MakeSequence
    {
        RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
        int minCount = 20;
        int maxCount = 100;
        int minValue = -100;
        int maxValue = 100;

        public MakeSequence()
        {

        }

        public int[] makeRandomSequence()
        {
            int count = randomNumberGenerator.Generate(minCount, maxCount);
            int[] generatedNumbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                generatedNumbers[i] = randomNumberGenerator.Generate(minValue, maxValue);
            }

            return generatedNumbers;
        }

        
    }
}
