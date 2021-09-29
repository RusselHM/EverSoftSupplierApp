
using EverSoftSupplier.Application.Suppliers.Commands;
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
    class SupplierRemoveCommandHandler : IRequestHandler<SupplierRemoveCommand, Supplier>
    {
        private readonly ISupplierRepository _SupplierRepository;

        public SupplierRemoveCommandHandler(ISupplierRepository SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }

        public async Task<Supplier> Handle(SupplierRemoveCommand request, CancellationToken cancellationToken)
        {
            var Supplier = await _SupplierRepository.GetSupplierAsync(request.Id);

            if (Supplier == null)
            {
                throw new ApplicationException("Entity could not be found");
            }
            else
            {
                return await _SupplierRepository.RemoveAsync(Supplier);
            }
        }
    }
}
