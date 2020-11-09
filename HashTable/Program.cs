/******************************************************************************
 *  Purpose: Implement Hash map using linked list and perform operations on it 
 *  using key value pair.
 *
 *
 *  @author  Chetan Rote
 *  @version 1.0
 *  @since   09-11-2020
 ******************************************************************************/
using System;

namespace HashTable
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Hashmap.");
            ///Creating reference of MyMapNode.
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);

            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            hash.GetFrequency("To");

            string wordOne = hash.Get("5");
            Console.WriteLine("5th index value is: " + wordOne);
            string wordTwo = hash.Get("2");
            Console.WriteLine("2nd index value is: " + wordTwo);

        }
    }
}
