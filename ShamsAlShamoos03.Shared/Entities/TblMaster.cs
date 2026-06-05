using MD.PersianDateTime.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

public class TblMaster333
{
    public string? EMP_NUM { get; set; }
    /// <summary>
    /// نام
    /// </summary>
    public string? FST_NAM { get; set; }
    /// <summary>
    /// نام خانوادگي
    /// </summary>
    public string? LST_NAM { get; set; }
    public string? BRT_COD { get; set; }
    public string? MelliCode { get; set; }

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
}

public class TblMaster
{
    public string? Tabaghe { get; set; }
    public string? ReasTabaghe { get; set; }
    public string? Benefits { get; set; }
    public string? Percenta { get; set; }

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

    #region "ستون مجازی محاسبه سن و سنوات خدمتی"

    [NotMapped]
    public int? YearsOFWorks
    {
        get
        {
            int yearsOfWork = 0;
            if (!string.IsNullOrEmpty(EMP_DAT) && EMP_DAT.Length == 8 && IsNumeric(EMP_DAT))
            {
                string shamsiDate = $"{EMP_DAT.Substring(0, 4)}/{EMP_DAT.Substring(4, 2)}/{EMP_DAT.Substring(6, 2)}";

                if (IsDateShamsi(shamsiDate) && IsShamsiDateValid(EMP_DAT))
                {
                    DateTime employmentDate = ConvertDateTime.ConvertShamsiToMiladi(shamsiDate);

                    yearsOfWork = DateTime.Now.Year - employmentDate.Year;

                    if (DateTime.Now.Month < employmentDate.Month ||
                        (DateTime.Now.Month == employmentDate.Month && DateTime.Now.Day < employmentDate.Day))
                    {
                        yearsOfWork--;
                    }
                }
            }
            return yearsOfWork;

        }
    }

    private bool IsDateShamsi(string dateShamsi)
    {
        try
        {
            ConvertDateTime.ConvertShamsiToMiladi(dateShamsi);
            return true;
        }
        catch (Exception wf)
        {
            return false;
        }
    }

    private bool IsNumeric(string input)
    {
        return input.All(char.IsDigit);
    }

    private bool IsShamsiDateValid(string shamsiDate)
    {
        int year = int.Parse(shamsiDate.Substring(0, 4));
        int month = int.Parse(shamsiDate.Substring(4, 2));
        int day = int.Parse(shamsiDate.Substring(6, 2));

        if (year < 1300 || year > 1500)
        {
            return false;
        }

        if (month < 1 || month > 12)
        {
            return false;
        }

        if (day < 1 || day > 31)
        {
            return false;
        }

        return true;
    }

    [NotMapped]
    public int? YearsOFOld
    {
        get
        {
            int yearsOfOld = 0;
            if (!string.IsNullOrEmpty(BRT_DAT) && BRT_DAT.Length == 8 && IsNumeric(BRT_DAT))
            {
                string shamsiDate = $"{BRT_DAT.Substring(0, 4)}/{BRT_DAT.Substring(4, 2)}/{BRT_DAT.Substring(6, 2)}";
                if (IsDateShamsi(shamsiDate) && IsShamsiDateValid(BRT_DAT))
                {
                    DateTime employmentDate = ConvertDateTime.ConvertShamsiToMiladi(shamsiDate);

                    yearsOfOld = DateTime.Now.Year - employmentDate.Year;

                    if (DateTime.Now.Month < employmentDate.Month ||
                        (DateTime.Now.Month == employmentDate.Month && DateTime.Now.Day < employmentDate.Day))
                    {
                        yearsOfOld--;
                    }
                }
            }
            return yearsOfOld;
        }
    }

    #endregion

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
    /// فرمانده یگان
    /// </summary>
    public int? ISFatmandeYeganGhesmat01 { get; set; }
    [ForeignKey("ISFatmandeYeganGhesmat01")]
    public virtual CategoryGeneral? oo_ISFatmandeYeganGhesmat01l { get; set; }

    /// <summary>
    /// یگان
    /// </summary>
    public int? UitID01 { get; set; }
    [ForeignKey("UitID01")]
    public virtual CategoryGeneral? oo_tblCategoryGeneralUit { get; set; }

