using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace housecleaning4Api.Models
{
    public partial class UserTbl
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter fullname.")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please enter your Address.")]
        public string StreetAddress { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Please Select your city.")]
        public string City { get; set; }
        public string Message { get; set; }
        public long? LivingRoomSqft { get; set; }
        public long? KitchenSqft { get; set; }
        public long? BedroomSqft { get; set; }
        public long? BathroomSqft { get; set; }
        public string PreferredDays { get; set; }

        [Required(ErrorMessage = "Please Enter anyone of the Room sqft")]
        public long TotalAmount { get; set; }
        public string RequestNo { get; set; }
    }
}
