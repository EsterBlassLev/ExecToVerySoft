using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execVerySoft
{
    public class Dog : Animal ,Land
    {
        int numberOfLegs;
        public Dog(bool m, bool c, int mood, int n) : base(m, c, mood) {
            this.numberOfLegs = n;
        }
        public override void sayHello()
        {
            Console.WriteLine("wagging their tails");
        }

        public override void sayHello(int mood)
        {
            if(mood==0)
            {
                Console.WriteLine("wagging their tails");
            }
            else
                Console.WriteLine("whooping");
        }

        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
