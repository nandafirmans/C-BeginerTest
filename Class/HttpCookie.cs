using System.Collections.Generic;

namespace ConsoleApplication.Class
{
    public class HttpCookie
    {
        // dictionary is a data type ( Dictionary< Tkey, Tvalue > ) that use hash table to stored data,
        // hash table has a special mecanism, that makes extremely fast to look an item by its key.
        // so whatever you have a list of object,
        // and you want to look them all by its key as an "index" you should use a Dictionary

        private readonly Dictionary<string, string> _dictionary; // in this case I using string as an Key and Value

        public HttpCookie() // I'm using constructor to create object of _dictionary. so its doesn't causes exception
        {
            _dictionary = new Dictionary<string, string>();
        }

        // this is the indexer, ( indexer doesnt have a name  so I use "this" keyword)
        // followed by indexer notatio, I'm using string to represent the keys for the key value pharse
        public string this[string key ] 
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}