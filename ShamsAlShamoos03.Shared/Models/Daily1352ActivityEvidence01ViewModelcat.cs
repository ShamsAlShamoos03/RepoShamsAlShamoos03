
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

    public class Daily1352ActivityEvidence01IDViewModelcat
    {

        public string Daily1352ActivityEvidence01ID { get; set; }
    }
    public class Daily1352ActivityEvidence01ViewModelcat
    {
        /// <summary>
        ///01 کد ملی ثبت کننده
        /// </summary>
        public string? RegisterPesronel01 { get; set; }
        public string? RegisterPesronel01strJobTitle { get; set; }
        public string? RegisterPesronel01strJobTitleN { get; set; }

        public string? strUnitID01 { get; set; }
        public int? UnitID01 { get; set; }


        public string? Daily1352ActivityEvidence01IDStateName01 { get; set; }



        public int? TimwStartEnd01 { get; set; }
        public string? strTimwStart01 { get; set; }
        public string? strTimwEnd01 { get; set; }

        public string? strDateCategory01 { get; set; }


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



        //public string UjobPesronel01IDstr { get; set; }

        [Display(Name = "دسته بندی")]
        public string Daily1352ActivityEvidence01ID { get; set; }
        public string Daily1352ActivityEvidence01IDstr { get; set; }

        public string Daily1352ActivityEvidence01IDstr3 { get; set; }
        public string Daily1352ActivityEvidence01IDstr4 { get; set; }
        public string Daily1352ActivityEvidence01IDstr5 { get; set; }
        public string Daily1352ActivityEvidence01IDstr6 { get; set; }
        public string ResaultStandCheckRamainDay01 { get; set; }



        //============================

        /// <summary>
        ///   
        /// </summary>
        //public string MelliCode { get; set; }


        ///// <summary>
        /////  سطح آزمون
        ///// </summary>
        //public int? LevelExam { get; set; }
        //public string? LevelExamstr { get; set; }




         
        ///// <summary>
        /////  شماره بالگرد 
        ///// </summary>
        //public string? TailHelicopter { get; set; }

        /// <summary>
        ///  ساعت اعلان هوا 
        /// </summary>
        //public string? TimeWeather { get; set; }

        /// <summary>
        /// نام پایگاه  
        /// </summary>
        public int? StateName01 { get; set; }
        public string? StateName01str { get; set; }


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







        ///// <summary>
        /////  گرید 
        ///// </summary>
        //public string? Grade { get; set; }

        ///// <summary>
        /////  عنوان مدرک
        ///// </summary>
        //public int? HealthEvidenceTitle { get; set; }
        //public string? HealthEvidenceTitlestr { get; set; }

        ///// <summary>
        ///// روز باقیمانده تا تاریخ شروع
        ///// </summary>
        //public string? FromDateDaily1352ActivityEvidence01TitleRamainDay01 { get; set; }
        ///// <summary>
        /////  روز باقیمانده تا تاریخ خاتمه
        ///// </summary>
        //public string? ToDateDaily1352ActivityEvidence01TitleRamainDay01 { get; set; }

        /// <summary>
        /// تاریخ شروع
        /// </summary>
        public string? FromDateDaily1352ActivityEvidence01Title { get; set; }
        ///// <summary>
        /////  تاریخ خاتمه
        ///// </summary>
        public string? ToDateDaily1352ActivityEvidence01Title { get; set; }


        /// <summary>
        ///  فعال غیر فعال
        /// </summary>
        public bool IsHaveJob { get; set; }
        public string IsHaveJobstring { get; set; }

        /// <summary>
        ///  ترتیب
        /// </summary>
        [Display(Name = "ترتیب")]
        public int? Sortable01Id { get; set; }
        public string SortableTitle01 { get; set; }

        /// <summary>
        ///  وضعیت هوا
        /// </summary>
        public int? StatusDaily1352ActivityEvidence01 { get; set; }
        public string? StatusDaily1352ActivityEvidence01str { get; set; }



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




        public string UjobPesronel05strPlan { get; set; }
        public string UjobPesronel05strPlanMelicode { get; set; }
        public string UjobPesronel05strPlanDarajee { get; set; }
        public string UjobPesronel05strPlanFirstName { get; set; }
        public string UjobPesronel05strPlanLastName { get; set; }
        public string UjobPesronel05strPlanEMP_NUM { get; set; }
        public string UjobPesronel05strPlanJobTitle { get; set; }
        public string UjobPesronel05strPlanJobTitleN { get; set; }
        public string UjobPesronel05strPlanFirstNameEN { get; set; }
        public string UjobPesronel05strPlanLastNameEN { get; set; }



 







        ///// <summary>
        /////  آزمون دهنده
        ///// </summary>
        //public string PersonImageMelliCodeExamer { get; set; }


        ///// <summary>
        /////  آزمون گیرنده
        ///// </summary>
        //public string? MelliCodeExamer { get; set; }
        ///// <summary>
        /////  تاریخ اخذ آزمون کتبی
        ///// </summary>
        //public string? DateExamWritten { get; set; }
        //public string? MelliCodeExamerstr { get; set; }

        ///// <summary>
        /////  گرید کتبی
        ///// </summary>
        //public string? WrittenGrade { get; set; }

        ///// <summary>
        /////  گرید کتبی آزمایشی
        ///// </summary>
        //public string? WrittenTPGrade { get; set; }


        ///// <summary>
        /////  گرید اضطراری
        ///// </summary>
        //public string? EmargencylimitationGrade { get; set; }
        ///// <summary>
        /////  گرید مقررات محلی پروازی
        ///// </summary>
        //public string? SOPLOPGrade { get; set; }
        ///// <summary>
        ///  قبول مردود
        /// </summary>
        //public int? Status01 { get; set; }
        ///// <summary>
        /////  ISSUE Revalidate
        /////  آزمون اولیه تمدید اعتبار
        ///// </summary>

        //public int? ISSUERevalidateID { get; set; }

        ///// <summary>
        /////  آزمون عادی یا تست
        ///// </summary>

        //public int? TPorNormalID { get; set; }

        //public string? Status01str { get; set; }
        //public string? ISSUERevalidateIDstr { get; set; }
        //public string? TPorNormalIDstr { get; set; }



        ///////////استندچک عملی/////استندچک عملی//////////استندچک عملی
        /////// <summary>
        ///////  نام استاد
        /////// </summary>
        ////public string? MelliCodeInstructor { get; set; }
        /////// <summary>
        ///////  تاریخ استندچک
        /////// </summary>
        ////public string? DateStandCheck { get; set; }


        ///// <summary>
        ///// گرید پروازی
        ///// </summary>
        //public string? GradeStatusDaily { get; set; }

        ///// <summary>
        /////  قبول مردود استندچک
        ///// </summary>
        //public int? Status01StandCheck { get; set; }

        ///// <summary>
        /////  تاریخ استندچک آزمایشی
        ///// </summary>
        //public string? DateStandCheckTP { get; set; }
        ///// <summary>
        ///// گرید خلبان آزمایشی
        ///// </summary>
        //public string? GradeStatusTP { get; set; }

        ///// <summary>
        /////  قبول مردود استندچک آزمایشی
        ///// </summary>
        //public int? Status01StandCheckTP { get; set; }

        /////////استندچک عملی/////استندچک عملی//////////استندچک عملی

        //public string? MelliCodeInstructorstr { get; set; }
        //public string? Status01StandCheckstr { get; set; }
        //public string? Status01StandCheckTPstr { get; set; }


        ///// <summary>
        ///// وضعیت نتیجه استند چک
        ///// </summary>
        //public int? ResaultStatus01StandCheck { get; set; }

        ///// <summary>
        ///// وضعیت نتیجه استند چک
        ///// </summary>
        //public string? ResaultStatus01StandCheckstr { get; set; }

        ///// <summary>
        ///// متن نتیجه استند چک
        ///// </summary>
        //public string? ResaultStandCheck { get; set; }




        ////=============================


        ////[Display(Name = "دسته بندی")]
        ////public string Title { get; set; }

        //////[Display(Name = "دسته بندی")]
        ////public string UserID { get; set; }
        //////[Display(Name = "دسته بندی")]
        ////public string FirstName { get; set; }
        //////[Display(Name = "دسته بندی")]
        ////public string LastName { get; set; }
        //////[Display(Name = "دسته بندی")]
        //public string Title { get; set; }
        //public string Darajee { get; set; }
        //public string DRJ_NAMGheshr1 { get; set; }
        //public string DRJ_NAMGheshr2  { get; set; }
        //public int DarajeeGheshrID { get; set; }
        //public string FName { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string LName { get; set; }

        ////[Display(Name = "دسته بندی")]
        //public string Rank01 { get; set; }

        //public string DarajeeEN { get; set; }
        //public string EMP_NUM { get; set; }
        //public string FstNamEN { get; set; }
        //public string LstNamEN { get; set; }



        ////public string FName { get; set; }
        //////[Display(Name = "دسته بندی")]
        ////public string LName { get; set; }

        //////[Display(Name = "دسته بندی")]
        ////public string Rank01 { get; set; }

        //[Display(Name = "عنوان مدرک")]
        //public int EvidenceDailyTitle { get; set; }
        //public string EvidenceDailyTitlestr { get; set; }

        //[Display(Name = "تاریخ شروع مدرک")]

        //public string DateSrartEvidenceDailyTitle { get; set; }
        //[Display(Name = "تاریخ خاتمه مدرک")]
        //public string DateEndEvidenceDailyTitle { get; set; }

        //[Display(Name = "دسته بندی")]
        //public int Rate { get; set; }
        //public string Ratestr { get; set; }
        //public string RatestrFa { get; set; }


        //[Display(Name = "دسته بندی")]
        //public int TypeRateID { get; set; }
        //public string TypeRatestr { get; set; }

        //public string TypeRatestrTypeRatestr { get; set; }


        //[Display(Name = "دسته بندی")]
        //public int TypeAC { get; set; }
        //public string TypeACstr { get; set; }
        //public string TypeACstrAll { get; set; }


        //[Display(Name = "دسته بندی")]
        //public string IsHaveJobFIsHaveJobF { get; set; }

        public string IsPortrait01 { get; set; }
        public string IsPortrait02 { get; set; }
        public string IsPortrait03 { get; set; }
        public string IsPortrait04 { get; set; }
        public string IsPortrait05 { get; set; }
        public string IsPortrait06 { get; set; }
        //public string Title01 { get; set; }

        //public string PersonImage { get; set; }













        public int? countDailyPlans01Ready { get; set; }

        public int? YearsOFWorks { get; set; }

        public int? YearsOFOld { get; set; }

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
        /// </summary>
        public string? MelliCode { get; set; }




        public int? DarajeeGheshrID { get; set; }


        public string? Darajee { get; set; }

        public int? TypeLetter01 { get; set; }
        public int TypeLetter01111 { get; set; }

        public string? strTypeLetter01 { get; set; }
        public string? strTextContent01 { get; set; }
        //public string? strTextContent02 { get; set; }

        public string? StrPayvarVazifeh01 { get; set; }
        public string? StrPayvarVazifeh02 { get; set; }
        public string? StrPayvarVazifeh03 { get; set; }

        public string? strUitID01 { get; set; }






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

       

    }





}
