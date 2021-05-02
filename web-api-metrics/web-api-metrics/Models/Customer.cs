using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api_metrics.Models
{
    public class Customer
    {
        public Customer(int id, string name, string email, string cpf)
        {
            Id = id;
            Name = name;
            Email = email;
            Cpf = new Cpf(cpf);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Cpf Cpf { get; set; }

        

        public bool Validate()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(Name) ||
                string.IsNullOrWhiteSpace(Email) ||
                Cpf.IsValid )
                isValid = false;
            return isValid;
        }
    }
}
