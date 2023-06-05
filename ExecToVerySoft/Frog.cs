using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execVerySoft
{
    public class Frog : Animal,Land, Water
    {
        int numberOfLegs;
        public Frog(bool m, bool c, int mood, int n) : base(m, c, mood) {
            this.numberOfLegs = n;
        }

        public void sayHello(int m)
        {
            if(m== base.MOOD_HAPPY)
            {
                Console.WriteLine("quack quack quack");
            }
            else
            {
                Console.WriteLine("plop into the water");
            }
        }
        public bool hasGills()
        {
            return true;
        }

        public bool hasLaysEggs()
        {
            return true;
        }

        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
