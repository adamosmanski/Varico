using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Varico.EF.Models
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        [Required]
        public int ProductionYear { get; set; }

        [Required]
        [EnumDataType(typeof(VehicleType))]
        public VehicleType VehicleType { get; set; }

        [Required]
        [EnumDataType(typeof(BodyType))]
        public BodyType BodyType { get; set; }

        [Required]
        public bool Availability { get; set; }

        public int ReservedById { get; set; }

        [ForeignKey("ReservedById")]
        public virtual Users ReservedBy { get; set; }

        [Required]
        public string PictureURL { get; set; }


    }

}
