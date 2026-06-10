
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    //NewsId CategoryID

    
    public class Daily1352PARTPlanEvidence01ViewModelcat
    {
        [Display(Name = "دسته بندی")]
        public string? Daily1352PARTPlanEvidence01ID { get; set; }
        //public string? DrjDailyPLookupSubId { get; set; }
        public int? Sortable01Id { get; set; }


        public string? CurrentDate01 { get; set; }
        public string? NOTAMCHECKETitle01Activitystr { get; set; }
        public string? Daily1352ActivityEvidence01ID { get; set; }

        public string? FromDateDailyActivityEvidence01Title { get; set; }

        public int? YearsOFWorks { get; set; }

        public int? YearsOFOld { get; set; }
        public string? EMP_DAT { get; set; }

        //public bool ValidEMP_DAT;
        //public bool ValidBRT_COD;

        public int? ValidEMP_DAT { get; set; }
        public int? ValidBRT_COD { get; set; }

        /// <summary>
        ///تعداد ایام تعطیل
        /// </summary>
        public string? CountDatelHoliday01 { get; set; }


        /// <summary>
        ///تعداد ایام تعطیل
        /// </summary>
        public string? CountVacatiaonWitoutHoliday { get; set; }

        ///ای دی مکاتبات پرسنلی 
        /// </summary>
        public string? PersonalCorrespondence01ID { get; set; }
        public string? DateDesAmar01PersonalCorrespondence01ID { get; set; }
        public string? DateDesAmar02PersonalCorrespondence01ID { get; set; }
        public int? DesAmar01PersonalCorrespondence01ID { get; set; }
         /// <summary>
        ///وضعیت آمار روزانه روز قبل  
        /// </summary>
        public int? LastStatAmar01 { get; set; }
        public int? LastStatAmar00 { get; set; }


        //[ForeignKey("PersonalCorrespondence01ID")]
        //public virtual PersonalCorrespondence01 oo_PersonalCorrespondence01ID { get; set; }



        public string? BRT_DAT { get; set; }

        public string? DocumentNO01 { get; set; }

        public string? StrPayvarVazifeh01 { get; set; }
        public string? StrPayvarVazifeh02 { get; set; }
        public string? StrPayvarVazifeh03 { get; set; }
        public string? persianWeekDate01 { get; set; }


        /// <summary>
        /// نام پایگاه  
        /// </summary>
        public int? StateName01 { get; set; }
        public string? StateName01str { get; set; }


        public int? TimwStartEnd01 { get; set; }
        public string? strTimwStart01 { get; set; }
        public string? strTimwEnd01 { get; set; }

        public string? strDateCategory01 { get; set; }
        public string? DifDateDesAmar02DateDesAmar01 { get; set; }

        public string? DifDateDesAmar02DateDesAmar01Personal { get; set; }



        /// <summary>
        ///  بررسی وجود تصویر در پوشه
        /// </summary>
        public bool? IsPersonelImage { get; set; }
        /// <summary>
        ///  بررسی وجود امضا لاتین در پوشه
        /// </summary>
        public bool? IsSignatureEn { get; set; }
        /// <summary>
        ///  بررسی وجود امضا فارسی در پوشه
        /// </summary>
        public bool? IsSignatureFa { get; set; }

        /// <summary>
        /// سمت
        /// </summary>
        public int? ISFatmandeYeganGhesmat01 { get; set; }
        public string? strISFatmandeYeganGhesmat01 { get; set; }
        public int? sort01SFatmandeYeganGhesmat01 { get; set; }

        public int? SubISFatmandeYeganGhesmat01 { get; set; }
        public string? SubstrISFatmandeYeganGhesmat01 { get; set; }

        public string? Darajee { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public int? DRJ_CODSort { get; set; }

        /// <summary>
        /// یگان
        /// </summary>
        public int? UitID01 { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public string? strUitID01 { get; set; }


        /// <summary>
        /// وضعیت آمار
        /// </summary>
        public int? StatAmar01 { get; set; }
        /// <summary>
        /// وضعیت آمار
        /// </summary>
        public string? strStatAmar01 { get; set; }
        public string? strSortStatAmar01 { get; set; }


        /// <summary>
        /// توضیح آمار
        /// </summary>
        public int? DesAmar01 { get; set; }
        /// <summary>
        /// وضعیت آمار
        /// </summary>
        public string? strDesAmar01 { get; set; }

        /// <summary>
        /// وضعیت آمار
        /// </summary>
        public string? strDesAmar01PersonalCorrespondence01ID { get; set; }

        public string? DateDesAmar01 { get; set; }
        public string? DateDesAmar02 { get; set; }

        /// <summary>
        /// تاریخ 
        /// </summary>

        public string? Date01 { get; set; }
        public string? Date02 { get; set; }
        public string? WeekDate01 { get; set; }
        public string? SortDateDarajeGheshr01 { get; set; }



        #region "مربوط به سابقه انفرادی"


        ///// <summary>
        ///// یگان
        ///// </summary>
        //public int? UitID01Doc { get; set; }
        ///// <summary>
        ///// یگان
        ///// </summary>
        //public string? strUitID01Doc { get; set; }


        ///// <summary>
        ///// وضعیت آمار
        ///// </summary>
        //public int? StatAmar01Doc { get; set; }
        ///// <summary>
        ///// وضعیت آمار
        ///// </summary>
        //public string? strStatAmar01Doc { get; set; }
        //public string? strSortStatAmar01Doc { get; set; }


        ///// <summary>
        ///// توضیح آمار
        ///// </summary>
        //public int? DesAmar01Doc { get; set; }
        ///// <summary>
        ///// وضعیت آمار
        ///// </summary>
        //public string? strDesAmar01Doc { get; set; }


        //public string? DateDesAmar01Doc { get; set; }
        //public string? DateDesAmar02Doc { get; set; }

        ///// <summary>
        ///// تاریخ 
        ///// </summary>

        //public string? Date01Doc { get; set; }
        //public string? WeekDate01Doc { get; set; }



        #endregion


        #region "روز های مربوط به آمار"


        /// <summary>
        /// وضعیت آمار
        /// </summary>
        public string? Day01 { get; set; }
        public int? StatAmar01Day01 { get; set; }
        public string? strStatAmar01Day01 { get; set; }
        public string? strSortStatAmar01Day01 { get; set; }
        public int? DesAmar01Day01 { get; set; }
        public string? strDesAmar01Day01 { get; set; }
        public string? DateDesAmar01Day01 { get; set; }
        public string? DateDesAmar02Day01 { get; set; }
        public int? UitID01Day01 { get; set; }
        public string? strUitID01Day01 { get; set; }


        #endregion


        /// <summary>
        /// یگان
        /// </summary>
        public int? UitIDGaurd01 { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public string? strUitIDGaurd01 { get; set; }




        public int DarajeeGheshrID { get; set; }

        [Display(Name = "دسته بندی")]
        public int TypeRateID { get; set; }
        public string TypeRatestr { get; set; }

        public string TypeRatestrTypeRatestr { get; set; }



        [Display(Name = "قشر")]
        public string? DRJ_CODSTR01 { get; set; }

        [Display(Name = "قشر")]
        public string? DRJ_NAMGheshr1 { get; set; }


        [Display(Name = "پایور/وظیفه")]
        public string? DRJ_NAMGheshr2 { get; set; }


        //[Key]
        //public string? PersonID { get; set; }
        /// <summary>
        /// شماره پرسنلی
        /// </summary>
        [Display(Name = "شماره کارگزینی")]
        public string? EMP_NUM { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        [Display(Name = "نام")]
        public string? FST_NAM { get; set; }
        /// <summary>
        /// نام خانوادگی
        /// </summary>
        [Display(Name = "نام خانوادگی")]
        public string? LST_NAM { get; set; }

        ///// <summary>
        ///// كد درجه / رتبه
        ///// </summary> type=10
        [Display(Name = "درجه")]

        public string? DRJ_COD { get; set; }
        ////[ForeignKey("DRJ_COD")]
        ////public virtual TblLuLookup _DRJ_COD { get; set; }

        [Display(Name = "رسته")]
        public string? RST_COD { get; set; }
        //public string? RST_NAM { get; set; }

        public string? DRJ_NAM { get; set; }
        public string? RST_NAM { get; set; }

        public string? MelliCode { get; set; }
        public string? DUS_COD { get; set; }
        public string? DUS_NAM { get; set; }


        //public string UjobPesronel01IDstr { get; set; }



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
        ///  فعال غیر فعال
        /// </summary>
        public bool IsHaveJob { get; set; }

         


        public string IsHaveJobstring { get; set; }


        #region "مربوط به امضاء کنندگان فعالیت"




        /// <summary>
        ///01 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel01Activity { get; set; }
        //public string? UjobPesronel01strActivity { get; set; }

        /// <summary>
        ///01 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation01Activity { get; set; }
        public string? StatusConfirmation01strActivity { get; set; }



        /// <summary>
        ///02 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel02Activity { get; set; }
        //public string? UjobPesronel02strActivity { get; set; }

        /// <summary>
        ///02 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation02Activity { get; set; }
        public string? StatusConfirmation02strActivity { get; set; }



        /// <summary>
        ///03 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel03Activity { get; set; }
        //public string? UjobPesronel03strActivity { get; set; }

        /// <summary>
        ///03 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation03Activity { get; set; }
        public string? StatusConfirmation03strActivity { get; set; }



        /// <summary>
        ///04 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel04Activity { get; set; }
        //public string? UjobPesronel04strActivity { get; set; }

        /// <summary>
        ///04 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation04Activity { get; set; }
        public string? StatusConfirmation04strActivity { get; set; }



        /// <summary>
        ///05 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel05Activity { get; set; }
        //public string? UjobPesronel05strActivity { get; set; }

        /// <summary>
        ///05 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation05Activity { get; set; }
        public string? StatusConfirmation05strActivity { get; set; }



        /// <summary>
        ///06 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel06Activity { get; set; }
        //public string? UjobPesronel06strActivity { get; set; }

        /// <summary>
        ///06 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation06Activity { get; set; }
        public string? StatusConfirmation06strActivity { get; set; }



        /// <summary>
        ///07 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel07Activity { get; set; }
        //public string? UjobPesronel07strActivity { get; set; }

        /// <summary>
        ///07 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation07Activity { get; set; }
        public string? StatusConfirmation07strActivity { get; set; }



        /// <summary>
        ///08 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel08Activity { get; set; }
        //public string? UjobPesronel08strActivity { get; set; }

        /// <summary>
        ///08 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation08Activity { get; set; }
        public string? StatusConfirmation08strActivity { get; set; }



        /// <summary>
        ///09 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel09Activity { get; set; }
        //public string? UjobPesronel09strActivity { get; set; }

        /// <summary>
        ///09 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation09Activity { get; set; }
        public string? StatusConfirmation09strActivity { get; set; }



        /// <summary>
        ///10 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel10Activity { get; set; }
        //public string? UjobPesronel10strActivity { get; set; }

        /// <summary>
        ///10 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation10Activity { get; set; }
        public string? StatusConfirmation10strActivity { get; set; }




        /// <summary>
        ///11 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel11Activity { get; set; }
        //public string? UjobPesronel11strActivity { get; set; }

        /// <summary>
        ///11 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation11Activity { get; set; }
        public string? StatusConfirmation11strActivity { get; set; }






        /// <summary>
        ///12 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel12Activity { get; set; }
        //public string? UjobPesronel12strActivity { get; set; }

        /// <summary>
        ///12 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation12Activity { get; set; }
        public string? StatusConfirmation12strActivity { get; set; }


















        public string UjobPesronel01strActivity { get; set; }
        public string UjobPesronel02strActivity { get; set; }
        public string UjobPesronel03strActivity { get; set; }
        public string UjobPesronel04strActivity { get; set; }
        public string UjobPesronel05strActivity { get; set; }
        public string UjobPesronel06strActivity { get; set; }
        public string UjobPesronel07strActivity { get; set; }
        public string UjobPesronel08strActivity { get; set; }
        public string UjobPesronel09strActivity { get; set; }
        public string UjobPesronel10strActivity { get; set; }
        public string UjobPesronel11strActivity { get; set; }
        public string UjobPesronel12strActivity { get; set; }


        public string UjobPesronel01strActivityMelicode { get; set; }
        public string UjobPesronel02strActivityMelicode { get; set; }
        public string UjobPesronel03strActivityMelicode { get; set; }
        public string UjobPesronel04strActivityMelicode { get; set; }
        public string UjobPesronel05strActivityMelicode { get; set; }
        public string UjobPesronel06strActivityMelicode { get; set; }
        public string UjobPesronel07strActivityMelicode { get; set; }
        public string UjobPesronel08strActivityMelicode { get; set; }
        public string UjobPesronel09strActivityMelicode { get; set; }
        public string UjobPesronel10strActivityMelicode { get; set; }
        public string UjobPesronel11strActivityMelicode { get; set; }
        public string UjobPesronel12strActivityMelicode { get; set; }

        public string UjobPesronel01strActivityDarajee { get; set; }
        public string UjobPesronel02strActivityDarajee { get; set; }
        public string UjobPesronel03strActivityDarajee { get; set; }
        public string UjobPesronel04strActivityDarajee { get; set; }
        public string UjobPesronel05strActivityDarajee { get; set; }
        public string UjobPesronel06strActivityDarajee { get; set; }
        public string UjobPesronel07strActivityDarajee { get; set; }
        public string UjobPesronel08strActivityDarajee { get; set; }
        public string UjobPesronel09strActivityDarajee { get; set; }
        public string UjobPesronel10strActivityDarajee { get; set; }
        public string UjobPesronel11strActivityDarajee { get; set; }
        public string UjobPesronel12strActivityDarajee { get; set; }

        public string UjobPesronel01strActivityFirstName { get; set; }
        public string UjobPesronel02strActivityFirstName { get; set; }
        public string UjobPesronel03strActivityFirstName { get; set; }
        public string UjobPesronel04strActivityFirstName { get; set; }
        public string UjobPesronel05strActivityFirstName { get; set; }
        public string UjobPesronel06strActivityFirstName { get; set; }
        public string UjobPesronel07strActivityFirstName { get; set; }
        public string UjobPesronel08strActivityFirstName { get; set; }
        public string UjobPesronel09strActivityFirstName { get; set; }
        public string UjobPesronel10strActivityFirstName { get; set; }
        public string UjobPesronel11strActivityFirstName { get; set; }
        public string UjobPesronel12strActivityFirstName { get; set; }


        public string UjobPesronel01strActivityFirstNameEN { get; set; }
        public string UjobPesronel02strActivityFirstNameEN { get; set; }
        public string UjobPesronel03strActivityFirstNameEN { get; set; }
        public string UjobPesronel04strActivityFirstNameEN { get; set; }
        public string UjobPesronel05strActivityFirstNameEN { get; set; }
        public string UjobPesronel06strActivityFirstNameEN { get; set; }
        public string UjobPesronel07strActivityFirstNameEN { get; set; }
        public string UjobPesronel08strActivityFirstNameEN { get; set; }
        public string UjobPesronel09strActivityFirstNameEN { get; set; }
        public string UjobPesronel10strActivityFirstNameEN { get; set; }
        public string UjobPesronel11strActivityFirstNameEN { get; set; }
        public string UjobPesronel12strActivityFirstNameEN { get; set; }


        public string UjobPesronel01strActivityLastName { get; set; }
        public string UjobPesronel02strActivityLastName { get; set; }
        public string UjobPesronel03strActivityLastName { get; set; }
        public string UjobPesronel04strActivityLastName { get; set; }
        public string UjobPesronel05strActivityLastName { get; set; }
        public string UjobPesronel06strActivityLastName { get; set; }
        public string UjobPesronel07strActivityLastName { get; set; }
        public string UjobPesronel08strActivityLastName { get; set; }
        public string UjobPesronel09strActivityLastName { get; set; }
        public string UjobPesronel10strActivityLastName { get; set; }
        public string UjobPesronel11strActivityLastName { get; set; }
        public string UjobPesronel12strActivityLastName { get; set; }


        public string UjobPesronel01strActivityLastNameEN { get; set; }
        public string UjobPesronel02strActivityLastNameEN { get; set; }
        public string UjobPesronel03strActivityLastNameEN { get; set; }
        public string UjobPesronel04strActivityLastNameEN { get; set; }
        public string UjobPesronel05strActivityLastNameEN { get; set; }
        public string UjobPesronel06strActivityLastNameEN { get; set; }
        public string UjobPesronel07strActivityLastNameEN { get; set; }
        public string UjobPesronel08strActivityLastNameEN { get; set; }
        public string UjobPesronel09strActivityLastNameEN { get; set; }
        public string UjobPesronel10strActivityLastNameEN { get; set; }
        public string UjobPesronel11strActivityLastNameEN { get; set; }
        public string UjobPesronel12strActivityLastNameEN { get; set; }


        public string UjobPesronel01strActivityEMP_NUM { get; set; }
        public string UjobPesronel02strActivityEMP_NUM { get; set; }
        public string UjobPesronel03strActivityEMP_NUM { get; set; }
        public string UjobPesronel04strActivityEMP_NUM { get; set; }
        public string UjobPesronel05strActivityEMP_NUM { get; set; }
        public string UjobPesronel06strActivityEMP_NUM { get; set; }
        public string UjobPesronel07strActivityEMP_NUM { get; set; }
        public string UjobPesronel08strActivityEMP_NUM { get; set; }
        public string UjobPesronel09strActivityEMP_NUM { get; set; }
        public string UjobPesronel10strActivityEMP_NUM { get; set; }
        public string UjobPesronel11strActivityEMP_NUM { get; set; }
        public string UjobPesronel12strActivityEMP_NUM { get; set; }


        public string UjobPesronel01strActivityJobTitle { get; set; }
        public string UjobPesronel02strActivityJobTitle { get; set; }
        public string UjobPesronel03strActivityJobTitle { get; set; }
        public string UjobPesronel04strActivityJobTitle { get; set; }
        public string UjobPesronel05strActivityJobTitle { get; set; }
        public string UjobPesronel06strActivityJobTitle { get; set; }
        public string UjobPesronel07strActivityJobTitle { get; set; }
        public string UjobPesronel08strActivityJobTitle { get; set; }
        public string UjobPesronel09strActivityJobTitle { get; set; }
        public string UjobPesronel10strActivityJobTitle { get; set; }
        public string UjobPesronel11strActivityJobTitle { get; set; }
        public string UjobPesronel12strActivityJobTitle { get; set; }

        public string UjobPesronel01strActivityJobTitleN { get; set; }
        public string UjobPesronel02strActivityJobTitleN { get; set; }
        public string UjobPesronel03strActivityJobTitleN { get; set; }
        public string UjobPesronel04strActivityJobTitleN { get; set; }
        public string UjobPesronel05strActivityJobTitleN { get; set; }
        public string UjobPesronel06strActivityJobTitleN { get; set; }
        public string UjobPesronel07strActivityJobTitleN { get; set; }
        public string UjobPesronel08strActivityJobTitleN { get; set; }
        public string UjobPesronel09strActivityJobTitleN { get; set; }
        public string UjobPesronel10strActivityJobTitleN { get; set; }
        public string UjobPesronel11strActivityJobTitleN { get; set; }
        public string UjobPesronel12strActivityJobTitleN { get; set; }



        #endregion

        #region "مربوط به امضاء کنندگان پلن"




        /// <summary>
        ///01 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel01 { get; set; }
        public string? UjobPesronel01str { get; set; }

        /// <summary>
        ///01 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation01 { get; set; }
        public string? StatusConfirmation01str { get; set; }



        /// <summary>
        ///02 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel02 { get; set; }
        public string? UjobPesronel02str { get; set; }

        /// <summary>
        ///02 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation02 { get; set; }
        public string? StatusConfirmation02str { get; set; }



        /// <summary>
        ///03 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel03 { get; set; }
        public string? UjobPesronel03str { get; set; }

        /// <summary>
        ///03 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation03 { get; set; }
        public string? StatusConfirmation03str { get; set; }



        /// <summary>
        ///04 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel04 { get; set; }
        public string? UjobPesronel04str { get; set; }

        /// <summary>
        ///04 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation04 { get; set; }
        public string? StatusConfirmation04str { get; set; }



        /// <summary>
        ///05 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel05 { get; set; }
        public string? UjobPesronel05str { get; set; }

        /// <summary>
        ///05 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation05 { get; set; }
        public string? StatusConfirmation05str { get; set; }



        /// <summary>
        ///06 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel06 { get; set; }
        public string? UjobPesronel06str { get; set; }

        /// <summary>
        ///06 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation06 { get; set; }
        public string? StatusConfirmation06str { get; set; }



        /// <summary>
        ///07 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel07 { get; set; }
        public string? UjobPesronel07str { get; set; }

        /// <summary>
        ///07 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation07 { get; set; }
        public string? StatusConfirmation07str { get; set; }



        /// <summary>
        ///08 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel08 { get; set; }
        public string? UjobPesronel08str { get; set; }

        /// <summary>
        ///08 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation08 { get; set; }
        public string? StatusConfirmation08str { get; set; }



        /// <summary>
        ///09 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel09 { get; set; }
        public string? UjobPesronel09str { get; set; }

        /// <summary>
        ///09 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation09 { get; set; }
        public string? StatusConfirmation09str { get; set; }



        /// <summary>
        ///10 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel10 { get; set; }
        public string? UjobPesronel10str { get; set; }

        /// <summary>
        ///10 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation10 { get; set; }
        public string? StatusConfirmation10str { get; set; }




        /// <summary>
        ///11 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel11 { get; set; }
        public string? UjobPesronel11str { get; set; }

        /// <summary>
        ///11 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation11 { get; set; }
        public string? StatusConfirmation11str { get; set; }






        /// <summary>
        ///12 کد ملی تأیید کننده
        /// </summary>
        public string? UjobPesronel12 { get; set; }
        public string? UjobPesronel12str { get; set; }

        /// <summary>
        ///12 وضعیت تأیید 
        /// </summary>
        public int? StatusConfirmation12 { get; set; }
        public string? StatusConfirmation12str { get; set; }


        public string UjobPesronel01strMelicode { get; set; }
        public string UjobPesronel02strMelicode { get; set; }
        public string UjobPesronel03strMelicode { get; set; }
        public string UjobPesronel04strMelicode { get; set; }
        public string UjobPesronel05strMelicode { get; set; }
        public string UjobPesronel06strMelicode { get; set; }
        public string UjobPesronel07strMelicode { get; set; }
        public string UjobPesronel08strMelicode { get; set; }
        public string UjobPesronel09strMelicode { get; set; }
        public string UjobPesronel10strMelicode { get; set; }
        public string UjobPesronel11strMelicode { get; set; }
        public string UjobPesronel12strMelicode { get; set; }

        public string UjobPesronel01strDarajee { get; set; }
        public string UjobPesronel02strDarajee { get; set; }
        public string UjobPesronel03strDarajee { get; set; }
        public string UjobPesronel04strDarajee { get; set; }
        public string UjobPesronel05strDarajee { get; set; }
        public string UjobPesronel06strDarajee { get; set; }
        public string UjobPesronel07strDarajee { get; set; }
        public string UjobPesronel08strDarajee { get; set; }
        public string UjobPesronel09strDarajee { get; set; }
        public string UjobPesronel10strDarajee { get; set; }
        public string UjobPesronel11strDarajee { get; set; }
        public string UjobPesronel12strDarajee { get; set; }

        public string UjobPesronel01strFirstName { get; set; }
        public string UjobPesronel02strFirstName { get; set; }
        public string UjobPesronel03strFirstName { get; set; }
        public string UjobPesronel04strFirstName { get; set; }
        public string UjobPesronel05strFirstName { get; set; }
        public string UjobPesronel06strFirstName { get; set; }
        public string UjobPesronel07strFirstName { get; set; }
        public string UjobPesronel08strFirstName { get; set; }
        public string UjobPesronel09strFirstName { get; set; }
        public string UjobPesronel10strFirstName { get; set; }
        public string UjobPesronel11strFirstName { get; set; }
        public string UjobPesronel12strFirstName { get; set; }


        public string UjobPesronel01strFirstNameEN { get; set; }
        public string UjobPesronel02strFirstNameEN { get; set; }
        public string UjobPesronel03strFirstNameEN { get; set; }
        public string UjobPesronel04strFirstNameEN { get; set; }
        public string UjobPesronel05strFirstNameEN { get; set; }
        public string UjobPesronel06strFirstNameEN { get; set; }
        public string UjobPesronel07strFirstNameEN { get; set; }
        public string UjobPesronel08strFirstNameEN { get; set; }
        public string UjobPesronel09strFirstNameEN { get; set; }
        public string UjobPesronel10strFirstNameEN { get; set; }
        public string UjobPesronel11strFirstNameEN { get; set; }
        public string UjobPesronel12strFirstNameEN { get; set; }


        public string UjobPesronel01strLastName { get; set; }
        public string UjobPesronel02strLastName { get; set; }
        public string UjobPesronel03strLastName { get; set; }
        public string UjobPesronel04strLastName { get; set; }
        public string UjobPesronel05strLastName { get; set; }
        public string UjobPesronel06strLastName { get; set; }
        public string UjobPesronel07strLastName { get; set; }
        public string UjobPesronel08strLastName { get; set; }
        public string UjobPesronel09strLastName { get; set; }
        public string UjobPesronel10strLastName { get; set; }
        public string UjobPesronel11strLastName { get; set; }
        public string UjobPesronel12strLastName { get; set; }


        public string UjobPesronel01strLastNameEN { get; set; }
        public string UjobPesronel02strLastNameEN { get; set; }
        public string UjobPesronel03strLastNameEN { get; set; }
        public string UjobPesronel04strLastNameEN { get; set; }
        public string UjobPesronel05strLastNameEN { get; set; }
        public string UjobPesronel06strLastNameEN { get; set; }
        public string UjobPesronel07strLastNameEN { get; set; }
        public string UjobPesronel08strLastNameEN { get; set; }
        public string UjobPesronel09strLastNameEN { get; set; }
        public string UjobPesronel10strLastNameEN { get; set; }
        public string UjobPesronel11strLastNameEN { get; set; }
        public string UjobPesronel12strLastNameEN { get; set; }
        public string UjobPesronel01strEMP_NUM { get; set; }
        public string UjobPesronel02strEMP_NUM { get; set; }
        public string UjobPesronel03strEMP_NUM { get; set; }
        public string UjobPesronel04strEMP_NUM { get; set; }
        public string UjobPesronel05strEMP_NUM { get; set; }
        public string UjobPesronel06strEMP_NUM { get; set; }
        public string UjobPesronel07strEMP_NUM { get; set; }
        public string UjobPesronel08strEMP_NUM { get; set; }
        public string UjobPesronel09strEMP_NUM { get; set; }
        public string UjobPesronel10strEMP_NUM { get; set; }
        public string UjobPesronel11strEMP_NUM { get; set; }
        public string UjobPesronel12strEMP_NUM { get; set; }


        public string UjobPesronel01strJobTitle { get; set; }
        public string UjobPesronel02strJobTitle { get; set; }
        public string UjobPesronel03strJobTitle { get; set; }
        public string UjobPesronel04strJobTitle { get; set; }
        public string UjobPesronel05strJobTitle { get; set; }
        public string UjobPesronel06strJobTitle { get; set; }
        public string UjobPesronel07strJobTitle { get; set; }
        public string UjobPesronel08strJobTitle { get; set; }
        public string UjobPesronel09strJobTitle { get; set; }
        public string UjobPesronel10strJobTitle { get; set; }
        public string UjobPesronel11strJobTitle { get; set; }
        public string UjobPesronel12strJobTitle { get; set; }

        public string UjobPesronel01strJobTitleN { get; set; }
        public string UjobPesronel02strJobTitleN { get; set; }
        public string UjobPesronel03strJobTitleN { get; set; }
        public string UjobPesronel04strJobTitleN { get; set; }
        public string UjobPesronel05strJobTitleN { get; set; }
        public string UjobPesronel06strJobTitleN { get; set; }
        public string UjobPesronel07strJobTitleN { get; set; }
        public string UjobPesronel08strJobTitleN { get; set; }
        public string UjobPesronel09strJobTitleN { get; set; }
        public string UjobPesronel10strJobTitleN { get; set; }
        public string UjobPesronel11strJobTitleN { get; set; }
        public string UjobPesronel12strJobTitleN { get; set; }

        #endregion

        #region "مربوط به بارگذاری مدرک"
        public string Daily1352PARTPlanEvidence01IDstr { get; set; }

        public string Daily1352PARTPlanEvidence01IDstr3 { get; set; }
        public string Daily1352PARTPlanEvidence01IDstr4 { get; set; }
        public string Daily1352PARTPlanEvidence01IDstr5 { get; set; }
        public string Daily1352PARTPlanEvidence01IDstr6 { get; set; }




        public string filename01 { get; set; }
        public string fileext01 { get; set; }

        public string filename02 { get; set; }
        public string fileext02 { get; set; }


        public string filename03 { get; set; }
        public string fileext03 { get; set; }

        public string filename04 { get; set; }
        public string fileext04 { get; set; }

        public string filename05 { get; set; }
        public string fileext05 { get; set; }

        public string filename06 { get; set; }
        public string fileext06 { get; set; }


        public string IsPortrait01 { get; set; }
        public string IsPortrait02 { get; set; }
        public string IsPortrait03 { get; set; }
        public string IsPortrait04 { get; set; }
        public string IsPortrait05 { get; set; }
        public string IsPortrait06 { get; set; }

        #endregion
        //public string Title01 { get; set; }

        //public string PersonImage { get; set; }
        /// <summary>
        /// تاریخ آخرین ویرایش یا ارسال توسط یگان
        /// </summary>
        public DateTime? TimeSignatureOREditYagen01 { get; set; }
        public DateTime? newTimeSignatureOREditYagen01 { get; set; }



        #region "مربوط به _DialogEditPartial "





        public int? countDailyPlans01Ready { get; set; }

 

        public string? VarDate01 { get; set; }
        public string? VarDate02 { get; set; }
        public string? VarDate03 { get; set; }
        public string? VarDate04 { get; set; }
        public string? VarDate05 { get; set; }
        public string? VarDate06 { get; set; }


        public int? SubjectLetter01 { get; set; }
        public int? strVariabl01 { get; set; }
        public int? strVariabl02 { get; set; }
        public int? strVariabl03 { get; set; }
        public int? strVariabl04 { get; set; }
        public int? strVariabl05 { get; set; }
        public int? strVariabl06 { get; set; }






        public int? Title { get; set; }
        public string? CategoryGeneralId { get; set; }



        /// <summary>
        ///  درجه نام و نشان ش کا کد ملی
 

        public int? TypeLetter01 { get; set; }
        public int TypeLetter01111 { get; set; }

        public string? strTypeLetter01 { get; set; }
        public string? strTextContent01 { get; set; }
        //public string? strTextContent02 { get; set; }

 






        public int Value { get; set; }
        public string Text { get; set; }



        public int OrderID { get; set; }
        public int CustomerID { get; set; }

        public int EmployeeID { get; set; }

        public string CustomerName { get; set; }
        public string City { get; set; }
        public DateTime? OrderDate { get; set; }

        public int Id { get; set; }

        public string Gender { get; set; }
        public bool Language1 { get; set; }

        public bool Language2 { get; set; }
        public bool Language3 { get; set; }



        #endregion

    }





}
