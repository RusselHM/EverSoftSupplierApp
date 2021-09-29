using EverSoftSupplier.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Domain.Interfaces
{
   
    public interface ISupplierRepository
    {
        Task<IEnumerable<Supplier>> GetSuppliersAsync();
        Task<Supplier> GetSupplierAsync(int? id);

        Task<Supplier> CreateAsync(Supplier category);
        Task<Supplier> UpdateAsync(Supplier category);
        Task<Supplier> RemoveAsync(Supplier category);
    }
}
