using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devnet_Csharp_backend.api.Models
{
    abstract class User
    {
        public long id { get; set; }
        public string? name { get; set; }
        public string? username { get; set; }
    }
}