    /// <summary>
    /// ریت لول
    /// </summary>
    public int? RateLevel { get; set; }
    [ForeignKey("RateLevel")]
    public virtual CategoryGeneral? oo_RateLevel { get; set; }

    /// <summary>
    /// تخصص فنی خلبان رسته مشترک
    /// </summary>
    public int? TakhasosFaniKhalabanMoshtarak { get; set; }
    [ForeignKey("TakhasosFaniKhalabanMoshtarak")]
    public virtual CategoryGeneral? oo_TakhasosFaniKhalabanMoshtarak { get; set; }

    /// <summary>
    /// مدل تخصص بالگرد
    /// </summary>
    public int? TypeAc { get; set; }
    [ForeignKey("TypeAc")]
    public virtual CategoryGeneral? oo_TypeAc { get; set; }

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
    /// یگان
    /// </summary>
    public int? UitIDGaurd01 { get; set; }
    [ForeignKey("UitIDGaurd01")]
    public virtual CategoryGeneral? oo_tblCategoryGeneralUitGaurd { get; set; }

    /// <summary>
    /// شماره پرسنلي
    /// </summary>
    public string? EMP_NUM { get; set; }
    /// <summary>
    /// نام
    /// </summary>
    public string? FST_NAM { get; set; }
    /// <summary>
    /// نام خانوادگي
    /// </summary>
    public string? LST_NAM { get; set; }
    /// <summary>
    /// نام قبلي
    /// </summary>
    public string? GBL_FNAM { get; set; }
    /// <summary>
    /// نام خانوادگي قبلي
    /// </summary>
    public string? GBL_LNAM { get; set; }
    /// <summary>
    /// نام پدر
    /// </summary>
    public string? FAT_NAM { get; set; }
    /// <summary>
    /// ش شناسنامه
    /// </summary>
    public string? INF_NUM { get; set; }
    /// <summary>
    /// محل تولد
    /// </summary>
    public string? BRT_COD { get; set; }

    /// <summary>
    /// تاريخ تولد
    /// </summary>
    public string? MAR_DAT { get; set; }

    /// <summary>
    /// تاريخ تولد
    /// </summary>
    public string? BRT_DAT { get; set; }
    /// <summary>
    /// محل صدور
    /// </summary>
    public string? ISS_COD { get; set; }

    /// <summary>
    /// تاريخ صدور
    /// </summary>
    public string? ISS_DAT { get; set; }
    /// <summary>
    /// گروه خون
    /// </summary>
    public string? BLG_COD { get; set; }

    /// <summary>
    /// دين مذهب
    /// </summary>
    public string? REL_COD { get; set; }
    /// <summary>
    /// كد دين و مذهب قبلي
    /// </summary>
    public string? REL_COD2 { get; set; }
    /// <summary>
    /// جنسيت
    /// </summary>
    public string? SEX_COD { get; set; }
    [ForeignKey("SEX_COD")]
    public virtual TblLuLookup? ooSEXCOD { get; set; }
    /// <summary>
    /// وضعيت تاهل
    /// </summary>
    public string? MAR_COD { get; set; }
    [ForeignKey("MAR_COD")]
    public virtual TblLuLookup? ooMARCOD { get; set; }

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
    /// وضعيت سكونت - خانه سازماني يا كانتينر
    /// </summary>
    public string? MAS_COD { get; set; }
    [ForeignKey("MAS_COD")]
    public virtual TblLuLookup? ooMASCOD { get; set; }
    /// <summary>
    ///  تاريخ شروع وضعيت مسكوني
    /// </summary>
    public string? HOM_DAT { get; set; }
    /// <summary>
    /// تاريخ استخدام
    /// </summary>
    public string? EMP_DAT { get; set; }
    /// <summary>
    /// نوع استخدام
    /// </summary>
    public string? TYP_EMP { get; set; }
    [ForeignKey("TYP_EMP")]
    public virtual TblLuLookup? ooTYPEMP { get; set; }
    /// </summary>
    /// /// مدرك يا ماده دستور استخدام
    /// </summary>
    public string? EMP_ORD { get; set; }

    /// <summary>
    /// كد يگان صاحب دستور استخدام
    /// </summary>
    public string? EMP_YEG { get; set; }

