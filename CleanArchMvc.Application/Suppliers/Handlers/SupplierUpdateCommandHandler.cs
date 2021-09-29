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
    class SupplierUpdateCommandHandler : IRequestHandler<SupplierUpdateCommand, Supplier>
    {
        private readonly ISupplierRepository _SupplierRepository;

        public SupplierUpdateCommandHandler(ISupplierRepository SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }

        public async Task<Supplier> Handle(SupplierUpdateCommand request, CancellationToken cancellationToken)
        {
            var Supplier = await _SupplierRepository.GetSupplierAsync(request.Id);

            if (Supplier == null)
            {
                throw new ApplicationException("Entity could not be found");
            }else
            {
                Supplier.Update(request.Name, request.TelephoneNumber, request.Code);
                return await _SupplierRepository.UpdateAsync(Supplier);
            }
        }
    }
}
