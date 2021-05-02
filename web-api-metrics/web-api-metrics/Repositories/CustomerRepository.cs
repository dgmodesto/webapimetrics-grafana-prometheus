using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api_metrics.Models;

namespace web_api_metrics.Repositories
{
    public class CustomerRepository
    {
        private List<Customer> Customers;

        public CustomerRepository()
        {
            Customers = new List<Customer>();
            Customers.Add(new Customer(1, "Douglas Modesto", "d.modesto@teste.com.br", "045.213.920-16"));
            Customers.Add(new Customer(1, "Martin Diogo Filipe Anthony Jesus", "martindiogojuanjesus__martindiogojuanjesus@urbam.com.br", "980.725.820-03"));
            Customers.Add(new Customer(1, "Diogo Nicolas Carvalho", "diogonicolascarvalho-74@saa.com.br", "406.244.580-83"));
            Customers.Add(new Customer(1, "Ericka Sebastião Silveira", "eerickantoniosilveira@transtelli.com.br", "705.559.730-77"));
            Customers.Add(new Customer(1, "Laura Jaqueline Aline Silva", "laurajaquelinealinesilva__laurajaquelinealinesilva@me.com", "711.605.230-53"));

        }


        // Retorna um único cliente
        public Customer CustomerById(int customerId)
        {
            // retorna um cliente
            return Customers.Where(x => x.Id == customerId).FirstOrDefault();
        }
        // retorna todos os clientes
        public IEnumerable<Customer> GetCustomers()
        {
            // retorna todos os clientes
            return Customers;
        }
        // Salva o cliente atual
        public bool Save(Customer customer)
        {
            //salva o cliente definido
            return true;
        }
    }
}
