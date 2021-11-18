using System;
using System.Collections.Generic;

#nullable disable

namespace housecleaning2Api.Models
{
    public partial class UserTbl
    {
        public int UserId { get; set; }
        public string RequestNo { get; set; }
        public string Fullname { get; set; }
        public string StreetAddress { get; set; }
        public string PhoneNo { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Message { get; set; }
        public int? NoOfLivingRooms { get; set; }
        public int? NoOfKitchens { get; set; }
        public int? NoOfBedrooms { get; set; }
        public int? NoOfBathrooms { get; set; }
        public long? LivingRoomSqft { get; set; }
        public long? KitchenSqft { get; set; }
        public long? BedroomSqft { get; set; }
        public long? BathroomSqft { get; set; }
        public string PreferredDays { get; set; }
        public long TotalAmount { get; set; }
    }
}
