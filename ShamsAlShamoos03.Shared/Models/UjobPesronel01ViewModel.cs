using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    //NewsId CategoryID
    public class UjobPesronel01ViewModelcat
    {

        public string filename01 { get; set; }
        public string fileext01 { get; set; }

        public string filename02 { get; set; }
        public string fileext02 { get; set; }

         
        public string UjobPesronel01IDstr { get; set; }

        [Display(Name = "دسته بندی")]
        public string UjobPesronel01ID { get; set; }

        //[Display(Name = "دسته بندی")]
        public string Title { get; set; }

        //[Display(Name = "دسته بندی")]
        public string UserID { get; set; }
        //[Display(Name = "دسته بندی")]
        public string FirstName { get; set; }
        //[Display(Name = "دسته بندی")]
        public string LastName { get; set; }
        //[Display(Name = "دسته بندی")]
        public string MelliCode { get; set; }
        [Display(Name = "دسته بندی")]
        public string FName { get; set; }
        //[Display(Name = "دسته بندی")]
        public string LName { get; set; }

        //[Display(Name = "دسته بندی")]
        public string Rank01 { get; set; }

        //[Display(Name = "دسته بندی")]
        [Display(Name = "تاریخ انتساب")]

        public string StartJobDate { get; set; }
        //[Display(Name = "دسته بندی")]
        public string EndJobDate { get; set; }
        //[Display(Name = "دسته بندی")]

        //public string IsHaveJobFIsHaveJobF { get; set; }

        public bool IsHaveJob { get; set; }

        //public bool IsHaveJobF { get; set; }

        //public bool IsHaveJobT { get; set; }

        public string IsHaveJobstring { get; set; }

        //public string filename01 { get; set; }

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string UserID { get; set; }
        //[Display(Name = "دسته بندی")]
        //[Display(Name = "دسته بندی")]
        [Display(Name = "تاریخ انتساب")]

        public string StartJobDatestr { get; set; }
        //[Display(Name = "دسته بندی")]
        //[Display(Name = "دسته بندی")]
        [Display(Name = "تاریخ عزل")]

        public string EndJobDatestr { get; set; }
        //[Display(Name = "دسته بندی")]
        public string des01 { get; set; }
        //[Display(Name = "دسته بندی")]
        public string des02 { get; set; }
        //[Display(Name = "دسته بندی")]
        public int Sortable01Id { get; set; }

        //public string sort01 { get; set; } = "0";
        //public string sort02 { get; set; } = "0";
        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }
    }

    public class UjobPesronel01ViewModel
    {
         public string UjobPesronel01ID { get; set; }

        public string UserID { get; set; }

        public string MelliCode { get; set; }
 
        public DateTime StartJobDate { get; set; }
        public DateTime EndJobDate { get; set; }
        public bool IsHaveJob { get; set; }

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string UserID { get; set; }
        public string sort01 { get; set; } = "0";
        public string sort02 { get; set; } = "0";
        public string des01 { get; set; } = "0";
        public string des02 { get; set; } = "0";
        public int Sortable01Id { get; set; }  

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }
    }
    public class UjobPesronel01ViewModel11
    {
        public string UjobPesronel01ID { get; set; }

        //public string UserID { get; set; }

        //public string MelliCode { get; set; }

        //public DateTime StartJobDate { get; set; }
        //public DateTime EndJobDate { get; set; }
        //public bool IsHaveJob { get; set; }

        ////[Display(Name = "دسته بندی")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        ////[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        ////public string UserID { get; set; }
        //public string sort01 { get; set; } = "0";
        //public string sort02 { get; set; } = "0";
        //public string des01 { get; set; } = "0";
        //public string des02 { get; set; } = "0";
        //public int Sortable01Id { get; set; }

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }
    }




    //public class NewsImagesListViewModelidEdit
    //{

    //    //public string UserID { get; set; } = "0";
    //    public string NewsImagesID { get; set; }

    //    //public int NewsId { get; set; }
    //    //public int ImagesListId { get; set; }
    //    [Display(Name = "مرتب کردن")]

    //    public int Sortable01Id { get; set; }

    //    //[Display(Name = "دسته بندی")]
    //    //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
    //    //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
    //    //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
    //    //public string UserID { get; set; }
    //    //public string sort01 { get; set; } = "0";
    //    //public string sort02 { get; set; } = "0";
    //    //public string des01 { get; set; } = "0";
    //    //public string des02 { get; set; } = "0";

    //    //[Display(Name = "توضیحات")]
    //    //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
    //    //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
    //    //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
    //    //public string Description { get; set; }
    //}

}
