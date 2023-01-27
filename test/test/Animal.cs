using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Animal
    {
        public string name;
        public string breed;
        public string color;
        public int age;




        public Animal(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;

        }


        public virtual string GetVoice()
        {
            return $" ";


        }



    }
}
