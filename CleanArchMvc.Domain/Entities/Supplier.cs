using EverSoftSupplier.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Domain.Entities
{
    public class Supplier : Entity
    {
        public Supplier(
            string name,
            string telephoneNumber,
            string code
            )
        {
            ValidateDomain(name, telephoneNumber, code);
        }
        public Supplier(int id, string name,
            string telephoneNumber,
            string code)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidateDomain(name, telephoneNumber, code);
        }

        public string Name { get; private set; }

        public void Update(string name,
            string telephoneNumber,
            string code)
        {
            ValidateDomain(name, telephoneNumber, code);
        }
        private void ValidateDomain(string name, string telephoneNumber, string code)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
            "Invalid name. Name is required");

            DomainExceptionValidation.When(name.Length < 3,
            "Invalid name. too short, minimum 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(telephoneNumber),
            "Invalid telephone. Name is required");

            DomainExceptionValidation.When(telephoneNumber.Length < 3,
            "Invalid telephome. too short, minimum 3 characters");

            Name = name;
            TelephoneNumber = telephoneNumber;
            Code = code;
        }

        public string TelephoneNumber { get; private set; }

        public string Code { get; private set; }

        

       
    }
}
