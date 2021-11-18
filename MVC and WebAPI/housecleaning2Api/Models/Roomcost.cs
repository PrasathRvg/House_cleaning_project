using System;
using System.Collections.Generic;

#nullable disable

namespace housecleaning2Api.Models
{
    public partial class Roomcost
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public long CostPerSqft { get; set; }
    }
}
