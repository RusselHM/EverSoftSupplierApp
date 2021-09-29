
using EverSoftSupplier.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.Suppliers.Commands
{
    public class SupplierRemoveCommand : IRequest<Supplier>
    {
        public int Id { get; set; }
        public SupplierRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
