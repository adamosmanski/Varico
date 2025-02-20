using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Varico.EF.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(200)]
        public string Email { get; set; }

        [Phone]
        [MaxLength(15)]
        public string Phone { get; set; }

        public virtual Address Address { get; set; }

        public virtual Cars? Car { get; set; }
    }
    
    
    public enum VehicleType
    {
        Osobowy,
        Ciężarowy,
        Motocykl
    }

    public enum BodyType
    {
        SUV,
        HATCHBACK,
        SEDAN,
        KOMBI,
        COUPE,
        VAN,
        MINIVAN,
        KABRIOLET,
        LIFTBACK,
        CROSSOVER,
        ROADSTER,
        PICK_UP
    }
}