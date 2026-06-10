using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    //NewsId CategoryID

    public class CheckUsersCategoryViewModelid
    {
        //public string UserID { get; set; } = "0";
        public int CategryId { get; set; }
        public string Title { get; set; }

        public int CategrySubId { get; set; }
        public string TitleSub { get; set; }

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string UserID { get; set; }
        //public string sort01 { get; set; } = "0";
        //public string sort02 { get; set; } = "0";
        //public string des01 { get; set; } = "0";
        //public string des02 { get; set; } = "0";

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }
    }

    public class UsersCategorySubViewModel
    {
        public int CategrySubId { get; set; }
        public int Sortable01Id { get; set; }

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string UserID { get; set; }
        public string sort01 { get; set; } = "0";
        public string sort02 { get; set; } = "0";
        public string des01 { get; set; } = "0";
        public string des02 { get; set; } = "0";

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }
    }

    public class UsersCategorySubViewModelid
    {
        public string UserID { get; set; } = "0";
        public int CategrySubId { get; set; }
        public int Sortable01Id { get; set; }

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string UserID { get; set; }
        public string sort01 { get; set; } = "0";
        public string sort02 { get; set; } = "0";
        public string des01 { get; set; } = "0";
        public string des02 { get; set; } = "0";

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }
    }

}
