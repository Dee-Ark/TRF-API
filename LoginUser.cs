using System;
using System.Collections.Generic;

namespace NSETRADEREPORT.MODEL.Models.DB
{
    public partial class LoginUser
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateLogin { get; set; }
        public string IpAddress { get; set; }
    }
}
