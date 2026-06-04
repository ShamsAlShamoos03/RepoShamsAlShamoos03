using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class CrewGaurdPlanEvidence01
{
    [Key]
    public string? CrewGaurdPlanEvidence01ID { get; set; }
    //public int FactorNumber { get; set; }

    /// <summary>
    ///  رجه نام و نشان ش کا کد ملی
    /// </summary>
    public string? MelliCode { get; set; }
    [ForeignKey("MelliCode")]
    //[LazyLoad(false)]

    public virtual TblMaster oo_CrewGaurdPesronel { get; set; }


    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public string? GaurdPlanEvidence01ID { get; set; }
    [ForeignKey("GaurdPlanEvidence01ID")]
    public virtual GaurdPlanEvidence01 oo_GaurdPlanEvidence01ID { get; set; }

    /// <summary>
    ///ای دی فعالیت پروازی 
    /// </summary>
    public bool? IsPIC { get; set; }


    //CategoryGeneralSubId=25
    public int? Duty { get; set; }
    [ForeignKey("Duty")]
    public virtual CategoryGeneral oo_Duty { get; set; }

    /// <summary>
    /////شماره و مدل بالگرد 
    ///// </summary>
    //public string? HelicopterTailEvidence01 { get; set; }
    //[ForeignKey("HelicopterTailEvidence01")]
    //public virtual HelicopterTailEvidence01 oo_HelicopterTailEvidence01 { get; set; }

    /// <summary>
    ///CALL-SIGN
    ///شناسه رادیویی
    /// </summary>
    /// CategoryGeneralSubId=27
    //public int? CALLSIGN { get; set; }
    //[ForeignKey("CALLSIGN")]
    //public virtual CategoryGeneral oo_CALLSIGN { get; set; }

    ///// <summary>
    /////FLT AREA
    /////منطقه پروازی
    ///// </summary>
    ///// CategoryGeneralSubId=28
    //public int? FLTAREA { get; set; }
    //[ForeignKey("FLTAREA")]
    //public virtual CategoryGeneral oo_FLTAREA { get; set; }






    ///// <summary>
    /////ETD
    ///// </summary>
    //public string? ETD { get; set; }
    //public TimeSpan? ETDTimeSpan { get; set; }
    //public DateTime? ETDDateTime { get; set; }

    ///// <summary>
    /////ETE
    ///// </summary>
    //public string? ETE { get; set; }
    //public DateTime? ETEDateTime { get; set; }
    //public TimeSpan? ETETimeSpan { get; set; }

    ///// <summary>
    ///// SerialNOPlan
    ///// </summary>
    //public string? SerialNOPlan { get; set; }

    ///// <summary>
    /////ALT
    /////ارتفاع ترافیک
    ///// </summary>
    ///// CategoryGeneralSubId=29
    //public int? ALT { get; set; }
    //[ForeignKey("ALT")]
    //public virtual CategoryGeneral oo_ALT { get; set; }

    ///// <summary>
    ///// STATION
    ///// </summary>
    //public string? STATION { get; set; }


    ///// <summary>
    /////VHF(G)
    /////فرکانس رادیویی 
    ///// </summary>
    ///// CategoryGeneralSubId=30
    //public int? VHFG { get; set; }
    //[ForeignKey("VHFG")]
    //public virtual CategoryGeneral oo_VHFG { get; set; }

    ///// <summary>
    /////UHF(G)
    /////فرکانس رادیویی 
    ///// </summary>
    ///// CategoryGeneralSubId=31
    //public int? UHFG { get; set; }
    //[ForeignKey("UHFG")]
    //public virtual CategoryGeneral oo_UHFG { get; set; }


    ///// <summary>
    /////FM(G)
    /////فرکانس رادیویی 
    ///// </summary>
    ///// CategoryGeneralSubId=32
    //public int? FMG { get; set; }
    //[ForeignKey("FMG")]
    //public virtual CategoryGeneral oo_FMG { get; set; }


    ///// <summary>
    /////VHF
    /////فرکانس رادیویی 
    ///// </summary>
    ///// CategoryGeneralSubId=33
    //public int? VHF { get; set; }
    //[ForeignKey("VHF")]
    //public virtual CategoryGeneral oo_VHF { get; set; }


    ///// <summary>
    /////UHF
    /////فرکانس رادیویی 
    ///// </summary>
    ///// CategoryGeneralSubId=34
    //public int? UHF { get; set; }
    //[ForeignKey("UHF")]
    //public virtual CategoryGeneral oo_UHF { get; set; }


    ///// <summary>
    /////ADF
    /////فرکانس رادیویی 
    ///// </summary>
    ///// CategoryGeneralSubId=35
    //public int? ADF { get; set; }
    //[ForeignKey("ADF")]
    //public virtual CategoryGeneral oo_ADF { get; set; }


    ///// <summary>
    /////VOR
    /////فرکانس رادیویی 
    ///// </summary>
    ///// CategoryGeneralSubId=36
    //public int? VOR { get; set; }
    //[ForeignKey("VOR")]
    //public virtual CategoryGeneral oo_VOR { get; set; }


    ///// <summary>
    /////RADAR
    /////فرکانس رادیویی 
    ///// </summary>
    ///// CategoryGeneralSubId=37
    //public int? RADAR { get; set; }
    //[ForeignKey("RADAR")]
    //public virtual CategoryGeneral oo_RADAR { get; set; }

    ///// <summary>
    /////ATIS
    /////فرکانس رادیویی 
    ///// </summary>
    ///// CategoryGeneralSubId=38
    //public int? ATIS { get; set; }
    //[ForeignKey("ATIS")]
    //public virtual CategoryGeneral oo_ATIS { get; set; }

    ///// <summary>
    /////PURPOSE OF FLT
    /////نوع فعالیت 
    ///// </summary>
    ///// CategoryGeneralSubId=39
    //public int? PURPOSEOFFLT { get; set; }
    //[ForeignKey("PURPOSEOFFLT")]
    //public virtual CategoryGeneral oo_PURPOSEOFFLT { get; set; }



    ///// <summary>
    /////هواشناسی
    ///// </summary>
    //public string? WeatherEvidence01ID { get; set; }
    //[ForeignKey("WeatherEvidence01ID")]
    //public virtual WeatherEvidence01 oo_WeatherEvidence01 { get; set; }



    ///// <summary>
    /////  رجه نام و نشان ش کا کد ملی
    ///// </summary>
    ////public string? MelliCode { get; set; }
    ////[ForeignKey("MelliCode")]
    ////public virtual TblMaster oo_CrewGaurdPlanEvidence01 { get; set; }

    ///// <summary>
    /////  شماره بالگرد 
    ///// </summary>
    ////public string? TailHelicopter { get; set; }

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


    ///// <summary>
    ///// منطقه پروازی 
    ///// </summary>
    //public int? FLTAREANOTAMCHECK { get; set; }
    //[ForeignKey("FLTAREANOTAMCHECK")]
    //public virtual CategoryGeneral oo_TFLTAREANOTAMCHECK { get; set; }
    ///// <summary>
    /////  وضعیت هوا
    ///// </summary>
    //public int? StatusCrewGaurdPlanEvidence01 { get; set; }
    //[ForeignKey("StatusCrewGaurdPlanEvidence01")]
    //public virtual CategoryGeneral oo_StatusCrewGaurdPlanEvidence01 { get; set; }

    /// <summary>
    ///  گرید 
    /// </summary>
    //public string? Grade { get; set; }

    /// <summary>
    ///  سطح آزمون
    /// </summary>
    //public int? LevelExam { get; set; }
    //[ForeignKey("LevelExam")]
    //public virtual CategoryGeneral oo_LevelExam { get; set; }
    /// <summary>
    /// تاریخ شروع
    /// </summary>
    //public string? FromDateCrewGaurdPlanEvidence01Title { get; set; }
    ///// <summary>
    /////  تاریخ خاتمه
    ///// </summary>
    //public string? ToDateCrewGaurdPlanEvidence01Title { get; set; }
    ///// <summary>
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
    ///  فعال غیر فعال
    /// </summary>
    public bool? IsHaveJob { get; set; }


    //    public bool? HoverFLT { get; set; }
    //    public bool? SidwardFLT { get; set; }
    //    public bool? BackwardFLT { get; set; }
    //    public bool? NormalTO { get; set; }
    //    public bool? IGEcheck { get; set; }
    //    public bool? OGEcheck { get; set; }
    //    public bool? NormalAPP { get; set; }
    //    public bool? SteepAPP { get; set; }
    //    public bool? MaxTO { get; set; }
    //    public bool? APP180 { get; set; }
    //    public bool? MinpowerTO { get; set; }
    //    public bool? Internalload { get; set; }
    //    public bool? Externalload { get; set; }
    //    public bool? ConfindOPS { get; set; }
    //    public bool? PinnacleOPS { get; set; }
    //    public bool? SLOPOPS { get; set; }
    //    //public bool? LOWLEVELFLT { get; set; }
    //    public bool? NOEFLT { get; set; }
    //    public bool? FMDFOPS { get; set; }
    //    public bool? Pricaurionarylanding { get; set; }
    //    public bool? Forcedlanding { get; set; }
    //    public bool? SingleENG { get; set; }
    //    public bool? HYDMAL { get; set; }
    //    public bool? ManualGOVOPS { get; set; }
    //    public bool? Runinglanding { get; set; }
    //    public bool? HoveringAUTO { get; set; }
    //    public bool? StandardAUTO { get; set; }
    //    public bool? LowlevelAUTO { get; set; }
    //    public bool? Lowlevelflt { get; set; }
    //    public bool? AUTOTWP { get; set; }
    //    public bool? AUTO180 { get; set; }
    //    public bool? WaterOPS { get; set; }
    //    public bool? gunnery { get; set; }
    //    public bool? HoodFLT { get; set; }
    //    public bool? INSTFLT { get; set; }
    //    public bool? AntiTorqueFailure { get; set; }



    public string? FlightEvidence01ID { get; set; }
    [ForeignKey("FlightEvidence01ID")]
    public virtual FlightEvidence01? ooRateFlight { get; set; }

    public string? StandCheckWritten01ID { get; set; }
    [ForeignKey("StandCheckWritten01ID")]
    public virtual StandCheckWritten01? ooStandCheck { get; set; }


    public string? HealthEvidence01ID { get; set; }
    [ForeignKey("HealthEvidence01ID")]
    public virtual HealthEvidence01? oo_HealthEvidence01 { get; set; }

    public string? NoNoticeEvidence01ID { get; set; }
    [ForeignKey("NoNoticeEvidence01ID")]
    public virtual NoNoticeEvidence01? oo_NoNoticeEvidence01 { get; set; }

    public string? EnglishExamEvidence01ID { get; set; }
    [ForeignKey("EnglishExamEvidence01ID")]
    public virtual EnglishExamEvidence01? oo_EnglishExamEvidence01 { get; set; }
    public string? LastfltDateFilnal01 { get; set; }


    //public TimeSpan? SumETEDateTime { get; set; }

    [NotMapped]
    public string? DateHealthEvidence01ID
    {

        get
        {


            //RADARDFstr =
            //                            (item.oo_GaurdPlanEvidence01ID.RADARDF == null) ? "" :
            //                            (item.oo_GaurdPlanEvidence01ID.RADARDF != null) ? item.oo_GaurdPlanEvidence01ID.oo_RADARDF.Title : null,

            //return this.oo_HealthEvidence01.ToDateHealthEvidenceTitle;
            //return this.oo_CrewGaurdPesronel.oodr;
            //return this.oo_CrewGaurdPesronel.ooDRJCOD.Title + " " + this.oo_CrewGaurdPesronel.FST_NAM + " " + this.oo_CrewGaurdPesronel.LST_NAM + " " + this.oo_CrewGaurdPesronel.ooRateGaurd.Rate_CategoryGeneral.Title + " " + this.oo_CrewGaurdPesronel.oo_PhoneEvidence01.Phone01;
            //return this.oo_CrewGaurdPesronel.ooDRJCOD.Title + " " + this.oo_CrewGaurdPesronel.FST_NAM + " " + this.oo_CrewGaurdPesronel.LST_NAM + " " + this.oo_CrewGaurdPesronel.ooRateGaurd.Rate_CategoryGeneral.Title + " " + this.oo_CrewGaurdPesronel.oo_PhoneEvidence01.Phone01;
            //return (this.MelliCode == null) ? "" :
            // (this.MelliCode != null) ? this.oo_CrewGaurdPesronel.ooDRJCOD.Title + " " + this.oo_CrewGaurdPesronel.FST_NAM + " " + this.oo_CrewGaurdPesronel.LST_NAM + " " + this.oo_CrewGaurdPesronel.ooRateGaurd.Rate_CategoryGeneral.Title + " " + this.oo_CrewGaurdPesronel.oo_PhoneEvidence01.Phone01
            //: null;
            //return this.oo_CrewGaurdPesronel.MelliCode == null ? "" : this.oo_CrewGaurdPesronel.MelliCode;
            //return this.oo_GaurdPlanEvidence01ID.oo_GaurdActivityEvidence01ID.FromDateGaurdActivityEvidence01Title == null ? "" : this.oo_GaurdPlanEvidence01ID.oo_GaurdActivityEvidence01ID.FromDateGaurdActivityEvidence01Title;
            //return this.oo_GaurdPlanEvidence01ID.RADARDF == null ? "" : /* return something else */;
            //return this.oo_StatusConfirmation11.Title == null ? "" : null/* return something else */;

            //return this.StatusConfirmation11 == null ? "33" : this.StatusConfirmation11 != null ? this.StatusConfirmation11.ToString() : null/* return something else */;
            //return this.MelliCode == null ? "33" : this.MelliCode != null ? this.MelliCode : null/* return something else */;
            //return this.MelliCode == null ? "33" : this.MelliCode != null ? this.oo_CrewGaurdPesronel.FST_NAM.ToString() : null/* return something else */;
            //return this.MelliCode


            //return this.oo_CrewGaurdPesronel.Include(u => u.Address).FirstOrDefault(u => u.Id == 1);


            //return this.oo_CrewGaurdPesronel..Where(b => b.Name == "ADO.NET Blog")
            //   .Include(b => b.Posts)
            //   .FirstOrDefault();

            return "000dc";
        }


    }


}
