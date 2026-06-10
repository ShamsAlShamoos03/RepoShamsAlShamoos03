using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShamsAlShamoos03.Shared.Models
{
    //NewsId CategoryID


    public class SelectedlistEvidence
    {

        
                               
                                    
        public int ID { get; set; }
        //[Key]

        public string Title { get; set; }
        public string DayValidFlight { get; set; }

        public string ToDateHealthEvidenceTitle { get; set; }
        public string ResaultStandCheck { get; set; }
        public string LastFlightDate { get; set; }

        public string? FlightEvidence01ID { get; set; }
        //[ForeignKey("FlightEvidence01ID")]
        //public virtual FlightEvidence01? ooRateFlight { get; set; }

        public string? StandCheckWritten01ID { get; set; }
        //[ForeignKey("StandCheckWritten01ID")]
        //public virtual StandCheckWritten01? ooStandCheck { get; set; }


        public string? HealthEvidence01ID { get; set; }
        //[ForeignKey("HealthEvidence01ID")]
        //public virtual HealthEvidence01? oo_HealthEvidence01 { get; set; }

        public string? NoNoticeEvidence01ID { get; set; }
        //[ForeignKey("NoNoticeEvidence01ID")]
        //public virtual NoNoticeEvidence01? oo_NoNoticeEvidence01 { get; set; }

        public string? EnglishExamEvidence01ID { get; set; }
        //[ForeignKey("EnglishExamEvidence01ID")]
        //public virtual EnglishExamEvidence01? oo_EnglishExamEvidence01 { get; set; }








        public string? LastfltDateFilnal01 { get; set; }



    }
    public class Selectedlist
    {
        

        public int ID { get; set; }
        //[Key]

         public string  Title { get; set; }
    }
    public class SelectedlistTimeSpan
    {


        public int Duty { get; set; }
        public int PURPOSEOFFLT { get; set; }
        public int PURPOSEOFFLTDispatch { get; set; }

        //[Key]

        //public string Title { get; set; }
        //public TimeSpan? ETETimeSpan { get; set; }
        //public TimeSpan? ETDTimeSpan { get; set; }
        public TimeSpan? SumETEDateTime01 { get; set; }

        //> new SelectedlistTimeSpan { ID = (int) v.Duty, DifTimeSpan01 = v.oo_FlightPlanEvidence01ID.ETETimeSpan.Value.Ticks - v.oo_FlightPlanEvidence01ID.ETDTimeSpan


    }

    public class Selectedlisttext
    {

         
        public string ID { get; set; }
        public string id { get; set; }
        //[Key]

        public string Cod_h { get; set; }
        public string TitleEn1 { get; set; }
        public string Title { get; set; }


        public string text { get; set; }
        public string DUTY { get; set; }
        public string FLTCREW { get; set; }
        public string RATE { get; set; }
        public string RANK { get; set; }
        public string TOTALFLTTIME { get; set; }
    public string PHISICALEXPDATE { get; set; }
    public string STDCHECKEXPDATE { get; set; }
    public string LASTFLTDATE { get; set; }
        public string stringhhmmHours { get; set; }
        public int Sortable01Id { get; set; }

        public string SortableTitle01 { get; set; }
        public string Title02 { get; set; }
        public string stringTitle02 { get; set; }


        //public string RATE { get; set; }

    }
    public class Selectedliststring
    {


        public string ID { get; set; }
        //[Key]

        public string Title { get; set; }
    }
    public class FlightEvidence01ViewModelcat
    {


        public int? YearsOFWorks { get; set; }

        public int? YearsOFOld { get; set; }

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
                                                /// یگان
                                                /// </summary>
                                                ///   
        public string? DUS_COD { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public string? DUS_NAM { get; set; }

        public string AlltimeRnagedate_01 { get; set; }
        public string STATIONstrFa { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public int? UnitID01 { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public string? strUnitID01 { get; set; }

        /// <summary>
        ///    یگان نگبهانی
        /// </summary>
        public int? UitIDGaurd01 { get; set; }
        /// <summary>
        ///    یگان نگبهانی
        /// </summary>
        public string? strUitIDGaurd01 { get; set; }
        public string SPd { get; set; }
        public string CPd { get; set; }
        public string Pd { get; set; }
        public string TPd { get; set; }
        public string IPd { get; set; }
        public string SIPd { get; set; }

        public string SPN { get; set; }
        public string CPN { get; set; }
        public string PN { get; set; }
        public string IPN { get; set; }
        public string SIPN { get; set; }
        public string YN { get; set; }

        public string SPNY { get; set; }
        public string CPNY { get; set; }
        public string PNY { get; set; }
        public string IPNY { get; set; }
        public string SIPNY { get; set; }

        public string SIM { get; set; }

        public string HOOD { get; set; }

        public string SPHOOD { get; set; }
        public string CPHOOD { get; set; }
        public string PHOOD { get; set; }
        public string IPHOOD { get; set; }
        public string SIPHOOD { get; set; }


       




        //public int Alltimeragedate { get; set; }
        //public int Alltimeragedate1 { get; set; }
        //public int Alltimeragedate  { get; set; }
        //public TimeSpan Alltimeragedate1  { get; set; }
        //public long Alltimeragedate { get; set; }
        //public TimeSpan Alltimeragedate { get; set; }
        //public string Alltimeragedate { get; set; }
        //public DateTime? Alltimeragedate { get; set; }
        //public DateTime Alltimeragedate { get; set; }

        //public Double Alltimeragedate { get; set; }

        //public TimeSpan Alltime_01 { get; set; }
        //public string Alltime_01 { get; set; }
        //public string Alltime_02 { get; set; }
        //public string Alltime_04 { get; set; }
        ////public double Alltime_02 { get; set; }
        //public long Alltime_03 { get; set; }

        //public TimeSpan? SumETEDateTime { get; set; }

        //public TimeSpan? SumETEDateTime
        //{

        //    get
        //    {
        //        //return this.ETEDateTime.Sum(edt => edt.Value.Minute);
        //        return this.ETEDateTime - this.ETDDateTime;

        //    }
        //}

        public string CountActivity { get; set; }

        public string CountActivityRescue { get; set; }
        public string CountActivityEMS { get; set; }
        public string CountActivitySMission { get; set; }
        public string CountActivityRequirment { get; set; }
        public string CountActivityVIP { get; set; }
        public string CountActivitySAHAN { get; set; }
        public string CountActivitySkydiving{ get; set; }
    public string CountActivityFormation { get; set; }
    public string CountActivityReposition { get; set; }
    public string CountActivityStandcheck{ get; set; }
public string CountActivityTraining { get; set; }
public string CountActivityEXPCheck{ get; set; }
 public string CountActivityNavigation { get; set; }
public string CountActivityGunnery { get; set; }
public string CountActivityMOC { get; set; }
public string CountActivityTESTFLT{ get; set; }
 public string CountActivityCOMPASS { get; set; }
public string CountActivityENGWASH{ get; set; }
 public string CountActivityENGWASHTEST{ get; set; }
 public string CountActivityPOWERCHECK{ get; set; }
 public string CountActivityMOCTEST { get; set; }
public string CountActivityRUNUP{ get; set; }
 public string CountActivityNightflt{ get; set; }
 public string CountActivityWaterOPS{ get; set; }
        public string CountActivityFIREFIGHTING { get; set; }
        public string CountActivitySLINGOPS { get; set; }










        public string TimeT { get; set; }

        public string TimeTRescue { get; set; }
        public string TimeTEMS { get; set; }
        public string TimeTSMission { get; set; }
        public string TimeTRequirment { get; set; }
        public string TimeTVIP { get; set; }
        public string TimeTSAHAN { get; set; }
        public string TimeTSkydiving { get; set; }
        public string TimeTFormation { get; set; }
        public string TimeTReposition { get; set; }
        public string TimeTStandcheck { get; set; }
        public string TimeTTraining { get; set; }
        public string TimeTEXPCheck { get; set; }
        public string TimeTNavigation { get; set; }
        public string TimeTGunnery { get; set; }
        public string TimeTMOC { get; set; }
        public string TimeTTESTFLT { get; set; }
        public string TimeTCOMPASS { get; set; }
        public string TimeTENGWASH { get; set; }
        public string TimeTENGWASHTEST { get; set; }
        public string TimeTPOWERCHECK { get; set; }
        public string TimeTMOCTEST { get; set; }
        public string TimeTRUNUP { get; set; }
        public string TimeTNightflt { get; set; }
        public string TimeTWaterOPS { get; set; }
        public string TimeTFIREFIGHTING { get; set; }
        public string TimeTSLINGOPS { get; set; }











        public string LastfltDateFilnal01amainDay01 { get; set; }
        public string LastfltDateFilnal01 { get; set; }
        public string stringhhmmHours { get; set; }

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
        public string FlightEvidence01ID { get; set; }
        public string FlightEvidence01IDstr { get; set; }

        public string FlightEvidence01IDstr3 { get; set; }
        public string FlightEvidence01IDstr4 { get; set; }
        public string FlightEvidence01IDstr5 { get; set; }
        public string FlightEvidence01IDstr6 { get; set; }

        /// <summary>
        ///  تلفن 
        /// </summary>
        public string? Phone01 { get; set; }

        /// <summary>
        ///  تلفن 
        /// </summary>
        public string? Phone01ALL { get; set; }


        public string ResaultStandCheck { get; set; }

        public string ResaultStandCheckRamainDay01 { get; set; }
        /// <summary>
        /// روز باقیمانده تا تاریخ شروع
        /// </summary>
        public string? FromDateHealthEvidenceTitleRamainDay01 { get; set; }
        /// <summary>
        ///  روز باقیمانده تا تاریخ خاتمه
        /// </summary>
        public string? ToDateHealthEvidenceTitleRamainDay01 { get; set; }


        /// <summary>
        /// روز باقیمانده تا تاریخ شروع
        /// </summary>
        public string? FromDateHealthEvidenceTitle  { get; set; }
        /// <summary>
        ///  روز باقیمانده تا تاریخ خاتمه
        /// </summary>
        public string? ToDateHealthEvidenceTitle   { get; set; }

        //[Display(Name = "دسته بندی")]
        //public string Title { get; set; }

        ////[Display(Name = "دسته بندی")]
        //public string UserID { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string FirstName { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string LastName { get; set; }
        ////[Display(Name = "دسته بندی")]
        public string MelliCode { get; set; }
        public string Title { get; set; }
        public string Darajee { get; set; }
        public string DRJ_NAMGheshr1 { get; set; }
        public string DRJ_NAMGheshr2  { get; set; }
        public int DarajeeGheshrID { get; set; }
        public string FName { get; set; }
        //[Display(Name = "دسته بندی")]
        public string LName { get; set; }

        //[Display(Name = "دسته بندی")]
        public string Rank01 { get; set; }

        public string DarajeeEN { get; set; }
        public string EMP_NUM { get; set; }
        public string FstNamEN { get; set; }
        public string LstNamEN { get; set; }

        

        //public string FName { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string LName { get; set; }

        ////[Display(Name = "دسته بندی")]
        //public string Rank01 { get; set; }

        [Display(Name = "عنوان مدرک")]
        public int EvidenceFlightTitle { get; set; }
        public string EvidenceFlightTitlestr { get; set; }

        [Display(Name = "تاریخ شروع مدرک")]

        public string DateSrartEvidenceFlightTitle { get; set; }
        [Display(Name = "تاریخ خاتمه مدرک")]
        public string DateEndEvidenceFlightTitle { get; set; }

        [Display(Name = "دسته بندی")]
        public int Rate { get; set; }
        public string Ratestr { get; set; }
        public string RatestrFa { get; set; }


        [Display(Name = "دسته بندی")]
        public int TypeRateID { get; set; }
        public string TypeRatestr { get; set; }

        public string TypeRatestrTypeRatestr { get; set; }


        [Display(Name = "دسته بندی")]
        public int TypeAC { get; set; }
        public string TypeACstr { get; set; }
        public string TypeACstrAll { get; set; }

        [Display(Name = "دسته بندی")]
        public int Sortable01Id { get; set; }

        //[Display(Name = "دسته بندی")]
        //public string IsHaveJobFIsHaveJobF { get; set; }

        public bool IsHaveJob { get; set; }
        public string IsHaveJobstring { get; set; }

        public string IsPortrait01 { get; set; }
        public string IsPortrait02 { get; set; }
        public string IsPortrait03 { get; set; }
        public string IsPortrait04 { get; set; }
        public string IsPortrait05 { get; set; }
        public string IsPortrait06 { get; set; }
        public string Title01 { get; set; }

        public string PersonImage { get; set; }

        //public bool IsHaveJobF { get; set; }

        //public bool IsHaveJobT { get; set; }

        //public string Sortable01Id { get; set; }

        //public string filename01 { get; set; }

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string UserID { get; set; }
        //[Display(Name = "دسته بندی")]
        //[Display(Name = "دسته بندی")]
        //[Display(Name = "تاریخ انتساب")]

        //public string StartJobDatestr { get; set; }
        ////[Display(Name = "دسته بندی")]
        ////[Display(Name = "دسته بندی")]
        //[Display(Name = "تاریخ عزل")]

        //public string EndJobDatestr { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string des01 { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string des02 { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public int Sortable01Id { get; set; }

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }




        public string? SUMSPd { get; set; }
        public string? SUMCPd { get; set; }
        public string? SUMPd { get; set; }
        public string? SUMTPd { get; set; }
        public string? SUMIPd { get; set; }
        public string? SUMSIPd { get; set; }
        public string? SUMSPN { get; set; }
        public string? SUMCPN { get; set; }
        public string? SUMPN { get; set; }
        public string? SUMIPN { get; set; }
        public string? SUMSIPN { get; set; }
        public string? SUMYN { get; set; }
        public string? SUMSPNY { get; set; }
        public string? SUMCPNY { get; set; }
        public string? SUMPNY { get; set; }
        public string? SUMIPNY { get; set; }
        public string? SUMSIPNY { get; set; }
        public string? SUMSIM { get; set; }
        public string? SUMHOOD { get; set; }
        public string? SUMSPHOOD { get; set; }
        public string? SUMCPHOOD { get; set; }
        public string? SUMPHOOD { get; set; }
        public string? SUMIPHOOD { get; set; }
        public string? SUMSIPHOOD { get; set; }

        public string? SUMSPdNew01 { get; set; }
        public string? SUMCPdNew01 { get; set; }
        public string? SUMPdNew01 { get; set; }
        public string? SUMTPdNew01 { get; set; }
        public string? SUMIPdNew01 { get; set; }
        public string? SUMSIPdNew01 { get; set; }
        public string? SUMSPNNew01 { get; set; }
        public string? SUMCPNNew01 { get; set; }
        public string? SUMPNNew01 { get; set; }
        public string? SUMIPNNew01 { get; set; }
        public string? SUMSIPNNew01 { get; set; }
        public string? SUMYNNew01 { get; set; }
        public string? SUMSPNYNew01 { get; set; }
        public string? SUMCPNYNew01 { get; set; }
        public string? SUMPNYNew01 { get; set; }
        public string? SUMIPNYNew01 { get; set; }
        public string? SUMSIPNYNew01 { get; set; }
        public string? SUMSIMNew01 { get; set; }
        public string? SUMHOODNew01 { get; set; }
        public string? SUMSPHOODNew01 { get; set; }
        public string? SUMCPHOODNew01 { get; set; }
        public string? SUMPHOODNew01 { get; set; }
        public string? SUMIPHOODNew01 { get; set; }
        public string? SUMSIPHOODNew01 { get; set; }
    }


    public class GaurdEvidence01ViewModelcat
    {

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
        /// یگان
        /// </summary>
        ///   
        public string? DUS_COD { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public string? DUS_NAM { get; set; }

        public string AlltimeRnagedate_01 { get; set; }
        public string STATIONstrFa { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public int? UnitID01 { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public string? strUnitID01 { get; set; }

        /// <summary>
        ///    یگان نگبهانی
        /// </summary>
        public int? UitIDGaurd01 { get; set; }
        /// <summary>
        ///    یگان نگبهانی
        /// </summary>
        public string? strUitIDGaurd01 { get; set; }
        public string SPd { get; set; }
        public string CPd { get; set; }
        public string Pd { get; set; }
        public string TPd { get; set; }
        public string IPd { get; set; }
        public string SIPd { get; set; }

        public string SPN { get; set; }
        public string CPN { get; set; }
        public string PN { get; set; }
        public string IPN { get; set; }
        public string SIPN { get; set; }
        public string YN { get; set; }

        public string SPNY { get; set; }
        public string CPNY { get; set; }
        public string PNY { get; set; }
        public string IPNY { get; set; }
        public string SIPNY { get; set; }

        public string SIM { get; set; }

        public string HOOD { get; set; }

        public string SPHOOD { get; set; }
        public string CPHOOD { get; set; }
        public string PHOOD { get; set; }
        public string IPHOOD { get; set; }
        public string SIPHOOD { get; set; }







        //public int Alltimeragedate { get; set; }
        //public int Alltimeragedate1 { get; set; }
        //public int Alltimeragedate  { get; set; }
        //public TimeSpan Alltimeragedate1  { get; set; }
        //public long Alltimeragedate { get; set; }
        //public TimeSpan Alltimeragedate { get; set; }
        //public string Alltimeragedate { get; set; }
        //public DateTime? Alltimeragedate { get; set; }
        //public DateTime Alltimeragedate { get; set; }

        //public Double Alltimeragedate { get; set; }

        //public TimeSpan Alltime_01 { get; set; }
        //public string Alltime_01 { get; set; }
        //public string Alltime_02 { get; set; }
        //public string Alltime_04 { get; set; }
        ////public double Alltime_02 { get; set; }
        //public long Alltime_03 { get; set; }

        //public TimeSpan? SumETEDateTime { get; set; }

        //public TimeSpan? SumETEDateTime
        //{

        //    get
        //    {
        //        //return this.ETEDateTime.Sum(edt => edt.Value.Minute);
        //        return this.ETEDateTime - this.ETDDateTime;

        //    }
        //}

        public string CountActivity { get; set; }

        public string CountActivityRescue { get; set; }
        public string CountActivityEMS { get; set; }
        public string CountActivitySMission { get; set; }
        public string CountActivityRequirment { get; set; }
        public string CountActivityVIP { get; set; }
        public string CountActivitySAHAN { get; set; }
        public string CountActivitySkydiving { get; set; }
        public string CountActivityFormation { get; set; }
        public string CountActivityReposition { get; set; }
        public string CountActivityStandcheck { get; set; }
        public string CountActivityTraining { get; set; }
        public string CountActivityEXPCheck { get; set; }
        public string CountActivityNavigation { get; set; }
        public string CountActivityGunnery { get; set; }
        public string CountActivityMOC { get; set; }
        public string CountActivityTESTFLT { get; set; }
        public string CountActivityCOMPASS { get; set; }
        public string CountActivityENGWASH { get; set; }
        public string CountActivityENGWASHTEST { get; set; }
        public string CountActivityPOWERCHECK { get; set; }
        public string CountActivityMOCTEST { get; set; }
        public string CountActivityRUNUP { get; set; }
        public string CountActivityNightflt { get; set; }
        public string CountActivityWaterOPS { get; set; }


        public string LastfltDateFilnal01amainDay01 { get; set; }
        public string LastfltDateFilnal01 { get; set; }
        public string stringhhmmHours { get; set; }

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
        public string GaurdEvidence01ID { get; set; }
        public string GaurdEvidence01IDstr { get; set; }

        public string GaurdEvidence01IDstr3 { get; set; }
        public string GaurdEvidence01IDstr4 { get; set; }
        public string GaurdEvidence01IDstr5 { get; set; }
        public string GaurdEvidence01IDstr6 { get; set; }

        /// <summary>
        ///  تلفن 
        /// </summary>
        public string? Phone01 { get; set; }

        /// <summary>
        ///  تلفن 
        /// </summary>
        public string? Phone01ALL { get; set; }


        public string ResaultStandCheck { get; set; }

        public string ResaultStandCheckRamainDay01 { get; set; }
        /// <summary>
        /// روز باقیمانده تا تاریخ شروع
        /// </summary>
        public string? FromDateHealthEvidenceTitleRamainDay01 { get; set; }
        /// <summary>
        ///  روز باقیمانده تا تاریخ خاتمه
        /// </summary>
        public string? ToDateHealthEvidenceTitleRamainDay01 { get; set; }


        /// <summary>
        /// روز باقیمانده تا تاریخ شروع
        /// </summary>
        public string? FromDateHealthEvidenceTitle { get; set; }
        /// <summary>
        ///  روز باقیمانده تا تاریخ خاتمه
        /// </summary>
        public string? ToDateHealthEvidenceTitle { get; set; }

        //[Display(Name = "دسته بندی")]
        //public string Title { get; set; }

        ////[Display(Name = "دسته بندی")]
        //public string UserID { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string FirstName { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string LastName { get; set; }
        ////[Display(Name = "دسته بندی")]
        public string MelliCode { get; set; }
        public string Title { get; set; }
        public string Darajee { get; set; }
        public string DRJ_NAMGheshr1 { get; set; }
        public string DRJ_NAMGheshr2 { get; set; }
        public int DarajeeGheshrID { get; set; }
        public string FName { get; set; }
        //[Display(Name = "دسته بندی")]
        public string LName { get; set; }

        //[Display(Name = "دسته بندی")]
        public string Rank01 { get; set; }

        public string DarajeeEN { get; set; }
        public string EMP_NUM { get; set; }
        public string FstNamEN { get; set; }
        public string LstNamEN { get; set; }



        //public string FName { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string LName { get; set; }

        ////[Display(Name = "دسته بندی")]
        //public string Rank01 { get; set; }

        [Display(Name = "عنوان مدرک")]
        public int EvidenceGaurdTitle { get; set; }
        public string EvidenceGaurdTitlestr { get; set; }

        [Display(Name = "تاریخ شروع مدرک")]

        public string DateSrartEvidenceGaurdTitle { get; set; }
        [Display(Name = "تاریخ خاتمه مدرک")]
        public string DateEndEvidenceGaurdTitle { get; set; }

        [Display(Name = "دسته بندی")]
        public int Rate { get; set; }
        public string Ratestr { get; set; }
        public string RatestrFa { get; set; }


        [Display(Name = "دسته بندی")]
        public int TypeRateID { get; set; }
        public string TypeRatestr { get; set; }

        public string TypeRatestrTypeRatestr { get; set; }


        [Display(Name = "دسته بندی")]
        public int TypeAC { get; set; }
        public string TypeACstr { get; set; }
        public string TypeACstrAll { get; set; }

        [Display(Name = "دسته بندی")]
        public int Sortable01Id { get; set; }

        //[Display(Name = "دسته بندی")]
        //public string IsHaveJobFIsHaveJobF { get; set; }

        public bool IsHaveJob { get; set; }
        public string IsHaveJobstring { get; set; }

        public string IsPortrait01 { get; set; }
        public string IsPortrait02 { get; set; }
        public string IsPortrait03 { get; set; }
        public string IsPortrait04 { get; set; }
        public string IsPortrait05 { get; set; }
        public string IsPortrait06 { get; set; }
        public string Title01 { get; set; }

        public string PersonImage { get; set; }

        //public bool IsHaveJobF { get; set; }

        //public bool IsHaveJobT { get; set; }

        //public string Sortable01Id { get; set; }

        //public string filename01 { get; set; }

        //[Display(Name = "دسته بندی")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
        //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string UserID { get; set; }
        //[Display(Name = "دسته بندی")]
        //[Display(Name = "دسته بندی")]
        //[Display(Name = "تاریخ انتساب")]

        //public string StartJobDatestr { get; set; }
        ////[Display(Name = "دسته بندی")]
        ////[Display(Name = "دسته بندی")]
        //[Display(Name = "تاریخ عزل")]

        //public string EndJobDatestr { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string des01 { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string des02 { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public int Sortable01Id { get; set; }

        //[Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
        //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
        //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string Description { get; set; }




        public string? SUMSPd { get; set; }
        public string? SUMCPd { get; set; }
        public string? SUMPd { get; set; }
        public string? SUMTPd { get; set; }
        public string? SUMIPd { get; set; }
        public string? SUMSIPd { get; set; }
        public string? SUMSPN { get; set; }
        public string? SUMCPN { get; set; }
        public string? SUMPN { get; set; }
        public string? SUMIPN { get; set; }
        public string? SUMSIPN { get; set; }
        public string? SUMYN { get; set; }
        public string? SUMSPNY { get; set; }
        public string? SUMCPNY { get; set; }
        public string? SUMPNY { get; set; }
        public string? SUMIPNY { get; set; }
        public string? SUMSIPNY { get; set; }
        public string? SUMSIM { get; set; }
        public string? SUMHOOD { get; set; }
        public string? SUMSPHOOD { get; set; }
        public string? SUMCPHOOD { get; set; }
        public string? SUMPHOOD { get; set; }
        public string? SUMIPHOOD { get; set; }
        public string? SUMSIPHOOD { get; set; }

        public string? SUMSPdNew01 { get; set; }
        public string? SUMCPdNew01 { get; set; }
        public string? SUMPdNew01 { get; set; }
        public string? SUMTPdNew01 { get; set; }
        public string? SUMIPdNew01 { get; set; }
        public string? SUMSIPdNew01 { get; set; }
        public string? SUMSPNNew01 { get; set; }
        public string? SUMCPNNew01 { get; set; }
        public string? SUMPNNew01 { get; set; }
        public string? SUMIPNNew01 { get; set; }
        public string? SUMSIPNNew01 { get; set; }
        public string? SUMYNNew01 { get; set; }
        public string? SUMSPNYNew01 { get; set; }
        public string? SUMCPNYNew01 { get; set; }
        public string? SUMPNYNew01 { get; set; }
        public string? SUMIPNYNew01 { get; set; }
        public string? SUMSIPNYNew01 { get; set; }
        public string? SUMSIMNew01 { get; set; }
        public string? SUMHOODNew01 { get; set; }
        public string? SUMSPHOODNew01 { get; set; }
        public string? SUMCPHOODNew01 { get; set; }
        public string? SUMPHOODNew01 { get; set; }
        public string? SUMIPHOODNew01 { get; set; }
        public string? SUMSIPHOODNew01 { get; set; }
    }



    //public class NewsImagesListViewModelidEdit
    //{

    //    //public string UserID { get; set; } = "0";
    //    public string NewsImagesID { get; set; }

    //    //public int NewsId { get; set; }
    //    //public int ImagesListId { get; set; }
    //    [Display(Name = "مرتب کردن")]

    //    public int Sortable01Id { get; set; }

    //    //[Display(Name = "دسته بندی")]
    //    //[Required(AllowEmptyStrings = false, ErrorMessage = "دسته بندی وارد نشده است.")]
    //    //[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
    //    //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
    //    //public string UserID { get; set; }
    //    //public string sort01 { get; set; } = "0";
    //    //public string sort02 { get; set; } = "0";
    //    //public string des01 { get; set; } = "0";
    //    //public string des02 { get; set; } = "0";

    //    //[Display(Name = "توضیحات")]
    //    //[Required(AllowEmptyStrings = false, ErrorMessage = "توضیخات وارد نشده است.")]
    //    //[StringLength(500, MinimumLength = 10, ErrorMessage = "تعداد کاراکترها باید بین 10 تا 500 حرف باشد")]
    //    //[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
    //    //public string Description { get; set; }
    //}

}
