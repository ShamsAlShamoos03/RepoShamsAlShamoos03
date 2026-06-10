using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShamsAlShamoos03.Shared.Models
{
    public class UsersViewModel01
    {
        public string UserID { get; set; }
        //public bool IsActive { get; set; }
        public byte IsActive { get; set; }
        public string IsActivestr { get; set; }


        public string EMP_NUM { get; set; }
        public string DarajeeID { get; set; }
        public string Darajee { get; set; }
        public string RasteeID { get; set; }
        public string Rastee { get; set; }
       
        public string Mobile { get; set; }
        public string Title { get; set; }
        public string PersonImage { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام کاربری وارد نشده است.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "کلمه عبور وارد نشده است.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "کلمه عبور وارد نشده است.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "رمز عبور با تکرار آن یکسان نیست")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "سمت")]
        public int SematID { get; set; }

        [Display(Name = "یگان")]
        public int YeganID { get; set; }

        [Display(Name = "شعبه")]
        public int ShobehID { get; set; }

        [Display(Name = "درجه")]
        public int RateID { get; set; }



        [Display(Name = "سمت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "سمت وارد نشده است.")]
        public string FirstName { get; set; }

        [Display(Name = "شعبه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شعبه وارد نشده است.")]
        public string LastName { get; set; }

        [Display(Name = "جنسیت")]
        public byte gender { get; set; }

        [Display(Name = "شماره تماس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شماره تماس وارد نشده است.")]
        //[StringLength(11, MinimumLength = 11, ErrorMessage = "شماره تماس 11 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره تماس شامل حرف نمی تواند باشد")]
        public string PhoneNumber { get; set; }

        //[Display(Name = "شماره ملی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "شماره ملی وارد نشده است.")]
        //[StringLength(10, MinimumLength = 10, ErrorMessage = "شماره ملی 11 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره ملی شامل حرف نمی تواند باشد")]
        //public string Melicode { get; set; }

        [Display(Name = "یگان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "یگان وارد نشده است.")]
        //[StringLength(8, MinimumLength = 8, ErrorMessage = "شماره کارگزینی 8 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره کارگزینی شامل حرف نمی تواند باشد")]
        public string PersonalCode { get; set; }

        [Display(Name = "توضیحات  ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "توضیحات وارد گردد")]
        public string TextRequest { get; set; }


        //[Display(Name = "ایمیل")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "ایمیل وارد نشده است.")]
        //public string Email { get; set; }

        [Display(Name = "تصویر")]
        public string? ImagePath { get; set; } = "userdefault.png";

        //[Display(Name = "تاریخ تولد")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ تولد وارد نشده است.")]
        //public DateTime BirthDayDate { get; set; }
        [Display(Name = "نام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام وارد نشده است.")]

        public string FName { get; set; }
        [Display(Name = "نشان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نشان وارد نشده است.")]

        public string LName { get; set; }
        [Display(Name = "درجه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]

        public string Rate { get; set; }

        [Display(Name = "شماره کارگزینی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شماره کارگزینی وارد نشده است.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "شماره کارگزینی 8 رقمی می باشد")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "شماره کارگزینی شامل حرف نمی تواند باشد")]

        public string Personelcodes { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]
        public string JobsLevel { get; set; }


        [Display(Name = "کد ملی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]
        public string MelliCodeID { get; set; }
        public string Sortable013d { get; set; }




    }

    public class UsersViewModel
    {
        //public string Id { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام کاربری وارد نشده است.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "کلمه عبور وارد نشده است.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "کلمه عبور وارد نشده است.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "رمز عبور با تکرار آن یکسان نیست")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "سمت")]
        public int SematID { get; set; }

        [Display(Name = "یگان")]
        public int YeganID { get; set; }

        [Display(Name = "شعبه")]
        public int ShobehID { get; set; }

        [Display(Name = "درجه")]
        public int RateID { get; set; }



        [Display(Name = "سمت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "سمت وارد نشده است.")]
        public string FirstName { get; set; }

        [Display(Name = "شعبه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شعبه وارد نشده است.")]
        public string LastName { get; set; }

        [Display(Name = "جنسیت")]
        public byte gender { get; set; }

        [Display(Name = "شماره تماس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شماره تماس وارد نشده است.")]
        //[StringLength(11, MinimumLength = 11, ErrorMessage = "شماره تماس 11 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره تماس شامل حرف نمی تواند باشد")]
        public string PhoneNumber { get; set; }

        //[Display(Name = "شماره ملی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "شماره ملی وارد نشده است.")]
        //[StringLength(10, MinimumLength = 10, ErrorMessage = "شماره ملی 11 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره ملی شامل حرف نمی تواند باشد")]
        //public string Melicode { get; set; }

        [Display(Name = "یگان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "یگان وارد نشده است.")]
        //[StringLength(8, MinimumLength = 8, ErrorMessage = "شماره کارگزینی 8 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره کارگزینی شامل حرف نمی تواند باشد")]
        public string PersonalCode { get; set; }

        [Display(Name = "توضیحات  ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "توضیحات وارد گردد")]
        public string TextRequest { get; set; }


        //[Display(Name = "ایمیل")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "ایمیل وارد نشده است.")]
        //public string Email { get; set; }

        [Display(Name = "تصویر")]
        public string? ImagePath { get; set; } = "userdefault.png";

        //[Display(Name = "تاریخ تولد")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ تولد وارد نشده است.")]
        //public DateTime BirthDayDate { get; set; }
        [Display(Name = "نام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام وارد نشده است.")]

        public string FName { get; set; }
        [Display(Name = "نشان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نشان وارد نشده است.")]

        public string LName { get; set; }
        [Display(Name = "درجه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]

        public string Rate { get; set; }

        [Display(Name = "شماره کارگزینی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شماره کارگزینی وارد نشده است.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "شماره کارگزینی 8 رقمی می باشد")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "شماره کارگزینی شامل حرف نمی تواند باشد")]

        public string Personelcodes { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]
        public string JobsLevel { get; set; }


        [Display(Name = "کد ملی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]
        public string MelliCodeID { get; set; }
        public string Sortable013d { get; set; }

         


    }

    public class EditUserViewModel 
    {
        public string Id { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام کاربری وارد نشده است.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        public string UserName { get; set; }
        //public string MelliCodeID { get; set; }

        //[Display(Name = "کلمه عبور")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "کلمه عبور وارد نشده است.")]
        //[StringLength(50, MinimumLength = 6, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[Display(Name = "تکرار کلمه عبور")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "کلمه عبور وارد نشده است.")]
        //[StringLength(50, MinimumLength = 6, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "رمز عبور با تکرار آن یکسان نیست")]
        //public string ConfirmPassword { get; set; }

        [Display(Name = "سمت")]
        public int SematID { get; set; }

        [Display(Name = "یگان")]
        public int YeganID { get; set; }

        [Display(Name = "شعبه")]
        public int ShobehID { get; set; }

        [Display(Name = "درجه")]
        public int RateID { get; set; }



        [Display(Name = "سمت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "سمت وارد نشده است.")]
        public string FirstName { get; set; }

        [Display(Name = "شعبه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شعبه وارد نشده است.")]
        public string LastName { get; set; }

        [Display(Name = "جنسیت")]
        public byte gender { get; set; }

        [Display(Name = "شماره تماس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شماره تماس وارد نشده است.")]
        //[StringLength(11, MinimumLength = 11, ErrorMessage = "شماره تماس 11 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره تماس شامل حرف نمی تواند باشد")]
        public string PhoneNumber { get; set; }

        //[Display(Name = "شماره ملی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "شماره ملی وارد نشده است.")]
        //[StringLength(10, MinimumLength = 10, ErrorMessage = "شماره ملی 11 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره ملی شامل حرف نمی تواند باشد")]
        //public string Melicode { get; set; }

        [Display(Name = "یگان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "یگان وارد نشده است.")]
        //[StringLength(8, MinimumLength = 8, ErrorMessage = "شماره کارگزینی 8 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره کارگزینی شامل حرف نمی تواند باشد")]
        public string PersonalCode { get; set; }

        [Display(Name = "توضیحات  ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "توضیحات وارد گردد")]
        public string TextRequest { get; set; }


        //[Display(Name = "ایمیل")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "ایمیل وارد نشده است.")]
        //public string Email { get; set; }

        [Display(Name = "تصویر")]
        public string? ImagePath { get; set; } = "userdefault.png";

        //[Display(Name = "تاریخ تولد")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ تولد وارد نشده است.")]
        //public DateTime BirthDayDate { get; set; }
        [Display(Name = "نام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام وارد نشده است.")]

        public string FName { get; set; }
        [Display(Name = "نشان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نشان وارد نشده است.")]

        public string LName { get; set; }
        [Display(Name = "درجه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]

        public string Rate { get; set; }

        [Display(Name = "شماره کارگزینی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شماره کارگزینی وارد نشده است.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "شماره کارگزینی 8 رقمی می باشد")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "شماره کارگزینی شامل حرف نمی تواند باشد")]

        public string Personelcodes { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]
        public string JobsLevel { get; set; }


        [Display(Name = "کد ملی")]
        //[Required(AllowEmptyStrings = true, ErrorMessage = "درجه وارد نشده است.")]
        public string MelliCodeID { get; set; }
        public string Sortable013d { get; set; }




    }



    public class EditUserViewModelEditMelicode
    {
        public string Id { get; set; }

         

        [Display(Name = "کد ملی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]
        public string MelliCodeID { get; set; }
        



    }

    public class EditUserViewModel1
    {
        public string Id { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام کاربری وارد نشده است.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "تعداد کاراکترها باید بین 5 تا 50 حرف باشد")]
        public string UserName { get; set; }

        [Display(Name = "سمت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "سمت وارد نشده است.")]
        public string FirstName { get; set; }


        [Display(Name = "شعبه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شعبه وارد نشده است.")]
        public string LastName { get; set; }





        [Display(Name = "سمت")]
        public int SematID { get; set; }

        [Display(Name = "یگان")]
        public int YeganID { get; set; }

        [Display(Name = "شعبه")]
        public int ShobehID { get; set; }

        [Display(Name = "درجه")]
        public int RateID { get; set; }



        [Display(Name = "جنسیت")]
        public byte gender { get; set; }

        [Display(Name = "شماره تماس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شماره تماس وارد نشده است.")]
        //[StringLength(11, MinimumLength = 11, ErrorMessage = "شماره تماس 11 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره تماس شامل حرف نمی تواند باشد")]
        public string PhoneNumber { get; set; }

        //[Display(Name = "شماره ملی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "شماره ملی وارد نشده است.")]
        //[StringLength(10, MinimumLength = 10, ErrorMessage = "شماره ملی 11 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره ملی شامل حرف نمی تواند باشد")]
        //public string Melicode { get; set; }


        [Display(Name = "یگان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "یگان وارد نشده است.")]
        //[StringLength(8, MinimumLength = 8, ErrorMessage = "شماره کارگزینی 8 رقمی می باشد")]
        //[RegularExpression("^[0-9]*$", ErrorMessage = "شماره کارگزینی شامل حرف نمی تواند باشد")]
        public string PersonalCode { get; set; }


        [Display(Name = "توضیحات  ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "توضیحات وارد گردد")]
        public string TextRequest { get; set; }


        //[Display(Name = "ایمیل")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "ایمیل وارد نشده است.")]
        //public string Email { get; set; }

        [Display(Name = "تصویر")]
        public string? ImagePath { get; set; }

        //[Display(Name = "تاریخ تولد")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ تولد وارد نشده است.")]
        //public DateTime BirthDayDate { get; set; }
        [Display(Name = "نام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام وارد نشده است.")]

        public string FName { get; set; }
        [Display(Name = "نشان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نشان وارد نشده است.")]

        public string LName { get; set; }
        [Display(Name = "درجه")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "درجه وارد نشده است.")]

        public string Rate { get; set; }

        [Display(Name = "شماره کارگزینی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "شماره کارگزینی وارد نشده است.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "شماره کارگزینی 8 رقمی می باشد")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "شماره کارگزینی شامل حرف نمی تواند باشد")]

        public string Personelcodes { get; set; }
    }


    public class LoginViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "نام کاربری وارد نشده است.")]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "کلمه عبور وارد نشده است.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "مرا بخاطر بسپار")]
        public bool RememberMe { get; set; }

        //[Display(Name = "کد ملی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "نام کاربری وارد نشده است.")]
        //public string MelliCodeID { get; set; }
        //public string MelliCodeIDSub { get; set; }

    }

    public class UserRolesViewModel
    {
        public string RoleName { get; set; }
        //public bool IsSelected { get; set; }
    }
    public class ChangePasswordByAdminViewModel
    {
        [Display(Name = "رمز عبور جدید")]
        public string NewPassword { get; set; }

        [Display(Name = "تکرار رمز عبور جدید")]
        public string ConfirmNewPassword { get; set; }

        public string userId { get; set; }
    }

}
