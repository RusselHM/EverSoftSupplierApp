using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverSoftSupplier.Application.DTOs
{
    public class SupplierDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The  ContactNumber is Required")]
        [MinLength(5)]
        [MaxLength(50)]
        [DisplayName("Telephone")]
        public string TelephoneNumber{ get; set; }

        [Required(ErrorMessage = "The Code is Required")]
        [MinLength(5)]
        [MaxLength(10)]
        [DisplayName("Code")]
        public string Code { get; set; }

    }
}
