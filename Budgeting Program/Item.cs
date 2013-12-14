using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeting_Program
{
    [Serializable]
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string @URL { get; set; }

        public Item(string Name, string Price, string @URL)
        {
            this.Name = Name;
            this.Price = Convert.ToDouble(Price);
            this.@URL = @URL;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
