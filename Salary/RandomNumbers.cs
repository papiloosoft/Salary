using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class RandomNumbers
    {
        public string rand(int min, int max)
        {
            Random rnd = new Random();
            return (rnd.Next(min, max)).ToString();
        }
    }
}
