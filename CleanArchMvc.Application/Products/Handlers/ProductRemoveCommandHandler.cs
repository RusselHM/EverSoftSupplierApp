using EverSoftSupplier.Application.Products.Commands;
using EverSoftSupplier.Domain.Entities;
using EverSoftSupplier.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.Products.Handlers
{
    class ProductRemoveCommandHandler : IRequestHandler<ProductRemoveCommand, Product>
    {
        private readonly IProductRepository _productRepository;

        public ProductRemoveCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductAsync(request.Id);

            if (product == null)
            {
                throw new ApplicationException("Entity could not be found");
            }
            else
            {
                return await _productRepository.RemoveAsync(product);
            }
        }
    }
}
