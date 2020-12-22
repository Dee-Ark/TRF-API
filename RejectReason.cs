using System;
using System.Collections.Generic;

namespace NSETRADEREPORT.MODEL.Models.DB
{
    public partial class RejectReason
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
