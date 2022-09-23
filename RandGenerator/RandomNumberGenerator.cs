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

        public int GenerateCount()
        {
            return randomNumber.Next(20, 100);
        }

        public int GenerateOne()
        {
            return randomNumber.Next(-100, 100);
        }


    }
}
