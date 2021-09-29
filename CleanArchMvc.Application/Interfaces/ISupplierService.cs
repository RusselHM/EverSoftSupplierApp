using EverSoftSupplier.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.Interfaces
{
    public interface ISupplierService
    {
        Task<IEnumerable<SupplierDTO>> GetSuppliers();
        Task<SupplierDTO> GetById(int? id);
        Task Add(SupplierDTO SupplierDTO);
        Task Update(SupplierDTO SupplierDTO);
        Task Remove(int? id);
    }
}