    /// <summary>
    /// فرمان يا دستور استخدام رده بالاتر
    /// </summary>
    public string? EMP_ORD2 { get; set; }

    /// <summary>
    /// كد مدرك تحصيلي بدو استخدام
    /// </summary>
    public string? EDF_COD { get; set; }

    /// <summary>
    /// كد هويت خدمتي
    /// </summary>
    public string? EMS_COD { get; set; }
    [ForeignKey("EMS_COD")]
    public virtual TblLuLookup? ooEMSCOD { get; set; }

    /// <summary>
    /// كد نوع تغيير وضعيت
    /// </summary>
    public string? CHG_COD { get; set; }
    [ForeignKey("CHG_COD")]
    public virtual TblLuLookup? ooCHGCOD { get; set; }

    /// <summary>
    /// كد آخرين مدرك تحصيلي
    /// </summary>
    public string? EDE_COD { get; set; }
    [ForeignKey("EDE_COD")]
    public virtual TblLuLookup? ooEDECOD { get; set; }

    /// <summary>
    /// كد رشته مدرك تحصيلي
    /// </summary>
    public string? SUB_COD { get; set; }

    /// <summary>
    /// تاريخ آخرين مدرك تحصيلي
    /// </summary>
    public string? EDE_DAT { get; set; }

    /// <summary>
    /// كد آخرين دوره طولي نظامي
    /// </summary>
    public string? LDOR_NEZ { get; set; }
    [ForeignKey("LDOR_NEZ")]
    public virtual TblLookupsData? ooLDORNEZ { get; set; }

    /// <summary>
    /// كد وضعيت از لحاظ خدمت
    /// </summary>
    public string? DUS_COD { get; set; }
    [ForeignKey("DUS_COD")]
    public virtual TblLuLookup? ooDUSCOD { get; set; }

    /// <summary>
    /// تاريخ شروع وضعيت كنوني از لحاظ خدمت
    /// </summary>
    public string? CUR_JOB { get; set; }
    /// <summary>
    /// تاريخ شروع وضعيت كنوني از لحاظ خدمت
    /// </summary>
    public string? HAZ_COD { get; set; }
    /// <summary>
    /// كد درجه / رتبه
    /// </summary>
    public string? DRJ_COD { get; set; }
    [ForeignKey("DRJ_COD")]
    public virtual TblLuLookup? ooDRJCOD { get; set; }

    /// <summary>
    /// كد درجه اصلي
    /// </summary>
    public string? DRJ_CODA { get; set; }

    /// <summary>
    /// نوع درجه - 0=دائم-1=موقت-2=مجازي
    /// </summary>
    public string? DRJ_STT { get; set; }
    [ForeignKey("DRJ_STT")]
    public virtual TblLuLookup? ooDRJSTT { get; set; }

    /// <summary>
    /// كد رسته
    /// </summary>
    public string? RST_COD { get; set; }
    [ForeignKey("RST_COD")]
    public virtual TblLuLookup? ooRSTCOD { get; set; }

    /// <summary>
    /// كد رسته قبلي
    /// </summary>
    public string? RST_COD2 { get; set; }

    /// <summary>
    /// تاريخ تغيير رسته
    /// </summary>
    public string? DAT_RST2 { get; set; }

    /// <summary>
    /// كد علت تغيير رسته
    /// </summary>
    public string? ELL_RST { get; set; }

    /// <summary>
    /// گروه كارمندان تجربي
    /// </summary>
    public string? EMP_GRH { get; set; }

    /// <summary>
    /// رده كارمندان تجربي
    /// </summary>
    public string? EMP_RAD { get; set; }

    /// <summary>
    /// كد تخصص اصلي
    /// </summary>
    public string? COD_TAA { get; set; }

    /// <summary>
    /// كد تخصص فرعي
    /// </summary>
    public string? COD_TAF { get; set; }

    /// <summary>
    /// كد تخصص خدمتي
    /// </summary>
    public string? COD_TAC { get; set; }

    /// <summary>
    /// شماره جدول سازماني
    /// </summary>
    public string? SHO_JGH { get; set; }

