using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefMelSauces.Models
{
    public class ECommerce
    {
        public int Id { get; set; }
        public Int16 Sales { get; set; }

        [Required]
        [StringLength (25)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        public string LastName { get; set; }


        [Required]
        [StringLength(75)]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(75)]
        public string City { get; set; }

        [Required]
        [StringLength(75)]
        public string State { get; set; }

        [Required]
        [StringLength(75)]
        public string ZipCode { get; set; }


        [Required, DataType(DataType.PhoneNumber)]        
        [StringLength(10)]
        public string PhoneNumber { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(40)]
        public string EmailAddress { get; set; }


        [Required]
        [CreditCard]
        [StringLength(16)]
        public string CreditCardNumber { get; set; }


        [Required, RegularExpression(@"[0-9][0-9]//[0-9][0-9]", ErrorMessage = "Format must be mm/yy")]
        [StringLength(25)]
        public string ExpDate { get; set; }


        [Required]
        [StringLength(4)]
        public int CvvCode { get; set; }

    }
}
