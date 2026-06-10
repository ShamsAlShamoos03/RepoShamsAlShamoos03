
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShamsAlShamoos03.Shared.Models
{
    public class UserRoleViewModel
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string NormalizedName { get; set; }
        public string RoleLevel { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string IdUser01 { get; set; }
        public string IdUser01RoleLevel { get; set; }

    }
}