using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP
{
    public class Animals
    {

        public virtual void eat()
        {
            Console.WriteLine("This animal is eating");
        }
    }


    public class Dogs : Animals
    {
        public void Bark()
        {
            Console.WriteLine("This dog is barking");
        }

    }

    public class Cats: Animals
    {
        public override void eat()
        {
            Console.WriteLine("Eating Meoooooow");
        }
    }
}
