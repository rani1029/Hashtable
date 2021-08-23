﻿using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to hashtable ");
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(5);

            //Add data
            myMapNode.Add("0", "To");
            myMapNode.Add("1", "be");
            myMapNode.Add("2", "To");
            myMapNode.Add("3", "or");
            myMapNode.Add("4", "not");
            myMapNode.Add("5", "be");

            //Get Value and Display
            string hash5 = myMapNode.Get("5");
            Console.WriteLine("5th index  value: " + hash5);


            string hash2 = myMapNode.Get("2");
            Console.WriteLine("2nd index  value: " + hash2);
        }
    }
}

