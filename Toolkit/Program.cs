using System;

namespace Toolkit
{
    class Entry
    {
        public string url;
            public string name;
        public string key;

        public Entry (string url, string name, string key)
        {
            url = newUrl;
            name = newName;
            key = newKey;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Entry[] entryies = new Entry[]
            {
                new Entry("www.facebook.com", "Facebook", "f"),
                new Entry("www.google.com", "Google", "g"),
                new Entry("www.youtube.com", "YouTube", "y")
            };

            Console.WriteLine("Wright the key and press enter");
            Console.WriteLine("Options");
            foreach (Entry entry in entryies)
            {
                Console.WriteLine("\t" + entry.key + "-" + entry.name);
            }

            Console.WriteLine("\nYour Option?");

            var userInput = Console.ReadLine();

            foreach (Entry entry1 in entryies)
            {
                if (userInput == Entry.key)
                {

                }
            }

            Console.ReadLine();
        }
    }
}
