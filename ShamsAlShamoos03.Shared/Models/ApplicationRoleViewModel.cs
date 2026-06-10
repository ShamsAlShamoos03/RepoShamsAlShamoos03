using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShamsAlShamoos03.Shared.Models
{
    public class ApplicationRoleViewModel
    {

        [Display(Name = "نام انگلیسی دسترسی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} وارد نمایید.")]
        public string Name { get; set; }

        [Display(Name = "نام فارسی دسترسی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا {0} وارد نمایید.")]
        public string Description { get; set; }

        public string RoleLevel { get; set; }
    }
}
