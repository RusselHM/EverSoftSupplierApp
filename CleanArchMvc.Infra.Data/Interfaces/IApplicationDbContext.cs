using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Infrastructure.Data.Interfaces
{
    public interface IApplicationDbContext
    {
      protected  void OnModelCreating(ModelBuilder modelBuilder);
    }
}
