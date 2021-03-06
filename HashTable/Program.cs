﻿/******************************************************************************
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
            Console.WriteLine("Hello Welcome to HashTables.");            
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            ///Split method returns an array of strings generated by splitting of original string.
            string[] para = paragraph.Split(" ");
            ///Creating reference of MyMapNode.
            MyMapNode<int, string> hash = new MyMapNode<int, string>(para.Length);
            int key = 0;
            ///foreach iterates on paragraph and adds key and value to hash.
            foreach (string word in para)
            {
                hash.Add(key, word);
                key++;
            }
            Console.WriteLine("Frequency :" + hash.GetFrequency("avoidable"));
            hash.RemoveValue("avoidable");
            Console.WriteLine("Frequency :" + hash.GetFrequency("avoidable"));
        }
    }
}
