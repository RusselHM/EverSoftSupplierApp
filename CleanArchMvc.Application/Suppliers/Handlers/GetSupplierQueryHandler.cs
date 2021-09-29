
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
    public class GetSupplierQueryHandler : IRequestHandler<GetSupplierByIdQuery, Supplier>
    {
        private readonly ISupplierRepository _SupplierRepository;

        public GetSupplierQueryHandler(ISupplierRepository SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }

        public async Task<Supplier> Handle(GetSupplierByIdQuery request, CancellationToken cancellationToken)
        {
            return await _SupplierRepository.GetSupplierAsync(request.Id);
        }
    }
}
