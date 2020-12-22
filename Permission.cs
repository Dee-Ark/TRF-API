using System;
using System.Collections.Generic;

namespace NSETRADEREPORT.MODEL.Models.DB
{
    public partial class Permission
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public int FormId { get; set; }
        public bool CanAdd { get; set; }
        public bool CanView { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanApprove { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public byte Status { get; set; }
        public DateTime DateCreated { get; set; }
        public string RoleName { get; set; }
        public string FormName { get; set; }
        public string ModuleName { get; set; }

        public Form Form { get; set; }
        public Module Module { get; set; }
        public Role Role { get; set; }
    }
}
