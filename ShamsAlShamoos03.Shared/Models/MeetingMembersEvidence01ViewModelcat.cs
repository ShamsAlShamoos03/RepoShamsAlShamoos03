
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    //NewsId CategoryID

    
    public class MeetingMembersEvidence01ViewModelcat
    {
        public string? PersonImage { get; set; }

        //public TimeSpan? TotalTime { get; set; }
        public string? MeetingDetailsEvidence01ID { get; set; }
        public string? MeetingEvidence01ID { get; set; }

        public string? FlightPlanEvidence01ID { get; set; }
        public int? YearsOFWorks { get; set; }
        public string? DrjSubLookupId { get; set; }
        public string? DrjLookupId { get; set; }

        public int? YearsOFOld { get; set; }


        public string? Darajee { get; set; }
        public string? Rastee { get; set; }
        public string? Fname { get; set; }
        public string? Rname { get; set; }
        public string? Mobile { get; set; }
        public string? Semat { get; set; }
        public string? YEGAN { get; set; }
        public string? EMP_NUM { get; set; }
        public string? NOTAMCHECKETitle01Activitystr { get; set; }

        //MeetingDetailsTemplateEvidence01ViewModelcat
        public int? Sortable01IdMeet { get; set; }
        public string? SortableTitle01Meet { get; set; }

        public string? FromDateMeetingEvidence01TitleMeet { get; set; }
        public int? FLTAREANOTAMCHECKMeet { get; set; }
        public string? FLTAREANOTAMCHECKMeetstr { get; set; }
        public int? TypeMeetingMeet { get; set; }
        public string? TypeMeetingMeetstr { get; set; }
        public int? TitleMeetingMeet { get; set; }
        public string? TitleMeetingMeetstr { get; set; }
        public int? PlaceMeetingMeet { get; set; }
        public string? PlaceMeetingMeetstr { get; set; }
        public int? StatusMeetingEvidence01Meet { get; set; }
        public string? StatusMeetingEvidence01Meetstr { get; set; }
        public string? ToDateMeetingEvidence01MeetTitle { get; set; }
        public string? NOTAMCHECKETitle01Meet { get; set; }
        public string? NOTAMCHECKETitle02Meet { get; set; }
        public string? NOTAMCHECKETitle03Meet { get; set; }
        //MeetingDetailsTemplateEvidence01ViewModelcat

        public int? UitID01 { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public string? strUitID01 { get; set; }

        //public string? HelicopterType { get; set; }
        //public string? HelicopterTail { get; set; }
        //public string? PURPOSEOFFLTstrFA { get; set; }
        //public string? FLTAREAstrFA { get; set; }


        //public TimeSpan? ETDTimeSpan { get; set; }
        //public TimeSpan? ETETimeSpan { get; set; }


        //public DateTime? ETDDateTime { get; set; }
        //public DateTime? ETEDateTime { get; set; }
        //public TimeSpan? DiferentETDETETimeSpan { get; set; }

        //نام پایگاه
        public string? STATIONstrFa { get; set; }
        //تاریخ نامه
        public string? DateFlightActivityLetterstr { get; set; }
        public string? NoFolderFlightActivitystr { get; set; }
        public string? RowLetterFlightActivitystr { get; set; }
        public string? FlightActivitypersianWeekCostum { get; set; }
        //public string? str { get; set; }
        //public string? str { get; set; }


        public string? PICstr { get; set; }
        public string? COPilotstr { get; set; }
        public string? Crewstr { get; set; }
        public string? MelliCode { get; set; }
        public string? Title { get; set; }
        public string? Title01 { get; set; }
        public string? Title02 { get; set; }

        public string? FLTCREW { get; set; }
        public string? RATE { get; set; }
        public string? RANK { get; set; }
 
 



        public string SubId { get; set; }


        public string? CrewFlightPesronelstr { get; set; }
        public string? CrewFlightPesronel { get; set; }
        public string? Dutystr { get; set; }
        public int? Duty { get; set; }

        public bool? IsPIC { get; set; }

        public string? IsPICstr { get; set; }

        public string? FLTAREAstrFA { get; set; }
         public string? PURPOSEOFFLTstr { get; set; }
        public string? PURPOSEOFFLTstrFA { get; set; }
         public string? FromDateFlightActivityEvidence01Title { get; set; }
        public string? ToDateFlightActivityEvidence01Title { get; set; }
        //public string? FLTAREANOTAMCHECK { get; set; }
        public string? StatusFlightActivityEvidence01 { get; set; }
        //public string? NOTAMCHECKETitle01 { get; set; }
        //public string? NOTAMCHECKETitle02 { get; set; }
        //public string? NOTAMCHECKETitle03 { get; set; }

       

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
        public string MeetingMembersEvidence01ID { get; set; }
        public string MeetingMembersEvidence01IDstr { get; set; }

        public string MeetingMembersEvidence01IDstr3 { get; set; }
        public string MeetingMembersEvidence01IDstr4 { get; set; }
        public string MeetingMembersEvidence01IDstr5 { get; set; }
        public string MeetingMembersEvidence01IDstr6 { get; set; }
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
        //public string? FromDateMeetingMembersEvidence01TitleRamainDay01 { get; set; }
        ///// <summary>
        /////  روز باقیمانده تا تاریخ خاتمه
        ///// </summary>
        //public string? ToDateMeetingMembersEvidence01TitleRamainDay01 { get; set; }

        /// <summary>
        /// تاریخ شروع
        /// </summary>
        public string? FromDateMeetingMembersEvidence01Title { get; set; }
        ///// <summary>
        /////  تاریخ خاتمه
        ///// </summary>
        public string? ToDateMeetingMembersEvidence01Title { get; set; }


        /// <summary>
        ///  فعال غیر فعال
        /// </summary>
        public bool IsHaveJob { get; set; }

        /// <summary>
        ///  پرواز/فعالیت
        /// </summary>
        public bool? IsFlight { get; set; }
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
        public int? StatusMeetingMembersEvidence01 { get; set; }
        public string? StatusMeetingMembersEvidence01str { get; set; }



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


        public string UjobPesronel01strPlan { get; set; }
        public string UjobPesronel02strPlan { get; set; }
        public string UjobPesronel03strPlan { get; set; }
        public string UjobPesronel04strPlan { get; set; }
        public string UjobPesronel05strPlan { get; set; }
        public string UjobPesronel06strPlan { get; set; }
        public string UjobPesronel07strPlan { get; set; }
        public string UjobPesronel08strPlan { get; set; }
        public string UjobPesronel09strPlan { get; set; }
        public string UjobPesronel10strPlan { get; set; }
        public string UjobPesronel11strPlan { get; set; }
        public string UjobPesronel12strPlan { get; set; }

        public string UjobPesronel01strPlanMelicode { get; set; }
        public string UjobPesronel02strPlanMelicode { get; set; }
        public string UjobPesronel03strPlanMelicode { get; set; }
        public string UjobPesronel04strPlanMelicode { get; set; }
        public string UjobPesronel05strPlanMelicode { get; set; }
        public string UjobPesronel06strPlanMelicode { get; set; }
        public string UjobPesronel07strPlanMelicode { get; set; }
        public string UjobPesronel08strPlanMelicode { get; set; }
        public string UjobPesronel09strPlanMelicode { get; set; }
        public string UjobPesronel10strPlanMelicode { get; set; }
        public string UjobPesronel11strPlanMelicode { get; set; }
        public string UjobPesronel12strPlanMelicode { get; set; }

        public string UjobPesronel01strPlanDarajee { get; set; }
        public string UjobPesronel02strPlanDarajee { get; set; }
        public string UjobPesronel03strPlanDarajee { get; set; }
        public string UjobPesronel04strPlanDarajee { get; set; }
        public string UjobPesronel05strPlanDarajee { get; set; }
        public string UjobPesronel06strPlanDarajee { get; set; }
        public string UjobPesronel07strPlanDarajee { get; set; }
        public string UjobPesronel08strPlanDarajee { get; set; }
        public string UjobPesronel09strPlanDarajee { get; set; }
        public string UjobPesronel10strPlanDarajee { get; set; }
        public string UjobPesronel11strPlanDarajee { get; set; }
        public string UjobPesronel12strPlanDarajee { get; set; }

        public string UjobPesronel01strPlanFirstName { get; set; }
        public string UjobPesronel02strPlanFirstName { get; set; }
        public string UjobPesronel03strPlanFirstName { get; set; }
        public string UjobPesronel04strPlanFirstName { get; set; }
        public string UjobPesronel05strPlanFirstName { get; set; }
        public string UjobPesronel06strPlanFirstName { get; set; }
        public string UjobPesronel07strPlanFirstName { get; set; }
        public string UjobPesronel08strPlanFirstName { get; set; }
        public string UjobPesronel09strPlanFirstName { get; set; }
        public string UjobPesronel10strPlanFirstName { get; set; }
        public string UjobPesronel11strPlanFirstName { get; set; }
        public string UjobPesronel12strPlanFirstName { get; set; }


        public string UjobPesronel01strPlanFirstNameEN { get; set; }
        public string UjobPesronel02strPlanFirstNameEN { get; set; }
        public string UjobPesronel03strPlanFirstNameEN { get; set; }
        public string UjobPesronel04strPlanFirstNameEN { get; set; }
        public string UjobPesronel05strPlanFirstNameEN { get; set; }
        public string UjobPesronel06strPlanFirstNameEN { get; set; }
        public string UjobPesronel07strPlanFirstNameEN { get; set; }
        public string UjobPesronel08strPlanFirstNameEN { get; set; }
        public string UjobPesronel09strPlanFirstNameEN { get; set; }
        public string UjobPesronel10strPlanFirstNameEN { get; set; }
        public string UjobPesronel11strPlanFirstNameEN { get; set; }
        public string UjobPesronel12strPlanFirstNameEN { get; set; }


        public string UjobPesronel01strPlanLastName { get; set; }
        public string UjobPesronel02strPlanLastName { get; set; }
        public string UjobPesronel03strPlanLastName { get; set; }
        public string UjobPesronel04strPlanLastName { get; set; }
        public string UjobPesronel05strPlanLastName { get; set; }
        public string UjobPesronel06strPlanLastName { get; set; }
        public string UjobPesronel07strPlanLastName { get; set; }
        public string UjobPesronel08strPlanLastName { get; set; }
        public string UjobPesronel09strPlanLastName { get; set; }
        public string UjobPesronel10strPlanLastName { get; set; }
        public string UjobPesronel11strPlanLastName { get; set; }
        public string UjobPesronel12strPlanLastName { get; set; }


        public string UjobPesronel01strPlanLastNameEN { get; set; }
        public string UjobPesronel02strPlanLastNameEN { get; set; }
        public string UjobPesronel03strPlanLastNameEN { get; set; }
        public string UjobPesronel04strPlanLastNameEN { get; set; }
        public string UjobPesronel05strPlanLastNameEN { get; set; }
        public string UjobPesronel06strPlanLastNameEN { get; set; }
        public string UjobPesronel07strPlanLastNameEN { get; set; }
        public string UjobPesronel08strPlanLastNameEN { get; set; }
        public string UjobPesronel09strPlanLastNameEN { get; set; }
        public string UjobPesronel10strPlanLastNameEN { get; set; }
        public string UjobPesronel11strPlanLastNameEN { get; set; }
        public string UjobPesronel12strPlanLastNameEN { get; set; }


        public string UjobPesronel01strPlanEMP_NUM { get; set; }
        public string UjobPesronel02strPlanEMP_NUM { get; set; }
        public string UjobPesronel03strPlanEMP_NUM { get; set; }
        public string UjobPesronel04strPlanEMP_NUM { get; set; }
        public string UjobPesronel05strPlanEMP_NUM { get; set; }
        public string UjobPesronel06strPlanEMP_NUM { get; set; }
        public string UjobPesronel07strPlanEMP_NUM { get; set; }
        public string UjobPesronel08strPlanEMP_NUM { get; set; }
        public string UjobPesronel09strPlanEMP_NUM { get; set; }
        public string UjobPesronel10strPlanEMP_NUM { get; set; }
        public string UjobPesronel11strPlanEMP_NUM { get; set; }
        public string UjobPesronel12strPlanEMP_NUM { get; set; }


        public string UjobPesronel01strPlanJobTitle { get; set; }
        public string UjobPesronel02strPlanJobTitle { get; set; }
        public string UjobPesronel03strPlanJobTitle { get; set; }
        public string UjobPesronel04strPlanJobTitle { get; set; }
        public string UjobPesronel05strPlanJobTitle { get; set; }
        public string UjobPesronel06strPlanJobTitle { get; set; }
        public string UjobPesronel07strPlanJobTitle { get; set; }
        public string UjobPesronel08strPlanJobTitle { get; set; }
        public string UjobPesronel09strPlanJobTitle { get; set; }
        public string UjobPesronel10strPlanJobTitle { get; set; }
        public string UjobPesronel11strPlanJobTitle { get; set; }
        public string UjobPesronel12strPlanJobTitle { get; set; }

        public string UjobPesronel01strPlanJobTitleN { get; set; }
        public string UjobPesronel02strPlanJobTitleN { get; set; }
        public string UjobPesronel03strPlanJobTitleN { get; set; }
        public string UjobPesronel04strPlanJobTitleN { get; set; }
        public string UjobPesronel05strPlanJobTitleN { get; set; }
        public string UjobPesronel06strPlanJobTitleN { get; set; }
        public string UjobPesronel07strPlanJobTitleN { get; set; }
        public string UjobPesronel08strPlanJobTitleN { get; set; }
        public string UjobPesronel09strPlanJobTitleN { get; set; }
        public string UjobPesronel10strPlanJobTitleN { get; set; }
        public string UjobPesronel11strPlanJobTitleN { get; set; }
        public string UjobPesronel12strPlanJobTitleN { get; set; }




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

         

        public string IsPortrait01 { get; set; }
        public string IsPortrait02 { get; set; }
        public string IsPortrait03 { get; set; }
        public string IsPortrait04 { get; set; }
        public string IsPortrait05 { get; set; }
        public string IsPortrait06 { get; set; }
  

    }





}
