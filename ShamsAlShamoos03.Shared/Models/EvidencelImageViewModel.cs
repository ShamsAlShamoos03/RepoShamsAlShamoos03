
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class EvidencelImageViewModel
    {
        //public int NewsId { get; set; }

        //[Display(Name = "عنوان خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "عنوان خبر وارد نشده است.")]
        ////[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Title { get; set; }




      
        public int EvidencelImageID { get; set; }

        [Display(Name = "تاریخ")]

        public string PropertyDayID { get; set; }



        [Display(Name = "تصویر مدرک")]
        public string EvidencelImage01 { get; set; }


        [Display(Name = "نام مدرک")]
        public string NameEvidence01 { get; set; }


        //public string DateDaySham { get; set; }
        //[Display(Name = "روز هفته")]

        //public string DateDayWeek { get; set; }


        //[Display(Name = "نوع روز")]

        //public int TypedayID { get; set; }


        //[Display(Name = "تقویم رسمی")]

        //public int IRcalID { get; set; }

        //[Display(Name = "تقویم پایگاه")]

        //public int StatecalID { get; set; }



        //public int Sortable01Id { get; set; }
        //[ForeignKey("Sortable01Id")]

        //public virtual Sortable01 Sortable01 { get; set; }


        //[Display(Name = "ویژگی 1")]
        //public int Prop01ID { get; set; }

        //[Display(Name = "ویژگی 2")]
        //public int Prop02ID { get; set; }

        //[Display(Name = "ویژگی 3")]
        //public int Prop03ID { get; set; }










        //public int GaurdPostID { get; set; }

        //[Display(Name = "نام پست نگهبانی")]
        //public int GaurdPostNameID { get; set; }

        //[Display(Name = "نام پاس")]
        //public int PasID { get; set; }

        //[Display(Name = "نوع پست نگهبانی")]
        //public int GaurdPostTypeID { get; set; }

        //[Display(Name = "نوع تجهیزات")]
        //public int EquipID { get; set; }

        //[Display(Name = "اولویت")]
        //public int Sortable01Id { get; set; }


        //[Display(Name = "ویژگی 1")]
        //public int Prop01ID { get; set; }

        //[Display(Name = "ویژگی 2")]
        //public int Prop02ID { get; set; }

        //[Display(Name = "ویژگی 3")]
        //public int Prop03ID { get; set; }


        //public byte IsActive { get; set; } = 1;













        //[Display(Name = "")]
        //public int VazifeId { get; set; }

        //[Display(Name = "درجه")]
        //public int RankID { get; set; }

        //[Display(Name = "رسته")]
        //public int RastehID { get; set; }

        //[Display(Name = "نام")]
        //public string Fname { get; set; }

        //[Display(Name = "نشان")]
        //public string Lname { get; set; }
        //[Display(Name = "نام پدر")]
        //public string Fathername { get; set; }
        //[Display(Name = "کد پرسنلی")]
        //public string PersonelCode { get; set; }

        //[Display(Name = "تاریخ اعزام")]
        //public DateTime DispatchDate { get; set; }

        //[Display(Name = "تاریخ اعزام")]
        //public string DispatchDateSham { get; set; }
        //[Display(Name = "تاریخ تولد")]
        //public DateTime BirthdayDate { get; set; }
        //[Display(Name = "تاریخ تولد")]
        //public string BirthdayDateSham { get; set; }
        //[Display(Name = "کد ملی")]
        //public string NationalCode { get; set; }

        //[Display(Name = "یگان")]
        //public int UitID { get; set; }

        //[Display(Name = "وضعیت سلامت")]
        //public int HealthID { get; set; }

        //[Display(Name = "تأهل")]
        //public int MariageID { get; set; }



        //[Display(Name = "تعداد فرزند")]
        //public int NoChild { get; set; }

        //[Display(Name = "وضعیت خدمتی")]
        //public int StatusID { get; set; }




        //[Display(Name = "گروه خونی")]
        //public int BloodtypeID { get; set; }

        //[Display(Name = "میزان تحصیلات")]
        //public int DegreeeducationID { get; set; }

        //[Display(Name = "رشته تحصیلی")]
        //public int FieldeducationID { get; set; }

        //[Display(Name = "دین")]
        //public int ReligionID { get; set; }

        //[Display(Name = "مذهب")]
        //public int CultID { get; set; }

        //[Display(Name = "شهر")]
        //public int CityID { get; set; }


        //[Display(Name = "آدرس")]
        //public string Adress { get; set; }

        //[Display(Name = "تلفن همراه")]
        //public string Mobile { get; set; }

        //[Display(Name = "تلفن ثابت")]
        //public string Phone { get; set; }












        //[Display(Name = "تصویر پرسنلی")]
        //public string PersonelImage { get; set; }
        //[Display(Name = "تصویر مدرک 1")]
        //public string EvidencelImage01 { get; set; }
        //[Display(Name = "تصویر مدرک 2")]
        //public string EvidencelImage02 { get; set; }
        //[Display(Name = "تصویر مدرک 3")]
        //public string EvidencelImage03 { get; set; }
        //[Display(Name = "تصویر مدرک 4")]
        //public string EvidencelImage04 { get; set; }

        //[Display(Name = "توضیح 1")]
        //public string Title01 { get; set; } = "";
        //[Display(Name = "توضیح 2")]
        //public string Title02 { get; set; } = "";
        //[Display(Name = "توضیح 3")]
        //public string Title03 { get; set; } = "";
        //[Display(Name = "توضیح 4")]
        //public string Title04 { get; set; } = "";
        //[Display(Name = "توضیح 5")]
        //public string Title05 { get; set; } = "";
        //[Display(Name = "توضیح 6")]
        //public string Title06 { get; set; } = "";
        //[Display(Name = "توضیح 7")]
        //public string Title07 { get; set; } = "";
        //[Display(Name = "توضیح 8")]
        //public string Title08 { get; set; } = "";

        //[Display(Name = "متن خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "متن خبر وارد نشده است.")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Content { get; set; }

        //[Display(Name = "چکیده خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "چکیده خبر وارد نشده است.")]

        //public string Abstract { get; set; }

        ////[Display(Name = "تعداد بازدید")]
        ////public int VisitCount { get; set; }

        ////[Display(Name = "تاریخ خبر")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ خبر وارد نشده است.")]

        //public string NewsDateSham { get; set; }


        //[Display(Name = "تاریخ خبر")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ خبر وارد نشده است.")]

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

        //public string UserID { get; set; }

        //[Display(Name = "دسته بندی خبر")]
        //public int CategoryID { get; set; }

    }
}
