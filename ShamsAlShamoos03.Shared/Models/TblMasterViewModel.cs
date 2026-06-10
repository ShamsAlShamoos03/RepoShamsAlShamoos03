
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class TblMasterViewModel01
    {
        public string? MelliCode { get; set; }
        public string? EMP_NUM { get; set; }
        public string? FST_NAM { get; set; }
        public string? LST_NAM { get; set; }
        public string? FAT_NAM { get; set; }
        public string? DRJ_NAM { get; set; }

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

    }
        public class TblMasterViewModel333
    {
        /// <summary>
        ///TotalFlightTime
        /// </summary>
        public string? TotalFlightTime { get; set; }
        public string? TotalFlightTimeNew01 { get; set; }

        public TimeSpan? TotalFlightTimeTimeSpan { get; set; }
        public DateTime? TotalFlightTimeDateTime { get; set; }

        /// <summary>
        ///LastFlightDate
        /// </summary>
        public string? LastFlightDate { get; set; }

        [Display(Name = "شماره کارگزینی")]
        public string? EMP_NUM { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        [Display(Name = "نام")]
        public string? FST_NAM { get; set; }
        [Display(Name = "")]
        public string? LST_NAM { get; set; }
        [Display(Name = "")]
        public string? BRT_COD { get; set; }
    
        public string? MelliCode { get; set; }

    }
    public class TblMasterViewModelEdit
    {        /// <summary>
             ///  بررسی وجود تصویر در پوشه
             /// </summary>

        //متن نامه
        /// </summary>
        public string? Tabaghe { get; set; }
        // <summary>
        //متن نامه
        /// </summary>
        public string? ReasTabaghe { get; set; }
        // <summary>
        //متن نامه
        /// </summary>
        public string? Benefits { get; set; }
        // <summary>
        //متن نامه
        /// </summary>
        public string? Percenta { get; set; }

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

        //FName = item.FST_NAM,
        //                            LName = item.LST_NAM,

        //                            Darajee = item.ooDRJCOD.Title,
        public string? Darajee { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public int? DRJ_CODSort { get; set; }

        public int? YearsOFWorks { get; set; }

        public int? YearsOFOld { get; set; }

      


        /// <summary>
        /// سمت
        /// </summary>
        public int? ISFatmandeYeganGhesmat01 { get; set; }
        public string? strISFatmandeYeganGhesmat01 { get; set; }
        public int? sort01SFatmandeYeganGhesmat01 { get; set; }

        /// <summary>
        /// ریت لول
        /// </summary>
        public int? RateLevel { get; set; }
        public string? strRateLevel { get; set; }
        public string? str01RateLevel { get; set; }

        /// <summary>
        /// تخصص فنی خلبان رسته مشترک
        /// </summary>
        public int? TakhasosFaniKhalabanMoshtarak { get; set; }
        public string? strTakhasosFaniKhalabanMoshtarak { get; set; }
        public string? str01TakhasosFaniKhalabanMoshtarak { get; set; }
        public string? str02TakhasosFaniKhalabanMoshtarak { get; set; }
        public int? FaniKhalabanMoshtarak { get; set; }
        public string? desFaniKhalabanMoshtarak { get; set; }

        public int? SortTakhasosFaniKhalabanMoshtarak { get; set; }


        /// <summary>
        /// مدل تخصص بالگرد
        /// </summary>
        public int? TypeAc { get; set; }
        public string? strTypeAc { get; set; }
        public string? str01TypeAc { get; set; }


        /// <summary>
        /// شماره پرونده بایگانی 01
        /// </summary>
        public string? NoFolder01 { get; set; }

        /// <summary>
        /// شماره پرونده بایگانی 02
        /// </summary>
        public string? NoFolder02 { get; set; }

        /// <summary>
        /// شماره پرونده بایگانی 03
        /// </summary>
        public string? NoFolder03 { get; set; }






















        /// <summary>
        ///    یگان نگبهانی
        /// </summary>
        public int? UitIDGaurd01 { get; set; }
        /// <summary>
        ///    یگان نگبهانی
        /// </summary>
        public string? strUitIDGaurd01 { get; set; }


        ///// <summary>
        ///// یگان
        ///// </summary>
        //public int? UnitID01 { get; set; }
        ///// <summary>
        ///// یگان
        ///// </summary>
        //public string? strUnitID01 { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public int? UitID01 { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public string? strUitID01 { get; set; }

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
        /// <summary>
        ///روز اعتبار تا لغو مجوز پرواز
        /// </summary>

        public string? DayValidFlight { get; set; }

        /// <summary>
        ///TotalFlightTime
        /// </summary>
        public string? TotalFlightTime { get; set; }
        public TimeSpan? TotalFlightTimeTimeSpan { get; set; }
        public DateTime? TotalFlightTimeDateTime { get; set; }

        /// <summary>
        ///LastFlightDate
        /// </summary>
        public string? LastFlightDate { get; set; }

        /// <summary>
        ///  تلفن 
        /// </summary>
        public string? Phone01 { get; set; }

        /// <summary>
        ///  تلفن 
        /// </summary>
        public string? Phone01ALL { get; set; }


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



        [Display(Name = "نام لاتین")]
        public string? FstNamEN { get; set; }
        [Display(Name = "نام خانوادگي لاتین")]
        public string? LstNamEN { get; set; }
     
        //[Key]
        //public Nullable<int> NewsId { get; set; }

        //[Display(Name = "عنوان خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "عنوان خبر وارد نشده است.")]
        ////[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string? Title { get; set; }






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
        /// <summary>
        /// نام قبلی
        /// </summary>
        [Display(Name = "نام قبلی")]
        public string? GBL_FNAM { get; set; }
        ///// <summary>
        ///// نام خانوادگی قبلی
        ///// </summary>
        [Display(Name = "نام خانوادگی قبلی")]
        public string? GBL_LNAM { get; set; }
        ///// <summary>
        ///// نام پدر
        ///// </summary>
        [Display(Name = "نام پدر")]

        public string? FAT_NAM { get; set; }
        ///// </summary>
        [Display(Name = "ش شناسنامه")]
        ///// ش شناسنامه
        ///// </summary>
        public string? INF_NUM { get; set; }
        ///// <summary>
        ///// محل تولد
        ///// </summary>
        [Display(Name = "محل تولد")]
        public string? BRT_COD { get; set; }
        ////[ForeignKey("BRT_COD")]

        ////public virtual CityType _BRT_COD { get; set; }

        ///// <summary>
        ///// تاریخ تولد
        ///// </summary>
        [Display(Name = "تاریخ تولد")]
        public string? BRT_DAT { get; set; }
        public string? MAR_DAT { get; set; }

        ///// <summary>
        ///// محل صدور
        ///// </summary>
        [Display(Name = "محل صدور")]
        public string? ISS_COD { get; set; }
        ////[ForeignKey("ISS_COD")]

        ////public virtual CityType _ISS_COD { get; set; }





        ///// <summary>
        ///// تاریخ صدور
        ///// </summary>
        [Display(Name = "تاریخ صدور")]
        public string? ISS_DAT { get; set; }
        ///// <summary>
        ///// گروه خون
        ///// </summary>  type=47
        public string? BLG_COD { get; set; }
        ////[ForeignKey("BLG_COD")]
        ////public virtual TblLuLookup _BLG_COD { get; set; }

        ///// <summary>
        ///// دین مذهب
        ///// </summary> type=99
        public string? REL_COD { get; set; }
        ////[ForeignKey("REL_COD")]

        ////public virtual TblLuLookup _REL_COD { get; set; }
        ///// <summary>
        ///// كد دین و مذهب قبلی
        ///// </summary> type=99
        public string? REL_COD2 { get; set; }
        ///// </summary> 
        ////[ForeignKey("REL_COD2")]
        ////public virtual TblLuLookup _REL_COD2 { get; set; }
        ///// <summary>
        ///// جنسیت
        ///// </summary>  type=32
        public string? SEX_COD { get; set; }
        ////[ForeignKey("SEX_COD")]




        ///// <summary>
        ///// جنسیت
        ///// </summary>  type=32

        public string? SEX_Name { get; set; }

        ///// <summary>
        ///// وضعیت تاهل
        ///// </summary>  type=32

        public string? MAR_Name { get; set; }





        ////public virtual TblLuLookup _SEX_COD { get; set; }
        ///// <summary>
        ///// وضعیت تاهل
        ///// </summary>type=23

        public string? MAR_COD { get; set; }
        ////[ForeignKey("MAR_COD")]

        ////public virtual TblLuLookup _MAR_COD { get; set; }

        ///// <summary> 
        ///// تعداد همسر
        ///// </summary>
        public string? WIF_QTY { get; set; }
        ///// <summary>
        ///// تعداد عائله بجز همسر و اولاد
        ///// </summary>
        public string? FAM_QTY { get; set; }
        ///// <summary>
        ///// تعداد اولاد پسر
        ///// </summary>
        public string? SUN_QTY { get; set; }
        ///// <summary>
        ///// تعداد اولاد دختر
        ///// </summary>
        public string? DOT_QTY { get; set; }
        ///// </summary>
        ///// وضعیت سكونت - خانه سازمانی یا كانتینر
        ///// </summary> type=80
        public string? MAS_COD { get; set; }
        public string? MAS_Name { get; set; }
        ////[ForeignKey("MAS_COD")]

        ////public virtual TblLuLookup _MAS_COD { get; set; }
        ///// <summary>
        /////  تاریخ شروع وضعیت مسكونی
        ///// </summary>
        public string? HOM_DAT { get; set; }
        ///// <summary>
        ///// تاریخ استخدام
        ///// </summary>
        public string? EMP_DAT { get; set; }
        ///// <summary>
        ///// نوع استخدام
        ///// </summary>type=123
        public string? TYP_EMP { get; set; }
        ////[ForeignKey("TYP_EMP")]

        ////public virtual TblLuLookup _TYP_EMP { get; set; }

        public string? TYP_EMPNAM { get; set; }


        ///// </summary>
        ///// /// مدرك یا ماده دستور استخدام
        ///// </summary>
        public string? EMP_ORD { get; set; }
        ////public virtual TblLuLookup yEmpOrd { get; set; }

        ///// <summary>
        ///// كد یگان صاحب دستور استخدام
        ///// </summary>
        public string? EMP_YEG { get; set; }
        ////public virtual TblLuLookup y { get; set; }

        ///// <summary>
        ///// فرمان یا دستور استخدام رده بالاتر
        ///// </summary>
        public string? EMP_ORD2 { get; set; }
        ////public virtual TblLuLookup yEmpOrd2 { get; set; }

        ///// <summary>
        ///// كد مدرك تحصیلی بدو استخدام
        ///// </summary>
        public string? EDF_COD { get; set; }
        ////public virtual TblLuLookup yEdfCod { get; set; }

        ///// <summary>
        ///// كد هویت خدمتی
        ///// </summary>  type=151
        public string? EMS_COD { get; set; }
        ////[ForeignKey("EMS_COD")]

        ////public virtual TblLuLookup _EMS_COD { get; set; }


        public string? EMS_NAM { get; set; }


        ///// <summary>
        ///// كد نوع تغییر وضعیت
        ///// </summary> type=251
        public string? CHG_COD { get; set; }
        ////[ForeignKey("CHG_COD")]

        ////public virtual TblLuLookup _CHG_COD { get; set; }

        public string? CHG_NAM { get; set; }


        ///// <summary>
        ///// كد آخرین مدرك تحصیلی
        ///// </summary> type=11
        public string? EDE_COD { get; set; }
        ////[ForeignKey("EDE_COD")]
        ////public virtual TblLuLookup _EDE_COD { get; set; }
        public string? EDE_NAM { get; set; }

        ///// <summary>
        ///// كد رشته مدرك تحصیلی
        ///// </summary>
        public string? SUB_COD { get; set; }
        ////public virtual TblLuLookup ySubCod { get; set; }

        ///// <summary>
        ///// تاریخ آخرین مدرك تحصیلی
        ///// </summary>
        public string? EDE_DAT { get; set; }
        ////public virtual TblLuLookup yEdeDat { get; set; }

        ///// <summary>
        ///// كد آخرین دوره طولی نظامی
        ///// </summary> type=90  TBL_LOOKUPS_DATA
        public string? LDOR_NEZ { get; set; }
        ////[ForeignKey("LDOR_NEZ")]
        ////public virtual TblLuLookup _LDOR_NEZ { get; set; }

        public string? LDOR_NAM { get; set; }


        ///// <summary>
        ///// كد وضعیت از لحاظ خدمت
        ///// </summary> type=9
        public string? DUS_COD { get; set; }
        ////[ForeignKey("DUS_COD")]
        ////public virtual TblLuLookup _DUS_COD { get; set; }

        public string? DUS_NAM { get; set; }


        ///// <summary>
        ///// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        ///// </summary>
        public string? CUR_JOB { get; set; }
        ///// <summary>
        ///// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        ///// </summary>
        public string? HAZ_COD { get; set; }
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



        ///// <summary>
        ///// كد درجه اصلی
        ///// </summary>
        public string? DRJ_CODA { get; set; }
        ////public virtual TblLuLookup yDrjCoda { get; set; }

        ///// <summary>
        ///// نوع درجه - 0=دائم-1=موقت-2=مجازی
        ///// </summary> type=36
        public string? DRJ_STT { get; set; }
        ////[ForeignKey("DRJ_STT")]
        ////public virtual TblLuLookup _DRJ_STT { get; set; }

        public string? DRJ_STTNAM { get; set; }


        ///// <summary>
        ///// كد رسته
        ///// </summary> type=30
        //public string? RST_COD { get; set; }
        ////[ForeignKey("RST_COD")]
        ////public virtual TblLuLookup _RST_COD { get; set; }

        ///// <summary>
        ///// كد رسته قبلی
        ///// </summary>
        public string? RST_COD2 { get; set; }
        ////public virtual TblLuLookup yRstCod2 { get; set; }

        ///// <summary>
        ///// تاریخ تغییر رسته
        ///// </summary>
        public string? DAT_RST2 { get; set; }
        //////public virtual TblLuLookup yDatRst2 { get; set; }

        ///// <summary>
        ///// كد علت تغییر رسته
        ///// </summary>
        public string? ELL_RST { get; set; }
        //////public virtual TblLuLookup yEllRst { get; set; }

        ///// <summary>
        ///// گروه كارمندان تجربی
        ///// </summary>
        public string? EMP_GRH { get; set; }
        ////public virtual TblLuLookup yEmpGrh { get; set; }

        ///// <summary>
        ///// رده كارمندان تجربی
        ///// </summary>
        public string? EMP_RAD { get; set; }
        ////public virtual TblLuLookup yEmpRad { get; set; }

        ///// <summary>
        ///// كد تخصص اصلی
        ///// </summary> type=155 TBL_LOOKUPS_DATA
        public string? COD_TAA { get; set; }
        ////[ForeignKey("COD_TAA")]
        ////public virtual TblLuLookup _COD_TAA { get; set; }

        ///// <summary>
        ///// كد تخصص فرعی
        ///// </summary>
        public string? COD_TAF { get; set; }
        ////public virtual TblLuLookup yCodTaf { get; set; }

        ///// <summary>
        ///// كد تخصص خدمتی
        ///// </summary> type=155  TBL_LOOKUPS_DATA
        public string? COD_TAC { get; set; }
        ////[ForeignKey("COD_TAC")]
        ////public virtual TblLuLookup _COD_TAC { get; set; }

        ///// <summary>
        ///// شماره جدول سازمانی
        ///// </summary>
        public string? SHO_JGH { get; set; }
        ////public virtual TblLuLookup yShoJgh { get; set; }

        ///// <summary>
        ///// كد یگان سازمانی یا شغلی
        ///// </summary> type=254
        public string? COD_GHA { get; set; }
        ////[ForeignKey("COD_GHA")]
        ////public virtual TblLuLookup _COD_GHA { get; set; }

        ///// <summary>
        ///// ش بند
        ///// </summary>
        public string? BND_NUM { get; set; }
        ///// <summary>
        ///// ش سطر
        ///// </summary>
        public string? STR_NUM { get; set; }
        ///// <summary>
        ///// كد حداكثر درجه شغل
        ///// </summary> type=158 TBL_LOOKUPS_DATA
        public string? DRJ_CODJ { get; set; }
        ////[ForeignKey("DRJ_CODJ")]
        ////public virtual TblLuLookup _DRJ_CODJ { get; set; }

        ///// <summary>
        ///// تاریخ انتصاب
        ///// </summary>
        public string? DAT_ENT { get; set; }
        ///// <summary>
        ///// علت بدون شغل شدن
        ///// </summary>
        public string? VAZ_ENT { get; set; }
        ////public virtual TblLuLookup yVazEnt { get; set; }

        ///// <summary>
        ///// تاریخ خروج از انتصاب
        ///// </summary>
        public string? END_ENT { get; set; }
        ///// <summary>
        ///// در حال انتقال/انتساب بودن
        ///// </summary> type=45
        public string? VAZ_NGH { get; set; }
        ////[ForeignKey("VAZ_NGH")]
        ////public virtual TblLuLookup _VAZ_NGH { get; set; }

        public string? VAZ_NGHNAM { get; set; }

        ///// <summary>
        ///// كد یگان مادر
        ///// </summary> type=254
        public string? OMD_YEG { get; set; }
        ////[ForeignKey("OMD_YEG")]
        ////public virtual TblLuLookup _OMD_YEG { get; set; }

        ///// <summary>
        ///// كد یگان خدمتی  
        ///// </summary>  [TBL_UnitsInfo]
        public string? YEG_COD2 { get; set; }
        ////[ForeignKey("YEG_COD2")]
        ////public virtual TblUnitsInfo _YEG_COD2 { get; set; }

        ///// <summary>
        ///// تاریخ حضور در یگان خدمتی
        ///// </summary>
        public string? DAT_YEG2 { get; set; }
        ///// <summary>
        ///// منطقه محل خدمتی
        ///// </summary>
        public string? TYP_MNT { get; set; }
        ////public virtual TblLuLookup yTypMnt { get; set; }

        ///// <summary>
        ///// تاریخ شروع خدمت در منطقه خدمتی
        ///// </summary>
        public string? MNT_DAT { get; set; }
        ///// <summary>
        ///// كد یگان حقوقی
        ///// </summary> type=80
        public string? YEG_COD { get; set; }
        ////public virtual TblLuLookup yYegCod { get; set; }

        ///// <summary>
        ///// تارخ آخرین ترفیع
        ///// </summary>
        public string? PRE_DAT { get; set; }
        ///// <summary>
        ///// تاریخ ترفیع بعدی
        ///// </summary>
        public string? PRN_DAT { get; set; }
        ///// <summary>
        ///// ارشدیت اعمال شده
        ///// </summary>
        public string? CUR_ARS { get; set; }
        /// <summary>
        /// تنبیهات اعمال شده
        /// </summary>
        public string? CUR_TAN { get; set; }
        /// <summary>
        /// (ارشدیت اعمال نشده (قدمت 
        /// </summary>
        public string? NXT_ARS { get; set; }
        /// <summary>
        /// تنبیهات اعمال نشده
        /// </summary>
        public string? NXT_TAN { get; set; }
        /// <summary>
        /// مرخصی بدون حقوق طول خدمت
        /// </summary>
        public string? FRE_QTY { get; set; }
        /// <summary>
        /// مدت خدمت سربازی
        /// </summary>
        public string? SAR_QTY { get; set; }
        /// <summary>
        /// جمع مدت خدمت نیمه وقت بانوان طول خدمت
        /// </summary>
        public string? LAD_QTY { get; set; }
        /// <summary>
        /// تاریخ بازنشستگی
        /// </summary>
        public string? DAT_BAZ { get; set; }
        /// <summary>
        /// ارتقا تشویقی دارد /ندارد
        /// </summary>
        public string? NUM_ETSH { get; set; }
        /// <summary>
        /// میزان ارتقا حقوقی
        /// </summary>
        public string? NUM_EPAY { get; set; }
        /// <summary>
        /// تاریخ آخرین ارتقا حقوقی
        /// </summary>
        public string? DAT_EPAY { get; set; }
        /// <summary>
        /// مدت خدمت در منطقه عملیاتی قبل از قطعنامه
        /// </summary>
        public string? TOT_AML { get; set; }
        /// <summary>
        /// مدت خدمت در منطقه عملیاتی بعد از قطعنامه
        /// </summary>
        public string? TOT_AML2 { get; set; }
        ///// <summary>
        ///// كد زبان مادری یا محلی
        ///// </summary> type=48
        public string? ZAB_MAH { get; set; }
        ////[ForeignKey("ZAB_MAH")]
        ////public virtual TblLuLookup _ZAB_MAH { get; set; }

        public string? ZAB_MAHNAM { get; set; }


        /// <summary>
        /// .f.یا .t.-سابقه اسارت                             
        /// </summary>
        public string? VAZ_ESA { get; set; }
        /// <summary>
        /// .f.یا .t.-سابقه  گروگان بودن                      
        /// </summary>
        public string? VAZ_GRO { get; set; }
        /// <summary>
        /// كد طبقه پزشكی
        /// </summary>
        public string? NAZ_COD { get; set; }
        /// <summary>
        /// تاریخ معاینه پزشكی
        /// </summary>
        public string? DAT_NAZ { get; set; }
        /// <summary>
        /// كد نواقص پزشكی
        /// </summary>
        public string? BOD_COD { get; set; }
        /// <summary>
        /// میزان در صد جانبازی ارتش
        /// </summary>
        public string? DRSAD_JA { get; set; }
        /// <summary>
        /// میزان در صد جانبازی بنیاد
        /// </summary>
        public string? DRSAD_JB { get; set; }
        /// <summary>
        /// آدرس محل سكونت
        /// </summary>
        public string? ADDRES { get; set; }
        /// <summary>
        /// پیش شماره یا كد تلفن محل
        /// </summary>
        public string? COD_TEL { get; set; }
        /// <summary>
        /// شماره تلفن
        /// </summary>
        public string? TEL_NUM { get; set; }
        /// <summary>
        /// رنگ چشم
        /// </summary>
        public string? COL_EYE { get; set; }
        /// <summary>
        /// وزن
        /// </summary>
        public string? VAZN_PER { get; set; }
        /// <summary>
        /// قد
        /// </summary>
        public string? HIG_PER { get; set; }
        /// <summary>
        /// اندازه پا
        /// </summary>
        public string? SIZ_FOT { get; set; }
        /// <summary>
        /// اندازه كلاه
        /// </summary>
        public string? SIZ_KLA { get; set; }
        /// <summary>
        /// چك مشخصات پرسنلی با اطلاعات سوابق
        /// </summary>
        public string? OK_SAB { get; set; }
        /// <summary>
        /// یگان فرستنده
        /// </summary>
        public string? FER_YEG { get; set; }
        /// <summary>
        /// ( اعاده/ابقا (یك = ابقا - دو= اعاده 
        /// </summary> type=147
        public string? RET_COD { get; set; }
        //[ForeignKey("RET_COD")]
        //public virtual TblLuLookup _RET_COD { get; set; }

        public string? RET_CODNAM { get; set; }


        /// <summary>
        /// وضعیت پرنده فرار - مفتوحه است یا نه
        /// </summary>
        public string? VAZ_FAR { get; set; }
        /// <summary>
        /// نوع اعلام حضور
        /// </summary>
        public string? T_ENTER { get; set; }
        /// <summary>
        /// سویچ چاپ فرم شناسایی
        /// </summary>
        public string? SW_PRT { get; set; }
        /// <summary>
        /// كلید شغل
        /// </summary>
        public string? KLD_SHGL { get; set; }
        /// <summary>
        /// مدت قدمت درجه فعلی
        /// </summary>
        public string? GED_OT { get; set; }
        /// <summary>
        /// كورس ترفیعاتی
        /// </summary>
        public string? CORS_T { get; set; }
        /// <summary>
        /// كد رشد تخصصی فرد
        /// </summary> type=160 TBL_LOOKUPS_DATA
        public string? ROSH_P { get; set; }
        //[ForeignKey("ROSH_P")]
        //public virtual TblLuLookup _ROSH_P { get; set; }

        public string? ROSH_PNAM { get; set; }


        //type=80
        public string? GHE_SHR { get; set; }

        /// <summary>
        /// كد هویت شغل
        /// </summary>
        public string? COD_C1 { get; set; }
        /// <summary>
        /// كد ماهیت یگان شغل
        /// </summary>
        public string? COD_C2 { get; set; }
        /// <summary>
        /// كد نوع شغل
        /// </summary>
        public string? COD_C3 { get; set; }
        /// <summary>
        /// كد نوع پذیرش شغل
        /// </summary>
        public string? COD_C4 { get; set; }
        /// <summary>
        /// كد رشد تخصصی شغل
        /// </summary> type=160  TBL_LOOKUPS_DATA
        public string? COD_C12 { get; set; }
        //[ForeignKey("COD_C12")]
        //public virtual TblLuLookup _COD_C12 { get; set; }

        /// <summary>
        /// كد رسته شغل
        /// </summary> type=157 TBL_LOOKUPS_DATA
        public string? COD_C78 { get; set; }
        //[ForeignKey("COD_C78")]
        //public virtual TblLuLookup _COD_C78 { get; set; }

        /// <summary>
        /// عنوان شغل
        /// </summary>
        public string? JOB_DES { get; set; }
        /// <summary>
        /// تاریخ ارتقا بعدی
        /// </summary>
        public string? DAT_ERTB { get; set; }
        public string? DAT_ERTG { get; set; }
        public string? TYP_GHE { get; set; }
        /// <summary>
        /// تاریخ رسمی شدن
        /// </summary>
        public string? DAT_RAS { get; set; }
        /// <summary>
        ///  نوع خدمت كارمندی
        /// </summary>
        public string? CHG_TYP { get; set; }
        public string? KHD_TYP { get; set; }
        public string? SOT_DAT { get; set; }
        public string? DAT_NGH { get; set; }
        public string? DAT_OMD { get; set; }
        /// <summary>
        /// نوع قشر
        /// </summary> type=112
        public string? GHESHR { get; set; }
        //[ForeignKey("GHESHR")]
        //public virtual TblLuLookup _GHESHR { get; set; }

        public string? GHESHRNAM { get; set; }

        public string? COD4 { get; set; }
        /// <summary>
        /// تاریخ بازنشستگی بر اساس 60 سال سن
        /// </summary>
        public string? DAT_BAZS { get; set; }
        public string? EmployArchismDuration { get; set; }
        public string? EmployUniversityCode { get; set; }
        public string? EmploySectionCode { get; set; }
        public string? EmployServiceTypeCode { get; set; }
        public string? LengthCode { get; set; }
        public string? PeopleCode { get; set; }
        /// <summary>
        /// تنزیل درجه
        /// </summary> type=80
        public string? DiscountStatus { get; set; }
        //public virtual TblLuLookup yDiscountStatus { get; set; }

        public string? CHG_TAR { get; set; }
        /// <summary>
        /// سابقه انتصاباتی نیاز به  اصلاح دارد
        /// </summary>
        public string? CHG_ENT { get; set; }
        /// <summary>
        /// تاریخ شروع طبقه پزشكی
        /// </summary>
        public string? datMedicalClassBegin { get; set; }
        /// <summary>
        /// تاریخ پایان طبقه پزشكی
        /// </summary>
        public string? datMedicalClassEnd { get; set; }
        public string? HasChanged { get; set; }
        public string? LastChangeTime { get; set; }
        public string? HasYegan { get; set; }
        public string? LastYegan { get; set; }
        public string? YEG_COD2_Tmp { get; set; }
        public string? HasYegan_Tmp { get; set; }
        public string? MAK_SR { get; set; }
        [Key]
        public string? MelliCode { get; set; }
        ////type=26
        public string? DeliverTypeCode { get; set; }
        ////[ForeignKey("DeliverTypeCode")]
        ////public virtual TblLuLookup _DeliverTypeCode { get; set; }
        public string? DeliverTypeNAM { get; set; }

        public string? Tel_workplace { get; set; }
        public string? Tel_mobile { get; set; }
        public string? Postcode { get; set; }
        public string? code_mosalsal { get; set; }
        public string? shomareh_seri { get; set; }
        public string? harfe_seri { get; set; }

        /////// <summary>
        ///////  نام لاتین
        /////// </summary>
        ////public string? FstNamEN { get; set; }
        /////// <summary>
        /////// نام خانوادگی لاتین
        /////// </summary>
        ////public string? LstNamEN { get; set; }
        /////// <summary>
        /////// ریت پروازی
        /////// </summary>
        ////public string? RateFlight { get; set; }


        #region "This Is TblMaster"
        public string? RasmiVazifeh { get; set; }
        /// <summary>
        /// یگان
        ///// </summary>
        //public int? UnitID01 { get; set; }
        ///// <summary>
        ///// یگان
        ///// </summary>
        //public int? UitID01 { get; set; }

        //public int? UitIDGaurd01 { get; set; }

        //public string? SUMSPd { get; set; }
        //public string? SUMCPd { get; set; }
        //public string? SUMPd { get; set; }
        //public string? SUMTPd { get; set; }
        //public string? SUMIPd { get; set; }
        //public string? SUMSIPd { get; set; }
        //public string? SUMSPN { get; set; }
        //public string? SUMCPN { get; set; }
        //public string? SUMPN { get; set; }
        //public string? SUMIPN { get; set; }
        //public string? SUMSIPN { get; set; }
        //public string? SUMYN { get; set; }
        //public string? SUMSPNY { get; set; }
        //public string? SUMCPNY { get; set; }
        //public string? SUMPNY { get; set; }
        //public string? SUMIPNY { get; set; }
        //public string? SUMSIPNY { get; set; }
        //public string? SUMSIM { get; set; }
        //public string? SUMHOOD { get; set; }
        //public string? SUMSPHOOD { get; set; }
        //public string? SUMCPHOOD { get; set; }
        //public string? SUMPHOOD { get; set; }
        //public string? SUMIPHOOD { get; set; }
        //public string? SUMSIPHOOD { get; set; }

        //public string? SUMSPdNew01 { get; set; }
        //public string? SUMCPdNew01 { get; set; }
        //public string? SUMPdNew01 { get; set; }
        //public string? SUMTPdNew01 { get; set; }
        //public string? SUMIPdNew01 { get; set; }
        //public string? SUMSIPdNew01 { get; set; }
        //public string? SUMSPNNew01 { get; set; }
        //public string? SUMCPNNew01 { get; set; }
        //public string? SUMPNNew01 { get; set; }
        //public string? SUMIPNNew01 { get; set; }
        //public string? SUMSIPNNew01 { get; set; }
        //public string? SUMYNNew01 { get; set; }
        //public string? SUMSPNYNew01 { get; set; }
        //public string? SUMCPNYNew01 { get; set; }
        //public string? SUMPNYNew01 { get; set; }
        //public string? SUMIPNYNew01 { get; set; }
        //public string? SUMSIPNYNew01 { get; set; }
        //public string? SUMSIMNew01 { get; set; }
        //public string? SUMHOODNew01 { get; set; }
        //public string? SUMSPHOODNew01 { get; set; }
        //public string? SUMCPHOODNew01 { get; set; }
        //public string? SUMPHOODNew01 { get; set; }
        //public string? SUMIPHOODNew01 { get; set; }
        //public string? SUMSIPHOODNew01 { get; set; }

        ///// <summary>
        /////روز اعتبار تا لغو مجوز پرواز
        ///// </summary>

        //public string? DayValidFlight { get; set; }

        ///// <summary>
        /////TotalFlightTime
        ///// </summary>
        //public string? TotalFlightTime { get; set; }
        //public TimeSpan? TotalFlightTimeTimeSpan { get; set; }
        //public DateTime? TotalFlightTimeDateTime { get; set; }

        ///// <summary>
        /////LastFlightDate
        ///// </summary>
        //public string? LastFlightDate { get; set; }

        //[Display(Name = "نام لاتین")]
        //public string? FstNamEN { get; set; }
        //[Display(Name = "نام خانوادگي لاتین")]
        //public string? LstNamEN { get; set; }


        ////[Key]
        ////public Nullable<int> NewsId { get; set; }

        ////[Display(Name = "عنوان خبر")]
        ////[Required(AllowEmptyStrings = false, ErrorMessage = "عنوان خبر وارد نشده است.")]
        //////[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        ////////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        ////public string? Title { get; set; }






        ////[Key]
        ////public string? PersonID { get; set; }
        ///// <summary>
        ///// شماره پرسنلی
        ///// </summary>
        //[Display(Name = "شماره کارگزینی")]
        //public string? EMP_NUM { get; set; }
        ///// <summary>
        ///// نام
        ///// </summary>
        //[Display(Name = "نام")]
        //public string? FST_NAM { get; set; }
        ///// <summary>
        ///// نام خانوادگی
        ///// </summary>
        //[Display(Name = "")]
        //public string? LST_NAM { get; set; }
        ///// <summary>
        ///// نام قبلی
        ///// </summary>
        //[Display(Name = "")]
        //public string? GBL_FNAM { get; set; }
        ///// <summary>
        ///// نام خانوادگی قبلی
        ///// </summary>
        //[Display(Name = "")]
        //public string? GBL_LNAM { get; set; }
        ///// <summary>
        ///// نام پدر
        ///// </summary>
        //public string? FAT_NAM { get; set; }
        ///// </summary>
        //[Display(Name = "")]
        ///// ش شناسنامه
        ///// </summary>
        //public string? INF_NUM { get; set; }
        ///// <summary>
        ///// محل تولد
        ///// </summary>
        //[Display(Name = "")]
        //public string? BRT_COD { get; set; }
        ////[ForeignKey("BRT_COD")]

        ////public virtual CityType _BRT_COD { get; set; }

        ///// <summary>
        ///// تاریخ تولد
        ///// </summary>
        //[Display(Name = "")]
        //public string? BRT_DAT { get; set; }
        ///// <summary>
        ///// محل صدور
        ///// </summary>
        //public string? ISS_COD { get; set; }
        ////[ForeignKey("ISS_COD")]

        ////public virtual CityType _ISS_COD { get; set; }





        ///// <summary>
        ///// تاریخ صدور
        ///// </summary>
        //public string? ISS_DAT { get; set; }
        ///// <summary>
        ///// گروه خون
        ///// </summary>  type=47
        //public string? BLG_COD { get; set; }
        ////[ForeignKey("BLG_COD")]
        ////public virtual TblLuLookup _BLG_COD { get; set; }

        ///// <summary>
        ///// دین مذهب
        ///// </summary> type=99
        //public string? REL_COD { get; set; }
        ////[ForeignKey("REL_COD")]

        ////public virtual TblLuLookup _REL_COD { get; set; }
        ///// <summary>
        ///// كد دین و مذهب قبلی
        ///// </summary> type=99
        //public string? REL_COD2 { get; set; }
        ///// </summary> 
        ////[ForeignKey("REL_COD2")]
        ////public virtual TblLuLookup _REL_COD2 { get; set; }
        ///// <summary>
        ///// جنسیت
        ///// </summary>  type=32
        //public string? SEX_COD { get; set; }
        ////[ForeignKey("SEX_COD")]

        ////public virtual TblLuLookup _SEX_COD { get; set; }
        ///// <summary>
        ///// وضعیت تاهل
        ///// </summary>type=23
        //public string? MAR_COD { get; set; }
        ////[ForeignKey("MAR_COD")]

        ////public virtual TblLuLookup _MAR_COD { get; set; }

        ///// <summary> 
        ///// تعداد همسر
        ///// </summary>
        //public string? WIF_QTY { get; set; }
        ///// <summary>
        ///// تعداد عائله بجز همسر و اولاد
        ///// </summary>
        //public string? FAM_QTY { get; set; }
        ///// <summary>
        ///// تعداد اولاد پسر
        ///// </summary>
        //public string? SUN_QTY { get; set; }
        ///// <summary>
        ///// تعداد اولاد دختر
        ///// </summary>
        //public string? DOT_QTY { get; set; }
        ///// </summary>
        ///// وضعیت سكونت - خانه سازمانی یا كانتینر
        ///// </summary> type=80
        //public string? MAS_COD { get; set; }
        ////[ForeignKey("MAS_COD")]

        ////public virtual TblLuLookup _MAS_COD { get; set; }
        ///// <summary>
        /////  تاریخ شروع وضعیت مسكونی
        ///// </summary>
        //public string? HOM_DAT { get; set; }
        ///// <summary>
        ///// تاریخ استخدام
        ///// </summary>
        //public string? EMP_DAT { get; set; }
        ///// <summary>
        ///// نوع استخدام
        ///// </summary>type=123
        //public string? TYP_EMP { get; set; }
        ////[ForeignKey("TYP_EMP")]

        ////public virtual TblLuLookup _TYP_EMP { get; set; }
        ///// </summary>
        ///// /// مدرك یا ماده دستور استخدام
        ///// </summary>
        //public string? EMP_ORD { get; set; }
        ////public virtual TblLuLookup yEmpOrd { get; set; }

        ///// <summary>
        ///// كد یگان صاحب دستور استخدام
        ///// </summary>
        //public string? EMP_YEG { get; set; }
        ////public virtual TblLuLookup y { get; set; }

        ///// <summary>
        ///// فرمان یا دستور استخدام رده بالاتر
        ///// </summary>
        //public string? EMP_ORD2 { get; set; }
        ////public virtual TblLuLookup yEmpOrd2 { get; set; }

        ///// <summary>
        ///// كد مدرك تحصیلی بدو استخدام
        ///// </summary>
        //public string? EDF_COD { get; set; }
        ////public virtual TblLuLookup yEdfCod { get; set; }

        ///// <summary>
        ///// كد هویت خدمتی
        ///// </summary>  type=151
        //public string? EMS_COD { get; set; }
        ////[ForeignKey("EMS_COD")]

        ////public virtual TblLuLookup _EMS_COD { get; set; }

        ///// <summary>
        ///// كد نوع تغییر وضعیت
        ///// </summary> type=251
        //public string? CHG_COD { get; set; }
        ////[ForeignKey("CHG_COD")]

        ////public virtual TblLuLookup _CHG_COD { get; set; }

        ///// <summary>
        ///// كد آخرین مدرك تحصیلی
        ///// </summary> type=11
        //public string? EDE_COD { get; set; }
        ////[ForeignKey("EDE_COD")]
        ////public virtual TblLuLookup _EDE_COD { get; set; }

        ///// <summary>
        ///// كد رشته مدرك تحصیلی
        ///// </summary>
        //public string? SUB_COD { get; set; }
        ////public virtual TblLuLookup ySubCod { get; set; }

        ///// <summary>
        ///// تاریخ آخرین مدرك تحصیلی
        ///// </summary>
        //public string? EDE_DAT { get; set; }
        ////public virtual TblLuLookup yEdeDat { get; set; }

        ///// <summary>
        ///// كد آخرین دوره طولی نظامی
        ///// </summary> type=90  TBL_LOOKUPS_DATA
        //public string? LDOR_NEZ { get; set; }
        ////[ForeignKey("LDOR_NEZ")]
        ////public virtual TblLuLookup _LDOR_NEZ { get; set; }

        ///// <summary>
        ///// كد وضعیت از لحاظ خدمت
        ///// </summary> type=9
        //public string? DUS_COD { get; set; }
        ////[ForeignKey("DUS_COD")]
        ////public virtual TblLuLookup _DUS_COD { get; set; }

        ///// <summary>
        ///// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        ///// </summary>
        //public string? CUR_JOB { get; set; }
        ///// <summary>
        ///// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        ///// </summary>
        //public string? HAZ_COD { get; set; }
        ///// <summary>
        ///// كد درجه / رتبه
        ///// </summary> type=10
        //public string? DRJ_COD { get; set; }
        ////[ForeignKey("DRJ_COD")]
        ////public virtual TblLuLookup _DRJ_COD { get; set; }
        //public string? UitID01 { get; set; }

        //public string? DRJ_NAM { get; set; }
        //public string? RST_NAM { get; set; }

        ///// <summary>
        ///// كد درجه اصلی
        ///// </summary>
        //public string? DRJ_CODA { get; set; }
        ////public virtual TblLuLookup yDrjCoda { get; set; }

        ///// <summary>
        ///// نوع درجه - 0=دائم-1=موقت-2=مجازی
        ///// </summary> type=36
        //public string? DRJ_STT { get; set; }
        ////[ForeignKey("DRJ_STT")]
        ////public virtual TblLuLookup _DRJ_STT { get; set; }

        ///// <summary>
        ///// كد رسته
        ///// </summary> type=30
        //public string? RST_COD { get; set; }
        ////[ForeignKey("RST_COD")]
        ////public virtual TblLuLookup _RST_COD { get; set; }

        ///// <summary>
        ///// كد رسته قبلی
        ///// </summary>
        //public string? RST_COD2 { get; set; }
        ////public virtual TblLuLookup yRstCod2 { get; set; }

        ///// <summary>
        ///// تاریخ تغییر رسته
        ///// </summary>
        //public string? DAT_RST2 { get; set; }
        //////public virtual TblLuLookup yDatRst2 { get; set; }

        ///// <summary>
        ///// كد علت تغییر رسته
        ///// </summary>
        //public string? ELL_RST { get; set; }
        //////public virtual TblLuLookup yEllRst { get; set; }

        ///// <summary>
        ///// گروه كارمندان تجربی
        ///// </summary>
        //public string? EMP_GRH { get; set; }
        ////public virtual TblLuLookup yEmpGrh { get; set; }

        ///// <summary>
        ///// رده كارمندان تجربی
        ///// </summary>
        //public string? EMP_RAD { get; set; }
        ////public virtual TblLuLookup yEmpRad { get; set; }

        ///// <summary>
        ///// كد تخصص اصلی
        ///// </summary> type=155 TBL_LOOKUPS_DATA
        //public string? COD_TAA { get; set; }
        ////[ForeignKey("COD_TAA")]
        ////public virtual TblLuLookup _COD_TAA { get; set; }

        ///// <summary>
        ///// كد تخصص فرعی
        ///// </summary>
        //public string? COD_TAF { get; set; }
        ////public virtual TblLuLookup yCodTaf { get; set; }

        ///// <summary>
        ///// كد تخصص خدمتی
        ///// </summary> type=155  TBL_LOOKUPS_DATA
        //public string? COD_TAC { get; set; }
        ////[ForeignKey("COD_TAC")]
        ////public virtual TblLuLookup _COD_TAC { get; set; }

        ///// <summary>
        ///// شماره جدول سازمانی
        ///// </summary>
        //public string? SHO_JGH { get; set; }
        ////public virtual TblLuLookup yShoJgh { get; set; }

        ///// <summary>
        ///// كد یگان سازمانی یا شغلی
        ///// </summary> type=254
        //public string? COD_GHA { get; set; }
        ////[ForeignKey("COD_GHA")]
        ////public virtual TblLuLookup _COD_GHA { get; set; }

        ///// <summary>
        ///// ش بند
        ///// </summary>
        //public string? BND_NUM { get; set; }
        ///// <summary>
        ///// ش سطر
        ///// </summary>
        //public string? STR_NUM { get; set; }
        ///// <summary>
        ///// كد حداكثر درجه شغل
        ///// </summary> type=158 TBL_LOOKUPS_DATA
        //public string? DRJ_CODJ { get; set; }
        ////[ForeignKey("DRJ_CODJ")]
        ////public virtual TblLuLookup _DRJ_CODJ { get; set; }

        ///// <summary>
        ///// تاریخ انتصاب
        ///// </summary>
        //public string? DAT_ENT { get; set; }
        ///// <summary>
        ///// علت بدون شغل شدن
        ///// </summary>
        //public string? VAZ_ENT { get; set; }
        ////public virtual TblLuLookup yVazEnt { get; set; }

        ///// <summary>
        ///// تاریخ خروج از انتصاب
        ///// </summary>
        //public string? END_ENT { get; set; }
        ///// <summary>
        ///// در حال انتقال/انتساب بودن
        ///// </summary> type=45
        //public string? VAZ_NGH { get; set; }
        ////[ForeignKey("VAZ_NGH")]
        ////public virtual TblLuLookup _VAZ_NGH { get; set; }

        ///// <summary>
        ///// كد یگان مادر
        ///// </summary> type=254
        //public string? OMD_YEG { get; set; }
        ////[ForeignKey("OMD_YEG")]
        ////public virtual TblLuLookup _OMD_YEG { get; set; }

        ///// <summary>
        ///// كد یگان خدمتی  
        ///// </summary>  [TBL_UnitsInfo]
        //public string? YEG_COD2 { get; set; }
        ////[ForeignKey("YEG_COD2")]
        ////public virtual TblUnitsInfo _YEG_COD2 { get; set; }

        ///// <summary>
        ///// تاریخ حضور در یگان خدمتی
        ///// </summary>
        //public string? DAT_YEG2 { get; set; }
        ///// <summary>
        ///// منطقه محل خدمتی
        ///// </summary>
        //public string? TYP_MNT { get; set; }
        ////public virtual TblLuLookup yTypMnt { get; set; }

        ///// <summary>
        ///// تاریخ شروع خدمت در منطقه خدمتی
        ///// </summary>
        //public string? MNT_DAT { get; set; }
        ///// <summary>
        ///// كد یگان حقوقی
        ///// </summary> type=80
        //public string? YEG_COD { get; set; }
        ////public virtual TblLuLookup yYegCod { get; set; }

        ///// <summary>
        ///// تارخ آخرین ترفیع
        ///// </summary>
        //public string? PRE_DAT { get; set; }
        ///// <summary>
        ///// تاریخ ترفیع بعدی
        ///// </summary>
        //public string? PRN_DAT { get; set; }
        ///// <summary>
        ///// ارشدیت اعمال شده
        ///// </summary>
        //public string? CUR_ARS { get; set; }
        ///// <summary>
        ///// تنبیهات اعمال شده
        ///// </summary>
        //public string? CUR_TAN { get; set; }
        ///// <summary>
        ///// (ارشدیت اعمال نشده (قدمت 
        ///// </summary>
        //public string? NXT_ARS { get; set; }
        ///// <summary>
        ///// تنبیهات اعمال نشده
        ///// </summary>
        //public string? NXT_TAN { get; set; }
        ///// <summary>
        ///// مرخصی بدون حقوق طول خدمت
        ///// </summary>
        //public string? FRE_QTY { get; set; }
        ///// <summary>
        ///// مدت خدمت سربازی
        ///// </summary>
        //public string? SAR_QTY { get; set; }
        ///// <summary>
        ///// جمع مدت خدمت نیمه وقت بانوان طول خدمت
        ///// </summary>
        //public string? LAD_QTY { get; set; }
        ///// <summary>
        ///// تاریخ بازنشستگی
        ///// </summary>
        //public string? DAT_BAZ { get; set; }
        ///// <summary>
        ///// ارتقا تشویقی دارد /ندارد
        ///// </summary>
        //public string? NUM_ETSH { get; set; }
        ///// <summary>
        ///// میزان ارتقا حقوقی
        ///// </summary>
        //public string? NUM_EPAY { get; set; }
        ///// <summary>
        ///// تاریخ آخرین ارتقا حقوقی
        ///// </summary>
        //public string? DAT_EPAY { get; set; }
        ///// <summary>
        ///// مدت خدمت در منطقه عملیاتی قبل از قطعنامه
        ///// </summary>
        //public string? TOT_AML { get; set; }
        ///// <summary>
        ///// مدت خدمت در منطقه عملیاتی بعد از قطعنامه
        ///// </summary>
        //public string? TOT_AML2 { get; set; }
        ///// <summary>
        ///// كد زبان مادری یا محلی
        ///// </summary> type=48
        //public string? ZAB_MAH { get; set; }
        ////[ForeignKey("ZAB_MAH")]
        ////public virtual TblLuLookup _ZAB_MAH { get; set; }

        ///// <summary>
        ///// .f.یا .t.-سابقه اسارت                             
        ///// </summary>
        //public string? VAZ_ESA { get; set; }
        ///// <summary>
        ///// .f.یا .t.-سابقه  گروگان بودن                      
        ///// </summary>
        //public string? VAZ_GRO { get; set; }
        ///// <summary>
        ///// كد طبقه پزشكی
        ///// </summary>
        //public string? NAZ_COD { get; set; }
        ///// <summary>
        ///// تاریخ معاینه پزشكی
        ///// </summary>
        //public string? DAT_NAZ { get; set; }
        ///// <summary>
        ///// كد نواقص پزشكی
        ///// </summary>
        //public string? BOD_COD { get; set; }
        ///// <summary>
        ///// میزان در صد جانبازی ارتش
        ///// </summary>
        //public string? DRSAD_JA { get; set; }
        ///// <summary>
        ///// میزان در صد جانبازی بنیاد
        ///// </summary>
        //public string? DRSAD_JB { get; set; }
        ///// <summary>
        ///// آدرس محل سكونت
        ///// </summary>
        //public string? ADDRES { get; set; }
        ///// <summary>
        ///// پیش شماره یا كد تلفن محل
        ///// </summary>
        //public string? COD_TEL { get; set; }
        ///// <summary>
        ///// شماره تلفن
        ///// </summary>
        //public string? TEL_NUM { get; set; }
        ///// <summary>
        ///// رنگ چشم
        ///// </summary>
        //public string? COL_EYE { get; set; }
        ///// <summary>
        ///// وزن
        ///// </summary>
        //public string? VAZN_PER { get; set; }
        ///// <summary>
        ///// قد
        ///// </summary>
        //public string? HIG_PER { get; set; }
        ///// <summary>
        ///// اندازه پا
        ///// </summary>
        //public string? SIZ_FOT { get; set; }
        ///// <summary>
        ///// اندازه كلاه
        ///// </summary>
        //public string? SIZ_KLA { get; set; }
        ///// <summary>
        ///// چك مشخصات پرسنلی با اطلاعات سوابق
        ///// </summary>
        //public string? OK_SAB { get; set; }
        ///// <summary>
        ///// یگان فرستنده
        ///// </summary>
        //public string? FER_YEG { get; set; }
        ///// <summary>
        ///// ( اعاده/ابقا (یك = ابقا - دو= اعاده 
        ///// </summary> type=147
        //public string? RET_COD { get; set; }
        ////[ForeignKey("RET_COD")]
        ////public virtual TblLuLookup _RET_COD { get; set; }

        ///// <summary>
        ///// وضعیت پرنده فرار - مفتوحه است یا نه
        ///// </summary>
        //public string? VAZ_FAR { get; set; }
        ///// <summary>
        ///// نوع اعلام حضور
        ///// </summary>
        //public string? T_ENTER { get; set; }
        ///// <summary>
        ///// سویچ چاپ فرم شناسایی
        ///// </summary>
        //public string? SW_PRT { get; set; }
        ///// <summary>
        ///// كلید شغل
        ///// </summary>
        //public string? KLD_SHGL { get; set; }
        ///// <summary>
        ///// مدت قدمت درجه فعلی
        ///// </summary>
        //public string? GED_OT { get; set; }
        ///// <summary>
        ///// كورس ترفیعاتی
        ///// </summary>
        //public string? CORS_T { get; set; }
        ///// <summary>
        ///// كد رشد تخصصی فرد
        ///// </summary> type=160 TBL_LOOKUPS_DATA
        //public string? ROSH_P { get; set; }
        ////[ForeignKey("ROSH_P")]
        ////public virtual TblLuLookup _ROSH_P { get; set; }
        ////type=80
        //public string? GHE_SHR { get; set; }
        public string? GHE_SHR01 { get; set; }



        ///// <summary>
        ///// كد هویت شغل
        ///// </summary>
        //public string? COD_C1 { get; set; }
        ///// <summary>
        ///// كد ماهیت یگان شغل
        ///// </summary>
        //public string? COD_C2 { get; set; }
        ///// <summary>
        ///// كد نوع شغل
        ///// </summary>
        //public string? COD_C3 { get; set; }
        ///// <summary>
        ///// كد نوع پذیرش شغل
        ///// </summary>
        //public string? COD_C4 { get; set; }
        ///// <summary>
        ///// كد رشد تخصصی شغل
        ///// </summary> type=160  TBL_LOOKUPS_DATA
        //public string? COD_C12 { get; set; }
        ////[ForeignKey("COD_C12")]
        ////public virtual TblLuLookup _COD_C12 { get; set; }

        ///// <summary>
        ///// كد رسته شغل
        ///// </summary> type=157 TBL_LOOKUPS_DATA
        //public string? COD_C78 { get; set; }
        ////[ForeignKey("COD_C78")]
        ////public virtual TblLuLookup _COD_C78 { get; set; }

        ///// <summary>
        ///// عنوان شغل
        ///// </summary>
        //public string? JOB_DES { get; set; }
        ///// <summary>
        ///// تاریخ ارتقا بعدی
        ///// </summary>
        //public string? DAT_ERTB { get; set; }
        //public string? DAT_ERTG { get; set; }
        //public string? TYP_GHE { get; set; }
        ///// <summary>
        ///// تاریخ رسمی شدن
        ///// </summary>
        //public string? DAT_RAS { get; set; }
        ///// <summary>
        /////  نوع خدمت كارمندی
        ///// </summary>
        //public string? CHG_TYP { get; set; }
        //public string? KHD_TYP { get; set; }
        //public string? SOT_DAT { get; set; }
        //public string? DAT_NGH { get; set; }
        //public string? DAT_OMD { get; set; }
        ///// <summary>
        ///// نوع قشر
        ///// </summary> type=112
        //public string? GHESHR { get; set; }
        ////[ForeignKey("GHESHR")]
        ////public virtual TblLuLookup _GHESHR { get; set; }

        //public string? COD4 { get; set; }
        ///// <summary>
        ///// تاریخ بازنشستگی بر اساس 60 سال سن
        ///// </summary>
        //public string? DAT_BAZS { get; set; }
        //public string? EmployArchismDuration { get; set; }
        //public string? EmployUniversityCode { get; set; }
        //public string? EmploySectionCode { get; set; }
        //public string? EmployServiceTypeCode { get; set; }
        //public string? LengthCode { get; set; }
        //public string? PeopleCode { get; set; }
        ///// <summary>
        ///// تنزیل درجه
        ///// </summary> type=80
        //public string? DiscountStatus { get; set; }
        ////public virtual TblLuLookup yDiscountStatus { get; set; }

        //public string? CHG_TAR { get; set; }
        ///// <summary>
        ///// سابقه انتصاباتی نیاز به  اصلاح دارد
        ///// </summary>
        //public string? CHG_ENT { get; set; }
        ///// <summary>
        ///// تاریخ شروع طبقه پزشكی
        ///// </summary>
        //public string? datMedicalClassBegin { get; set; }
        ///// <summary>
        ///// تاریخ پایان طبقه پزشكی
        ///// </summary>
        //public string? datMedicalClassEnd { get; set; }
        //public string? HasChanged { get; set; }
        //public string? LastChangeTime { get; set; }
        //public string? HasYegan { get; set; }
        //public string? LastYegan { get; set; }
        //public string? YEG_COD2_Tmp { get; set; }
        //public string? HasYegan_Tmp { get; set; }
        //public string? MAK_SR { get; set; }
        //[Key]
        //public string? MelliCode { get; set; }
        ////type=26
        //public string? DeliverTypeCode { get; set; }
        ////[ForeignKey("DeliverTypeCode")]
        ////public virtual TblLuLookup _DeliverTypeCode { get; set; }

        //public string? Tel_workplace { get; set; }
        //public string? Tel_mobile { get; set; }
        //public string? Postcode { get; set; }
        //public string? code_mosalsal { get; set; }
        //public string? shomareh_seri { get; set; }
        //public string? harfe_seri { get; set; }

        /////// <summary>
        ///////  نام لاتین
        ///// </summary>
        //public string? FstNamEN { get; set; }
        ///// <summary>
        ///// نام خانوادگی لاتین
        ///// </summary>
        //public string? LstNamEN { get; set; }
        ///// <summary>
        ///// ریت پروازی
        ///// </summary>
        //public string? RateFlight { get; set; }
        #endregion







    }

    public class TblMasterViewModelEditold
    {

        /// <summary>
        /// یگان
        /// </summary>
        public int? UitID01 { get; set; }
        /// <summary>
        /// یگان
        /// </summary>
        public string? strUitID01 { get; set; }

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
        /// <summary>
        ///روز اعتبار تا لغو مجوز پرواز
        /// </summary>

        public string? DayValidFlight { get; set; }

        /// <summary>
        ///TotalFlightTime
        /// </summary>
        public string? TotalFlightTime { get; set; }
        public TimeSpan? TotalFlightTimeTimeSpan { get; set; }
        public DateTime? TotalFlightTimeDateTime { get; set; }

        /// <summary>
        ///LastFlightDate
        /// </summary>
        public string? LastFlightDate { get; set; }

        /// <summary>
        ///  تلفن 
        /// </summary>
        public string? Phone01 { get; set; }

        /// <summary>
        ///  تلفن 
        /// </summary>
        public string? Phone01ALL { get; set; }


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



        [Display(Name = "نام لاتین")]
        public string? FstNamEN { get; set; }
        [Display(Name = "نام خانوادگي لاتین")]
        public string? LstNamEN { get; set; }

        //[Key]
        //public Nullable<int> NewsId { get; set; }

        //[Display(Name = "عنوان خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "عنوان خبر وارد نشده است.")]
        ////[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string? Title { get; set; }






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
        /// <summary>
        /// نام قبلی
        /// </summary>
        [Display(Name = "نام قبلی")]
        public string? GBL_FNAM { get; set; }
        ///// <summary>
        ///// نام خانوادگی قبلی
        ///// </summary>
        [Display(Name = "نام خانوادگی قبلی")]
        public string? GBL_LNAM { get; set; }
        ///// <summary>
        ///// نام پدر
        ///// </summary>
        [Display(Name = "نام پدر")]

        public string? FAT_NAM { get; set; }
        ///// </summary>
        [Display(Name = "ش شناسنامه")]
        ///// ش شناسنامه
        ///// </summary>
        public string? INF_NUM { get; set; }
        ///// <summary>
        ///// محل تولد
        ///// </summary>
        [Display(Name = "محل تولد")]
        public string? BRT_COD { get; set; }
        ////[ForeignKey("BRT_COD")]

        ////public virtual CityType _BRT_COD { get; set; }

        ///// <summary>
        ///// تاریخ تولد
        ///// </summary>
        [Display(Name = "تاریخ تولد")]
        public string? BRT_DAT { get; set; }

        public string? MAR_DAT { get; set; }

        ///// <summary>
        ///// محل صدور
        ///// </summary>
        [Display(Name = "محل صدور")]
        public string? ISS_COD { get; set; }
        ////[ForeignKey("ISS_COD")]

        ////public virtual CityType _ISS_COD { get; set; }





        ///// <summary>
        ///// تاریخ صدور
        ///// </summary>
        [Display(Name = "تاریخ صدور")]
        public string? ISS_DAT { get; set; }
        ///// <summary>
        ///// گروه خون
        ///// </summary>  type=47
        public string? BLG_COD { get; set; }
        ////[ForeignKey("BLG_COD")]
        ////public virtual TblLuLookup _BLG_COD { get; set; }

        ///// <summary>
        ///// دین مذهب
        ///// </summary> type=99
        public string? REL_COD { get; set; }
        ////[ForeignKey("REL_COD")]

        ////public virtual TblLuLookup _REL_COD { get; set; }
        ///// <summary>
        ///// كد دین و مذهب قبلی
        ///// </summary> type=99
        public string? REL_COD2 { get; set; }
        ///// </summary> 
        ////[ForeignKey("REL_COD2")]
        ////public virtual TblLuLookup _REL_COD2 { get; set; }
        ///// <summary>
        ///// جنسیت
        ///// </summary>  type=32
        public string? SEX_COD { get; set; }
        ////[ForeignKey("SEX_COD")]




        ///// <summary>
        ///// جنسیت
        ///// </summary>  type=32

        public string? SEX_Name { get; set; }

        ///// <summary>
        ///// وضعیت تاهل
        ///// </summary>  type=32

        public string? MAR_Name { get; set; }





        ////public virtual TblLuLookup _SEX_COD { get; set; }
        ///// <summary>
        ///// وضعیت تاهل
        ///// </summary>type=23

        public string? MAR_COD { get; set; }
        ////[ForeignKey("MAR_COD")]

        ////public virtual TblLuLookup _MAR_COD { get; set; }

        ///// <summary> 
        ///// تعداد همسر
        ///// </summary>
        public string? WIF_QTY { get; set; }
        ///// <summary>
        ///// تعداد عائله بجز همسر و اولاد
        ///// </summary>
        public string? FAM_QTY { get; set; }
        ///// <summary>
        ///// تعداد اولاد پسر
        ///// </summary>
        public string? SUN_QTY { get; set; }
        ///// <summary>
        ///// تعداد اولاد دختر
        ///// </summary>
        public string? DOT_QTY { get; set; }
        ///// </summary>
        ///// وضعیت سكونت - خانه سازمانی یا كانتینر
        ///// </summary> type=80
        public string? MAS_COD { get; set; }
        public string? MAS_Name { get; set; }
        ////[ForeignKey("MAS_COD")]

        ////public virtual TblLuLookup _MAS_COD { get; set; }
        ///// <summary>
        /////  تاریخ شروع وضعیت مسكونی
        ///// </summary>
        public string? HOM_DAT { get; set; }
        ///// <summary>
        ///// تاریخ استخدام
        ///// </summary>
        public string? EMP_DAT { get; set; }
        ///// <summary>
        ///// نوع استخدام
        ///// </summary>type=123
        public string? TYP_EMP { get; set; }
        ////[ForeignKey("TYP_EMP")]

        ////public virtual TblLuLookup _TYP_EMP { get; set; }

        public string? TYP_EMPNAM { get; set; }


        ///// </summary>
        ///// /// مدرك یا ماده دستور استخدام
        ///// </summary>
        public string? EMP_ORD { get; set; }
        ////public virtual TblLuLookup yEmpOrd { get; set; }

        ///// <summary>
        ///// كد یگان صاحب دستور استخدام
        ///// </summary>
        public string? EMP_YEG { get; set; }
        ////public virtual TblLuLookup y { get; set; }

        ///// <summary>
        ///// فرمان یا دستور استخدام رده بالاتر
        ///// </summary>
        public string? EMP_ORD2 { get; set; }
        ////public virtual TblLuLookup yEmpOrd2 { get; set; }

        ///// <summary>
        ///// كد مدرك تحصیلی بدو استخدام
        ///// </summary>
        public string? EDF_COD { get; set; }
        ////public virtual TblLuLookup yEdfCod { get; set; }

        ///// <summary>
        ///// كد هویت خدمتی
        ///// </summary>  type=151
        public string? EMS_COD { get; set; }
        ////[ForeignKey("EMS_COD")]

        ////public virtual TblLuLookup _EMS_COD { get; set; }


        public string? EMS_NAM { get; set; }


        ///// <summary>
        ///// كد نوع تغییر وضعیت
        ///// </summary> type=251
        public string? CHG_COD { get; set; }
        ////[ForeignKey("CHG_COD")]

        ////public virtual TblLuLookup _CHG_COD { get; set; }

        public string? CHG_NAM { get; set; }


        ///// <summary>
        ///// كد آخرین مدرك تحصیلی
        ///// </summary> type=11
        public string? EDE_COD { get; set; }
        ////[ForeignKey("EDE_COD")]
        ////public virtual TblLuLookup _EDE_COD { get; set; }
        public string? EDE_NAM { get; set; }

        ///// <summary>
        ///// كد رشته مدرك تحصیلی
        ///// </summary>
        public string? SUB_COD { get; set; }
        ////public virtual TblLuLookup ySubCod { get; set; }

        ///// <summary>
        ///// تاریخ آخرین مدرك تحصیلی
        ///// </summary>
        public string? EDE_DAT { get; set; }
        ////public virtual TblLuLookup yEdeDat { get; set; }

        ///// <summary>
        ///// كد آخرین دوره طولی نظامی
        ///// </summary> type=90  TBL_LOOKUPS_DATA
        public string? LDOR_NEZ { get; set; }
        ////[ForeignKey("LDOR_NEZ")]
        ////public virtual TblLuLookup _LDOR_NEZ { get; set; }

        public string? LDOR_NAM { get; set; }


        ///// <summary>
        ///// كد وضعیت از لحاظ خدمت
        ///// </summary> type=9
        public string? DUS_COD { get; set; }
        ////[ForeignKey("DUS_COD")]
        ////public virtual TblLuLookup _DUS_COD { get; set; }

        public string? DUS_NAM { get; set; }


        ///// <summary>
        ///// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        ///// </summary>
        public string? CUR_JOB { get; set; }
        ///// <summary>
        ///// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        ///// </summary>
        public string? HAZ_COD { get; set; }
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



        ///// <summary>
        ///// كد درجه اصلی
        ///// </summary>
        public string? DRJ_CODA { get; set; }
        ////public virtual TblLuLookup yDrjCoda { get; set; }

        ///// <summary>
        ///// نوع درجه - 0=دائم-1=موقت-2=مجازی
        ///// </summary> type=36
        public string? DRJ_STT { get; set; }
        ////[ForeignKey("DRJ_STT")]
        ////public virtual TblLuLookup _DRJ_STT { get; set; }

        public string? DRJ_STTNAM { get; set; }


        ///// <summary>
        ///// كد رسته
        ///// </summary> type=30
        //public string? RST_COD { get; set; }
        ////[ForeignKey("RST_COD")]
        ////public virtual TblLuLookup _RST_COD { get; set; }

        ///// <summary>
        ///// كد رسته قبلی
        ///// </summary>
        public string? RST_COD2 { get; set; }
        ////public virtual TblLuLookup yRstCod2 { get; set; }

        ///// <summary>
        ///// تاریخ تغییر رسته
        ///// </summary>
        public string? DAT_RST2 { get; set; }
        //////public virtual TblLuLookup yDatRst2 { get; set; }

        ///// <summary>
        ///// كد علت تغییر رسته
        ///// </summary>
        public string? ELL_RST { get; set; }
        //////public virtual TblLuLookup yEllRst { get; set; }

        ///// <summary>
        ///// گروه كارمندان تجربی
        ///// </summary>
        public string? EMP_GRH { get; set; }
        ////public virtual TblLuLookup yEmpGrh { get; set; }

        ///// <summary>
        ///// رده كارمندان تجربی
        ///// </summary>
        public string? EMP_RAD { get; set; }
        ////public virtual TblLuLookup yEmpRad { get; set; }

        ///// <summary>
        ///// كد تخصص اصلی
        ///// </summary> type=155 TBL_LOOKUPS_DATA
        public string? COD_TAA { get; set; }
        ////[ForeignKey("COD_TAA")]
        ////public virtual TblLuLookup _COD_TAA { get; set; }

        ///// <summary>
        ///// كد تخصص فرعی
        ///// </summary>
        public string? COD_TAF { get; set; }
        ////public virtual TblLuLookup yCodTaf { get; set; }

        ///// <summary>
        ///// كد تخصص خدمتی
        ///// </summary> type=155  TBL_LOOKUPS_DATA
        public string? COD_TAC { get; set; }
        ////[ForeignKey("COD_TAC")]
        ////public virtual TblLuLookup _COD_TAC { get; set; }

        ///// <summary>
        ///// شماره جدول سازمانی
        ///// </summary>
        public string? SHO_JGH { get; set; }
        ////public virtual TblLuLookup yShoJgh { get; set; }

        ///// <summary>
        ///// كد یگان سازمانی یا شغلی
        ///// </summary> type=254
        public string? COD_GHA { get; set; }
        ////[ForeignKey("COD_GHA")]
        ////public virtual TblLuLookup _COD_GHA { get; set; }

        ///// <summary>
        ///// ش بند
        ///// </summary>
        public string? BND_NUM { get; set; }
        ///// <summary>
        ///// ش سطر
        ///// </summary>
        public string? STR_NUM { get; set; }
        ///// <summary>
        ///// كد حداكثر درجه شغل
        ///// </summary> type=158 TBL_LOOKUPS_DATA
        public string? DRJ_CODJ { get; set; }
        ////[ForeignKey("DRJ_CODJ")]
        ////public virtual TblLuLookup _DRJ_CODJ { get; set; }

        ///// <summary>
        ///// تاریخ انتصاب
        ///// </summary>
        public string? DAT_ENT { get; set; }
        ///// <summary>
        ///// علت بدون شغل شدن
        ///// </summary>
        public string? VAZ_ENT { get; set; }
        ////public virtual TblLuLookup yVazEnt { get; set; }

        ///// <summary>
        ///// تاریخ خروج از انتصاب
        ///// </summary>
        public string? END_ENT { get; set; }
        ///// <summary>
        ///// در حال انتقال/انتساب بودن
        ///// </summary> type=45
        public string? VAZ_NGH { get; set; }
        ////[ForeignKey("VAZ_NGH")]
        ////public virtual TblLuLookup _VAZ_NGH { get; set; }

        public string? VAZ_NGHNAM { get; set; }

        ///// <summary>
        ///// كد یگان مادر
        ///// </summary> type=254
        public string? OMD_YEG { get; set; }
        ////[ForeignKey("OMD_YEG")]
        ////public virtual TblLuLookup _OMD_YEG { get; set; }

        ///// <summary>
        ///// كد یگان خدمتی  
        ///// </summary>  [TBL_UnitsInfo]
        public string? YEG_COD2 { get; set; }
        ////[ForeignKey("YEG_COD2")]
        ////public virtual TblUnitsInfo _YEG_COD2 { get; set; }

        ///// <summary>
        ///// تاریخ حضور در یگان خدمتی
        ///// </summary>
        public string? DAT_YEG2 { get; set; }
        ///// <summary>
        ///// منطقه محل خدمتی
        ///// </summary>
        public string? TYP_MNT { get; set; }
        ////public virtual TblLuLookup yTypMnt { get; set; }

        ///// <summary>
        ///// تاریخ شروع خدمت در منطقه خدمتی
        ///// </summary>
        public string? MNT_DAT { get; set; }
        ///// <summary>
        ///// كد یگان حقوقی
        ///// </summary> type=80
        public string? YEG_COD { get; set; }
        ////public virtual TblLuLookup yYegCod { get; set; }

        ///// <summary>
        ///// تارخ آخرین ترفیع
        ///// </summary>
        public string? PRE_DAT { get; set; }
        ///// <summary>
        ///// تاریخ ترفیع بعدی
        ///// </summary>
        public string? PRN_DAT { get; set; }
        ///// <summary>
        ///// ارشدیت اعمال شده
        ///// </summary>
        public string? CUR_ARS { get; set; }
        /// <summary>
        /// تنبیهات اعمال شده
        /// </summary>
        public string? CUR_TAN { get; set; }
        /// <summary>
        /// (ارشدیت اعمال نشده (قدمت 
        /// </summary>
        public string? NXT_ARS { get; set; }
        /// <summary>
        /// تنبیهات اعمال نشده
        /// </summary>
        public string? NXT_TAN { get; set; }
        /// <summary>
        /// مرخصی بدون حقوق طول خدمت
        /// </summary>
        public string? FRE_QTY { get; set; }
        /// <summary>
        /// مدت خدمت سربازی
        /// </summary>
        public string? SAR_QTY { get; set; }
        /// <summary>
        /// جمع مدت خدمت نیمه وقت بانوان طول خدمت
        /// </summary>
        public string? LAD_QTY { get; set; }
        /// <summary>
        /// تاریخ بازنشستگی
        /// </summary>
        public string? DAT_BAZ { get; set; }
        /// <summary>
        /// ارتقا تشویقی دارد /ندارد
        /// </summary>
        public string? NUM_ETSH { get; set; }
        /// <summary>
        /// میزان ارتقا حقوقی
        /// </summary>
        public string? NUM_EPAY { get; set; }
        /// <summary>
        /// تاریخ آخرین ارتقا حقوقی
        /// </summary>
        public string? DAT_EPAY { get; set; }
        /// <summary>
        /// مدت خدمت در منطقه عملیاتی قبل از قطعنامه
        /// </summary>
        public string? TOT_AML { get; set; }
        /// <summary>
        /// مدت خدمت در منطقه عملیاتی بعد از قطعنامه
        /// </summary>
        public string? TOT_AML2 { get; set; }
        ///// <summary>
        ///// كد زبان مادری یا محلی
        ///// </summary> type=48
        public string? ZAB_MAH { get; set; }
        ////[ForeignKey("ZAB_MAH")]
        ////public virtual TblLuLookup _ZAB_MAH { get; set; }

        public string? ZAB_MAHNAM { get; set; }


        /// <summary>
        /// .f.یا .t.-سابقه اسارت                             
        /// </summary>
        public string? VAZ_ESA { get; set; }
        /// <summary>
        /// .f.یا .t.-سابقه  گروگان بودن                      
        /// </summary>
        public string? VAZ_GRO { get; set; }
        /// <summary>
        /// كد طبقه پزشكی
        /// </summary>
        public string? NAZ_COD { get; set; }
        /// <summary>
        /// تاریخ معاینه پزشكی
        /// </summary>
        public string? DAT_NAZ { get; set; }
        /// <summary>
        /// كد نواقص پزشكی
        /// </summary>
        public string? BOD_COD { get; set; }
        /// <summary>
        /// میزان در صد جانبازی ارتش
        /// </summary>
        public string? DRSAD_JA { get; set; }
        /// <summary>
        /// میزان در صد جانبازی بنیاد
        /// </summary>
        public string? DRSAD_JB { get; set; }
        /// <summary>
        /// آدرس محل سكونت
        /// </summary>
        public string? ADDRES { get; set; }
        /// <summary>
        /// پیش شماره یا كد تلفن محل
        /// </summary>
        public string? COD_TEL { get; set; }
        /// <summary>
        /// شماره تلفن
        /// </summary>
        public string? TEL_NUM { get; set; }
        /// <summary>
        /// رنگ چشم
        /// </summary>
        public string? COL_EYE { get; set; }
        /// <summary>
        /// وزن
        /// </summary>
        public string? VAZN_PER { get; set; }
        /// <summary>
        /// قد
        /// </summary>
        public string? HIG_PER { get; set; }
        /// <summary>
        /// اندازه پا
        /// </summary>
        public string? SIZ_FOT { get; set; }
        /// <summary>
        /// اندازه كلاه
        /// </summary>
        public string? SIZ_KLA { get; set; }
        /// <summary>
        /// چك مشخصات پرسنلی با اطلاعات سوابق
        /// </summary>
        public string? OK_SAB { get; set; }
        /// <summary>
        /// یگان فرستنده
        /// </summary>
        public string? FER_YEG { get; set; }
        /// <summary>
        /// ( اعاده/ابقا (یك = ابقا - دو= اعاده 
        /// </summary> type=147
        public string? RET_COD { get; set; }
        //[ForeignKey("RET_COD")]
        //public virtual TblLuLookup _RET_COD { get; set; }

        public string? RET_CODNAM { get; set; }


        /// <summary>
        /// وضعیت پرنده فرار - مفتوحه است یا نه
        /// </summary>
        public string? VAZ_FAR { get; set; }
        /// <summary>
        /// نوع اعلام حضور
        /// </summary>
        public string? T_ENTER { get; set; }
        /// <summary>
        /// سویچ چاپ فرم شناسایی
        /// </summary>
        public string? SW_PRT { get; set; }
        /// <summary>
        /// كلید شغل
        /// </summary>
        public string? KLD_SHGL { get; set; }
        /// <summary>
        /// مدت قدمت درجه فعلی
        /// </summary>
        public string? GED_OT { get; set; }
        /// <summary>
        /// كورس ترفیعاتی
        /// </summary>
        public string? CORS_T { get; set; }
        /// <summary>
        /// كد رشد تخصصی فرد
        /// </summary> type=160 TBL_LOOKUPS_DATA
        public string? ROSH_P { get; set; }
        //[ForeignKey("ROSH_P")]
        //public virtual TblLuLookup _ROSH_P { get; set; }

        public string? ROSH_PNAM { get; set; }


        //type=80
        public string? GHE_SHR { get; set; }

        /// <summary>
        /// كد هویت شغل
        /// </summary>
        public string? COD_C1 { get; set; }
        /// <summary>
        /// كد ماهیت یگان شغل
        /// </summary>
        public string? COD_C2 { get; set; }
        /// <summary>
        /// كد نوع شغل
        /// </summary>
        public string? COD_C3 { get; set; }
        /// <summary>
        /// كد نوع پذیرش شغل
        /// </summary>
        public string? COD_C4 { get; set; }
        /// <summary>
        /// كد رشد تخصصی شغل
        /// </summary> type=160  TBL_LOOKUPS_DATA
        public string? COD_C12 { get; set; }
        //[ForeignKey("COD_C12")]
        //public virtual TblLuLookup _COD_C12 { get; set; }

        /// <summary>
        /// كد رسته شغل
        /// </summary> type=157 TBL_LOOKUPS_DATA
        public string? COD_C78 { get; set; }
        //[ForeignKey("COD_C78")]
        //public virtual TblLuLookup _COD_C78 { get; set; }

        /// <summary>
        /// عنوان شغل
        /// </summary>
        public string? JOB_DES { get; set; }
        /// <summary>
        /// تاریخ ارتقا بعدی
        /// </summary>
        public string? DAT_ERTB { get; set; }
        public string? DAT_ERTG { get; set; }
        public string? TYP_GHE { get; set; }
        /// <summary>
        /// تاریخ رسمی شدن
        /// </summary>
        public string? DAT_RAS { get; set; }
        /// <summary>
        ///  نوع خدمت كارمندی
        /// </summary>
        public string? CHG_TYP { get; set; }
        public string? KHD_TYP { get; set; }
        public string? SOT_DAT { get; set; }
        public string? DAT_NGH { get; set; }
        public string? DAT_OMD { get; set; }
        /// <summary>
        /// نوع قشر
        /// </summary> type=112
        public string? GHESHR { get; set; }
        //[ForeignKey("GHESHR")]
        //public virtual TblLuLookup _GHESHR { get; set; }

        public string? GHESHRNAM { get; set; }

        public string? COD4 { get; set; }
        /// <summary>
        /// تاریخ بازنشستگی بر اساس 60 سال سن
        /// </summary>
        public string? DAT_BAZS { get; set; }
        public string? EmployArchismDuration { get; set; }
        public string? EmployUniversityCode { get; set; }
        public string? EmploySectionCode { get; set; }
        public string? EmployServiceTypeCode { get; set; }
        public string? LengthCode { get; set; }
        public string? PeopleCode { get; set; }
        /// <summary>
        /// تنزیل درجه
        /// </summary> type=80
        public string? DiscountStatus { get; set; }
        //public virtual TblLuLookup yDiscountStatus { get; set; }

        public string? CHG_TAR { get; set; }
        /// <summary>
        /// سابقه انتصاباتی نیاز به  اصلاح دارد
        /// </summary>
        public string? CHG_ENT { get; set; }
        /// <summary>
        /// تاریخ شروع طبقه پزشكی
        /// </summary>
        public string? datMedicalClassBegin { get; set; }
        /// <summary>
        /// تاریخ پایان طبقه پزشكی
        /// </summary>
        public string? datMedicalClassEnd { get; set; }
        public string? HasChanged { get; set; }
        public string? LastChangeTime { get; set; }
        public string? HasYegan { get; set; }
        public string? LastYegan { get; set; }
        public string? YEG_COD2_Tmp { get; set; }
        public string? HasYegan_Tmp { get; set; }
        public string? MAK_SR { get; set; }
        [Key]
        public string? MelliCode { get; set; }
        ////type=26
        public string? DeliverTypeCode { get; set; }
        ////[ForeignKey("DeliverTypeCode")]
        ////public virtual TblLuLookup _DeliverTypeCode { get; set; }
        public string? DeliverTypeNAM { get; set; }

        public string? Tel_workplace { get; set; }
        public string? Tel_mobile { get; set; }
        public string? Postcode { get; set; }
        public string? code_mosalsal { get; set; }
        public string? shomareh_seri { get; set; }
        public string? harfe_seri { get; set; }

        /////// <summary>
        ///////  نام لاتین
        /////// </summary>
        ////public string? FstNamEN { get; set; }
        /////// <summary>
        /////// نام خانوادگی لاتین
        /////// </summary>
        ////public string? LstNamEN { get; set; }
        /////// <summary>
        /////// ریت پروازی
        /////// </summary>
        ////public string? RateFlight { get; set; }

    }


    public class TblMasterBorhanViewModel
    {
        public string? RasmiVazifeh { get; set; }




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
        [Display(Name = "")]
        public string? LST_NAM { get; set; }
        ///// <summary>
        ///// نام قبلی
        ///// </summary>
        //[Display(Name = "")]
        //public string? GBL_FNAM { get; set; }
        ///// <summary>
        ///// نام خانوادگی قبلی
        ///// </summary>
        //[Display(Name = "")]
        //public string? GBL_LNAM { get; set; }
        /// <summary>
        /// نام پدر
        /// </summary>
        public string? FAT_NAM { get; set; }
        /// </summary>
        [Display(Name = "")]
        /// ش شناسنامه
        /// </summary>
        public string? INF_NUM { get; set; }
        /// <summary>
        /// محل تولد
        /// </summary>
        //[Display(Name = "")]
        //public string? BRT_COD { get; set; }
        //[ForeignKey("BRT_COD")]

        //public virtual CityType _BRT_COD { get; set; }

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        [Display(Name = "")]
        public string? BRT_DAT { get; set; }
        public string? MAR_DAT { get; set; }

        /// <summary>
        /// محل صدور
        /// </summary>
        //public string? ISS_COD { get; set; }
        //[ForeignKey("ISS_COD")]

        //public virtual CityType _ISS_COD { get; set; }





        /// <summary>
        /// تاریخ صدور
        /// </summary>
        public string? ISS_DAT { get; set; }
        /// <summary>
        /// گروه خون
        /// </summary>  type=47
        //public string? BLG_COD { get; set; }
        //[ForeignKey("BLG_COD")]
        //public virtual TblLuLookup _BLG_COD { get; set; }

        /// <summary>
        /// دین مذهب
        /// </summary> type=99
        //public string? REL_COD { get; set; }
        ////[ForeignKey("REL_COD")]

        ////public virtual TblLuLookup _REL_COD { get; set; }
        ///// <summary>
        ///// كد دین و مذهب قبلی
        ///// </summary> type=99
        //public string? REL_COD2 { get; set; }
        ///// </summary> 
        ////[ForeignKey("REL_COD2")]
        ////public virtual TblLuLookup _REL_COD2 { get; set; }
        ///// <summary>
        ///// جنسیت
        ///// </summary>  type=32
        //public string? SEX_COD { get; set; }
        ////[ForeignKey("SEX_COD")]

        ////public virtual TblLuLookup _SEX_COD { get; set; }
        ///// <summary>
        ///// وضعیت تاهل
        ///// </summary>type=23
        //public string? MAR_COD { get; set; }
        ////[ForeignKey("MAR_COD")]

        ////public virtual TblLuLookup _MAR_COD { get; set; }

        ///// <summary> 
        ///// تعداد همسر
        ///// </summary>
        //public string? WIF_QTY { get; set; }
        ///// <summary>
        ///// تعداد عائله بجز همسر و اولاد
        ///// </summary>
        //public string? FAM_QTY { get; set; }
        ///// <summary>
        ///// تعداد اولاد پسر
        ///// </summary>
        //public string? SUN_QTY { get; set; }
        ///// <summary>
        ///// تعداد اولاد دختر
        ///// </summary>
        //public string? DOT_QTY { get; set; }
        ///// </summary>
        ///// وضعیت سكونت - خانه سازمانی یا كانتینر
        ///// </summary> type=80
        //public string? MAS_COD { get; set; }
        ////[ForeignKey("MAS_COD")]

        ////public virtual TblLuLookup _MAS_COD { get; set; }
        ///// <summary>
        /////  تاریخ شروع وضعیت مسكونی
        ///// </summary>
        //public string? HOM_DAT { get; set; }
        /// <summary>
        /// تاریخ استخدام
        /// </summary>
        public string? EMP_DAT { get; set; }
        /// <summary>
        /// نوع استخدام
        /// </summary>type=123
        //public string? TYP_EMP { get; set; }
        ////[ForeignKey("TYP_EMP")]

        ////public virtual TblLuLookup _TYP_EMP { get; set; }
        ///// </summary>
        ///// /// مدرك یا ماده دستور استخدام
        ///// </summary>
        //public string? EMP_ORD { get; set; }
        ////public virtual TblLuLookup yEmpOrd { get; set; }

        ///// <summary>
        ///// كد یگان صاحب دستور استخدام
        ///// </summary>
        //public string? EMP_YEG { get; set; }
        ////public virtual TblLuLookup y { get; set; }

        ///// <summary>
        ///// فرمان یا دستور استخدام رده بالاتر
        ///// </summary>
        //public string? EMP_ORD2 { get; set; }
        ////public virtual TblLuLookup yEmpOrd2 { get; set; }

        ///// <summary>
        ///// كد مدرك تحصیلی بدو استخدام
        ///// </summary>
        //public string? EDF_COD { get; set; }
        ////public virtual TblLuLookup yEdfCod { get; set; }

        ///// <summary>
        ///// كد هویت خدمتی
        ///// </summary>  type=151
        //public string? EMS_COD { get; set; }
        ////[ForeignKey("EMS_COD")]

        ////public virtual TblLuLookup _EMS_COD { get; set; }

        ///// <summary>
        ///// كد نوع تغییر وضعیت
        ///// </summary> type=251
        //public string? CHG_COD { get; set; }
        ////[ForeignKey("CHG_COD")]

        ////public virtual TblLuLookup _CHG_COD { get; set; }

        ///// <summary>
        ///// كد آخرین مدرك تحصیلی
        ///// </summary> type=11
        //public string? EDE_COD { get; set; }
        ////[ForeignKey("EDE_COD")]
        ////public virtual TblLuLookup _EDE_COD { get; set; }

        ///// <summary>
        ///// كد رشته مدرك تحصیلی
        ///// </summary>
        //public string? SUB_COD { get; set; }
        ////public virtual TblLuLookup ySubCod { get; set; }

        ///// <summary>
        ///// تاریخ آخرین مدرك تحصیلی
        ///// </summary>
        //public string? EDE_DAT { get; set; }
        ////public virtual TblLuLookup yEdeDat { get; set; }

        ///// <summary>
        ///// كد آخرین دوره طولی نظامی
        ///// </summary> type=90  TBL_LOOKUPS_DATA
        //public string? LDOR_NEZ { get; set; }
        ////[ForeignKey("LDOR_NEZ")]
        ////public virtual TblLuLookup _LDOR_NEZ { get; set; }

        ///// <summary>
        ///// كد وضعیت از لحاظ خدمت
        ///// </summary> type=9
        //public string? DUS_COD { get; set; }
        ////[ForeignKey("DUS_COD")]
        ////public virtual TblLuLookup _DUS_COD { get; set; }

        ///// <summary>
        ///// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        ///// </summary>
        //public string? CUR_JOB { get; set; }
        ///// <summary>
        ///// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        ///// </summary>
        //public string? HAZ_COD { get; set; }
        ///// <summary>
        /// كد درجه / رتبه
        /// </summary> type=10
        public string? DRJ_COD { get; set; }
        //[ForeignKey("DRJ_COD")]
        //public virtual TblLuLookup _DRJ_COD { get; set; }

        //public string? DRJ_NAM { get; set; }
        //public string? RST_NAM { get; set; }

        /// <summary>
        /// كد درجه اصلی
        /// </summary>
        //public string? DRJ_CODA { get; set; }
        ////public virtual TblLuLookup yDrjCoda { get; set; }

        ///// <summary>
        ///// نوع درجه - 0=دائم-1=موقت-2=مجازی
        ///// </summary> type=36
        //public string? DRJ_STT { get; set; }
        ////[ForeignKey("DRJ_STT")]
        ////public virtual TblLuLookup _DRJ_STT { get; set; }

        ///// <summary>
        ///// كد رسته
        ///// </summary> type=30
        //public string? RST_COD { get; set; }
        ////[ForeignKey("RST_COD")]
        ////public virtual TblLuLookup _RST_COD { get; set; }

        ///// <summary>
        ///// كد رسته قبلی
        ///// </summary>
        //public string? RST_COD2 { get; set; }
        ////public virtual TblLuLookup yRstCod2 { get; set; }

        ///// <summary>
        ///// تاریخ تغییر رسته
        ///// </summary>
        //public string? DAT_RST2 { get; set; }
        //////public virtual TblLuLookup yDatRst2 { get; set; }

        ///// <summary>
        ///// كد علت تغییر رسته
        ///// </summary>
        //public string? ELL_RST { get; set; }
        //////public virtual TblLuLookup yEllRst { get; set; }

        ///// <summary>
        ///// گروه كارمندان تجربی
        ///// </summary>
        //public string? EMP_GRH { get; set; }
        ////public virtual TblLuLookup yEmpGrh { get; set; }

        ///// <summary>
        ///// رده كارمندان تجربی
        ///// </summary>
        //public string? EMP_RAD { get; set; }
        ////public virtual TblLuLookup yEmpRad { get; set; }

        ///// <summary>
        ///// كد تخصص اصلی
        ///// </summary> type=155 TBL_LOOKUPS_DATA
        //public string? COD_TAA { get; set; }
        ////[ForeignKey("COD_TAA")]
        ////public virtual TblLuLookup _COD_TAA { get; set; }

        ///// <summary>
        ///// كد تخصص فرعی
        ///// </summary>
        //public string? COD_TAF { get; set; }
        ////public virtual TblLuLookup yCodTaf { get; set; }

        ///// <summary>
        ///// كد تخصص خدمتی
        ///// </summary> type=155  TBL_LOOKUPS_DATA
        //public string? COD_TAC { get; set; }
        ////[ForeignKey("COD_TAC")]
        ////public virtual TblLuLookup _COD_TAC { get; set; }

        ///// <summary>
        ///// شماره جدول سازمانی
        ///// </summary>
        //public string? SHO_JGH { get; set; }
        ////public virtual TblLuLookup yShoJgh { get; set; }

        ///// <summary>
        ///// كد یگان سازمانی یا شغلی
        ///// </summary> type=254
        //public string? COD_GHA { get; set; }
        ////[ForeignKey("COD_GHA")]
        ////public virtual TblLuLookup _COD_GHA { get; set; }

        ///// <summary>
        ///// ش بند
        ///// </summary>
        //public string? BND_NUM { get; set; }
        ///// <summary>
        ///// ش سطر
        ///// </summary>
        //public string? STR_NUM { get; set; }
        ///// <summary>
        ///// كد حداكثر درجه شغل
        ///// </summary> type=158 TBL_LOOKUPS_DATA
        //public string? DRJ_CODJ { get; set; }
        ////[ForeignKey("DRJ_CODJ")]
        ////public virtual TblLuLookup _DRJ_CODJ { get; set; }

        ///// <summary>
        ///// تاریخ انتصاب
        ///// </summary>
        //public string? DAT_ENT { get; set; }
        ///// <summary>
        ///// علت بدون شغل شدن
        ///// </summary>
        //public string? VAZ_ENT { get; set; }
        ////public virtual TblLuLookup yVazEnt { get; set; }

        ///// <summary>
        ///// تاریخ خروج از انتصاب
        ///// </summary>
        //public string? END_ENT { get; set; }
        ///// <summary>
        ///// در حال انتقال/انتساب بودن
        ///// </summary> type=45
        //public string? VAZ_NGH { get; set; }
        ////[ForeignKey("VAZ_NGH")]
        ////public virtual TblLuLookup _VAZ_NGH { get; set; }

        ///// <summary>
        ///// كد یگان مادر
        ///// </summary> type=254
        //public string? OMD_YEG { get; set; }
        ////[ForeignKey("OMD_YEG")]
        ////public virtual TblLuLookup _OMD_YEG { get; set; }

        ///// <summary>
        ///// كد یگان خدمتی  
        ///// </summary>  [TBL_UnitsInfo]
        //public string? YEG_COD2 { get; set; }
        ////[ForeignKey("YEG_COD2")]
        ////public virtual TblUnitsInfo _YEG_COD2 { get; set; }

        ///// <summary>
        ///// تاریخ حضور در یگان خدمتی
        ///// </summary>
        //public string? DAT_YEG2 { get; set; }
        ///// <summary>
        ///// منطقه محل خدمتی
        ///// </summary>
        //public string? TYP_MNT { get; set; }
        ////public virtual TblLuLookup yTypMnt { get; set; }

        ///// <summary>
        ///// تاریخ شروع خدمت در منطقه خدمتی
        ///// </summary>
        //public string? MNT_DAT { get; set; }
        ///// <summary>
        ///// كد یگان حقوقی
        ///// </summary> type=80
        //public string? YEG_COD { get; set; }
        ////public virtual TblLuLookup yYegCod { get; set; }

        ///// <summary>
        ///// تارخ آخرین ترفیع
        ///// </summary>
        //public string? PRE_DAT { get; set; }
        ///// <summary>
        ///// تاریخ ترفیع بعدی
        ///// </summary>
        //public string? PRN_DAT { get; set; }
        ///// <summary>
        ///// ارشدیت اعمال شده
        ///// </summary>
        //public string? CUR_ARS { get; set; }
        ///// <summary>
        ///// تنبیهات اعمال شده
        ///// </summary>
        //public string? CUR_TAN { get; set; }
        ///// <summary>
        ///// (ارشدیت اعمال نشده (قدمت 
        ///// </summary>
        //public string? NXT_ARS { get; set; }
        ///// <summary>
        ///// تنبیهات اعمال نشده
        ///// </summary>
        //public string? NXT_TAN { get; set; }
        ///// <summary>
        ///// مرخصی بدون حقوق طول خدمت
        ///// </summary>
        //public string? FRE_QTY { get; set; }
        ///// <summary>
        ///// مدت خدمت سربازی
        ///// </summary>
        //public string? SAR_QTY { get; set; }
        ///// <summary>
        ///// جمع مدت خدمت نیمه وقت بانوان طول خدمت
        ///// </summary>
        //public string? LAD_QTY { get; set; }
        ///// <summary>
        ///// تاریخ بازنشستگی
        ///// </summary>
        //public string? DAT_BAZ { get; set; }
        ///// <summary>
        ///// ارتقا تشویقی دارد /ندارد
        ///// </summary>
        //public string? NUM_ETSH { get; set; }
        ///// <summary>
        ///// میزان ارتقا حقوقی
        ///// </summary>
        //public string? NUM_EPAY { get; set; }
        ///// <summary>
        ///// تاریخ آخرین ارتقا حقوقی
        ///// </summary>
        //public string? DAT_EPAY { get; set; }
        ///// <summary>
        ///// مدت خدمت در منطقه عملیاتی قبل از قطعنامه
        ///// </summary>
        //public string? TOT_AML { get; set; }
        ///// <summary>
        ///// مدت خدمت در منطقه عملیاتی بعد از قطعنامه
        ///// </summary>
        //public string? TOT_AML2 { get; set; }
        ///// <summary>
        ///// كد زبان مادری یا محلی
        ///// </summary> type=48
        //public string? ZAB_MAH { get; set; }
        ////[ForeignKey("ZAB_MAH")]
        ////public virtual TblLuLookup _ZAB_MAH { get; set; }

        ///// <summary>
        ///// .f.یا .t.-سابقه اسارت                             
        ///// </summary>
        //public string? VAZ_ESA { get; set; }
        ///// <summary>
        ///// .f.یا .t.-سابقه  گروگان بودن                      
        ///// </summary>
        //public string? VAZ_GRO { get; set; }
        ///// <summary>
        ///// كد طبقه پزشكی
        ///// </summary>
        //public string? NAZ_COD { get; set; }
        ///// <summary>
        ///// تاریخ معاینه پزشكی
        ///// </summary>
        //public string? DAT_NAZ { get; set; }
        ///// <summary>
        ///// كد نواقص پزشكی
        ///// </summary>
        //public string? BOD_COD { get; set; }
        ///// <summary>
        ///// میزان در صد جانبازی ارتش
        ///// </summary>
        //public string? DRSAD_JA { get; set; }
        ///// <summary>
        ///// میزان در صد جانبازی بنیاد
        ///// </summary>
        //public string? DRSAD_JB { get; set; }
        ///// <summary>
        ///// آدرس محل سكونت
        ///// </summary>
        //public string? ADDRES { get; set; }
        ///// <summary>
        ///// پیش شماره یا كد تلفن محل
        ///// </summary>
        //public string? COD_TEL { get; set; }
        ///// <summary>
        /// شماره تلفن
        /// </summary>
        //public string? TEL_NUM { get; set; }
        /// <summary>
        /// رنگ چشم
        /// </summary>
        public string? COL_EYE { get; set; }
        /// <summary>
        /// وزن
        /// </summary>
        public string? VAZN_PER { get; set; }
        /// <summary>
        /// قد
        /// </summary>
        //public string? HIG_PER { get; set; }
        /// <summary>
        /// اندازه پا
        /// </summary>
        public string? SIZ_FOT { get; set; }
        /// <summary>
        /// اندازه كلاه
        /// </summary>
        public string? SIZ_KLA { get; set; }
        /// <summary>
        /// چك مشخصات پرسنلی با اطلاعات سوابق
        /// </summary>
        //public string? OK_SAB { get; set; }
        ///// <summary>
        ///// یگان فرستنده
        ///// </summary>
        //public string? FER_YEG { get; set; }
        ///// <summary>
        ///// ( اعاده/ابقا (یك = ابقا - دو= اعاده 
        ///// </summary> type=147
        //public string? RET_COD { get; set; }
        ////[ForeignKey("RET_COD")]
        ////public virtual TblLuLookup _RET_COD { get; set; }

        ///// <summary>
        ///// وضعیت پرنده فرار - مفتوحه است یا نه
        ///// </summary>
        //public string? VAZ_FAR { get; set; }
        ///// <summary>
        ///// نوع اعلام حضور
        ///// </summary>
        //public string? T_ENTER { get; set; }
        ///// <summary>
        ///// سویچ چاپ فرم شناسایی
        ///// </summary>
        //public string? SW_PRT { get; set; }
        ///// <summary>
        ///// كلید شغل
        ///// </summary>
        //public string? KLD_SHGL { get; set; }
        ///// <summary>
        ///// مدت قدمت درجه فعلی
        ///// </summary>
        //public string? GED_OT { get; set; }
        ///// <summary>
        ///// كورس ترفیعاتی
        ///// </summary>
        //public string? CORS_T { get; set; }
        ///// <summary>
        ///// كد رشد تخصصی فرد
        ///// </summary> type=160 TBL_LOOKUPS_DATA
        //public string? ROSH_P { get; set; }
        ////[ForeignKey("ROSH_P")]
        ////public virtual TblLuLookup _ROSH_P { get; set; }
        ////type=80
        //public string? GHE_SHR { get; set; }
        //public string? GHE_SHR01 { get; set; }



        ///// <summary>
        ///// كد هویت شغل
        ///// </summary>
        //public string? COD_C1 { get; set; }
        ///// <summary>
        ///// كد ماهیت یگان شغل
        ///// </summary>
        //public string? COD_C2 { get; set; }
        ///// <summary>
        ///// كد نوع شغل
        ///// </summary>
        //public string? COD_C3 { get; set; }
        ///// <summary>
        ///// كد نوع پذیرش شغل
        ///// </summary>
        //public string? COD_C4 { get; set; }
        ///// <summary>
        ///// كد رشد تخصصی شغل
        ///// </summary> type=160  TBL_LOOKUPS_DATA
        //public string? COD_C12 { get; set; }
        ////[ForeignKey("COD_C12")]
        ////public virtual TblLuLookup _COD_C12 { get; set; }

        ///// <summary>
        ///// كد رسته شغل
        ///// </summary> type=157 TBL_LOOKUPS_DATA
        //public string? COD_C78 { get; set; }
        ////[ForeignKey("COD_C78")]
        ////public virtual TblLuLookup _COD_C78 { get; set; }

        ///// <summary>
        ///// عنوان شغل
        ///// </summary>
        //public string? JOB_DES { get; set; }
        ///// <summary>
        ///// تاریخ ارتقا بعدی
        ///// </summary>
        //public string? DAT_ERTB { get; set; }
        //public string? DAT_ERTG { get; set; }
        //public string? TYP_GHE { get; set; }
        ///// <summary>
        ///// تاریخ رسمی شدن
        ///// </summary>
        //public string? DAT_RAS { get; set; }
        ///// <summary>
        /////  نوع خدمت كارمندی
        ///// </summary>
        //public string? CHG_TYP { get; set; }
        //public string? KHD_TYP { get; set; }
        //public string? SOT_DAT { get; set; }
        //public string? DAT_NGH { get; set; }
        //public string? DAT_OMD { get; set; }
        ///// <summary>
        ///// نوع قشر
        ///// </summary> type=112
        //public string? GHESHR { get; set; }
        ////[ForeignKey("GHESHR")]
        ////public virtual TblLuLookup _GHESHR { get; set; }

        //public string? COD4 { get; set; }
        ///// <summary>
        ///// تاریخ بازنشستگی بر اساس 60 سال سن
        ///// </summary>
        //public string? DAT_BAZS { get; set; }
        //public string? EmployArchismDuration { get; set; }
        //public string? EmployUniversityCode { get; set; }
        //public string? EmploySectionCode { get; set; }
        //public string? EmployServiceTypeCode { get; set; }
        //public string? LengthCode { get; set; }
        //public string? PeopleCode { get; set; }
        ///// <summary>
        ///// تنزیل درجه
        ///// </summary> type=80
        //public string? DiscountStatus { get; set; }
        ////public virtual TblLuLookup yDiscountStatus { get; set; }

        //public string? CHG_TAR { get; set; }
        ///// <summary>
        ///// سابقه انتصاباتی نیاز به  اصلاح دارد
        ///// </summary>
        //public string? CHG_ENT { get; set; }
        ///// <summary>
        ///// تاریخ شروع طبقه پزشكی
        ///// </summary>
        //public string? datMedicalClassBegin { get; set; }
        ///// <summary>
        ///// تاریخ پایان طبقه پزشكی
        ///// </summary>
        //public string? datMedicalClassEnd { get; set; }
        //public string? HasChanged { get; set; }
        //public string? LastChangeTime { get; set; }
        //public string? HasYegan { get; set; }
        //public string? LastYegan { get; set; }
        //public string? YEG_COD2_Tmp { get; set; }
        //public string? HasYegan_Tmp { get; set; }
        //public string? MAK_SR { get; set; }
        [Key]
        public string? MelliCode { get; set; }
        //type=26
        //public string? DeliverTypeCode { get; set; }
        ////[ForeignKey("DeliverTypeCode")]
        ////public virtual TblLuLookup _DeliverTypeCode { get; set; }

        //public string? Tel_workplace { get; set; }
        public string? Tel_mobile { get; set; }
        //public string? Postcode { get; set; }
        //public string? code_mosalsal { get; set; }
        //public string? shomareh_seri { get; set; }
        //public string? harfe_seri { get; set; }

        /// <summary>
        ///  نام لاتین
        /// </summary>
        public string? FstNamEN { get; set; }
        /// <summary>
        /// نام خانوادگی لاتین
        /// </summary>
        public string? LstNamEN { get; set; }
        ///// <summary>
        ///// ریت پروازی
        ///// </summary>
        //public string? RateFlight { get; set; }

    }
    public class SoldierData
    {
        public List<Soldier> Data { get; set; }
    }
    public class Soldier
    {
         
        public string? p_id { get; set; }

        public string n_id { get; set; }
        public string sh_number { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        public string status { get; set; }
        public string status_coment { get; set; }
        public string fathers_name { get; set; }
        public string birth_location { get; set; }
        public string sabt_location { get; set; }
        public string birth_date { get; set; }
        public string eye_color { get; set; }
        public string hair_color { get; set; }
        public string blood_type { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string sickness { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string zip_code { get; set; }
        public string local { get; set; }
        public string telephone { get; set; }
        public string mobile { get; set; }
        public string religion { get; set; }
        public string education { get; set; }
        public string job { get; set; }
        public string education_field { get; set; }
        public string sport { get; set; }
        public string is_father_alive { get; set; }
        public string is_mother_alive { get; set; }
        public string married { get; set; }
        public string number_of_children { get; set; }
        public string number_of_brothers { get; set; }
        public string number_of_sisters { get; set; }
        public string wife_birth_date { get; set; }
        public string marriage_date { get; set; }
        public string dispatch_date { get; set; }
        public string release_date { get; set; }
        public string serve_period { get; set; }
        public string training_base { get; set; }
        public string dispatch_location { get; set; }
        public string rank { get; set; }
        public string raste { get; set; }
        public string serve_unit { get; set; }
        public string job_unit { get; set; }
        public string ac_number { get; set; }
        public string is_moaf_razm { get; set; }
        public string is_moaf_putin { get; set; }
        public string driver_licence { get; set; }
        public string moarefi_date { get; set; }
        public string race { get; set; }
        public string language { get; set; }
        public string org_job { get; set; }
        public string org_band { get; set; }
        public string org_satr { get; set; }
        public string org_title { get; set; }
        public string org_raste { get; set; }
        public string org_unit { get; set; }
        //public string   { get; set; }


    }


    [Table("BorhanTabaghePezashki02")]
    public class viewBorhanTabaghePezashki02
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }


        [Column("MelliCode")]
        [StringLength(20)]
        public string? MelliCode { get; set; }

        [Column("Tabaghe")]
        [StringLength(200)]
        public string? Tabaghe { get; set; }

        [Column("ReasTabaghe")]
        [StringLength(200)]
        public string? ReasTabaghe { get; set; }

        [Column("Benefits")]
        [StringLength(200)]
        public string? Benefits { get; set; }

        [Column("TabagheDate")]
        [StringLength(200)]
        public string? TabagheDate { get; set; }

        [Column("TabagheDur")]
        [StringLength(200)]
        public string? TabagheDur { get; set; }

        [Column("Percenta")]
        [StringLength(200)]
        public string? Percenta { get; set; }



    }


    [Table("BorhanEntesabat02")]
    public class viewBorhanEntesabat02
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("EntesabDate")]
        [StringLength(50)]
        public string? EntesabDate { get; set; }

        [Column("MelliCode")]
        [StringLength(20)]
        public string? MelliCode { get; set; }

        [Column("JOB_Seed")]
        [StringLength(100)]
        public string? JOB_Seed { get; set; }

        [Column("Rosh")]
        [StringLength(200)]
        public string? Rosh { get; set; }

        [Column("Rst01")]
        [StringLength(200)]
        public string? Rst01 { get; set; }

        [Column("Rst02")]
        [StringLength(200)]
        public string? Rst02 { get; set; }

        [Column("JOB_DRJ")]
        [StringLength(500)]
        public string? JOB_DRJ { get; set; }

        [Column("JOB_DES")]
        [StringLength(500)]
        public string? JOB_DES { get; set; }


        [Column("YeganSN")]
        [StringLength(100)]
        public string? YeganSN { get; set; }

        [Column("Takhasos")]
        [StringLength(200)]
        public string? Takhasos { get; set; }

        [Column("BND_NUM")]
        [StringLength(50)]
        public string? BND_NUM { get; set; }

        [Column("STR_NUM")]
        [StringLength(50)]
        public string? STR_NUM { get; set; }

        [Column("Mahiat")]
        [StringLength(500)]
        public string? Mahiat { get; set; }

        [Column("JOB_Yegan")]
        [StringLength(200)]
        public string? JOB_Yegan { get; set; }

        [Column("JOB_Loc")]
        [StringLength(200)]
        public string? JOB_Loc { get; set; }

        [Column("JOB_TYPE")]
        [StringLength(100)]
        public string? JOB_TYPE { get; set; }

        [Column("Cod42")]
        [StringLength(100)]
        public string? Cod42 { get; set; }

        [Column("DasNo")]
        [StringLength(100)]
        public string? DasNo { get; set; }

        [Column("CommandNO")]
        [StringLength(100)]
        public string? CommandNO { get; set; }

        [Column("Ray")]
        [MaxLength] // برای NVARCHAR(MAX)
        public string? Ray { get; set; }
    }
    public class TblMasterViewModel
    {
        public string? strStatAmar { get; set; }

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

        public string ID { get; set; }
        public string? Cod_h { get; set; }
        public string? TitleEn1 { get; set; }
        public string? Title { get; set; }
        public string? DrjLookupTitle { get; set; }
        public int DarajeeGheshrID { get; set; }
        public string? UnitTitle  { get; set; }

        public string? DrjSubLookupDescription { get; set; }
        public int? DrjSubLookupId { get; set; }

        //RST_NAM
        public int? PilotoOrother { get; set; }

        //public string? LastFlightDate { get; set; }
        public string? DateHealthEvidence01ID { get; set; }
        public string? FlightEvidence01ID { get; set; }

        public string? DayValidFlight { get; set; }
        public string? ToDateHealthEvidenceTitleRamainDay01 { get; set; }
        public string? LastfltDateFilnal01amainDay01 { get; set; }
        public string? LastFlightDate { get; set; }

        public string? ResaultStandCheckRamainDay01 { get; set; }

        public string? PhisicalEXPDate { get; set; }
        public string? NOTAMCHECKETitle01Activitystr { get; set; }
        public string? StandEXP { get; set; }
        public string? LastfltDate { get; set; }


        //PhisicalEXPDate = dateProp.oo_HealthEvidence01.ToDateHealthEvidenceTitle,
        //            NOTAMCHECKETitle01Activitystr = dateProp.oo_FlightActivityEvidence01ID.NOTAMCHECKETitle01,
        //            StandEXP = dateProp.ooStandCheck.ResaultStandCheck,
        //            LastfltDate = dateProp.LastFlightDate,

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

 
        public string? RasmiVazifeh { get; set; }
        /// <summary>
        /// یگان
        ///// </summary>
        //public int? UnitID01 { get; set; }
        ///// <summary>
        ///// یگان
        ///// </summary>
        //public int? UitID01 { get; set; }

        public int? UitIDGaurd01 { get; set; }

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

        /// <summary>
        ///روز اعتبار تا لغو مجوز پرواز
        /// </summary>

        //public string? DayValidFlight { get; set; }

        /// <summary>
        ///TotalFlightTime
        /// </summary>
        public string? TotalFlightTime { get; set; }
        public TimeSpan? TotalFlightTimeTimeSpan { get; set; }
        public DateTime? TotalFlightTimeDateTime { get; set; }

        /// <summary>
        ///LastFlightDate
        /// </summary>
        //public string? LastFlightDate { get; set; }

        [Display(Name = "نام لاتین")]
        public string? FstNamEN { get; set; }
        [Display(Name = "نام خانوادگي لاتین")]
        public string? LstNamEN { get; set; }
     

        //[Key]
        //public Nullable<int> NewsId { get; set; }

        //[Display(Name = "عنوان خبر")]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "عنوان خبر وارد نشده است.")]
        ////[StringLength(150, MinimumLength = 4, ErrorMessage = "تعداد کاراکترها باید بین 4 تا 150 حرف باشد")]
        //////[RegularExpression(@"[0-9A-Zا-یa-z_\s\-\(\)\.]+", ErrorMessage = "در {0} کاراکترهای نامعتبر وارد شده است.")]
        //public string? Title { get; set; }



         


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
        [Display(Name = "")]
        public string? LST_NAM { get; set; }
        /// <summary>
        /// نام قبلی
        /// </summary>
        [Display(Name = "")]
        public string? GBL_FNAM { get; set; }
        /// <summary>
        /// نام خانوادگی قبلی
        /// </summary>
        [Display(Name = "")]
        public string? GBL_LNAM { get; set; }
        /// <summary>
        /// نام پدر
        /// </summary>
        public string? FAT_NAM { get; set; }
        /// </summary>
        [Display(Name = "")]
        /// ش شناسنامه
        /// </summary>
        public string? INF_NUM { get; set; }
        /// <summary>
        /// محل تولد
        /// </summary>
        [Display(Name = "")]
        public string? BRT_COD { get; set; }
        //[ForeignKey("BRT_COD")]

        //public virtual CityType _BRT_COD { get; set; }

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        [Display(Name = "")]
        public string? BRT_DAT { get; set; }
        public string? MAR_DAT { get; set; }
        /// <summary>
        /// محل صدور
        /// </summary>
        public string? ISS_COD { get; set; }
        //[ForeignKey("ISS_COD")]

        //public virtual CityType _ISS_COD { get; set; }





        /// <summary>
        /// تاریخ صدور
        /// </summary>
        public string? ISS_DAT { get; set; }
        /// <summary>
        /// گروه خون
        /// </summary>  type=47
        public string? BLG_COD { get; set; }
        //[ForeignKey("BLG_COD")]
        //public virtual TblLuLookup _BLG_COD { get; set; }

        /// <summary>
        /// دین مذهب
        /// </summary> type=99
        public string? REL_COD { get; set; }
        //[ForeignKey("REL_COD")]

        //public virtual TblLuLookup _REL_COD { get; set; }
        /// <summary>
        /// كد دین و مذهب قبلی
        /// </summary> type=99
        public string? REL_COD2 { get; set; }
        /// </summary> 
        //[ForeignKey("REL_COD2")]
        //public virtual TblLuLookup _REL_COD2 { get; set; }
        /// <summary>
        /// جنسیت
        /// </summary>  type=32
        public string? SEX_COD { get; set; }
        //[ForeignKey("SEX_COD")]

        //public virtual TblLuLookup _SEX_COD { get; set; }
        /// <summary>
        /// وضعیت تاهل
        /// </summary>type=23
        public string? MAR_COD { get; set; }
        //[ForeignKey("MAR_COD")]

        //public virtual TblLuLookup _MAR_COD { get; set; }

        /// <summary> 
        /// تعداد همسر
        /// </summary>
        public string? WIF_QTY { get; set; }
        /// <summary>
        /// تعداد عائله بجز همسر و اولاد
        /// </summary>
        public string? FAM_QTY { get; set; }
        /// <summary>
        /// تعداد اولاد پسر
        /// </summary>
        public string? SUN_QTY { get; set; }
        /// <summary>
        /// تعداد اولاد دختر
        /// </summary>
        public string? DOT_QTY { get; set; }
        /// </summary>
        /// وضعیت سكونت - خانه سازمانی یا كانتینر
        /// </summary> type=80
        public string? MAS_COD { get; set; }
        //[ForeignKey("MAS_COD")]

        //public virtual TblLuLookup _MAS_COD { get; set; }
        /// <summary>
        ///  تاریخ شروع وضعیت مسكونی
        /// </summary>
        public string? HOM_DAT { get; set; }
        /// <summary>
        /// تاریخ استخدام
        /// </summary>
        public string? EMP_DAT { get; set; }
        /// <summary>
        /// نوع استخدام
        /// </summary>type=123
        public string? TYP_EMP { get; set; }
        //[ForeignKey("TYP_EMP")]

        //public virtual TblLuLookup _TYP_EMP { get; set; }
        /// </summary>
        /// /// مدرك یا ماده دستور استخدام
        /// </summary>
        public string? EMP_ORD { get; set; }
        //public virtual TblLuLookup yEmpOrd { get; set; }

        /// <summary>
        /// كد یگان صاحب دستور استخدام
        /// </summary>
        public string? EMP_YEG { get; set; }
        //public virtual TblLuLookup y { get; set; }

        /// <summary>
        /// فرمان یا دستور استخدام رده بالاتر
        /// </summary>
        public string? EMP_ORD2 { get; set; }
        //public virtual TblLuLookup yEmpOrd2 { get; set; }

        /// <summary>
        /// كد مدرك تحصیلی بدو استخدام
        /// </summary>
        public string? EDF_COD { get; set; }
        //public virtual TblLuLookup yEdfCod { get; set; }

        /// <summary>
        /// كد هویت خدمتی
        /// </summary>  type=151
        public string? EMS_COD { get; set; }
        //[ForeignKey("EMS_COD")]

        //public virtual TblLuLookup _EMS_COD { get; set; }

        /// <summary>
        /// كد نوع تغییر وضعیت
        /// </summary> type=251
        public string? CHG_COD { get; set; }
        //[ForeignKey("CHG_COD")]

        //public virtual TblLuLookup _CHG_COD { get; set; }

        /// <summary>
        /// كد آخرین مدرك تحصیلی
        /// </summary> type=11
        public string? EDE_COD { get; set; }
        //[ForeignKey("EDE_COD")]
        //public virtual TblLuLookup _EDE_COD { get; set; }

        /// <summary>
        /// كد رشته مدرك تحصیلی
        /// </summary>
        public string? SUB_COD { get; set; }
        //public virtual TblLuLookup ySubCod { get; set; }

        /// <summary>
        /// تاریخ آخرین مدرك تحصیلی
        /// </summary>
        public string? EDE_DAT { get; set; }
        //public virtual TblLuLookup yEdeDat { get; set; }

        /// <summary>
        /// كد آخرین دوره طولی نظامی
        /// </summary> type=90  TBL_LOOKUPS_DATA
        public string? LDOR_NEZ { get; set; }
        //[ForeignKey("LDOR_NEZ")]
        //public virtual TblLuLookup _LDOR_NEZ { get; set; }

        /// <summary>
        /// كد وضعیت از لحاظ خدمت
        /// </summary> type=9
        public string? DUS_COD { get; set; }
        //[ForeignKey("DUS_COD")]
        //public virtual TblLuLookup _DUS_COD { get; set; }

        /// <summary>
        /// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        /// </summary>
        public string? CUR_JOB { get; set; }
        /// <summary>
        /// تاریخ شروع وضعیت كنونی از لحاظ خدمت
        /// </summary>
        public string? HAZ_COD { get; set; }
        /// <summary>
        /// كد درجه / رتبه
        /// </summary> type=10
        public string? DRJ_COD { get; set; }
        //[ForeignKey("DRJ_COD")]
        //public virtual TblLuLookup _DRJ_COD { get; set; }
        public string? UitID01 { get; set; }

        public string? DRJ_NAM { get; set; }
        public string? RST_NAM  { get; set; }

        /// <summary>
        /// كد درجه اصلی
        /// </summary>
        public string? DRJ_CODA { get; set; }
        //public virtual TblLuLookup yDrjCoda { get; set; }

        /// <summary>
        /// نوع درجه - 0=دائم-1=موقت-2=مجازی
        /// </summary> type=36
        public string? DRJ_STT { get; set; }
        //[ForeignKey("DRJ_STT")]
        //public virtual TblLuLookup _DRJ_STT { get; set; }

        /// <summary>
        /// كد رسته
        /// </summary> type=30
        public string? RST_COD { get; set; }
        //[ForeignKey("RST_COD")]
        //public virtual TblLuLookup _RST_COD { get; set; }

        /// <summary>
        /// كد رسته قبلی
        /// </summary>
        public string? RST_COD2 { get; set; }
        //public virtual TblLuLookup yRstCod2 { get; set; }

        /// <summary>
        /// تاریخ تغییر رسته
        /// </summary>
        public string? DAT_RST2 { get; set; }
        ////public virtual TblLuLookup yDatRst2 { get; set; }

        /// <summary>
        /// كد علت تغییر رسته
        /// </summary>
        public string? ELL_RST { get; set; }
        ////public virtual TblLuLookup yEllRst { get; set; }

        /// <summary>
        /// گروه كارمندان تجربی
        /// </summary>
        public string? EMP_GRH { get; set; }
        //public virtual TblLuLookup yEmpGrh { get; set; }

        /// <summary>
        /// رده كارمندان تجربی
        /// </summary>
        public string? EMP_RAD { get; set; }
        //public virtual TblLuLookup yEmpRad { get; set; }

        /// <summary>
        /// كد تخصص اصلی
        /// </summary> type=155 TBL_LOOKUPS_DATA
        public string? COD_TAA { get; set; }
        //[ForeignKey("COD_TAA")]
        //public virtual TblLuLookup _COD_TAA { get; set; }

        /// <summary>
        /// كد تخصص فرعی
        /// </summary>
        public string? COD_TAF { get; set; }
        //public virtual TblLuLookup yCodTaf { get; set; }

        /// <summary>
        /// كد تخصص خدمتی
        /// </summary> type=155  TBL_LOOKUPS_DATA
        public string? COD_TAC { get; set; }
        //[ForeignKey("COD_TAC")]
        //public virtual TblLuLookup _COD_TAC { get; set; }

        /// <summary>
        /// شماره جدول سازمانی
        /// </summary>
        public string? SHO_JGH { get; set; }
        //public virtual TblLuLookup yShoJgh { get; set; }

        /// <summary>
        /// كد یگان سازمانی یا شغلی
        /// </summary> type=254
        public string? COD_GHA { get; set; }
        //[ForeignKey("COD_GHA")]
        //public virtual TblLuLookup _COD_GHA { get; set; }

        /// <summary>
        /// ش بند
        /// </summary>
        public string? BND_NUM { get; set; }
        /// <summary>
        /// ش سطر
        /// </summary>
        public string? STR_NUM { get; set; }
        /// <summary>
        /// كد حداكثر درجه شغل
        /// </summary> type=158 TBL_LOOKUPS_DATA
        public string? DRJ_CODJ { get; set; }
        //[ForeignKey("DRJ_CODJ")]
        //public virtual TblLuLookup _DRJ_CODJ { get; set; }

        /// <summary>
        /// تاریخ انتصاب
        /// </summary>
        public string? DAT_ENT { get; set; }
        /// <summary>
        /// علت بدون شغل شدن
        /// </summary>
        public string? VAZ_ENT { get; set; }
        //public virtual TblLuLookup yVazEnt { get; set; }

        /// <summary>
        /// تاریخ خروج از انتصاب
        /// </summary>
        public string? END_ENT { get; set; }
        /// <summary>
        /// در حال انتقال/انتساب بودن
        /// </summary> type=45
        public string? VAZ_NGH { get; set; }
        //[ForeignKey("VAZ_NGH")]
        //public virtual TblLuLookup _VAZ_NGH { get; set; }

        /// <summary>
        /// كد یگان مادر
        /// </summary> type=254
        public string? OMD_YEG { get; set; }
        //[ForeignKey("OMD_YEG")]
        //public virtual TblLuLookup _OMD_YEG { get; set; }

        /// <summary>
        /// كد یگان خدمتی  
        /// </summary>  [TBL_UnitsInfo]
        public string? YEG_COD2 { get; set; }
        //[ForeignKey("YEG_COD2")]
        //public virtual TblUnitsInfo _YEG_COD2 { get; set; }

        /// <summary>
        /// تاریخ حضور در یگان خدمتی
        /// </summary>
        public string? DAT_YEG2 { get; set; }
        /// <summary>
        /// منطقه محل خدمتی
        /// </summary>
        public string? TYP_MNT { get; set; }
        //public virtual TblLuLookup yTypMnt { get; set; }

        /// <summary>
        /// تاریخ شروع خدمت در منطقه خدمتی
        /// </summary>
        public string? MNT_DAT { get; set; }
        /// <summary>
        /// كد یگان حقوقی
        /// </summary> type=80
        public string? YEG_COD { get; set; }
        //public virtual TblLuLookup yYegCod { get; set; }

        /// <summary>
        /// تارخ آخرین ترفیع
        /// </summary>
        public string? PRE_DAT { get; set; }
        /// <summary>
        /// تاریخ ترفیع بعدی
        /// </summary>
        public string? PRN_DAT { get; set; }
        /// <summary>
        /// ارشدیت اعمال شده
        /// </summary>
        public string? CUR_ARS { get; set; }
        /// <summary>
        /// تنبیهات اعمال شده
        /// </summary>
        public string? CUR_TAN { get; set; }
        /// <summary>
        /// (ارشدیت اعمال نشده (قدمت 
        /// </summary>
        public string? NXT_ARS { get; set; }
        /// <summary>
        /// تنبیهات اعمال نشده
        /// </summary>
        public string? NXT_TAN { get; set; }
        /// <summary>
        /// مرخصی بدون حقوق طول خدمت
        /// </summary>
        public string? FRE_QTY { get; set; }
        /// <summary>
        /// مدت خدمت سربازی
        /// </summary>
        public string? SAR_QTY { get; set; }
        /// <summary>
        /// جمع مدت خدمت نیمه وقت بانوان طول خدمت
        /// </summary>
        public string? LAD_QTY { get; set; }
        /// <summary>
        /// تاریخ بازنشستگی
        /// </summary>
        public string? DAT_BAZ { get; set; }
        /// <summary>
        /// ارتقا تشویقی دارد /ندارد
        /// </summary>
        public string? NUM_ETSH { get; set; }
        /// <summary>
        /// میزان ارتقا حقوقی
        /// </summary>
        public string? NUM_EPAY { get; set; }
        /// <summary>
        /// تاریخ آخرین ارتقا حقوقی
        /// </summary>
        public string? DAT_EPAY { get; set; }
        /// <summary>
        /// مدت خدمت در منطقه عملیاتی قبل از قطعنامه
        /// </summary>
        public string? TOT_AML { get; set; }
        /// <summary>
        /// مدت خدمت در منطقه عملیاتی بعد از قطعنامه
        /// </summary>
        public string? TOT_AML2 { get; set; }
        /// <summary>
        /// كد زبان مادری یا محلی
        /// </summary> type=48
        public string? ZAB_MAH { get; set; }
        //[ForeignKey("ZAB_MAH")]
        //public virtual TblLuLookup _ZAB_MAH { get; set; }

        /// <summary>
        /// .f.یا .t.-سابقه اسارت                             
        /// </summary>
        public string? VAZ_ESA { get; set; }
        /// <summary>
        /// .f.یا .t.-سابقه  گروگان بودن                      
        /// </summary>
        public string? VAZ_GRO { get; set; }
        /// <summary>
        /// كد طبقه پزشكی
        /// </summary>
        public string? NAZ_COD { get; set; }
        /// <summary>
        /// تاریخ معاینه پزشكی
        /// </summary>
        public string? DAT_NAZ { get; set; }
        /// <summary>
        /// كد نواقص پزشكی
        /// </summary>
        public string? BOD_COD { get; set; }
        /// <summary>
        /// میزان در صد جانبازی ارتش
        /// </summary>
        public string? DRSAD_JA { get; set; }
        /// <summary>
        /// میزان در صد جانبازی بنیاد
        /// </summary>
        public string? DRSAD_JB { get; set; }
        /// <summary>
        /// آدرس محل سكونت
        /// </summary>
        public string? ADDRES { get; set; }
        /// <summary>
        /// پیش شماره یا كد تلفن محل
        /// </summary>
        public string? COD_TEL { get; set; }
        /// <summary>
        /// شماره تلفن
        /// </summary>
        public string? TEL_NUM { get; set; }
        /// <summary>
        /// رنگ چشم
        /// </summary>
        public string? COL_EYE { get; set; }
        /// <summary>
        /// وزن
        /// </summary>
        public string? VAZN_PER { get; set; }
        /// <summary>
        /// قد
        /// </summary>
        public string? HIG_PER { get; set; }
        /// <summary>
        /// اندازه پا
        /// </summary>
        public string? SIZ_FOT { get; set; }
        /// <summary>
        /// اندازه كلاه
        /// </summary>
        public string? SIZ_KLA { get; set; }
        /// <summary>
        /// چك مشخصات پرسنلی با اطلاعات سوابق
        /// </summary>
        public string? OK_SAB { get; set; }
        /// <summary>
        /// یگان فرستنده
        /// </summary>
        public string? FER_YEG { get; set; }
        /// <summary>
        /// ( اعاده/ابقا (یك = ابقا - دو= اعاده 
        /// </summary> type=147
        public string? RET_COD { get; set; }
        //[ForeignKey("RET_COD")]
        //public virtual TblLuLookup _RET_COD { get; set; }

        /// <summary>
        /// وضعیت پرنده فرار - مفتوحه است یا نه
        /// </summary>
        public string? VAZ_FAR { get; set; }
        /// <summary>
        /// نوع اعلام حضور
        /// </summary>
        public string? T_ENTER { get; set; }
        /// <summary>
        /// سویچ چاپ فرم شناسایی
        /// </summary>
        public string? SW_PRT { get; set; }
        /// <summary>
        /// كلید شغل
        /// </summary>
        public string? KLD_SHGL { get; set; }
        /// <summary>
        /// مدت قدمت درجه فعلی
        /// </summary>
        public string? GED_OT { get; set; }
        /// <summary>
        /// كورس ترفیعاتی
        /// </summary>
        public string? CORS_T { get; set; }
        /// <summary>
        /// كد رشد تخصصی فرد
        /// </summary> type=160 TBL_LOOKUPS_DATA
        public string? ROSH_P { get; set; }
        //[ForeignKey("ROSH_P")]
        //public virtual TblLuLookup _ROSH_P { get; set; }
        //type=80
        public string? GHE_SHR { get; set; }
        public string? GHE_SHR01 { get; set; }

        

        /// <summary>
        /// كد هویت شغل
        /// </summary>
        public string? COD_C1 { get; set; }
        /// <summary>
        /// كد ماهیت یگان شغل
        /// </summary>
        public string? COD_C2 { get; set; }
        /// <summary>
        /// كد نوع شغل
        /// </summary>
        public string? COD_C3 { get; set; }
        /// <summary>
        /// كد نوع پذیرش شغل
        /// </summary>
        public string? COD_C4 { get; set; }
        /// <summary>
        /// كد رشد تخصصی شغل
        /// </summary> type=160  TBL_LOOKUPS_DATA
        public string? COD_C12 { get; set; }
        //[ForeignKey("COD_C12")]
        //public virtual TblLuLookup _COD_C12 { get; set; }

        /// <summary>
        /// كد رسته شغل
        /// </summary> type=157 TBL_LOOKUPS_DATA
        public string? COD_C78 { get; set; }
        //[ForeignKey("COD_C78")]
        //public virtual TblLuLookup _COD_C78 { get; set; }

        /// <summary>
        /// عنوان شغل
        /// </summary>
        public string? JOB_DES { get; set; }
        /// <summary>
        /// تاریخ ارتقا بعدی
        /// </summary>
        public string? DAT_ERTB { get; set; }
        public string? DAT_ERTG { get; set; }
        public string? TYP_GHE { get; set; }
        /// <summary>
        /// تاریخ رسمی شدن
        /// </summary>
        public string? DAT_RAS { get; set; }
        /// <summary>
        ///  نوع خدمت كارمندی
        /// </summary>
        public string? CHG_TYP { get; set; }
        public string? KHD_TYP { get; set; }
        public string? SOT_DAT { get; set; }
        public string? DAT_NGH { get; set; }
        public string? DAT_OMD { get; set; }
        /// <summary>
        /// نوع قشر
        /// </summary> type=112
        public string? GHESHR { get; set; }
        //[ForeignKey("GHESHR")]
        //public virtual TblLuLookup _GHESHR { get; set; }

        public string? COD4 { get; set; }
        /// <summary>
        /// تاریخ بازنشستگی بر اساس 60 سال سن
        /// </summary>
        public string? DAT_BAZS { get; set; }
        public string? EmployArchismDuration { get; set; }
        public string? EmployUniversityCode { get; set; }
        public string? EmploySectionCode { get; set; }
        public string? EmployServiceTypeCode { get; set; }
        public string? LengthCode { get; set; }
        public string? PeopleCode { get; set; }
        /// <summary>
        /// تنزیل درجه
        /// </summary> type=80
        public string? DiscountStatus { get; set; }
        //public virtual TblLuLookup yDiscountStatus { get; set; }

        public string? CHG_TAR { get; set; }
        /// <summary>
        /// سابقه انتصاباتی نیاز به  اصلاح دارد
        /// </summary>
        public string? CHG_ENT { get; set; }
        /// <summary>
        /// تاریخ شروع طبقه پزشكی
        /// </summary>
        public string? datMedicalClassBegin { get; set; }
        /// <summary>
        /// تاریخ پایان طبقه پزشكی
        /// </summary>
        public string? datMedicalClassEnd { get; set; }
        public string? HasChanged { get; set; }
        public string? LastChangeTime { get; set; }
        public string? HasYegan { get; set; }
        public string? LastYegan { get; set; }
        public string? YEG_COD2_Tmp { get; set; }
        public string? HasYegan_Tmp { get; set; }
        public string? MAK_SR { get; set; }
        [Key]
        public string? MelliCode { get; set; }
        //type=26
        public string? DeliverTypeCode { get; set; }
        //[ForeignKey("DeliverTypeCode")]
        //public virtual TblLuLookup _DeliverTypeCode { get; set; }

        public string? Tel_workplace { get; set; }
        public string? Tel_mobile { get; set; }
        public string? Postcode { get; set; }
        public string? code_mosalsal { get; set; }
        public string? shomareh_seri { get; set; }
        public string? harfe_seri { get; set; }

        ///// <summary>
        /////  نام لاتین
        ///// </summary>
        //public string? FstNamEN { get; set; }
        ///// <summary>
        ///// نام خانوادگی لاتین
        ///// </summary>
        //public string? LstNamEN { get; set; }
        ///// <summary>
        ///// ریت پروازی
        ///// </summary>
        //public string? RateFlight { get; set; }

    }

    public class TblMasterViewModelCostum01
    {
        public string? Hoghog01ID { get; set; }
        public string? MelliCode { get; set; }

    }
    public class TblHoghog01ViewModel
    {
         /// <summary>
        /// یگان
        ///// </summary>



        //public int? UitID01 { get; set; }

        public string? Hoghog01ID { get; set; }
        public string? Year01 { get; set; }
        public string? Month01 { get; set; }

        public string? S2P { get; set; }
        public string? N { get; set; }
        public string? NK2 { get; set; }
        public string? NP { get; set; }
        public string? M_ezafe { get; set; }
        public string? FMR { get; set; }
        public string? CYK2 { get; set; }
        public string? CDI { get; set; }
        public string? CDYR { get; set; }
        public string? CND { get; set; }
        public string? CBPH { get; set; }
        public string? CNHBPH { get; set; }
        public string? S2H { get; set; }
        public string? CHK2 { get; set; }
        public string? CVLK2 { get; set; }
        public string? TT { get; set; }
        public string? TES { get; set; }
        public string? SK2 { get; set; }
        public string? TNDYR { get; set; }
        public string? TNDYRB { get; set; }
        public string? CNK2S { get; set; }
        public string? CPM { get; set; }
        public string? CJ { get; set; }
        public string? CVT { get; set; }
        public string? THD { get; set; }
        public string? TKOZ { get; set; }
        public string? TKOO { get; set; }
        public string? TATT { get; set; }
        public string? TFMBBJ { get; set; }
        public string? TFGMBBJ { get; set; }
        public string? CNBDS2 { get; set; }
        public string? TBS2 { get; set; }
        public string? TBS2KKF4 { get; set; }
        public string? ARH { get; set; }
        public string? ARHJAN { get; set; }
        public string? CODXRAY { get; set; }
        public string? DARJAN { get; set; }
        public string? TARJAN { get; set; }
        public string? MMTB { get; set; }
        public string? TEVF { get; set; }
        public string? THE { get; set; }
        public string? TET { get; set; }
        public string? TEDM { get; set; }
        public string? CM6 { get; set; }
        public string? TET1M6 { get; set; }
        public string? TET2M6 { get; set; }
        public string? CDYRMS { get; set; }
        public string? CNS2 { get; set; }
        public string? CTMS { get; set; }
        public string? S2SERY { get; set; }
        public string? S2MBS { get; set; }
        public string? S2SMS { get; set; }
        public string? S2J6MS { get; set; }
        public string? CM42 { get; set; }
        public string? S2S { get; set; }
        public string? CML1 { get; set; }
        //public string? MelliCode { get; set; }
        public string? FIL99 { get; set; }
        public string? HSA { get; set; }
        public string? FMO { get; set; }
        public string? FME { get; set; }
        public string? HSO { get; set; }
        public string? TTH { get; set; }
        public string? TTG { get; set; }
        public string? TG2 { get; set; }
        public string? KHK { get; set; }
        public string? T99 { get; set; }
        public string? T01 { get; set; }
        public string? HS2 { get; set; }
        public string? HS3 { get; set; }
        public string? HS4 { get; set; }
        public string? HS5 { get; set; }
        public string? FMT { get; set; }
        public string? FVK { get; set; }
        public string? FEJ { get; set; }
        public string? FND { get; set; }
        public string? FSM { get; set; }
        public string? T97 { get; set; }
        public string? FM1 { get; set; }
        public string? FM2 { get; set; }
        public string? FM3 { get; set; }
        public string? FM4 { get; set; }
        public string? FM5 { get; set; }
        public string? FBA { get; set; }
        public string? FBK { get; set; }
        public string? FMA { get; set; }
        public string? FEN { get; set; }
        public string? SFS { get; set; }
        public string? TSV { get; set; }
        public string? FS2 { get; set; }
        public string? FS3 { get; set; }
        public string? FS4 { get; set; }
        public string? FS5 { get; set; }
        public string? FS6 { get; set; }
        public string? HAO { get; set; }
        public string? KHM { get; set; }
        public string? HNJ { get; set; }
        public string? KHF { get; set; }
        public string? HEZ { get; set; }
        public string? KHS { get; set; }
        public string? HTO { get; set; }
        public string? EZF { get; set; }
        public string? BPB { get; set; }
        public string? BPI { get; set; }
        public string? BPD { get; set; }
        public string? KHR { get; set; }
        public string? TWN { get; set; }
        public string? HTF { get; set; }
        public string? MLK { get; set; }
        public string? KR4 { get; set; }
        public string? KR5 { get; set; }
        public string? KR6 { get; set; }
        public string? KR7 { get; set; }
        public string? KR8 { get; set; }
        public string? SWP { get; set; }
        public string? THM { get; set; }
        public string? TKD { get; set; }
        public string? TMD { get; set; }
        public string? TTT { get; set; }
        public string? PPK { get; set; }
        public string? MEN { get; set; }
        public string? BPS { get; set; }
        public string? BPM { get; set; }
        public string? BKM { get; set; }
        public string? TBI { get; set; }
        public string? TBK { get; set; }
        public string? TTF { get; set; }
        public string? TML { get; set; }
        public string? TTS { get; set; }
        public string? SD6 { get; set; }
        public string? SD7 { get; set; }
        public string? SD8 { get; set; }
        public string? SD9 { get; set; }
        public string? SDA { get; set; }
        public string? MBA { get; set; }
        public string? MBI { get; set; }
        public string? BKD { get; set; }
        public string? BMD { get; set; }
        public string? KKD { get; set; }
        public string? KMD { get; set; }
        public string? KTT { get; set; }
        public string? MHG { get; set; }
        public string? SKG { get; set; }
        public string? KG1 { get; set; }
        public string? KG2 { get; set; }
        public string? KG3 { get; set; }
        public string? KG4 { get; set; }
        public string? HOM { get; set; }
        public string? BHS { get; set; }
        public string? BOS { get; set; }
        public string? MPS { get; set; }
        public string? MPM { get; set; }
        public string? KKS { get; set; }
        public string? SHR { get; set; }
        public string? JKS { get; set; }
        public string? TZH { get; set; }
        public string? EJB { get; set; }
        public string? BBK { get; set; }
        public string? KE3 { get; set; }
        public string? KE4 { get; set; }
        public string? KE5 { get; set; }
        public string? KE6 { get; set; }
        public string? BHM { get; set; }
        public string? BFM { get; set; }
        public string? BPK { get; set; }
        public string? KPK { get; set; }
        public string? BME { get; set; }
        public string? KME { get; set; }
        public string? KAM { get; set; }
        public string? MHM { get; set; }
        public string? MKD { get; set; }
        public string? MMD { get; set; }
        public string? MTT { get; set; }
        public string? MFM { get; set; }
        public string? MPK { get; set; }
        public string? MME { get; set; }
        public string? KLB { get; set; }
        public string? KBM { get; set; }
        public string? SKM { get; set; }
        public string? BBI { get; set; }
        public string? BTS { get; set; }
        public string? BTF { get; set; }
        public string? BML { get; set; }
        public string? MTS { get; set; }
        public string? MTF { get; set; }
        public string? MML { get; set; }
        public string? KO7 { get; set; }
        public string? KO8 { get; set; }
        public string? KO9 { get; set; }
        public string? KOA { get; set; }
        public string? KOB { get; set; }
        public string? KOC { get; set; }
        public string? KM1 { get; set; }
        public string? KM2 { get; set; }
        public string? KM3 { get; set; }
        public string? KM4 { get; set; }
        public string? JKG { get; set; }
        public string? JVP { get; set; }
        public string? JKK { get; set; }
        public string? HMK { get; set; }
        public string? GGK { get; set; }
        public string? JHM { get; set; }
        public string? K2P { get; set; }
        public string? SNK { get; set; }
        public string? NK1 { get; set; }
        public string? NK22 { get; set; }
        public string? NK3 { get; set; }
        public string? CMO { get; set; }
        public string? TMO { get; set; }
        public string? S2HBPH { get; set; }
        public string? FIL1 { get; set; }
        public string? SWR { get; set; }
        public string? PPS { get; set; }
        public string? PLB { get; set; }
        public string? SDD { get; set; }
        public string? BHT { get; set; }
        public string? OKD { get; set; }
        public string? TSY { get; set; }
        public string? MAE { get; set; }
        public string? SP8 { get; set; }
        public string? SP9 { get; set; }
        public string? SPA { get; set; }
        public string? SPB { get; set; }
        public string? SPC { get; set; }
        public string? SPD { get; set; }




    }



}



