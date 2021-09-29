using EverSoftSupplier.Domain.Entities;
using EverSoftSupplier.Domain.Interfaces;
using EverSoftSupplier.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Infrastructure.Data.Repository
{
    
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ApplicationDbContext _supplierRepository;

        public SupplierRepository(ApplicationDbContext context)
        {
           _supplierRepository = context;
        }

        public async Task<Supplier> CreateAsync(Supplier Supplier)
        {
           _supplierRepository.Add(Supplier);
            await _supplierRepository.SaveChangesAsync();
            return Supplier;
        }

        public async Task<Supplier> GetSupplierAsync(int? id)
        {
            return await _supplierRepository.Suppliers.Include(x => x.Name)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        //public async Task<Supplier> GetSupplierCategoryAsync(int? id)
        //{
        //    return await_supplierRepository.Suppliers.Include(x => x.Category)
        //        .SingleOrDefaultAsync(x => x.Id == id);
        //}

        public async Task<IEnumerable<Supplier>> GetSuppliersAsync()
        {
            return await _supplierRepository.Suppliers.ToListAsync();
        }

        public async Task<Supplier> RemoveAsync(Supplier Supplier)
        {
           _supplierRepository.Remove(Supplier);
            await _supplierRepository.SaveChangesAsync();
            return Supplier;
        }

        public async Task<Supplier> UpdateAsync(Supplier Supplier)
        {
           _supplierRepository.Update(Supplier);
            await _supplierRepository.SaveChangesAsync();
            return Supplier;
        }
    }
}
