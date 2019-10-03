 using System.Data;
 
using MyWindowsFormsApp.Repository;
using MyWindowsFormsApp.BLL;

namespace MyWindowsFormsApp.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Add(string name, string address, string contact)
        {
            return _customerRepository.Add(name, address, contact);
        }

        public bool IsNameExist(string name)
        {
            return _customerRepository.IsNameExist(name);
        }

        public bool Delete(int id)
        {
            return _customerRepository.Delete(id);
        }

        public bool Update(string name, string address, string contact, int id)
        {
            return _customerRepository.Update(name, address, contact, id);
        }

        public DataTable Display()
        {
            return _customerRepository.Display();
        }

        public DataTable Search(string name)
        {
            return _customerRepository.Search(name);
        }

        public DataTable CustomerCombo()
        {
            return _customerRepository.CustomerCombo();
        }
    }
}
