

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


    public class DailyPlanEvidence01
    {
         [Key]
        public string? DailyPlanEvidence01ID  { get; set; }
        //public int FactorNumber { get; set; }

        /// <summary>
        /// مدت زمان ماندن در پایگاه
        /// </summary>
        public string? TimeFromHistoryTraficPersonal01ID { get; set; }
        /// <summary>
        /// مدت زمان ماندن اضافه در پایگاه در روز
        /// </summary>
        public string? TimeEzafehInDayFromHistoryTraficPersonal01ID { get; set; }
        /// <summary>
        /// مدت زمان ماندن اضافه در پایگاه در ماه
        /// </summary>
        public string? TimeEzafehInMonthFromHistoryTraficPersonal01ID { get; set; }


        /// <summary>
        /// تعداد استراحت نگهبانی و شیفت
        /// </summary>
        public string? NorestAmadegiNegahbani { get; set; }




               public string? NoMorakhasi { get; set; }
       public string? NoMamordoor { get; set; }
       public string? NoMamorNazdik { get; set; }
       public string? NoRestPezeshki { get; set; }
       public string? NoNahast { get; set; }
       public string? NoFarar { get; set; }
       public string? NoEzamBimarestan { get; set; }
       public string? NoEntezarKhedmat { get; set; }
       public string? NoBedonkari { get; set; }
       public string? NoZendan { get; set; }
       public string? NoHazer { get; set; }

















        /// <summary>
        /// تعداد روز تشویقی
        /// </summary>
        public string? RewardDaysCount { get; set; }

        /// <summary>
        /// تعداد روز مرخصی مانده
        /// </summary>
        public string? RemainDaysVacationCount { get; set; }

        /// <summary>
        /// تعداد روز مرخصی سهمیه
        /// </summary>
        public string? TotalVacationDaysCount { get; set; }

        /// <summary>
        /// تعداد روز مرخصی سهمیه
        /// </summary>
        public string? CombinedTotal { get; set; }



        /// <summary>
        ///ای دی فعالیت پروازی 
        /// </summary>
        public string? DailyActivityEvidence01ID { get; set; }
        [ForeignKey("DailyActivityEvidence01ID")]
        public virtual DailyActivityEvidence01 oo_DailyActivityEvidence01ID { get; set; }


        /// <summary>
        ///ای دی مکاتبات پرسنلی 
        /// </summary>
        public string? PersonalCorrespondence01ID { get; set; }
        [ForeignKey("PersonalCorrespondence01ID")]
        public virtual PersonalCorrespondence01 oo_PersonalCorrespondence01ID { get; set; }



        
       


        /// <summary>
        ///  درجه نام و نشان ش کا کد ملی
        /// </summary>
        public string? MelliCode { get; set; }
        [ForeignKey("MelliCode")]
        //[LazyLoad(false)]

        public virtual TblMaster oo_CrewDailyPesronel { get; set; }



        /// <summary>
        ///وضعیت آمار روزانه 
        /// </summary>
        public int? StatAmar01 { get; set; }
        [ForeignKey("StatAmar01")]
        public virtual CategoryGeneral oo_StatAmar01 { get; set; }




        /// <summary>
        ///توضیجات آمار روزانه 
        /// </summary>
        public int? DesAmar01 { get; set; }
        [ForeignKey("DesAmar01")]
        public virtual CategoryGeneral oo_DesAmar01 { get; set; }


        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext01 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext02 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext03 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext04 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext05 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext06 { get; set; }

        /// <summary>
        //تاریخ استراحت نگهبان
        /// </summary>
        public string? DateDesAmar01 { get; set; }
        [ForeignKey("DateDesAmar01")]
        public virtual DateProperty01 oo_DateDesAmar01 { get; set; }

        /// <summary>
        //تاریخ استراحت نگهبان
        /// </summary>
        public string? DateDesAmar02 { get; set; }
        [ForeignKey("DateDesAmar02")]
        public virtual DateProperty01 oo_DateDesAmar02 { get; set; }




        /// <summary>
        /// كد وضعيت از لحاظ خدمت
        /// </summary> type=9
        public string? DUS_COD01 { get; set; }
        [ForeignKey("DUS_COD01")]
        public virtual TblLuLookup? ooDUSCOD01 { get; set; }

        /// <summary>
        /// یگان
        /// </summary>
        public int? UnitID01 { get; set; }
        [ForeignKey("UnitID01")]
        public virtual CategoryGeneral? oo_UnitID01 { get; set; }



        /// <summary>
        /// محل نگهبانی
        /// </summary>
        public int? UitIDGaurd01 { get; set; }
        [ForeignKey("UitIDGaurd01")]
        public virtual CategoryGeneral? oo_tblCategoryGeneralUitGaurd { get; set; }

        /// كد درجه / رتبه
        /// </summary> type=10
        public string? DRJ_COD { get; set; }
        [ForeignKey("DRJ_COD")]
        public virtual TblLuLookup? ooDRJCOD { get; set; }

        ///// <summary>
        /////  محل نگهبانی
        ///// </summary>
        //public int? DailyPost01ID { get; set; }
        //[ForeignKey("DailyPost01ID")]
        //public virtual DailyPost oo_DailyPost01ID { get; set; }


        /// <summary>
        ///  محل نگهبانی
        /// </summary>

        //public int DailyPost01ID { get; set; }
        //public virtual DailyPost? oo_DailyPost01ID { get; set; }


        #region "امضاء کنندگان"


        /// <summary>
        ///01 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel01 { get; set; }
        [ForeignKey("UjobPesronel01")]
        public virtual UjobPesronel01 oo_UjobPesronel01 { get; set; }

        /// <summary>
        ///01 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation01 { get; set; }
        [ForeignKey("StatusConfirmation01")]
        public virtual CategoryGeneral oo_StatusConfirmation01 { get; set; }








        /// <summary>
        ///02 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel02 { get; set; }
        [ForeignKey("UjobPesronel02")]
        public virtual UjobPesronel01 oo_UjobPesronel02 { get; set; }

        /// <summary>
        ///02 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation02 { get; set; }
        [ForeignKey("StatusConfirmation02")]
        public virtual CategoryGeneral oo_StatusConfirmation02 { get; set; }


        /// <summary>
        ///03 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel03 { get; set; }
        [ForeignKey("UjobPesronel03")]
        public virtual UjobPesronel01 oo_UjobPesronel03 { get; set; }

        /// <summary>
        ///03 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation03 { get; set; }
        [ForeignKey("StatusConfirmation03")]
        public virtual CategoryGeneral oo_StatusConfirmation03 { get; set; }


        /// <summary>
        ///04 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel04 { get; set; }
        [ForeignKey("UjobPesronel04")]
        public virtual UjobPesronel01 oo_UjobPesronel04 { get; set; }

        /// <summary>
        ///04 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation04 { get; set; }
        [ForeignKey("StatusConfirmation04")]
        public virtual CategoryGeneral oo_StatusConfirmation04 { get; set; }


        /// <summary>
        ///05 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel05 { get; set; }
        [ForeignKey("UjobPesronel05")]
        public virtual UjobPesronel01 oo_UjobPesronel05 { get; set; }

        /// <summary>
        ///05 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation05 { get; set; }
        [ForeignKey("StatusConfirmation05")]
        public virtual CategoryGeneral oo_StatusConfirmation05 { get; set; }


        /// <summary>
        ///06 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel06 { get; set; }
        [ForeignKey("UjobPesronel06")]
        public virtual UjobPesronel01 oo_UjobPesronel06 { get; set; }

        /// <summary>
        ///06 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation06 { get; set; }
        [ForeignKey("StatusConfirmation06")]
        public virtual CategoryGeneral oo_StatusConfirmation06 { get; set; }


        /// <summary>
        ///07 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel07 { get; set; }
        [ForeignKey("UjobPesronel07")]
        public virtual UjobPesronel01 oo_UjobPesronel07 { get; set; }

        /// <summary>
        ///07 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation07 { get; set; }
        [ForeignKey("StatusConfirmation07")]
        public virtual CategoryGeneral oo_StatusConfirmation07 { get; set; }


        /// <summary>
        ///08 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel08 { get; set; }
        [ForeignKey("UjobPesronel08")]
        public virtual UjobPesronel01 oo_UjobPesronel08 { get; set; }

        /// <summary>
        ///08 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation08 { get; set; }
        [ForeignKey("StatusConfirmation08")]
        public virtual CategoryGeneral oo_StatusConfirmation08 { get; set; }


        /// <summary>
        ///09 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel09 { get; set; }
        [ForeignKey("UjobPesronel09")]
        public virtual UjobPesronel01 oo_UjobPesronel09 { get; set; }

        /// <summary>
        ///09 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation09 { get; set; }
        [ForeignKey("StatusConfirmation09")]
        public virtual CategoryGeneral oo_StatusConfirmation09 { get; set; }


        /// <summary>
        ///10 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel10 { get; set; }
        [ForeignKey("UjobPesronel10")]
        public virtual UjobPesronel01 oo_UjobPesronel10 { get; set; }

        /// <summary>
        ///10 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation10 { get; set; }
        [ForeignKey("StatusConfirmation10")]
        public virtual CategoryGeneral oo_StatusConfirmation10 { get; set; }



        /// <summary>
        ///11 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel11 { get; set; }
        [ForeignKey("UjobPesronel11")]
        public virtual UjobPesronel01 oo_UjobPesronel11 { get; set; }

        /// <summary>
        ///11 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation11 { get; set; }
        [ForeignKey("StatusConfirmation11")]
        public virtual CategoryGeneral oo_StatusConfirmation11 { get; set; }




        /// <summary>
        ///12 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel12 { get; set; }
        [ForeignKey("UjobPesronel12")]
        public virtual UjobPesronel01 oo_UjobPesronel12 { get; set; }

        /// <summary>
        ///12 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation12 { get; set; }
        [ForeignKey("StatusConfirmation12")]
        public virtual CategoryGeneral oo_StatusConfirmation12 { get; set; }

        #endregion
        
        /// <summary>
        ///  ترتیب
        /// </summary>
        public int? Sortable01Id { get; set; }
        [ForeignKey("Sortable01Id")]
        public virtual Sortable01 Sortable01 { get; set; }


        /// <summary>
        /// متن نوتم 01
        /// </summary>
        public string? NOTAMCHECKETitle01 { get; set; }

        /// <summary>
        /// متن نوتم 02
        /// </summary>
        public string? NOTAMCHECKETitle02 { get; set; }

        /// <summary>
        /// متن نوتم 03
        /// </summary>
        public string? NOTAMCHECKETitle03 { get; set; }



        /// <summary>
        /// تاریخ آخرین ویرایش یا ارسال توسط یگان
        /// </summary>
        public DateTime? TimeSignatureOREditYagen01 { get; set; }

        [NotMapped]
        public DateTime? newTimeSignatureOREditYagen01
        {

            get
            {
                return TimeSignatureOREditYagen01?.AddHours(-1); // یک ساعت از مقدار اصلی کم می‌کند

            }
        }
        /// <summary>
        ///  فعال غیر فعال
        /// </summary>
        public bool? IsHaveJob { get; set; }

 


}
