using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    public class Worker
    {
        public string salary;
        public string experience;

        public Worker(string sal, string exp)
        {
            salary = sal;
            experience = exp;
        }
    }
    public class MyHashtable : IEnumerable<Worker>
    {
        public class Item
        {  
            public string Key { get; private set; }

            public string Value { get; private set; }

            public Item(Worker itemWorker)
            {
                if (string.IsNullOrEmpty(itemWorker.salary))
                {
                    throw new ArgumentNullException(nameof(itemWorker.salary));
                }

                if (string.IsNullOrEmpty(itemWorker.experience))
                {
                    throw new ArgumentNullException(nameof(itemWorker.experience));
                }

                Key = itemWorker.salary;
                Value = itemWorker.experience;
            }

            public Item(string key, string value)
            {
                if (string.IsNullOrEmpty(key))
                {
                    throw new ArgumentNullException(nameof(key));
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                Key = key;
                Value = value;
            }

            public override string ToString() => Key;
        }
   
        private readonly byte _maxSize = 255;
        
        private Dictionary<int, List<Item>> _items = null;
    
        public IReadOnlyCollection<KeyValuePair<int, List<Item>>> Items => _items.ToList().AsReadOnly();


        public MyHashtable()
        {
           
            _items = new Dictionary<int, List<Item>>(_maxSize);
        }

        public void Add(string key, string value)
        {
         
            IsNullOrEmpty(key);

            if (key.Length > _maxSize)
            {
                throw new ArgumentException($"The maximum key length is {_maxSize} characters.", nameof(key));
            }

            IsNullOrEmpty(value);

            var item = new Item(key, value);

            var hash = GetHash(item.Key);

            List<Item> hashTableItem = null;
            if (_items.ContainsKey(hash))
            {
                hashTableItem = _items[hash];

                var oldElementWithKey = hashTableItem.SingleOrDefault(x => x.Key == item.Key);
                if (oldElementWithKey != null)
                {
                    throw new ArgumentException($"The hash table already contains an item with a key {key}. The key must be unique.", nameof(key));
                }

                _items[hash].Add(item);
            }
            else
            {
                hashTableItem = new List<Item> { item };
                _items.Add(hash, hashTableItem);
            }
        }

        public void Add(Worker itemWorker)
        {
            var item = new Item(itemWorker);

            var hash = GetHash(item.Key);

            List<Item> hashTableItem = null;
            if (_items.ContainsKey(hash))
            {
                hashTableItem = _items[hash];

                var oldElementWithKey = hashTableItem.SingleOrDefault(x => x.Key == item.Key);
                if (oldElementWithKey != null)
                {
                    throw new ArgumentException($"The hash table already contains an item with a key {itemWorker.salary}. The key must be unique.", nameof(itemWorker.salary));
                }

                _items[hash].Add(item);
            }
            else
            {
                hashTableItem = new List<Item> { item };
                _items.Add(hash, hashTableItem);
            }
        }
        //---------------------------
        
    }
}