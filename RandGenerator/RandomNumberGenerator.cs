using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandGenerator
{
    public class RandomNumberGenerator
    {
        Random randomNumber = new Random();

        public RandomNumberGenerator()
        {

        }

        public int GenerateOne()
        {
            int value = randomNumber.Next();
            return value;
        }
    }
}
