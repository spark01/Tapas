using System.Data;
using MyWindowsFormsApp.Repository;
using MyWindowsFormsApp.Model;

namespace MyWindowsFormsApp.BLL
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();

        public bool Add(Item item)
        {
            return _itemRepository.Add(item);
        }

        public bool IsNameExist(string name)
        {
            return _itemRepository.IsNameExist(name);
        }
        public bool Delete(Item item)
        {
            return _itemRepository.Delete(item);
        }

        public bool Update(Item item)
        {
            return _itemRepository.Update(item);
        }
        public DataTable Display()
        {
            return _itemRepository.Display();
        }
        public DataTable IDwiseDisplay(int ID)
        {
            return _itemRepository.IDwiseDisplay(ID);
        }
        public DataTable Search(string name)
        {
            return _itemRepository.Search(name);
        }

        public DataTable ItemCombo()
        {
            return _itemRepository.ItemCombo();
        }

        public bool SelectById(int Id, string Name, double Price)
        {
            return _itemRepository.SelectById(Id,Name,Price);
        }
    }
}
