using EverSoftSupplier.Application.DTOs;
using EverSoftSupplier.Application.Interfaces;
using EverSoftSupplier.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EverSoftSupplier.WebUI.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(ISupplierService SupplierService)
        {
            _supplierService = SupplierService;
        }
        public async Task<IActionResult> ViewCategory([FromBody] string searchString)
        {
            var Suppliers = await _supplierService.GetSuppliers();
            var updatedModel= from m in Suppliers
                             select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                updatedModel= Enumerable.Empty<SupplierDTO>();
                 updatedModel= Suppliers.Where(s => s.Name.Contains(searchString));
            }

            return View("Index", updatedModel);
        }
        public async Task<IActionResult> Index()
        {
            var Suppliers = await _supplierService.GetSuppliers();
            return View(Suppliers);
        }

        public async Task<IActionResult> GetSupplier(int id)
        {

            await _supplierService.GetById(id);
            return View();
        }
        public async Task<IActionResult> AddSupplier([FromBody] AddModel model)
        {
            
            var supplier = new SupplierDTO()
            {
                
                Code = model.Code,
                Name = model.Name,
                TelephoneNumber = model.TelephoneNumber

            };
            
            await _supplierService.Add(supplier);


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveSupplier(int id)
        {
            
            await _supplierService.Remove(id);
            return View();
        }
        public async Task<IActionResult> UpdateSupplier([FromBody] AddModel model)
        {
            var supplier = new SupplierDTO()
            {
                Code = model.Code,
                Name = model.Name,
                TelephoneNumber = model.TelephoneNumber

            };
            await _supplierService.Update(supplier);

            return View();
        }
    }
}
