
using EverSoftSupplier.Domain.Entities;
using MediatR;
using System.Collections;
using System.Collections.Generic;

namespace EverSoftSupplier.Application.Suppliers.Queries
{
    public class GetSuppliersQuery : IRequest<IEnumerable<Supplier>>
    {
    }
}
