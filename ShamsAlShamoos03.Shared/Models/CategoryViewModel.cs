
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class CategoryViewModel
    {
        public int CategryId { get; set; }

        [Display(Name ="دسته بندی")]
        [Required(AllowEmptyStrings = false,ErrorMessage ="دسته بندی وارد نشده است.")]
        [StringLength(150,MinimumLength =2,ErrorMessage = "تعداد کاراکترها باید بین 2 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Description { get; set; }

        [Display(Name = "مرتب کردن")]
        public int Sortable01Id { get; set; } = 1;

        [Display(Name = "محل 1")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Section_01 { get; set; }


        [Display(Name = "محل 2")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Section_02 { get; set; }



        [Display(Name = "تاریخ شروع")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Seed_01 { get; set; }



        [Display(Name = "تاریخ خاتمه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Seed_02 { get; set; }


        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public int CategrySubId { get; set; }



    }

    public class CategoryTitleViewModel
    {
        //public int CategryId { get; set; }

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 2, ErrorMessage = "تعداد کاراکترها باید بین 2 تا 150 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }
        //public List<Category> Title { get; set; }
        //public List<> Titlet { get; set; }

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }

        //[Display(Name = "مرتب کردن")]
        //public int Sortable01Id { get; set; } = 1;

        //[Display(Name = "محل 1")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_01 { get; set; }


        //[Display(Name = "محل 2")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_02 { get; set; }



        //[Display(Name = "تاریخ شروع")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_01 { get; set; }



        //[Display(Name = "تاریخ خاتمه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_02 { get; set; }


        //[Display(Name = "گروه")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public int CategrySubId { get; set; }



    }
}
