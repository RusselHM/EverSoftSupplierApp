using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.Suppliers.Commands
{
    public class SupplierUpdateCommand : SupplierCommand
    {
        public int Id { get;private set; }
    }
}
