using System;
using System.Collections.Generic;

namespace testproj.Models
{
    public partial class UsersLogin
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? LogInDate { get; set; }
        public DateTime? LogOutDate { get; set; }
        public string? Pcname { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
