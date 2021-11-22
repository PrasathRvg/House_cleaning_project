using System;
using System.Collections.Generic;

#nullable disable

namespace housecleaning4Api.Models
{
    public partial class RoomCost
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public long CostPerSqft { get; set; }
    }
}
