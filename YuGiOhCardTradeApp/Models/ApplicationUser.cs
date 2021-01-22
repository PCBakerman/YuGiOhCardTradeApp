using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace YuGiOhCardTradeApp2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int UserInventoryId { get; set; }
        public UserInventory UserInventory { get; set; }
    }
}
