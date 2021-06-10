using System;
using System.Collections.Generic;

namespace LumberjacksAndFlapjacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();                                                   // This random gets used in the while loop below, where we give the Lumberjack-objects a random set of flapjacks. 

            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();                        // The Main()-method keeps its Lumberjack references in a queue. 

            string name;

            Console.Write("First lumberjack's name: ");                                     // We ask the user to input the lumberjacks name. 
            while ((name = Console.ReadLine()) != "")                                       // This loop will iterate as long as the user types anything.  (If the user just presses Enter, the program exits). 
            {
                Console.Write("Number of flapjacks: ");                                     // Inside the loop we ask the user to input the amount of flapjacks the Lumberjack-object should have.
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Lumberjack lumberjack = new Lumberjack(name);                           // If the user enters a valid number, a new Lumberjack-object is created and that objects Name-field is set with the input from the user. 
                    for (int i = 0; i < number; i++)                                        // This loop iterates as many times as the amount of flapjacks the object has (specified by the user above).
                    {
                        lumberjack.TakeFlapjack((Flapjack)random.Next(0, 4));               // For every iteration of the loop, this specific Lumberjack-objects TakeFlapjack()-method is called. The argument is randomized between the four enum-values in the Flapjack-enum. 
                    }
                    lumberjacks.Enqueue(lumberjack);                                        // After all of the randomized flapjacks have been added to the lumberjack-object it enqueues that reference (The lumberjack-reference gets added to the lumberjacks-Queue). 
                }
                Console.Write("Next lumberjack's name (blank to end): ");                   // The user then gets the option to add another Lumberjack-object to the lumberjacks-Queue. (In that case the while loop iterates another time). 
            }

            while (lumberjacks.Count > 0)                                                   // When the user is done with adding Lumberjacks to the Queue (the user have pressed Enter), a while loop iterates thru all of the lumberjacks in the lumberjacks-queue. 
            {
                Lumberjack next = lumberjacks.Dequeue();                                    // The lumberjack object then gets Dequeued from the lumberjacks-queue, one after the other. It instead gets copied to a Lumberjack-class reference variable. 
                next.EatFlapjacks();                                                        // That reference variable then gets used to call on the current objects EatFlapjacks()-method in the Lumberjack-class. 
            }
        }
    }
}
