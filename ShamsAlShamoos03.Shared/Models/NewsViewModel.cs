
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{

 
    public class NewsViewModelcat
    {
    

        public int NewsId { get; set; }


        public int IDNewsCategry01 { get; set; }


        [Display(Name = "عنوان خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "عنوان خبر وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string parentid { get; set; }
        

               [Display(Name = "متن خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "متن خبر وارد نشده است.")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Content { get; set; }

        [Display(Name = " محل وقوع خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "محل وقوع خبر وارد نشده است.")]
        
        public string Abstract { get; set; }

        [Display(Name = "دسته")]

        public int[] group { get; set; }
        public int[] group1 { get; set; }
        public int[] group2 { get; set; }
        public string[] strgroup2 { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You need to agree to the Terms and Conditions")]
        public bool check { get; set; }
        //[Display(Name = "تعداد بازدید")]
        //public int VisitCount { get; set; }

        //[Display(Name = "تاریخ خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ خبر وارد نشده است.")]

        public string NewsDateSham { get; set; }


        public string NewsImagesID01 { get; set; }
        public string NewsImagesID02 { get; set; }
        public string NewsImagesID03 { get; set; }
        public string NewsImagesID04 { get; set; }

        //public int? NewsCategoryID01 { get; set; }
        //public int? NewsCategoryID02 { get; set; }
        //public int? NewsCategoryID03 { get; set; }
        //public int? NewsCategoryID04 { get; set; }
        
        public string HaveNewsCategory { get; set; }
        public string HaveNewsimages { get; set; }


        [Display(Name = "تاریخ خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ خبر وارد نشده است.")]

        public DateTime NewsDate { get; set; }

        [Display(Name = "زمان ثبت خبر")]
        public DateTime NewsTime { get; set; }

        [Display(Name = "تصویر خبر اول")]
        public string? IndexImage { get; set; }

        [Display(Name = "تصویر خبر دوم")]
        public string? IndexImage02 { get; set; }
        [Display(Name = "تصویر خبر سوم")]
        public string? IndexImage03 { get; set; }

        [Display(Name = "محل ارسال خبر")]
        public byte PlaceNewsID { get; set; }

        [Display(Name = "نوع خبر")]
        public byte NewsType { get; set; }

        //SEO Property
        [Display(Name = "متاتگ ها")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "متاتگ ها وارد نشده است.")]

        public string MetaTag { get; set; }

        [Display(Name = "متای توضیحات")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "متای توضیحات وارد نشده است.")]

        public string MetaDescription { get; set; }
        public byte IsActive { get; set; }
        
        public string UserID { get; set; }

        [Display(Name = "دسته بندی خبر")]
        public int CategoryID { get; set; }
        
    }

    public class NewsViewModel
    {
        public int NewsId { get; set; }

        [Display(Name = "عنوان خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "عنوان خبر وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        [Display(Name = "متن خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "متن خبر وارد نشده است.")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Content { get; set; }

        [Display(Name = " محل وقوع خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "محل وقوع خبر وارد نشده است.")]

        public string Abstract { get; set; }

        //[Display(Name = "تعداد بازدید")]
        //public int VisitCount { get; set; }

        //[Display(Name = "تاریخ خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ خبر وارد نشده است.")]

        public string NewsDateSham { get; set; }


        [Display(Name = "تاریخ خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ خبر وارد نشده است.")]

        public DateTime NewsDate { get; set; }

        [Display(Name = "زمان ثبت خبر")]
        public DateTime NewsTime { get; set; }

        [Display(Name = "تصویر خبر اول")]
        public string? IndexImage { get; set; }

        [Display(Name = "تصویر خبر دوم")]
        public string? IndexImage02 { get; set; }
        [Display(Name = "تصویر خبر سوم")]
        public string? IndexImage03 { get; set; }

        [Display(Name = "محل ارسال خبر")]
        public byte PlaceNewsID { get; set; }

        [Display(Name = "نوع خبر")]
        public byte NewsType { get; set; }

        //SEO Property
        [Display(Name = "متاتگ ها")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "متاتگ ها وارد نشده است.")]

        public string MetaTag { get; set; }

        [Display(Name = "متای توضیحات")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "متای توضیحات وارد نشده است.")]

        public string MetaDescription { get; set; }
        public byte IsActive { get; set; }

        public string UserID { get; set; }

        [Display(Name = "دسته بندی خبر")]
        public int CategoryID { get; set; }


    }

    public class NewsView_syncModel
    {
        [Key]
        public Nullable<int> NewsId { get; set; }

        [Display(Name = "عنوان خبر")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "عنوان خبر وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        //[Display(Name = "متن خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "متن خبر وارد نشده است.")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Content { get; set; }

        //[Display(Name = " محل وقوع خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "محل وقوع خبر وارد نشده است.")]

        //public string Abstract { get; set; }

        ////[Display(Name = "تعداد بازدید")]
        ////public int VisitCount { get; set; }

        ////[Display(Name = "تاریخ خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ خبر وارد نشده است.")]

        //public string NewsDateSham { get; set; }


        //[Display(Name = "تاریخ خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ خبر وارد نشده است.")]

        //public DateTime NewsDate { get; set; }

        //[Display(Name = "زمان ثبت خبر")]
        //public DateTime NewsTime { get; set; }

        //[Display(Name = "تصویر خبر اول")]
        //public string? IndexImage { get; set; }

        //[Display(Name = "تصویر خبر دوم")]
        //public string? IndexImage02 { get; set; }
        //[Display(Name = "تصویر خبر سوم")]
        //public string? IndexImage03 { get; set; }

        //[Display(Name = "محل ارسال خبر")]
        //public byte PlaceNewsID { get; set; }

        //[Display(Name = "نوع خبر")]
        //public byte NewsType { get; set; }

        ////SEO Property
        //[Display(Name = "متاتگ ها")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "متاتگ ها وارد نشده است.")]

        //public string MetaTag { get; set; }

        //[Display(Name = "متای توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "متای توضیحات وارد نشده است.")]

        //public string MetaDescription { get; set; }
        //public byte IsActive { get; set; }

        //public string UserID { get; set; }

        //[Display(Name = "دسته بندی خبر")]
        //public int CategoryID { get; set; }

    }

}