    /// <summary>
    /// كد يگان سازماني يا شغلي
    /// </summary>
    public string? COD_GHA { get; set; }

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
    /// </summary>
    public string? DRJ_CODJ { get; set; }

    /// <summary>
    /// تاريخ انتصاب
    /// </summary>
    public string? DAT_ENT { get; set; }
    /// <summary>
    /// علت بدون شغل شدن
    /// </summary>
    public string? VAZ_ENT { get; set; }

    /// <summary>
    /// تاريخ خروج از انتصاب
    /// </summary>
    public string? END_ENT { get; set; }
    /// <summary>
    /// در حال انتقال/انتساب بودن
    /// </summary>
    public string? VAZ_NGH { get; set; }
    [ForeignKey("VAZ_NGH")]
    public virtual TblLuLookup? ooVAZNGH { get; set; }

    /// <summary>
    /// كد يگان مادر
    /// </summary>
    public string? OMD_YEG { get; set; }

    /// <summary>
    /// كد يگان خدمتي  
    /// </summary>
    public string? YEG_COD2 { get; set; }

    /// <summary>
    /// تاريخ حضور در يگان خدمتي
    /// </summary>
    public string? DAT_YEG2 { get; set; }
    /// <summary>
    /// منطقه محل خدمتي
    /// </summary>
    public string? TYP_MNT { get; set; }

    /// <summary>
    /// تاريخ شروع خدمت در منطقه خدمتي
    /// </summary>
    public string? MNT_DAT { get; set; }
    /// <summary>
    /// كد يگان حقوقي
    /// </summary>
    public string? YEG_COD { get; set; }

    /// <summary>
    /// تارخ آخرين ترفيع
    /// </summary>
    public string? PRE_DAT { get; set; }
    /// <summary>
    /// تاريخ ترفيع بعدي
    /// </summary>
    public string? PRN_DAT { get; set; }
    /// <summary>
    /// ارشديت اعمال شده
    /// </summary>
    public string? CUR_ARS { get; set; }
    /// <summary>
    /// تنبيهات اعمال شده
    /// </summary>
    public string? CUR_TAN { get; set; }
    /// <summary>
    /// (ارشديت اعمال نشده (قدمت 
    /// </summary>
    public string? NXT_ARS { get; set; }
    /// <summary>
    /// تنبيهات اعمال نشده
    /// </summary>
    public string? NXT_TAN { get; set; }
    /// <summary>
    /// مرخصي بدون حقوق طول خدمت
    /// </summary>
    public string? FRE_QTY { get; set; }
    /// <summary>
    /// مدت خدمت سربازي
    /// </summary>
    public string? SAR_QTY { get; set; }
    /// <summary>
    /// جمع مدت خدمت نيمه وقت بانوان طول خدمت
    /// </summary>
    public string? LAD_QTY { get; set; }
    /// <summary>
    /// تاريخ بازنشستگي
    /// </summary>
    public string? DAT_BAZ { get; set; }
    /// <summary>
    /// ارتقا تشويقي دارد /ندارد
    /// </summary>
    public string? NUM_ETSH { get; set; }
    /// <summary>
    /// ميزان ارتقا حقوقي
    /// </summary>
    public string? NUM_EPAY { get; set; }
    /// <summary>
    /// تاريخ آخرين ارتقا حقوقي
    /// </summary>
    public string? DAT_EPAY { get; set; }
    /// <summary>
    /// مدت خدمت در منطقه عملياتي قبل از قطعنامه
    /// </summary>
    public string? TOT_AML { get; set; }
    /// <summary>
    /// مدت خدمت در منطقه عملياتي بعد از قطعنامه
    /// </summary>
    public string? TOT_AML2 { get; set; }
    /// <summary>
    /// كد زبان مادري يا محلي
    /// </summary>
    public string? ZAB_MAH { get; set; }
    [ForeignKey("ZAB_MAH")]
    public virtual TblLuLookup? ooZABMAH { get; set; }

