
using EverSoftSupplier.Application.Suppliers.Queries;
using EverSoftSupplier.Domain.Entities;
using EverSoftSupplier.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.Suppliers.Handlers
{
    public class GetSuppliersQueryHandler : IRequestHandler<GetSuppliersQuery, IEnumerable<Supplier>>
    {
        private readonly ISupplierRepository _SupplierRepository;

        public GetSuppliersQueryHandler(ISupplierRepository SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }

        public async Task<IEnumerable<Supplier>> Handle(GetSuppliersQuery request, CancellationToken cancellationToken)
        {
            return await _SupplierRepository.GetSuppliersAsync();
        }
    }
}
