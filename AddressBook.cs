using System;
using System.Collections.Generic;

namespace TD_7_A2
{
    public class AddressBook
    {
        private SortedList<int, string> _contacts;

        public AddressBook(SortedList<int, string> contacts)
        {
            this._contacts = contacts;
        }
        public AddressBook()
        {
            this._contacts = new SortedList<int, string>();
        }

        public SortedList<int, string> Contacts
        {
            get => _contacts;
        }

        public bool Add(int number, string name)
        {
            if (!this._contacts.ContainsKey(number))
            {
                this._contacts.Add(number, name);
                return true;
            }
            else return false;
        }

        public bool Remove(int number)
        {
            if (this._contacts.ContainsKey(number))
            {
                this._contacts.Remove(number);
                return true;
            }
            else return false;
        }

        public int Search(string query)
        {
            return this._contacts.IndexOfValue(query);
        }
        
        public string Search(int query)
        {
            return this._contacts[this._contacts.IndexOfKey(query)];
        }

        public override string ToString()
        {
            var output = "";
            foreach (var (key, value) in this._contacts)
            {
                output = output + "0" + value + " : " + key.ToString() + "\n";
            }

            return output;
        }
    }
}