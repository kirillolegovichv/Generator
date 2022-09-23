namespace RandGenerator
{
    public class RandomNumberGenerator
    {
        Random randomNumber = new Random();

        public RandomNumberGenerator()
        {

        }

        public int Generate(int minValue, int maxValue)
        {   
            return randomNumber.Next(minValue, maxValue);
        }
    }
}
