using System.Data;
using MyWindowsFormsApp.Repository;
using MyWindowsFormsApp.Model;

namespace MyWindowsFormsApp.BLL
{
    class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();
        public bool Add(Order order)
        {
            return _orderRepository.Add(order);
        }
        public bool Delete(int id)
        {
            return _orderRepository.Delete(id);
        }

        public DataTable Display()
        {
            return _orderRepository.Display();
        }

        public bool Update( int quantity, int id)
        {
            return _orderRepository.Update(quantity, id);
        }

        public DataTable Search(int quantity)
        {
            return _orderRepository.Search(quantity);
        }
    }
}
