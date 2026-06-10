
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class ListFlightActivity01ViewModelcat
    {
        public int CategoryGeneralId { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150,MinimumLength =4,ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Description { get; set; }


        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public int CategoryGeneralSubId { get; set; }




        /// <summary>
        ///سورتی پرواز
        /// </summary>
        public string? SUMB206Sorties01 { get; set; }
        public string? SUMH209Sorties01 { get; set; }
        public string? SUMB214Sorties01 { get; set; }
        /// <summary>
        ///تعداد مسافر
        /// </summary>
        public string? SUMB206NOPassengers01 { get; set; }
        public string? SUMH209NOPassengers01 { get; set; }
        public string? SUMB214NOPassengers01 { get; set; }
        /// <summary>
        ///تعداد مجروح
        /// </summary>
        public string? SUMB206NOInjured01 { get; set; }
        public string? SUMH209NOInjured01 { get; set; }
        public string? SUMB214NOInjured01 { get; set; }
        /// <summary>
        ///مقدار بار
        /// </summary>
        public string? SUMB206QTCargo01 { get; set; }
        public string? SUMH209QTCargo01 { get; set; }
        public string? SUMB214QTCargo01 { get; set; }
        /// <summary>
        ///مقدار 20 م م
        /// </summary>
        public string? SUMB206QT20MM01 { get; set; }
        public string? SUMH209QT20MM01 { get; set; }
        public string? SUMB214QT20MM01 { get; set; }
        /// <summary>
        ///مقدار راکت
        /// </summary>
        public string? SUMB206QTRocket01 { get; set; }
        public string? SUMH209QTRocket01 { get; set; }
        public string? SUMB214QTRocket01 { get; set; }

        /// <summary>
        ///مقدار سوخت
        /// </summary>
        public string? SUMB206QTFuel01 { get; set; }
        public string? SUMH209QTFuel01 { get; set; }
        public string? SUMB214QTFuel01 { get; set; }

        /// <summary>
        ///مسیر پرواز
        /// </summary>
        public string? FlightPath01 { get; set; }


        [Display(Name = "ساعت پرواز تست 206")]
        public string CountTestTimeB20601 { get; set; }

        [Display(Name = "ساعت پرواز آموزشی 206")]
        public string CountTRAININGTimeB20601 { get; set; }

        [Display(Name = "ساعت پرواز الزامات 206")]
        public string CountREQUIRMENTTimeB20601 { get; set; }

        [Display(Name = "ساعت پرواز کل 206")]
        public string CountTOTALTimeB20601 { get; set; }

        [Display(Name = "ساعت پرواز کل 206")]
        public string CountTOTALTimeB20601018 { get; set; }


        [Display(Name = "ساعت پرواز تست 209")]
        public string CountTestTimeH20901 { get; set; }

        [Display(Name = "ساعت پرواز آموزشی 209")]
        public string CountTRAININGTimeH20901 { get; set; }

        [Display(Name = "ساعت پرواز الزامات 209")]
        public string CountREQUIRMENTTimeH20901 { get; set; }

        [Display(Name = "ساعت پرواز کل 209")]
        public string CountTOTALTimeH20901 { get; set; }

        [Display(Name = "ساعت پرواز کل 209")]
        public string CountTOTALTimeH20901018 { get; set; }




        [Display(Name = "ساعت پرواز تست 214")]
        public string CountTestTimeB21401 { get; set; }

        [Display(Name = "ساعت پرواز آموزشی 214")]
        public string CountTRAININGTimeB21401 { get; set; }

        [Display(Name = "ساعت پرواز الزامات 214")]
        public string CountREQUIRMENTTimeB21401 { get; set; }

        [Display(Name = "ساعت پرواز کل 214")]
        public string CountTOTALTimeB21401 { get; set; }

        [Display(Name = "ساعت پرواز کل 214")]
        public string CountTOTALTimeB21401018 { get; set; }




        //[Display(Name = "ساعت پرواز تست")]
        //public string CountTestTimeB20901 { get; set; }

        [Display(Name = "تعداد فعالیت")]
        public string CountActivity01 { get; set; }

        [Display(Name = "تعداد فعالیت")]
        public string CountActivityB20601 { get; set; }

        [Display(Name = "تعداد فعالیت")]
        public string CountActivityH20901 { get; set; }

        [Display(Name = "تعداد فعالیت")]
        public string CountActivityB21401 { get; set; }
        //public string CountActivity01 { get; set; }

        [Display(Name = "تعداد بالگرد 206")]
        public string CountTailB20601 { get; set; }

        [Display(Name = "تعداد بالگرد 209")]
        public string CountTailH20901 { get; set; }

        [Display(Name = "تعداد بالگرد 214")]
        public string CountTailB21401 { get; set; }


        [Display(Name = "تعداد بالگرد 214")]
        public string CountTailB21401018 { get; set; }


        [Display(Name = "تعداد بالگرد 206")]
        public string CountTailB20601018 { get; set; }

        [Display(Name = "تعداد بالگرد 209")]
        public string CountTailH20901018 { get; set; }

        [Display(Name = "لیست نوع پرواز")]
        public string ListPURPOSE018 { get; set; }
        

        [Display(Name = "شماره بالگرد")]
        public string TailActivity01 { get; set; }

        [Display(Name = "شماره بالگرد")]
        public string TailActivityB20601 { get; set; }

        [Display(Name = "شماره بالگرد")]
        public string TailActivityH20901 { get; set; }

        [Display(Name = "شماره بالگرد")]
        public string TailActivityB21401 { get; set; }

        [Display(Name = "شماره بالگرد")]
        public string HelicopterType { get; set; }



        public int Sortable01PURPOSEId { get; set; }

        [Display(Name = "گروه")]
        public string strCategoryGeneralSub01TitleS { get; set; }

        [Display(Name = "گروه")]
        public string strCategoryGeneralSub02TitleS { get; set; }

        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string strCategoryGeneralSub01Description { get; set; }
        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string strCategoryGeneralSub02Description { get; set; }


        [Display(Name = "مرتب کردن")]
        public int Sortable01Id { get; set; } = 1;
        //[ForeignKey("Sortable01Id")]

        //public virtual Sortable01 Sortable01 { get; set; }

        public byte IsActive { get; set; } = 1;
        [Display(Name = "مرتب کردن")]
        public string SortableTitle01 { get; set; }

        [Display(Name = "گروه بندی 1")]
        public string CategoryGeneralTitle01 { get; set; }

        [Display(Name = "گروه بندی 2")]
        public string CategoryGeneralTitle02 { get; set; }



        //public virtual CategoryGeneralSub ooCategoryGeneralSub { get; set; }




    }




    public class CategoryGeneralLevelViewModelcat
    {
        public int CategoryGeneralId { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150,MinimumLength =4,ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Description { get; set; }



        //[Display(Name = "محل ")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_01 { get; set; } = "1";


        //[Display(Name = "محل 2")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_02 { get; set; } = "1";



        //[Display(Name = "تاریخ شروع")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_01 { get; set; } = "1";



        ////[Display(Name = "تاریخ خاتمه")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_02 { get; set; } = "1";


        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public int CategoryGeneralSubId { get; set; }

        [Display(Name = "مرتب کردن")]
        public int Sortable01Id { get; set; } = 1;

        [Display(Name = "مرتب کردن")]
        public int? ooCategoryGeneralSubId { get; set; }

        //[ForeignKey("Sortable01Id")]

        //public virtual Sortable01 Sortable01 { get; set; }

        public byte IsActive { get; set; } = 1;



        [Display(Name = "مرتب کردن")]
        public string SortableTitle01 { get; set; }

        [Display(Name = "گروه بندی 1")]
        public string CategoryGeneralTitle01 { get; set; }

        [Display(Name = "گروه بندی 2")]
        public string CategoryGeneralTitle02 { get; set; }


        public int? UitID01 { get; set; }
        public string? strUitID01 { get; set; }
        public int? SortstrUitID01 { get; set; }

        /// <summary>
        ///قشر
        /// </summary>

        public int? TblLuLookupSubbId { get; set; }
        public string? TitleTblLuLookupSubbId { get; set; }
        public string? DescriptionstrTblLuLookupSubbId { get; set; }
        public int? SortTblLuLookupSubbId { get; set; }

        /// <summary>
        ///
        /// </summary>

         //public string? strSortable01Id { get; set; }


        [Display(Name = "تعداد لول 1")]
        public string CountLevel1 { get; set; }

   

        [Display(Name = "تعداد لول 3")]
        public string CountLevel3 { get; set; }

        [Display(Name = "عداد لول 5")]
        public string CountLevel5 { get; set; }


        [Display(Name = "تعداد لول 7")]
        public string CountLevel7 { get; set; }


        [Display(Name = "تعداد لول 9")]
        public string CountLevel9 { get; set; }
        public string CountAllLevel { get; set; }

        //public virtual CategoryGeneralSub ooCategoryGeneralSub { get; set; }








        [Display(Name = "تعداد لول 1")]
        public string CountLevel1All { get; set; }



        [Display(Name = "تعداد لول 3")]
        public string CountLevel3All { get; set; }

        [Display(Name = "عداد لول 5")]
        public string CountLevel5All { get; set; }


        [Display(Name = "تعداد لول 7")]
        public string CountLevel7All { get; set; }


        [Display(Name = "تعداد لول 9")]
        public string CountLevel9All { get; set; }
        public string CountAllLevelAll { get; set; }



    }









    public class ListGaurdActivity01ViewModelcat
    {
        public int CategoryGeneralId { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150,MinimumLength =4,ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Description { get; set; }


        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public int CategoryGeneralSubId { get; set; }


        [Display(Name = "تعداد فعالیت")]
        public string CountActivity01 { get; set; }

        [Display(Name = "تعداد فعالیت")]
        public string CountActivityB20601 { get; set; }

        [Display(Name = "تعداد فعالیت")]
        public string CountActivityH20901 { get; set; }

        [Display(Name = "تعداد فعالیت")]
        public string CountActivityB21401 { get; set; }
        //public string CountActivity01 { get; set; }


        [Display(Name = "شماره بالگرد")]
        public string TailActivity01 { get; set; }

        [Display(Name = "شماره بالگرد")]
        public string TailActivityB20601 { get; set; }

        [Display(Name = "شماره بالگرد")]
        public string TailActivityH20901 { get; set; }

        [Display(Name = "شماره بالگرد")]
        public string TailActivityB21401 { get; set; }

        [Display(Name = "شماره بالگرد")]
        public string HelicopterType { get; set; }



        public int Sortable01PURPOSEId { get; set; }

        [Display(Name = "گروه")]
        public string strCategoryGeneralSub01TitleS { get; set; }

        [Display(Name = "گروه")]
        public string strCategoryGeneralSub02TitleS { get; set; }

        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string strCategoryGeneralSub01Description { get; set; }
        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string strCategoryGeneralSub02Description { get; set; }


        [Display(Name = "مرتب کردن")]
        public int Sortable01Id { get; set; } = 1;
        //[ForeignKey("Sortable01Id")]

        //public virtual Sortable01 Sortable01 { get; set; }

        public byte IsActive { get; set; } = 1;
        [Display(Name = "مرتب کردن")]
        public string SortableTitle01 { get; set; }

        [Display(Name = "گروه بندی 1")]
        public string CategoryGeneralTitle01 { get; set; }

        [Display(Name = "گروه بندی 2")]
        public string CategoryGeneralTitle02 { get; set; }



        //public virtual CategoryGeneralSub ooCategoryGeneralSub { get; set; }




    }


    public class CategoryGeneralViewModelcat
    {
        public int CategoryGeneralId { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150,MinimumLength =4,ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Description { get; set; }



        //[Display(Name = "محل ")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_01 { get; set; } = "1";


        //[Display(Name = "محل 2")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_02 { get; set; } = "1";



        //[Display(Name = "تاریخ شروع")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_01 { get; set; } = "1";



        ////[Display(Name = "تاریخ خاتمه")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_02 { get; set; } = "1";


        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public int CategoryGeneralSubId { get; set; }

        [Display(Name = "مرتب کردن")]
        public int Sortable01Id { get; set; } = 1;

        [Display(Name = "مرتب کردن")]
        public int? ooCategoryGeneralSubId { get; set; }   

        //[ForeignKey("Sortable01Id")]

        //public virtual Sortable01 Sortable01 { get; set; }

        public byte IsActive { get; set; } = 1;



        [Display(Name = "مرتب کردن")]
        public string SortableTitle01 { get; set; }

        [Display(Name = "گروه بندی 1")]
        public string CategoryGeneralTitle01 { get; set; }

        [Display(Name = "گروه بندی 2")]
        public string CategoryGeneralTitle02 { get; set; }



        //public virtual CategoryGeneralSub ooCategoryGeneralSub { get; set; }




    }

    public class CategoryGeneralViewModel
    {
        public int CategoryGeneralId { get; set; }

        [Display(Name = "عنوان")]
        [Required(AllowEmptyStrings = false,ErrorMessage ="دسته بندی وارد نشده است.")]
        //[StringLength(150,MinimumLength =4,ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public string Description { get; set; }



        //[Display(Name = "محل ")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_01 { get; set; } = "1";


        //[Display(Name = "محل 2")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Section_02 { get; set; } = "1";



        //[Display(Name = "تاریخ شروع")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_01 { get; set; } = "1";



        ////[Display(Name = "تاریخ خاتمه")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "تاریخ شروع وارد نشده است.")]
        ////[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        ////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Seed_02 { get; set; } = "1";


        [Display(Name = "گروه")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 1, ErrorMessage = "تعداد کاراکترها باید بین 1 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        public int CategoryGeneralSubId { get; set; }

        [Display(Name = "مرتب کردن")]
        public int Sortable01Id { get; set; } = 1;
        //[ForeignKey("Sortable01Id")]

        //public virtual Sortable01 Sortable01 { get; set; }

        public byte IsActive { get; set; } = 1;



        //[Display(Name = "مرتب کردن")]
        //public string SortableTitle01 { get; set; }

        //[Display(Name = "گروه بندی 1")]
        //public string CategoryGeneralTitle01 { get; set; }

        //[Display(Name = "گروه بندی 2")]
        //public string CategoryGeneralTitle02 { get; set; }



        //public virtual CategoryGeneralSub ooCategoryGeneralSub { get; set; }




    }
}