    /// <summary>
    /// .f.يا .t.-سابقه اسارت                             
    /// </summary>
    public string? VAZ_ESA { get; set; }
    /// <summary>
    /// .f.يا .t.-سابقه  گروگان بودن                      
    /// </summary>
    public string? VAZ_GRO { get; set; }
    /// <summary>
    /// كد طبقه پزشكي
    /// </summary>
    public string? NAZ_COD { get; set; }
    /// <summary>
    /// تاريخ معاينه پزشكي
    /// </summary>
    public string? DAT_NAZ { get; set; }
    /// <summary>
    /// كد نواقص پزشكي
    /// </summary>
    public string? BOD_COD { get; set; }
    /// <summary>
    /// ميزان در صد جانبازي ارتش
    /// </summary>
    public string? DRSAD_JA { get; set; }
    /// <summary>
    /// ميزان در صد جانبازي بنياد
    /// </summary>
    public string? DRSAD_JB { get; set; }
    /// <summary>
    /// آدرس محل سكونت
    /// </summary>
    public string? ADDRES { get; set; }
    /// <summary>
    /// پيش شماره يا كد تلفن محل
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
    /// چك مشخصات پرسنلي با اطلاعات سوابق
    /// </summary>
    public string? OK_SAB { get; set; }
    /// <summary>
    /// يگان فرستنده
    /// </summary>
    public string? FER_YEG { get; set; }
    /// <summary>
    /// ( اعاده/ابقا (يك = ابقا - دو= اعاده 
    /// </summary>
    public string? RET_COD { get; set; }
    [ForeignKey("RET_COD")]
    public virtual TblLuLookup? ooRETCOD { get; set; }

    /// <summary>
    /// وضعيت پرنده فرار - مفتوحه است يا نه
    /// </summary>
    public string? VAZ_FAR { get; set; }
    /// <summary>
    /// نوع اعلام حضور
    /// </summary>
    public string? T_ENTER { get; set; }
    /// <summary>
    /// سويچ چاپ فرم شناسايي
    /// </summary>
    public string? SW_PRT { get; set; }
    /// <summary>
    /// كليد شغل
    /// </summary>
    public string? KLD_SHGL { get; set; }
    /// <summary>
    /// مدت قدمت درجه فعلي
    /// </summary>
    public string? GED_OT { get; set; }
    /// <summary>
    /// كورس ترفيعاتي
    /// </summary>
    public string? CORS_T { get; set; }
    /// <summary>
    /// كد رشد تخصصي فرد
    /// </summary>
    public string? ROSH_P { get; set; }
    [ForeignKey("ROSH_P")]
    public virtual TblLookupsData? ooROSHP { get; set; }

    public string? GHE_SHR { get; set; }

    /// <summary>
    /// كد هويت شغل
    /// </summary>
    public string? COD_C1 { get; set; }
    /// <summary>
    /// كد ماهيت يگان شغل
    /// </summary>
    public string? COD_C2 { get; set; }
    /// <summary>
    /// كد نوع شغل
    /// </summary>
    public string? COD_C3 { get; set; }
    /// <summary>
    /// كد نوع پذيرش شغل
    /// </summary>
    public string? COD_C4 { get; set; }
    /// <summary>
    /// كد رشد تخصصي شغل
    /// </summary>
    public string? COD_C12 { get; set; }

    /// <summary>
    /// كد رسته شغل
    /// </summary>
    public string? COD_C78 { get; set; }

    /// <summary>
    /// عنوان شغل
    /// </summary>
    public string? JOB_DES { get; set; }
    /// <summary>
    /// تاريخ ارتقا بعدي
    /// </summary>
    public string? DAT_ERTB { get; set; }
    public string? DAT_ERTG { get; set; }
    public string? TYP_GHE { get; set; }
    /// <summary>
    /// تاريخ رسمي شدن
    /// </summary>
    public string? DAT_RAS { get; set; }
    /// <summary>
    ///  نوع خدمت كارمندي
    /// </summary>
    public string? CHG_TYP { get; set; }
    public string? KHD_TYP { get; set; }
    public string? SOT_DAT { get; set; }
    public string? DAT_NGH { get; set; }
    public string? DAT_OMD { get; set; }
    /// <summary>
    /// نوع قشر
    /// </summary>
    public string? GHESHR { get; set; }
    [ForeignKey("GHESHR")]
    public virtual TblLuLookup? ooGHESHR { get; set; }

