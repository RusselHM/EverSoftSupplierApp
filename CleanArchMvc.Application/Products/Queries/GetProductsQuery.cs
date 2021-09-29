using EverSoftSupplier.Domain.Entities;
using MediatR;
using System.Collections;
using System.Collections.Generic;

namespace EverSoftSupplier.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
