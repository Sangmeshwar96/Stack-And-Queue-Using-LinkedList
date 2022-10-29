using System;
using System.Collections;

namespace StackUsingLinkedList
{
    class StactAndQueue
    {


        static public void Main()
        {

            Stack numbers = new Stack();


            numbers.Push(70);
            numbers.Push(30);
            numbers.Push(56);
           


            foreach (var elem in numbers)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
