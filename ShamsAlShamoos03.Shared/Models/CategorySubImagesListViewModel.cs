using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class CategorySubImagesListViewModel
    {
        public int CategorySubImagesId { get; set; }

        [Display(Name ="گروه بندی")]
        [Required(AllowEmptyStrings = false,ErrorMessage ="دسته بندی وارد نشده است.")]
        [StringLength(150,MinimumLength =4,ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string TitleCategorySub { get; set; }

        public string NewsDateSham { get; set; } = "";
         

        [Display(Name = "تاریخ خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ خبر وارد نشده است.")]

        public DateTime NewsDate { get; set; }

        [Display(Name = "زمان ثبت خبر")]
        public DateTime NewsTime { get; set; }


        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string DescriptionS { get; set; }



        //[Display(Name = "محل 1")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_S01 { get; set; }


        //[Display(Name = "محل 2")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_S02 { get; set; }



        //[Display(Name = "دسته 1")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_S01 { get; set; }



        //[Display(Name = "دسته 2")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_S02 { get; set; }

        public string DateTimestring { get; set; } = "";



    }
}
