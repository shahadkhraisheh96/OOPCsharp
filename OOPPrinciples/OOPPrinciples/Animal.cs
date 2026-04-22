using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("this animal speak like this");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("this animal make sound like this");

        }

    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("the dog speak Woof Woof");
        }
        public override void MakeSound()
        {
            Console.WriteLine("the dog make sound Woof Woof");

        }

    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("the dog speak meow meow");
        }
        public override void MakeSound()
        {
            Console.WriteLine("the dog make sound meow meow");

        }
    }
}