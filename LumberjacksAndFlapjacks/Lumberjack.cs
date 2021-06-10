using System;
using System.Collections.Generic;
using System.Text;

namespace LumberjacksAndFlapjacks
{
    class Lumberjack
    {
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();              // Here's the stack of Flapjack enums. It gets filled up when the Main method calls the TakeFlapjack()-method with random flapjacks, and drained when it calls the EatFlapjacks()-method. 

        public string Name { get; private set; }

        public Lumberjack(string name)
        {
            this.Name = name;
        }

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);                                           // The TakeFlapjack()-method pushes the randomized flapjack onto the stack.
        }

        public void EatFlapjacks()                                                                          // This method is called upon with a Lumberjack reference variable. So it's called once by every object created. 
        {
            Console.WriteLine($"{Name} is eating flapjacks");                                               // That specific objects Name-field gets printed. 

            while (flapjackStack.Count > 0)                                                                 // The loop iterates as many times as the amount of flapjacks in this specific objects flapjackStack-Stack. 
            {
                Console.WriteLine($"{Name} ate a {flapjackStack.Pop().ToString().ToLower()} flapjack");     // For every flapjack in the Stack, this line gets printed. We Pop() the printed flapjack at the same time as we print it. 
            }
        }
    }
}
