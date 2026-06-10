using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    //NewsId CategoryID

    public class ImagesListCategoryImagesListViewModel
    {
        public int ImagesListId { get; set; }
        public string HaveNewsimages { get; set; }
        public string HaveNewsimagesDates { get; set; }

        public string IndexImage { get; set; }
        public string CategoryImagesListTitle { get; set; }
        public string CategoryImagesListNewsDateSham { get; set; }

        

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public int CategoryImagesId { get; set; }

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }
    }

}
