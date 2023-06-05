using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execVerySoft
{
    public abstract class Animal
    {
        bool mammals;
        bool carnivorous;
        int mood;
        protected int MOOD_HAPPY = 0;
        protected int MOOD_SCARE = 1;
        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.mammals = mammals;
            this.carnivorous = carnivorous;
            this.mood = mood;
        }

        public virtual void sayHello()
        {
            // Default greeting
        }

        public virtual void sayHello(int mood)
        {
            // Greeting based on mood
        }

        bool isMammals()
        {
            return mammals;
        }

        void setMammals(bool mammals)
        {
            this.mammals = mammals;
        }

        bool isCarnivorous()
        {
            return carnivorous;
        }

        void setCarnivorous(bool carnivorous)
        {
            this.carnivorous = carnivorous;
        }
    }
}
