using Assignment6.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.MODEL;

namespace Assignment6.MANAGER
{
    class ItemManager
    {
        private ItemRepository _itemRepository = new ItemRepository();

        public bool AddItem(Item _item)
        {
            return _itemRepository.AddItem(_item);
        }
        public bool IsItemExist(Item _item)
        {
            return _itemRepository.IsItemExist(_item);
        }
        public DataTable SearchItem(Item _item)
        {
            return _itemRepository.SearchItem(_item);
        }
        public bool UpdateItem(Item _item)
        {
            return _itemRepository.UpdateItem(_item);
        }
        public bool DeleteItem(Item _item)
        {
            return _itemRepository.DeleteItem(_item);
        }
        public DataTable ShowData()
        {
            return _itemRepository.ShowData();
        }
    }
}
