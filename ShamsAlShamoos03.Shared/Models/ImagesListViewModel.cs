
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class ImagesListViewModel
    {
        public int ImagesListId { get; set; }

        [Display(Name = "عنوان عکس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "عنوان عکس وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        //[Display(Name = "متن عکس")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "متن عکس وارد نشده است.")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Content { get; set; } = "";

        //[Display(Name = "چکیده عکس")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "چکیده عکس وارد نشده است.")]
        
        //public string Abstract { get; set; }

        //[Display(Name = "تعداد بازدید")]
        //public int VisitCount { get; set; }

        //[Display(Name = "تاریخ عکس")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ عکس وارد نشده است.")]

        public string ImagesListDateSham { get; set; }


        [Display(Name = "تاریخ عکس")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ عکس وارد نشده است.")]

        public DateTime ImagesListDate { get; set; }

        [Display(Name = "زمان ثبت عکس")]
        public DateTime ImagesListTime { get; set; }

        [Display(Name = "تصویر عکس اول")]
        public string? IndexImage { get; set; }

        //[Display(Name = "تصویر عکس دوم")]
        //public string? IndexImage02 { get; set; }

        //[Display(Name = "محل ارسال عکس")]
        //public byte PlaceImagesListID { get; set; }

        //[Display(Name = "نوع عکس")]
        //public byte ImagesListType { get; set; }

        ////SEO Property
        //[Display(Name = "متاتگ ها")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "متاتگ ها وارد نشده است.")]

        //public string MetaTag { get; set; }

        //[Display(Name = "متای توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "متای توضیحات وارد نشده است.")]

        //public string MetaDescription { get; set; }

        //public string UserID { get; set; }

        [Display(Name = "دسته بندی عکس")]
        public int CategoryImagesId { get; set; }

    }
}
