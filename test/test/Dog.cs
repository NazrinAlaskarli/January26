using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Dog : Animal
    {




        public Dog(string name, string breed, string color, int age) : base(name, breed, age, color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;

        }


        public override string GetVoice()
        {
            return "hav";

        }
    }
}
