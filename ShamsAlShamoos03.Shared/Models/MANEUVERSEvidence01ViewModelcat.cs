
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

    
    public class MANEUVERSEvidence01ViewModelcat
    {
        public string SubId { get; set; }
        public TimeSpan? TotalTime { get; set; }


        public int? PURPOSEOFFLTDispatch { get; set; }
        public string? PURPOSEOFFLTDispatchstr { get; set; }
        public string? PURPOSEOFFLTDispatchstrFA { get; set; }

        /// <summary>
        ///ریت خلبان یکم 
        /// </summary>
        public int? Rate01 { get; set; }
        public string? Rate01str { get; set; }
        public string? Rate01strFA { get; set; }
         
        /// <summary>
        ///ریت خلبان دوم 
        /// </summary>
        public int? Rate02 { get; set; }
        public string? Rate02str { get; set; }
        public string? Rate02strFA { get; set; }

        /// <summary>
        ///مدل بالکرد 
        /// </summary>
        public int? ModelAc { get; set; }
        public string? ModelAcstr { get; set; }
        public string? ModelAcstrFA { get; set; }


        public string? HelicopterType { get; set; }
        public string? HelicopterTail { get; set; }
        public string? PURPOSEOFFLTstrFA { get; set; }
        public string? FLTAREAstrFA { get; set; }


        public TimeSpan? ETDTimeSpan { get; set; }
        public TimeSpan? ETETimeSpan { get; set; }


        public DateTime? ETDDateTime { get; set; }
        public DateTime? ETEDateTime { get; set; }

        public string? ADFstr { get; set; }
        public string? ALTstr { get; set; }
        public string? ATISstr { get; set; }
        public string? CALLSIGNstr { get; set; }
        //public string? ETDstr { get; set; }
        //public string? ETEstr { get; set; }
        public string? FLTAREAstr { get; set; }
        public string? FMGstr { get; set; }
        public string? PURPOSEOFFLTstr { get; set; }
        public string? RADARstr { get; set; }
        public string? UHFstr { get; set; }
        public string? UHFGstr { get; set; }
        public string? VHFstr { get; set; }
        public string? VHFGstr { get; set; }
        public string? VORstr { get; set; }

         
        public int? ADF { get; set; }
        public int? ALT { get; set; }
        public int? ATIS { get; set; }
        public int? CALLSIGN { get; set; }
        public string? ETD { get; set; }
        public string? ETDstr { get; set; }
        public string? ETE { get; set; }
        public string? ETEstr { get; set; }
        public int? FLTAREA { get; set; }
        public int? FMG { get; set; }
        public int? PURPOSEOFFLT { get; set; }
        public int? RADAR { get; set; }
        public string? SerialNOPlan { get; set; }
        public int? UHF { get; set; }
        public int? UHFG { get; set; }
        public int? VHF { get; set; }
        public int? VHFG { get; set; }
        public int? VOR { get; set; }
        public int? STATION { get; set; }
        public string? FlightActivityEvidence01ID { get; set; }
        public string? HelicopterTailEvidence01 { get; set; }
        public string? WeatherEvidence01ID { get; set; }
        public string? FromDateFlightActivityEvidence01Title { get; set; }
        public string? ToDateFlightActivityEvidence01Title { get; set; }
        //public string? FLTAREANOTAMCHECK { get; set; }
        public string? StatusFlightActivityEvidence01 { get; set; }
        //public string? NOTAMCHECKETitle01 { get; set; }
        //public string? NOTAMCHECKETitle02 { get; set; }
        //public string? NOTAMCHECKETitle03 { get; set; }

        public bool? HoverFLT { get; set; }
        public bool? SidwardFLT { get; set; }
        public bool? BackwardFLT { get; set; }
        public bool? NormalTO { get; set; }
        public bool? IGEcheck { get; set; }
        public bool? OGEcheck { get; set; }
        public bool? NormalAPP { get; set; }
        public bool? SteepAPP { get; set; }
        public bool? MaxTO { get; set; }
        public bool? APP180 { get; set; }
        public bool? MinpowerTO { get; set; }
        public bool? Internalload { get; set; }
        public bool? Externalload { get; set; }
        public bool? ConfindOPS { get; set; }
        public bool? PinnacleOPS { get; set; }
        public bool? SLOPOPS { get; set; }
        public bool? LOLEELFLT { get; set; }
        public bool? Lowlevelflt { get; set; }

        public bool? NOEFLT { get; set; }
        public bool? FMDFOPS { get; set; }
        public bool? Pricaurionarylanding { get; set; }
        public bool? Forcedlanding { get; set; }
        public bool? SingleENG { get; set; }
        public bool? HYDMAL { get; set; }
        public bool? ManualGOVOPS { get; set; }
        public bool? Runinglanding { get; set; }
        public bool? HoveringAUTO { get; set; }
        public bool? StandardAUTO { get; set; }
        public bool? LowlevelAUTO { get; set; }
        public bool? AUTOTWP { get; set; }
        public bool? AUTO180 { get; set; }
        public bool? WaterOPS { get; set; }
        public bool? gunnery { get; set; }
        public bool? HoodFLT { get; set; }
        public bool? INSTFLT { get; set; }
        public bool? AntiTorqueFailure { get; set; }





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
        public string MANEUVERSEvidence01ID { get; set; }
        public string MANEUVERSEvidence01IDstr { get; set; }

        public string MANEUVERSEvidence01IDstr3 { get; set; }
        public string MANEUVERSEvidence01IDstr4 { get; set; }
        public string MANEUVERSEvidence01IDstr5 { get; set; }
        public string MANEUVERSEvidence01IDstr6 { get; set; }
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
        /// منطقه پروازی 
        /// </summary>
        public int? FLTAREANOTAMCHECK { get; set; }
        public string? FLTAREANOTAMCHECKstr { get; set; }


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
        //public string? FromDateMANEUVERSEvidence01TitleRamainDay01 { get; set; }
        ///// <summary>
        /////  روز باقیمانده تا تاریخ خاتمه
        ///// </summary>
        //public string? ToDateMANEUVERSEvidence01TitleRamainDay01 { get; set; }

        /// <summary>
        /// تاریخ شروع
        /// </summary>
        public string? FromDateMANEUVERSEvidence01Title { get; set; }
        ///// <summary>
        /////  تاریخ خاتمه
        ///// </summary>
        public string? ToDateMANEUVERSEvidence01Title { get; set; }


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
        public int? StatusMANEUVERSEvidence01 { get; set; }
        public string? StatusMANEUVERSEvidence01str { get; set; }



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
        //public string? GradeStatusFlight { get; set; }

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
        //public int EvidenceFlightTitle { get; set; }
        //public string EvidenceFlightTitlestr { get; set; }

        //[Display(Name = "تاریخ شروع مدرک")]

        //public string DateSrartEvidenceFlightTitle { get; set; }
        //[Display(Name = "تاریخ خاتمه مدرک")]
        //public string DateEndEvidenceFlightTitle { get; set; }

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


    }





}
