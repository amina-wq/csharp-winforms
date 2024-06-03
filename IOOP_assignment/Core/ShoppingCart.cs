using IOOP_assignment.Models;
using System.Collections.Generic;
using System.Linq;

namespace IOOP_assignment.Core
{
    public class ShoppingCart
    {
        private Dictionary<MenuItem, int> _items;

        public ShoppingCart()
        {
            _items = new Dictionary<MenuItem, int>(new MenuItemComparer());
        }

        public void AddItem(MenuItem item)
        {
            if (_items.ContainsKey(item))
            {
                _items[item]++;
            }
            else
            {
                _items[item] = 1;
            }
        }

        public void RemoveItem(MenuItem item)
        {
            if (_items.ContainsKey(item))
            {
                if (_items[item] > 1)
                {
                    _items[item]--;
                }
                else
                {
                    _items.Remove(item);
                }
            }
        }

        public Dictionary<MenuItem, int> GetItems()
        {
            return _items;
        }

        public List<MenuItem> ToList()
        {
            return _items.SelectMany(i => Enumerable.Repeat(i.Key, i.Value)).ToList();
        }

        public decimal GetTotal()
        {
            return _items.Sum(i => i.Key.Price * i.Value);
        }

        public int GetQuantity(MenuItem item)
        {
            return _items.ContainsKey(item) ? _items[item] : 0;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }

    public class MenuItemComparer : IEqualityComparer<MenuItem>
    {
        public bool Equals(MenuItem x, MenuItem y)
        {
            return x.ItemName == y.ItemName && x.Price == y.Price;
        }

        public int GetHashCode(MenuItem obj)
        {
            return obj.ItemName.GetHashCode() ^ obj.Price.GetHashCode();
        }
    }
}
