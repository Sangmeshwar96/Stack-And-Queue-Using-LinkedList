using System;
using System.Collections;
using System.Collections.Generic;

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

            Console.WriteLine("Number of elements in the Stack: " + numbers.Count);

            Console.Write("Top element of Stack is: ");
            Console.Write(numbers.Pop());


            Console.WriteLine("\nNumber of elements in the Stack: " + numbers.Count);



            foreach (var elem in numbers)
            {
                Console.WriteLine(elem);
            }
        }
    }
}