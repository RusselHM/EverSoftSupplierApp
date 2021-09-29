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
    public class SupplierCreateCommandHandler : IRequestHandler<SupplierCreateCommand, Supplier>
    {
        private readonly ISupplierRepository _SupplierRepository;

        public SupplierCreateCommandHandler(ISupplierRepository SupplierRepository)
        {
            _SupplierRepository = SupplierRepository;
        }

        public async Task<Supplier> Handle(SupplierCreateCommand request, CancellationToken cancellationToken)
        {
            var Supplier = new Supplier(request.Name, request.TelephoneNumber, request.Code);

            if (Supplier == null)
            {
                throw new ApplicationException("Error creating entity");
            }else
            {
                Supplier.Id = request.Id;
                return await _SupplierRepository.CreateAsync(Supplier);
            }
        }
    }
}
