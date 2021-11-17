using System;
using System.Collections.Generic;

#nullable disable

namespace housecleaningApi.Models
{
    public partial class RoomCost
    {
        public RoomCost()
        {
            UserTbls = new HashSet<UserTbl>();
        }

        public int RoomId { get; set; }
        public string RoomNameSqft { get; set; }
        public long CostPerSqft { get; set; }

        public virtual ICollection<UserTbl> UserTbls { get; set; }
    }
}
