using System;

namespace TD_7_A2
{
    public class Contact
    {
        private string _name;
        private int _number;

        public Contact(string name, int number)
        {
            this._name = name ?? throw new ArgumentNullException(nameof(name));
            this._number = number;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public bool Equals(Contact other)
        {
            return (this.Name == other.Name || this.Number == other.Number);
        }

        public bool Contains(string query)
        {
            return (this.Name.Contains(query) || this.Number.ToString().Contains(query));
        }
    }
}