using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class CategoryReportSubViewModel
    {
        public int CategoryReportSubId { get; set; }

        [Display(Name ="نام دسته گزارش")]
        [Required(AllowEmptyStrings = false,ErrorMessage ="دسته بندی وارد نشده است.")]
        //[StringLength(150,MinimumLength =4,ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string TitleS { get; set; } = "1";

        [Display(Name = "نام لاتین گزارش")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string DescriptionS { get; set; } = "1";



        [Display(Name = "محل ")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Section_S01 { get; set; } = "1";


        [Display(Name = "محل 2")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Section_S02 { get; set; } = "1";



        [Display(Name = "دسته 1")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Seed_S01 { get; set; } = "1";



        [Display(Name = "دسته 2")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Seed_S02 { get; set; } = "1";




    }
}
