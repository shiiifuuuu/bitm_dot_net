using MyWindowsFormsApp.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWindowsFormsApp.Manager
{
    public class ItemManager
    {
        public ItemRepository _itemRepository = new ItemRepository();
        public bool Add(string name, double price)
        {
            return _itemRepository.Add(name, price);
        }
        public bool IsNameExists(string name)
        {
            return _itemRepository.IsNameExists(name);
        }
        public DataTable Display()
        {
            return _itemRepository.Display();
        }
    }
}
