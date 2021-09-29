
using EverSoftSupplier.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.Suppliers.Commands
{
    public abstract class SupplierCommand : IRequest<Supplier>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public string Code { get; set; }
      
    }
}
