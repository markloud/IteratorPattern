using IteratorPattern.Aggregate;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Iterator.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Iterator Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            IAggregate<string> aggregate = new ConcreteAggregate<string>();

            aggregate.AddItem("Apple");    //add sample data
            aggregate.AddItem("Orange");
            aggregate.AddItem("Banana");
            aggregate.AddItem("Plum");

            //iterate through the collection using IAggregate only
            foreach (string i in aggregate.GetAll())
                Console.WriteLine(i);
            // Wait for user
            Console.ReadKey();
        }
    }

}