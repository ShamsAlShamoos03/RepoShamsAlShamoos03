using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShamsAlShamoos03.Shared.Models
{
    public class SiteSettingViweModel
    {
        public int id { get; set; }

        [Display(Name = "تگ ها")]
        public string MetaTag { get; set; }

        [Display(Name = "متای توضیحات")]
        public string MetaDescription { get; set; }

        [Display(Name = "عنوان سایت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "عنوان سایت وارد نشده است.")]
        public string SiteTitle { get; set; }
    }
}
