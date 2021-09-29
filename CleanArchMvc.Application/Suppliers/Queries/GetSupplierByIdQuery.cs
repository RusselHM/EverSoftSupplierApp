
using EverSoftSupplier.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.Suppliers.Queries
{
    public class GetSupplierByIdQuery : IRequest<Supplier>
    {
        public int Id { get; set; }
        public GetSupplierByIdQuery(int id)
        {
            Id = id;
        }
    }
}
