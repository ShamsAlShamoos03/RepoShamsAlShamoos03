using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public class HistoryRokn04jamDetailDastoor01
    {
        /// <summary>
        ///  تاریخ شمسی
        /// </summary>
        [Key]
        //[StringLength(10, MinimumLength = 10, ErrorMessage = "HistoryRokn04jamDetailDastoor01ID must be 8 characters")]
        public string? HistoryRokn04jamDetailDastoor01ID { get; set; }

        public string? HistoryRokn04jamDastoor01ID { get; set; }
        [ForeignKey("HistoryRokn04jamDastoor01ID")]
        public virtual HistoryRokn04jamDastoor01 oo_HistoryRokn04jamDastoor { get; set; }



        /// <summary>
        /// نام پابگاه 
        /// </summary>
        public int? StateName01 { get; set; }
        [ForeignKey("StateName01")]
        public virtual CategoryGeneral oo_StateName01 { get; set; }
        //318
        //StateName01 = item.StateName01,
        //                            StateName01str = item.oo_StateName01.Title,


        //public string? PersonalCorrespondence01ID { get; set; }
        //[ForeignKey("PersonalCorrespondence01ID")]
        //public virtual PersonalCorrespondence01 oo_PersonalCorrespondence01ID { get; set; }




        //public string? HistoryTraficPersonal01ID { get; set; }
        //[ForeignKey("HistoryTraficPersonal01ID")]
        //public virtual HistoryTraficPersonal01 oo_HistoryTraficPersonal01ID { get; set; }






        ///// <summary>
        /////ای دی فعالیت پروازی 
        ///// </summary>
        //public string? DailyActivityEvidence01ID { get; set; }
        //[ForeignKey("DailyActivityEvidence01ID")]
        //public virtual DailyActivityEvidence01 oo_DailyActivityEvidence01ID { get; set; }








        /// <summary>
        //تاریخ
        /// </summary>
        public string? VarDate01 { get; set; }
        [ForeignKey("VarDate01")]
        public virtual DateProperty01 oo_VarDate01 { get; set; }


        /// <summary>
        //تاریخ
        /// </summary>
        public string? VarDate02 { get; set; }
        [ForeignKey("VarDate02")]
        public virtual DateProperty01 oo_VarDate02 { get; set; }


        /// <summary>
        //تاریخ
        /// </summary>
        public string? VarDate03 { get; set; }
        [ForeignKey("VarDate03")]
        public virtual DateProperty01 oo_VarDate03 { get; set; }


        /// <summary>
        //تاریخ
        /// </summary>
        public string? VarDate04 { get; set; }
        [ForeignKey("VarDate04")]
        public virtual DateProperty01 oo_VarDate04 { get; set; }


        /// <summary>
        //تاریخ
        /// </summary>
        public string? VarDate05 { get; set; }
        [ForeignKey("VarDate05")]
        public virtual DateProperty01 oo_VarDate05 { get; set; }


        /// <summary>
        //تاریخ
        /// </summary>
        public string? VarDate06 { get; set; }
        [ForeignKey("VarDate06")]
        public virtual DateProperty01 oo_VarDate06 { get; set; }





        /// <summary>
        /// یگان
        /// </summary>
        public int? UnitID01 { get; set; }
        [ForeignKey("UnitID01")]
        public virtual CategoryGeneral? oo_UnitID01 { get; set; }





        /// <summary>
        //شماره نامه
        /// </summary>
        public string? DocumentNO01 { get; set; }

        /// <summary>
        //متن نامه
        /// </summary>
        public string? strTextContent01 { get; set; }

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


        public string? DateRegDastoor { get; set; }


        public string? Vartext07 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext08 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext09 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext10 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext11 { get; set; }
        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext12 { get; set; }

        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext13 { get; set; }


        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext14 { get; set; }


        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext15 { get; set; }


        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext16 { get; set; }


        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext17 { get; set; }


        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext18 { get; set; }


        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext19 { get; set; }


        /// <summary>
        //متن نامه
        /// </summary>
        public string? Vartext20 { get; set; }

        /// <summary>
        ///  درجه نام و نشان ش کا کد ملی
        /// </summary>
        public string? MelliCode { get; set; }
        [ForeignKey("MelliCode")]
        public virtual TblMaster oo_CrewDailyPesronel { get; set; }





        /// <summary>
        ///نوع نامه  
        /// </summary>
        public int? TypeLetter01 { get; set; }
        [ForeignKey("TypeLetter01")]
        public virtual CategoryGeneral oo_TypeLetter01 { get; set; }


        public DateTime? TimeAddOREditYagen01 { get; set; }





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








}
