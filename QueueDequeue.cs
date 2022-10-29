
using System;
using System.Collections;

namespace QueueUsingLinkedlist
{
    class StactAndQueue
    {
        static public void Main()
        {


            Queue numbers = new Queue();


            numbers.Enqueue(56);
            numbers.Enqueue(30);
            numbers.Enqueue(70);

            Console.WriteLine("Total elements present in queue: " + numbers.Count);

            numbers.Dequeue();

            
            Console.WriteLine("Total elements present in queue: " + numbers.Count);



            //numbers.Clear();

            
            //Console.WriteLine("Total elements present in queue: " + numbers.Count);




            foreach (var ele in numbers)
            {
                Console.WriteLine(ele);
            }
        }
    }

}