using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to hashtable ");
            int key = 0;


            string paragraphPhrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paragraph = paragraphPhrase.Split(" ");


            MyMapNode<int, string> myMapNode = new MyMapNode<int, string>(paragraph.Length);

            //Add 
            foreach (string word in paragraph)
            {
                myMapNode.Add(key, word);
                key++;
            }


            Console.WriteLine("frequency of words ");


            for (key = 0; key < paragraph.Length; key++)
            {
                string value = myMapNode.Get(key);
                Console.WriteLine(key + " - " + value);
            }

        }
    }
}

