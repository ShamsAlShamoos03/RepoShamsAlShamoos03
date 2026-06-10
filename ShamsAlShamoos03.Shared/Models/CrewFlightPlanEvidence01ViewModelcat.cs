using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

    
    public class CrewFlightPlanEvidence01ViewModelcat
    {

        public int? PURPOSEOFFLTDispatch { get; set; }
        public string? PURPOSEOFFLTDispatchstr { get; set; }
        public string? PURPOSEOFFLTDispatchstrFA { get; set; }
        public int? CrewstrType { get; set; }
        public int? YearsOFWorks { get; set; }

        public int? YearsOFOld { get; set; }
        //public string Title { get; set; }
        //public string Darajee { get; set; }
        //public string DRJ_NAMGheshr1 { get; set; }
        //public string DRJ_NAMGheshr2 { get; set; }
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



        //public string FName { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string LName { get; set; }

        ////[Display(Name = "دسته بندی")]


        //[Display(Name = "دسته بندی")]
        //public int Rate { get; set; }
        public string Ratestr { get; set; }
        //public string RatestrFa { get; set; }




        public string DutyInFlight { get; set; }


        public string? PlusTimeSpan { get; set; }
        public DateTime? PlusDateTime { get; set; }




        public string AlltimeRnagedate_01 { get; set; }




        public string DifAlltimeRnagedate_01stringhhmmHours { get; set; }
        //public TimeSpan DifAlltimeRnagedate_01stringhhmmHours { get; set; }
        public TimeSpan DifAlltimeRnagedate_01stringhhmmHoursTime { get; set; }




        //AlltimeRnagedate_01
        //            public string? stringhhmmHours { get; set; }






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







        public int? TypeRateID { get; set; }
        public int? RateID { get; set; }

        public int? TypeAC { get; set; }
        public int? DarajeeGheshrID { get; set; }

        
        public string t0SPd { get; set; }
        public string t0CPd { get; set; }
        public string t0Pd { get; set; }
        public string t0TPd { get; set; }
        public string t0IPd { get; set; }
        public string t0SIPd { get; set; }

        public string t0SPN { get; set; }
        public string t0CPN { get; set; }
        public string t0PN { get; set; }
        public string t0IPN { get; set; }
        public string t0SIPN { get; set; }


        public string t0YN { get; set; }

        public string t0SPNY { get; set; }
        public string t0CPNY { get; set; }
        public string t0PNY { get; set; }
        public string t0IPNY { get; set; }
        public string t0SIPNY { get; set; }

        public string t0SIM { get; set; }

        public string t0HOOD { get; set; }

        public string t0SPHOOD { get; set; }
        public string t0CPHOOD { get; set; }
        public string t0PHOOD { get; set; }
        public string t0IPHOOD { get; set; }
        public string t0SIPHOOD { get; set; }







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














        public string TotalSPd { get; set; }
        public string TotalCPd { get; set; }
        public string TotalPd { get; set; }
        public string TotalTPd { get; set; }
        public string TotalIPd { get; set; }
        public string TotalSIPd { get; set; }

        public string TotalSPN { get; set; }
        public string TotalCPN { get; set; }
        public string TotalPN { get; set; }
        public string TotalIPN { get; set; }
        public string TotalSIPN { get; set; }


        public string TotalYN { get; set; }
        public string TotalSPNY { get; set; }
        public string TotalCPNY { get; set; }
        public string TotalPNY { get; set; }
        public string TotalIPNY { get; set; }
        public string TotalSIPNY { get; set; }

        public string TotalSIM { get; set; }

        public string TotalHOOD { get; set; }

        public string TotalSPHOOD { get; set; }
        public string TotalCPHOOD { get; set; }
        public string TotalPHOOD { get; set; }
        public string TotalIPHOOD { get; set; }
        public string TotalSIPHOOD { get; set; }











        public TimeSpan TotalSPdTime { get; set; }
        public TimeSpan TotalCPdTime { get; set; }
        public TimeSpan TotalPdTime { get; set; }
        public TimeSpan TotalTPdTime { get; set; }
        public TimeSpan TotalIPdTime { get; set; }
        public TimeSpan TotalSIPdTime { get; set; }

        public TimeSpan TotalSPNTime { get; set; }
        public TimeSpan TotalCPNTime { get; set; }
        public TimeSpan TotalPNTime { get; set; }
        public TimeSpan TotalIPNTime { get; set; }
        public TimeSpan TotalSIPNTime { get; set; }


        public TimeSpan TotalYNTime { get; set; }
        public TimeSpan TotalSPNYTime { get; set; }
        public TimeSpan TotalCPNYTime { get; set; }
        public TimeSpan TotalPNYTime { get; set; }
        public TimeSpan TotalIPNYTime { get; set; }
        public TimeSpan TotalSIPNYTime { get; set; }

        public TimeSpan TotalSIMTime { get; set; }

        public TimeSpan TotalHOODTime { get; set; }

        public TimeSpan TotalSPHOODTime { get; set; }
        public TimeSpan TotalCPHOODTime { get; set; }
        public TimeSpan TotalPHOODTime { get; set; }
        public TimeSpan TotalIPHOODTime { get; set; }
        public TimeSpan TotalSIPHOODTime { get; set; }














































        public string Darajee { get; set; }
        public string DarajeeEN { get; set; }
        public string EMP_NUM { get; set; }
        public string FstNamEN { get; set; }
        public string LstNamEN { get; set; }
        public string Rank01 { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        //public DateTime? SumETEDateTime { get; set; }
        //public TimeSpan? SumETEDateTime01 { get; set; }

        public string? DateHealthEvidence01ID { get; set; }
        /// <summary>
        ///روز اعتبار تا لغو مجوز پرواز
        /// </summary>

        public string? DayValidFlight { get; set; }

        /// <summary>
        ///  روز باقیمانده تا تاریخ خاتمه
        /// </summary>
        public string? ToDateHealthEvidenceTitleRamainDay01 { get; set; }
        //public string? ResaultStandCheckRamainDay01 { get; set; }

 
        //public TimeSpan? TotalTime { get; set; }
        public string? NOTAMCHECKETitle01Activitystr { get; set; }

        public string? LastfltDateFilnal01 { get; set; }
        public string? LastfltDateFilnal02 { get; set; }

        /// <summary>
        ///  روز باقیمانده از ۀخرین پرواز    
        /// </summary>

        public string? LastfltDateFilnal01amainDay01 { get; set; }

        //public string? FLTAREAstrFA { get; set; }

        public TimeSpan? TotalTime1 { get; set; }
        public double? TotalTimestr1 { get; set; }
        public double? TotalTimestr2 { get; set; }
        public TimeSpan? TotalTime2 { get; set; }
        public TimeSpan? TotalTime3 { get; set; }
        public long? TotalTime4 { get; set; }
        public TimeSpan? TotalTimeFirst01 { get; set; }
        public TimeSpan? TotalTimeFirst02 { get; set; }
        public TimeSpan TotalTime3aa { get; set; }

        public string? TotalTime1str01 { get; set; }
        public TimeSpan?  TotalTime1str02 { get; set; }
        public string? stringhhmmHours { get; set; }
        public string? DiferentETDETE { get; set; }


        /// <summary>
        /// NUMBER OF AIRCRAFT
        /// 79
        /// </summary>
        public int? NUMBEROFAIRCRAFT { get; set; }
        public string? NUMBEROFAIRCRAFTstr { get; set; }


        /// <summary>
        /// DEPARTURE AERODROME
        ///  فرودگاه مبدأ
        ///  80
        /// </summary>
        public int? DEPARTUREAERODROME { get; set; }
        public string? DEPARTUREAERODROMEstr { get; set; }
        public string? DEPARTUREAERODROMEstr1 { get; set; }

        /// <summary>
        ///Time UTC
        ///زمانی که به فرودگاه برای پرواز اعلام می شود و تا یک ساعت اعتبار دارد
        /// </summary>
        public string? TimeUTCZone { get; set; }
        public string? TimeUTCstr { get; set; }

        public DateTime? TimeUTCZoneDateTime { get; set; }

        public string? TimeUTC { get; set; }
        public DateTime? TimeUTCDateTime { get; set; }
        public TimeSpan? TimeUTCTimeSpan { get; set; }



        /// <summary>
        /// LEVEL
        /// </summary>
        public string? LEVEL { get; set; }
        //public string? LEVELstr { get; set; }


        /// <summary>
        ///ROUTE line1
        /// </summary>
        public string? ROUTEline1 { get; set; }

        /// <summary>
        ///ROUTE line2
        /// </summary>
        public string? ROUTEline2 { get; set; }
        /// <summary>
        ///ROUTE line3
        /// </summary>
        public string? ROUTEline3 { get; set; }
        /// <summary>
        ///ROUTE line4
        /// </summary>
        public string? ROUTEline4 { get; set; }


        /// <summary>
        /// DESTINATION AERODROME
        /// فرودگاه مقصد
        /// 80
        /// </summary>
        public int? DESTINATIONAERODROME { get; set; }
        public string? DESTINATIONAERODROMEstr { get; set; }
        public string? DESTINATIONAERODROMEstr1 { get; set; }


        /// <summary>
        /// TOTAL EET HR MIN
        /// مدت زمان تقریبی مسیر
        /// </summary>
        public string? TOTALEETHRMIN { get; set; }
        public DateTime? TOTALEETHRMINDateTime { get; set; }
        public TimeSpan? TOTALEETHRMINTimeSpan { get; set; }

        /// <summary>
        /// ALTNAERODRME
        /// فرودگاه رزرو اول
        /// 80
        /// </summary>
        public int? ALTNAERODRME { get; set; }
        public string? ALTNAERODRMEstr { get; set; }
        public string? ALTNAERODRMEstr1 { get; set; }


        /// <summary>
        /// ALTNAERODRME2
        /// فرودگاه رزرو دوم
        /// 80
        /// </summary>
        public int? ALTNAERODRME2 { get; set; }
        public string? ALTNAERODRME2str { get; set; }
        public string? ALTNAERODRME2str1 { get; set; }



        /// <summary>
        ///OTHER INFORMATION line1
        /// </summary>
        public string? OTHERINFORMATIONline1 { get; set; }

        /// <summary>
        ///OTHER INFORMATION line2
        /// </summary>
        public string? OTHERINFORMATIONline2 { get; set; }
        /// <summary>
        ///OTHER INFORMATION line3
        /// </summary>
        public string? OTHERINFORMATIONline3 { get; set; }
        /// <summary>
        ///OTHER INFORMATION line4
        /// </summary>
        public string? OTHERINFORMATIONline4 { get; set; }

        /// <summary>
        /// PERSONS ON BOARD
        /// تعداد سرنشینان
        /// 81
        /// </summary>
        public int? PERSONSONBOARD { get; set; }
        public string? PERSONSONBOARDstr { get; set; }


        /// <summary>
        /// REMARKS
        /// 82
        /// </summary>
        public int? REMARKS { get; set; }
        public string? REMARKSstr { get; set; }



        /// <summary>
        ///  مدل بالگرد 
        /// </summary>
        public int? TypeHelicopter { get; set; }
        public string? TypeHelicopterstr { get; set; }
        public string? TypeHelicopterstr1 { get; set; }


        /// <summary>
        /// FLIGHT ROLES
        /// 71
        /// </summary>
        public int? FLIGHTROLES { get; set; }
        public string? FLIGHTROLESstr { get; set; }
        public string? FLIGHTROLESstr1 { get; set; }
        /// <summary>
        /// TYPE OF FLIGHT
        /// 72
        /// </summary>
        public int? TYPEOFFLIGHT { get; set; }
        public string? TYPEOFFLIGHTstr { get; set; }
        public string? TYPEOFFLIGHTstr1 { get; set; }



        /// <summary>
        /// WAKE TURBULENCE CAL
        /// 73
        /// </summary>
        public int? WAKETURBULENCECAL { get; set; }
        public string? WAKETURBULENCECALstr { get; set; }
        public string? WAKETURBULENCECALstr1 { get; set; }
        
        /// <summary>
        /// EQUIPMENT AND CAPABILITIES
        /// 74
        /// </summary>
        public int? EQUIPMENTANDCAPABILITIES { get; set; }
        public string? EQUIPMENTANDCAPABILITIESstr { get; set; }
         

        /// <summary>
        /// CRUISING SPEED
        /// 75
        /// </summary>
        public int? CRUISINGSPEED { get; set; }
        public string? CRUISINGSPEEDstr { get; set; }



        ///// <summary>
        ///// LEVEL
        ///// </summary>
        //public int? LEVEL { get; set; }
        //[ForeignKey("LEVEL")]
        //public virtual CategoryGeneral oo_LEVEL { get; set; }





        /// <summary>
        /// ENDURANCE HR MIN
        /// 76
        /// </summary>
        public int? ENDURANCEHRMIN { get; set; }
        public string? ENDURANCEHRMINstr { get; set; }



        /// <summary>
        /// AIRCRAFT COLOUR AND MARKINGS
        /// 77
        /// </summary>
        public int? AIRCRAFTCOLOURANDMARKINGS { get; set; }
        public string? AIRCRAFTCOLOURANDMARKINGSstr { get; set; }


        /// <summary>
        /// EMERGENCY RADIO
        /// 78
        /// </summary>
        public int? EMERGENCYRADIO { get; set; }
        public string? EMERGENCYRADIOstr { get; set; }



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


        public string? PICstrPhone { get; set; }
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
        public string? TotalFLTTIME { get; set; }
        public string? PhisicalEXPDate  { get; set; }

        public string? StandEXP { get; set; }
        public string? LastfltDate { get; set; }




        public string SubId { get; set; }


        public string? CrewFlightPesronelstr { get; set; }
        public string? CrewFlightPesronel { get; set; }
        public string? Dutystr { get; set; }
        public int? Duty { get; set; }

        public bool? IsPIC { get; set; }

        public string? IsPICstr { get; set; }

        public TimeSpan TotalTime { get; set; }

        public TimeSpan? ETDTimeSpan { get; set; }
        public TimeSpan? ETETimeSpan { get; set; }


        public DateTime? ETDDateTime { get; set; }
        public DateTime? ETEDateTime { get; set; }

        public TimeSpan? DiferentETDETETimeSpan { get; set; }

        public string? ADFstr { get; set; }
        public string? ALTstr { get; set; }
        public string? ATISstr { get; set; }
        public string? CALLSIGNstr { get; set; }
        public string? STATIONstr { get; set; }

        //public string? ETDstr { get; set; }
        //public string? ETEstr { get; set; }
        public string? FLTAREAstr { get; set; }
        public string? FLTAREAstrFA { get; set; }
        public string? FMGstr { get; set; }
        public string? PURPOSEOFFLTstr { get; set; }
        public string? PURPOSEOFFLTstrFA { get; set; }
        public string? RADARstr { get; set; }
        public string? UHFstr { get; set; }
        public string? UHFGstr { get; set; }
        public string? VHFstr { get; set; }
        public string? VHFGstr { get; set; }
        public string? VORstr { get; set; }

        public int? RADARDF { get; set; }

        public string? RADARDFstr { get; set; }
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
        public string? SerialNOPlanHelicopterTail { get; set; }
         
        public int? UHF { get; set; }
        public int? UHFG { get; set; }
        public int? VHF { get; set; }
        public int? VHFG { get; set; }
        public int? VOR { get; set; }
        public int? STATION { get; set; }
         public string? FlightPlanEvidence01ID { get; set; }
        public string? FlightActivityEvidence01ID { get; set; }

        public string? HelicopterTailEvidence01 { get; set; }
        public string? HelicopterType { get; set; }
        public string? HelicopterTail { get; set; }
        public int? HelicopterTypeID { get; set; }
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



        //هواشناسی

        ///// <summary>
        ///// VIS
        ///// </summary>
        //public string? VIS { get; set; }

        //هواشناسی

        /// <summary>
        /// WIND
        /// </summary>
        public string? WIND { get; set; }


        /// <summary>
        /// VIIBILITY
        /// </summary>
        public string? VIIBILITY { get; set; }


        /// <summary>
        /// P.W
        /// </summary>
        public string? PW { get; set; }


        /// <summary>
        /// TEMP
        /// </summary>
        public string? TEMP { get; set; }


        /// <summary>
        /// D.P
        /// </summary>
        public string? DP { get; set; }


        /// <summary>
        /// CLOUDS
        /// </summary>
        public string? CLOUDS { get; set; }


        /// <summary>
        /// ALT.SET
        /// </summary>
        public string? ALTSET { get; set; }


        /// <summary>
        /// D.A
        /// </summary>
        public string? DA { get; set; }


        /// <summary>
        /// SUN.RISE
        /// </summary>
        public string? SUNRISE { get; set; }


        /// <summary>
        /// SUN.SET
        /// </summary>
        public string? SUNSET { get; set; }

        //هواشناسی

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
        public string CrewFlightPlanEvidence01ID { get; set; }
        public string CrewFlightPlanEvidence01IDstr { get; set; }

        public string CrewFlightPlanEvidence01IDstr3 { get; set; }
        public string CrewFlightPlanEvidence01IDstr4 { get; set; }
        public string CrewFlightPlanEvidence01IDstr5 { get; set; }
        public string CrewFlightPlanEvidence01IDstr6 { get; set; }
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
        //public string? FromDateCrewFlightPlanEvidence01TitleRamainDay01 { get; set; }
        ///// <summary>
        /////  روز باقیمانده تا تاریخ خاتمه
        ///// </summary>
        //public string? ToDateCrewFlightPlanEvidence01TitleRamainDay01 { get; set; }

        /// <summary>
        /// تاریخ شروع
        /// </summary>
        public string? FromDateCrewFlightPlanEvidence01Title { get; set; }
        ///// <summary>
        /////  تاریخ خاتمه
        ///// </summary>
        public string? ToDateCrewFlightPlanEvidence01Title { get; set; }


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


        [Display(Name = "ترتیب")]
        public int? Sortable01PURPOSEId { get; set; }
        public string SortableTitle01PURPOSE { get; set; }


        /// <summary>
        ///  وضعیت هوا
        /// </summary>
        public int? StatusCrewFlightPlanEvidence01 { get; set; }
        public string? StatusCrewFlightPlanEvidence01str { get; set; }



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

        public string UjobPesronel01strPhone { get; set; }

         
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
    }


    public class CrewFlightPlanEvidence01ViewModelcat02
    {
        public int? YearsOFWorks { get; set; }
        public int? PURPOSEOFFLTDispatch { get; set; }
        public string? PURPOSEOFFLTDispatchstr { get; set; }
        public string? PURPOSEOFFLTDispatchstrFA { get; set; }
        public int? YearsOFOld { get; set; }

        public string? PlusTimeSpan { get; set; }
        public DateTime? PlusDateTime { get; set; }
        public string DutyInFlight { get; set; }

        public string Darajee { get; set; }
        public string DarajeeEN { get; set; }
        public string EMP_NUM { get; set; }
        public string FstNamEN { get; set; }
        public string LstNamEN { get; set; }
        public string Rank01 { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }



        public string tSPd { get; set; }
        public string tCPd { get; set; }
        public string tPd { get; set; }
        public string tTPd { get; set; }
        public string tIPd { get; set; }
        public string tSIPd { get; set; }

        public string tSPN { get; set; }
        public string tCPN { get; set; }
        public string tPN { get; set; }
        public string tYN { get; set; }
        public string tIPN { get; set; }
        public string tSIPN { get; set; }






        public string SPd { get; set; }
        public string CPd { get; set; }
        public string Pd { get; set; }
        public string TPd { get; set; }
        public string IPd { get; set; }
        public string SIPd { get; set; }

        public string SPN { get; set; }
        public string CPN { get; set; }
        public string PN { get; set; }
        public string YN { get; set; }
        public string IPN { get; set; }
        public string SIPN { get; set; }





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







        public string tSPNY { get; set; }
        public string tCPNY { get; set; }
        public string tPNY { get; set; }
        public string tIPNY { get; set; }
        public string tSIPNY { get; set; }

        public string tSIM { get; set; }

        public string tHOOD { get; set; }

        public string tSPHOOD { get; set; }
        public string tCPHOOD { get; set; }
        public string tPHOOD { get; set; }
        public string tIPHOOD { get; set; }
        public string tSIPHOOD { get; set; }




        /// <summary>
        ///روز اعتبار تا لغو مجوز پرواز
        /// </summary>

        public string? DayValidFlight { get; set; }

        /// <summary>
        ///  روز باقیمانده تا تاریخ خاتمه
        /// </summary>
        public string? ToDateHealthEvidenceTitleRamainDay01 { get; set; }
        //public string? ResaultStandCheckRamainDay01 { get; set; }


        //public TimeSpan? TotalTime { get; set; }
        public string? NOTAMCHECKETitle01Activitystr { get; set; }

        public string? LastfltDateFilnal01 { get; set; }
        public string? LastfltDateFilnal02 { get; set; }

        /// <summary>
        ///  روز باقیمانده از ۀخرین پرواز    
        /// </summary>

        public string? LastfltDateFilnal01amainDay01 { get; set; }

        //public string? FLTAREAstrFA { get; set; }

        public TimeSpan? TotalTime1 { get; set; }
        public double? TotalTimestr1 { get; set; }
        public double? TotalTimestr2 { get; set; }
        public TimeSpan? TotalTime2 { get; set; }
        public TimeSpan? TotalTime3 { get; set; }
        public long? TotalTime4 { get; set; }
        public TimeSpan? TotalTimeFirst01 { get; set; }
        public TimeSpan? TotalTimeFirst02 { get; set; }
        public TimeSpan TotalTime3aa { get; set; }

        public string? TotalTime1str01 { get; set; }
        public TimeSpan? TotalTime1str02 { get; set; }
        public string? stringhhmmHours { get; set; }
        public string? DiferentETDETE { get; set; }


        /// <summary>
        /// NUMBER OF AIRCRAFT
        /// 79
        /// </summary>
        public int? NUMBEROFAIRCRAFT { get; set; }
        public string? NUMBEROFAIRCRAFTstr { get; set; }


        /// <summary>
        /// DEPARTURE AERODROME
        ///  فرودگاه مبدأ
        ///  80
        /// </summary>
        public int? DEPARTUREAERODROME { get; set; }
        public string? DEPARTUREAERODROMEstr { get; set; }
        public string? DEPARTUREAERODROMEstr1 { get; set; }

        /// <summary>
        ///Time UTC
        ///زمانی که به فرودگاه برای پرواز اعلام می شود و تا یک ساعت اعتبار دارد
        /// </summary>
        public string? TimeUTCZone { get; set; }
        public string? TimeUTCstr { get; set; }

        public DateTime? TimeUTCZoneDateTime { get; set; }

        public string? TimeUTC { get; set; }
        public DateTime? TimeUTCDateTime { get; set; }
        public TimeSpan? TimeUTCTimeSpan { get; set; }



        /// <summary>
        /// LEVEL
        /// </summary>
        public string? LEVEL { get; set; }
        //public string? LEVELstr { get; set; }


        /// <summary>
        ///ROUTE line1
        /// </summary>
        public string? ROUTEline1 { get; set; }

        /// <summary>
        ///ROUTE line2
        /// </summary>
        public string? ROUTEline2 { get; set; }
        /// <summary>
        ///ROUTE line3
        /// </summary>
        public string? ROUTEline3 { get; set; }
        /// <summary>
        ///ROUTE line4
        /// </summary>
        public string? ROUTEline4 { get; set; }


        /// <summary>
        /// DESTINATION AERODROME
        /// فرودگاه مقصد
        /// 80
        /// </summary>
        public int? DESTINATIONAERODROME { get; set; }
        public string? DESTINATIONAERODROMEstr { get; set; }
        public string? DESTINATIONAERODROMEstr1 { get; set; }


        /// <summary>
        /// TOTAL EET HR MIN
        /// مدت زمان تقریبی مسیر
        /// </summary>
        public string? TOTALEETHRMIN { get; set; }
        public DateTime? TOTALEETHRMINDateTime { get; set; }
        public TimeSpan? TOTALEETHRMINTimeSpan { get; set; }

        /// <summary>
        /// ALTNAERODRME
        /// فرودگاه رزرو اول
        /// 80
        /// </summary>
        public int? ALTNAERODRME { get; set; }
        public string? ALTNAERODRMEstr { get; set; }
        public string? ALTNAERODRMEstr1 { get; set; }


        /// <summary>
        /// ALTNAERODRME2
        /// فرودگاه رزرو دوم
        /// 80
        /// </summary>
        public int? ALTNAERODRME2 { get; set; }
        public string? ALTNAERODRME2str { get; set; }
        public string? ALTNAERODRME2str1 { get; set; }



        /// <summary>
        ///OTHER INFORMATION line1
        /// </summary>
        public string? OTHERINFORMATIONline1 { get; set; }

        /// <summary>
        ///OTHER INFORMATION line2
        /// </summary>
        public string? OTHERINFORMATIONline2 { get; set; }
        /// <summary>
        ///OTHER INFORMATION line3
        /// </summary>
        public string? OTHERINFORMATIONline3 { get; set; }
        /// <summary>
        ///OTHER INFORMATION line4
        /// </summary>
        public string? OTHERINFORMATIONline4 { get; set; }

        /// <summary>
        /// PERSONS ON BOARD
        /// تعداد سرنشینان
        /// 81
        /// </summary>
        public int? PERSONSONBOARD { get; set; }
        public string? PERSONSONBOARDstr { get; set; }


        /// <summary>
        /// REMARKS
        /// 82
        /// </summary>
        public int? REMARKS { get; set; }
        public string? REMARKSstr { get; set; }



        /// <summary>
        ///  مدل بالگرد 
        /// </summary>
        public int? TypeHelicopter { get; set; }
        public string? TypeHelicopterstr { get; set; }
        public string? TypeHelicopterstr1 { get; set; }


        /// <summary>
        /// FLIGHT ROLES
        /// 71
        /// </summary>
        public int? FLIGHTROLES { get; set; }
        public string? FLIGHTROLESstr { get; set; }
        public string? FLIGHTROLESstr1 { get; set; }
        /// <summary>
        /// TYPE OF FLIGHT
        /// 72
        /// </summary>
        public int? TYPEOFFLIGHT { get; set; }
        public string? TYPEOFFLIGHTstr { get; set; }
        public string? TYPEOFFLIGHTstr1 { get; set; }



        /// <summary>
        /// WAKE TURBULENCE CAL
        /// 73
        /// </summary>
        public int? WAKETURBULENCECAL { get; set; }
        public string? WAKETURBULENCECALstr { get; set; }
        public string? WAKETURBULENCECALstr1 { get; set; }

        /// <summary>
        /// EQUIPMENT AND CAPABILITIES
        /// 74
        /// </summary>
        public int? EQUIPMENTANDCAPABILITIES { get; set; }
        public string? EQUIPMENTANDCAPABILITIESstr { get; set; }


        /// <summary>
        /// CRUISING SPEED
        /// 75
        /// </summary>
        public int? CRUISINGSPEED { get; set; }
        public string? CRUISINGSPEEDstr { get; set; }



        ///// <summary>
        ///// LEVEL
        ///// </summary>
        //public int? LEVEL { get; set; }
        //[ForeignKey("LEVEL")]
        //public virtual CategoryGeneral oo_LEVEL { get; set; }





        /// <summary>
        /// ENDURANCE HR MIN
        /// 76
        /// </summary>
        public int? ENDURANCEHRMIN { get; set; }
        public string? ENDURANCEHRMINstr { get; set; }



        /// <summary>
        /// AIRCRAFT COLOUR AND MARKINGS
        /// 77
        /// </summary>
        public int? AIRCRAFTCOLOURANDMARKINGS { get; set; }
        public string? AIRCRAFTCOLOURANDMARKINGSstr { get; set; }


        /// <summary>
        /// EMERGENCY RADIO
        /// 78
        /// </summary>
        public int? EMERGENCYRADIO { get; set; }
        public string? EMERGENCYRADIOstr { get; set; }



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


        public string? PICstrPhone { get; set; }
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
        public string? TotalFLTTIME { get; set; }
        public string? PhisicalEXPDate { get; set; }

        public string? StandEXP { get; set; }
        public string? LastfltDate { get; set; }




        public string SubId { get; set; }


        public string? CrewFlightPesronelstr { get; set; }
        public string? CrewFlightPesronel { get; set; }
        public string? Dutystr { get; set; }
        public int? Duty { get; set; }

        public bool? IsPIC { get; set; }

        public string? IsPICstr { get; set; }

        public TimeSpan TotalTime { get; set; }

        public TimeSpan? ETDTimeSpan { get; set; }
        public TimeSpan? ETETimeSpan { get; set; }


        public DateTime? ETDDateTime { get; set; }
        public DateTime? ETEDateTime { get; set; }

        public TimeSpan? DiferentETDETETimeSpan { get; set; }

        public string? ADFstr { get; set; }
        public string? ALTstr { get; set; }
        public string? ATISstr { get; set; }
        public string? CALLSIGNstr { get; set; }
        public string? STATIONstr { get; set; }

        //public string? ETDstr { get; set; }
        //public string? ETEstr { get; set; }
        public string? FLTAREAstr { get; set; }
        public string? FLTAREAstrFA { get; set; }
        public string? FMGstr { get; set; }
        public string? PURPOSEOFFLTstr { get; set; }
        public string? PURPOSEOFFLTstrFA { get; set; }
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
        public string? SerialNOPlanHelicopterTail { get; set; }

        public int? UHF { get; set; }
        public int? UHFG { get; set; }
        public int? VHF { get; set; }
        public int? VHFG { get; set; }
        public int? VOR { get; set; }
        public int? STATION { get; set; }
        public string? FlightPlanEvidence01ID { get; set; }
        public string? FlightActivityEvidence01ID { get; set; }

        public string? HelicopterTailEvidence01 { get; set; }
        public string? HelicopterType { get; set; }
        public string? HelicopterTail { get; set; }
        public int? HelicopterTypeID { get; set; }
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



        //هواشناسی

        ///// <summary>
        ///// VIS
        ///// </summary>
        //public string? VIS { get; set; }

        //هواشناسی

        /// <summary>
        /// WIND
        /// </summary>
        public string? WIND { get; set; }


        /// <summary>
        /// VIIBILITY
        /// </summary>
        public string? VIIBILITY { get; set; }


        /// <summary>
        /// P.W
        /// </summary>
        public string? PW { get; set; }


        /// <summary>
        /// TEMP
        /// </summary>
        public string? TEMP { get; set; }


        /// <summary>
        /// D.P
        /// </summary>
        public string? DP { get; set; }


        /// <summary>
        /// CLOUDS
        /// </summary>
        public string? CLOUDS { get; set; }


        /// <summary>
        /// ALT.SET
        /// </summary>
        public string? ALTSET { get; set; }


        /// <summary>
        /// D.A
        /// </summary>
        public string? DA { get; set; }


        /// <summary>
        /// SUN.RISE
        /// </summary>
        public string? SUNRISE { get; set; }


        /// <summary>
        /// SUN.SET
        /// </summary>
        public string? SUNSET { get; set; }

        //هواشناسی

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
        public string CrewFlightPlanEvidence01ID { get; set; }
        public string CrewFlightPlanEvidence01IDstr { get; set; }

        public string CrewFlightPlanEvidence01IDstr3 { get; set; }
        public string CrewFlightPlanEvidence01IDstr4 { get; set; }
        public string CrewFlightPlanEvidence01IDstr5 { get; set; }
        public string CrewFlightPlanEvidence01IDstr6 { get; set; }
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
        //public string? FromDateCrewFlightPlanEvidence01TitleRamainDay01 { get; set; }
        ///// <summary>
        /////  روز باقیمانده تا تاریخ خاتمه
        ///// </summary>
        //public string? ToDateCrewFlightPlanEvidence01TitleRamainDay01 { get; set; }

        /// <summary>
        /// تاریخ شروع
        /// </summary>
        public string? FromDateCrewFlightPlanEvidence01Title { get; set; }
        ///// <summary>
        /////  تاریخ خاتمه
        ///// </summary>
        public string? ToDateCrewFlightPlanEvidence01Title { get; set; }


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


        [Display(Name = "ترتیب")]
        public int? Sortable01PURPOSEId { get; set; }
        public string SortableTitle01PURPOSE { get; set; }


        /// <summary>
        ///  وضعیت هوا
        /// </summary>
        public int? StatusCrewFlightPlanEvidence01 { get; set; }
        public string? StatusCrewFlightPlanEvidence01str { get; set; }



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

        public string UjobPesronel01strPhone { get; set; }


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
