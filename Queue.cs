// C# program to illustrate queue
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



            foreach (var ele in numbers)
            {
                Console.WriteLine(ele);
            }
        }
    }

}