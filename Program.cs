using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_DIP__Implementandolo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
    }

    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerById(int id)
        {
            return new Customer { Id = id, Name = "Cliente de ejemplo" };
        }
    }

    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }
    }

}
