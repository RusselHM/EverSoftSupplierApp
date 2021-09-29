using AutoMapper;
using EverSoftSupplier.Application.DTOs;
using EverSoftSupplier.Application.Interfaces;
using EverSoftSupplier.Domain.Entities;
using EverSoftSupplier.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.Services
{
   
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IMapper _mapper;

        public SupplierService(ISupplierRepository supplierRepository, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SupplierDTO>> GetSuppliers()
        {
            var categoriesEntity = await _supplierRepository.GetSuppliersAsync();
            return _mapper.Map<IEnumerable<SupplierDTO>>(categoriesEntity);
        }

        public async Task<SupplierDTO> GetById(int? id)
        {
            var categoryEntity = await _supplierRepository.GetSupplierAsync(id);
            return _mapper.Map<SupplierDTO>(categoryEntity);
        }

        public async Task Add(SupplierDTO SupplierDTO)
        {
            var categoryEntity = _mapper.Map<Supplier>(SupplierDTO);
            await _supplierRepository.CreateAsync(categoryEntity);
        }

        public async Task Update(SupplierDTO SupplierDTO)
        {
            var categoryEntity = _mapper.Map<Supplier>(SupplierDTO);
            await _supplierRepository.UpdateAsync(categoryEntity);
        }

        public async Task Remove(int? id)
        {
            var categoryEntity = _supplierRepository.GetSupplierAsync(id).Result;
            await _supplierRepository.RemoveAsync(categoryEntity);
        }
    }
}
