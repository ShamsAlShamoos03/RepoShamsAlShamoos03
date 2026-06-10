using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShamsAlShamoos03.Shared.Models
{
    public class AdvertiseViewModel
    {
        public int AdId { get; set; }

        [Display(Name = "تصویر")]
        public string? gifPath { get; set; }
        public string? newImagePathName { get; set; }

        [Display(Name = "از تاریخ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع تبلیغ وارد نشده است.")]
        public DateTime FromDate { get; set; }

        [Display(Name = "تا تاریخ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ پایان تبلیغ وارد نشده است.")]
        public DateTime ToDate { get; set; }

        [Display(Name = "متن تبلیغ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "متن تبلیغ وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        public string Link { get; set; }

        [Display(Name = "وضعیت")]
        public byte flag { get; set; }

        [Display(Name = "محل نمایش")]
        public byte Advlocation { get; set; }
    }
}
