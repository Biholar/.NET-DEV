using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoIdentityWebApi.Entity
{
    public class FileUser
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public int UserId { get; set; }
        public int Role { get; set; }
    }
}
