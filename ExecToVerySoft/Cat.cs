using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execVerySoft
{
    public class Cat : Animal, Land
    {
        int numberOfLegs;
        public Cat(bool m, bool c, int mood, int n) : base(m, c, mood)
        {
            this.numberOfLegs = n;
        }
        public override void sayHello()
        {
            Console.WriteLine("meow~");
        }

        public override void sayHello(int mood)
        {
            if (mood == base.MOOD_HAPPY)
            {
                Console.WriteLine("meow~");
            }
            else
                Console.WriteLine("purr, purr");
        }

        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
