using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    //NewsId CategoryID
    public class SelectCategorySubViewModel
    {

        //[Display(Name = "تاریخ")]
        public int SelectedID { get; set; }


        //[Display(Name = "پست نگهبانی")]
        public string Title { get; set; }



    }
    public class SelectGuardPostViewModel
    {
 
        //[Display(Name = "تاریخ")]
        public int SelectedID { get; set; }


        //[Display(Name = "پست نگهبانی")]
        public string GuardName { get; set; }

        //[Display(Name = "مشخصات نگهبان")]
        //public int VazifeID { get; set; }


        //public int ImagesListId { get; set; }

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public int CategoryImagesId { get; set; }

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }
    }


    public class SelectPersonnelGuardsViewModel
    {

        //[Display(Name = "تاریخ")]
        public int SelectedID { get; set; }


        //[Display(Name = "پست نگهبانی")]
        public string PersonnelGuardName { get; set; }

       
    }

    public class SelectUnitGuardsViewModel
    {

        //[Display(Name = "تاریخ")]
        public int SelectedID { get; set; }


        //[Display(Name = "یگان نگهبانی")]
        public string UnitGuardName { get; set; }


    }

}