    public string? COD4 { get; set; }
    /// <summary>
    /// تاريخ بازنشستگي بر اساس 60 سال سن
    /// </summary>
    public string? DAT_BAZS { get; set; }
    public string? EmployArchismDuration { get; set; }
    public string? EmployUniversityCode { get; set; }
    public string? EmploySectionCode { get; set; }
    public string? EmployServiceTypeCode { get; set; }
    public string? LengthCode { get; set; }
    public string? PeopleCode { get; set; }
    /// <summary>
    /// تنزيل درجه
    /// </summary>
    public string? DiscountStatus { get; set; }

    public string? CHG_TAR { get; set; }
    /// <summary>
    /// سابقه انتصاباتي نياز به  اصلاح دارد
    /// </summary>
    public string? CHG_ENT { get; set; }
    /// <summary>
    /// تاريخ شروع طبقه پزشكي
    /// </summary>
    public string? datMedicalClassBegin { get; set; }
    /// <summary>
    /// تاريخ پايان طبقه پزشكي
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

    public string? DeliverTypeCode { get; set; }
    [ForeignKey("DeliverTypeCode")]
    public virtual TblLuLookup? ooDeliverTypeCode { get; set; }

    public string? Tel_workplace { get; set; }
    public string? Tel_mobile { get; set; }
    public string? Postcode { get; set; }
    public string? code_mosalsal { get; set; }
    public string? shomareh_seri { get; set; }
    public string? harfe_seri { get; set; }

    public virtual IList<UjobPesronel01> UjobPesronel01s { get; set; }

    /// <summary>
    ///  نام لاتین
    /// </summary>
    public string? FstNamEN { get; set; }
    /// <summary>
    /// نام خانوادگي لاتین
    /// </summary>
    public string? LstNamEN { get; set; }

    public string? FlightEvidence01ID { get; set; }
    [ForeignKey("FlightEvidence01ID")]
    public virtual FlightEvidence01? ooRateFlight { get; set; }

    public string? StandCheckWritten01ID { get; set; }
    [ForeignKey("StandCheckWritten01ID")]
    public virtual StandCheckWritten01? ooStandCheck { get; set; }

    public string? Hoghog01ID { get; set; }
    [ForeignKey("Hoghog01ID")]
    public virtual TblHoghog01? oo_Hoghog01ID { get; set; }

    public string? HealthEvidence01ID { get; set; }
    [ForeignKey("HealthEvidence01ID")]
    public virtual HealthEvidence01? oo_HealthEvidence01 { get; set; }

    public string? NoNoticeEvidence01ID { get; set; }
    [ForeignKey("NoNoticeEvidence01ID")]
    public virtual NoNoticeEvidence01? oo_NoNoticeEvidence01 { get; set; }

    public string? EnglishExamEvidence01ID { get; set; }
    [ForeignKey("EnglishExamEvidence01ID")]
    public virtual EnglishExamEvidence01? oo_EnglishExamEvidence01 { get; set; }

    public string? PhoneEvidence01ID { get; set; }
    [ForeignKey("PhoneEvidence01ID")]
    public virtual PhoneEvidence01? oo_PhoneEvidence01 { get; set; }

    public string? AdressEvidence01ID { get; set; }
    [ForeignKey("AdressEvidence01ID")]
    public virtual AdressEvidence01? oo_AdressEvidence01 { get; set; }

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

    public string? TotalFlightTimeNew01 { get; set; }
    /// <summary>
    ///روز اعتبار تا لغو مجوز پرواز
    /// </summary>
    public string? DayValidFlight { get; set; }

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

public static class ConvertDateTime
{
    public static DateTime ConvertShamsiToMiladi(string date)
    {
        PersianDateTime persianDateTime = PersianDateTime.Parse(date);
        return persianDateTime.ToDateTime();
    }

    public static string ConvertMiladiToShamsi(this DateTime? date, string format)
    {
        PersianDateTime persianDateTime = new PersianDateTime(date);
        return persianDateTime.ToString(format);
    }

    public static string GetShamsiDate(this DateTime date, string format)
    {
        PersianCalendar pc = new PersianCalendar();

        return pc.GetYear(date).ToString("0000") + "/" +
               pc.GetMonth(date).ToString("00") + "/" +
               pc.GetDayOfMonth(date).ToString("00");
    }
}
