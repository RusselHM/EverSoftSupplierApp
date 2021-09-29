using AutoMapper;
using EverSoftSupplier.Application.Suppliers.Commands;
using EverSoftSupplier.Application.DTOs;
using EverSoftSupplier.Application.Products.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
            CreateMap<SupplierDTO, SupplierUpdateCommand>();
            //CreateMap<CategoryDTO, CategoryUpdateCommand>();
        }
    }
}
