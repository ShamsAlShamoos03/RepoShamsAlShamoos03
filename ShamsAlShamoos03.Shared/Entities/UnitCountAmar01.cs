using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    public class UnitCountAmar01
    {
        /// <summary>
        ///  ای دی
        /// </summary>
        [Key]
        //[StringLength(10, MinimumLength = 10, ErrorMessage = "UnitCountAmar01ID must be 8 characters")]
        public string? UnitCountAmar01ID  { get; set; }

        /// <summary>
        ///ای دی فعالیت پروازی 
        /// </summary>
        public string? DailyActivityEvidence01ID { get; set; }
        [ForeignKey("DailyActivityEvidence01ID")]
        public virtual DailyActivityEvidence01 oo_DailyActivityEvidence01ID { get; set; }


        /// <summary>
        /// یگان
        /// </summary>
        public int? UitID01 { get; set; }
        [ForeignKey("UitID01")]
        public virtual CategoryGeneral? oo_tblCategoryGeneralUit { get; set; }


        public int? DrjDailyPLookupSubId { get; set; }
        [ForeignKey("DrjDailyPLookupSubId")]
        public virtual TblLuLookupSub TblLuLookupSub { get; set; }


        public int? Sortable01Id { get; set; }
        [ForeignKey("Sortable01Id")]
        public virtual Sortable01 Sortable01 { get; set; }




        /// <summary>
        ///امتیاز زمانی
        /// </summary>

        public string? RatioTimeDiff { get; set; }

        /// <summary>
        ///نمره 
        /// </summary>

        public string? FinalScoreNormalized_100 { get; set; }
        /// <summary>
        ///رتبه در روز
        /// </summary>

        public string? RankInDay { get; set; }
        /// <summary>
        ///رتبه در ماه
        /// </summary>

        public string? RankInMonth { get; set; }
        /// <summary>
        ///رتبه در سال
        /// </summary>

        public string? RankInYear { get; set; }

        /// <summary>
        ///رتبه در فصل
        /// </summary>

        public string? RankInFasl { get; set; }

        /// <summary>
        ///سازمانی
        /// </summary>

        public string? CountSazmani { get; set; }

        /// <summary>
        ///موجودی
        /// </summary>

        public string? CountMojodi { get; set; }

 
        public string? CountMojodiY5 { get; set; }
        public string? CountMojodiY10 { get; set; }
        public string? CountMojodiY15 { get; set; }
        public string? CountMojodiY20 { get; set; }
        public string? CountMojodiY25 { get; set; }
        public string? CountMojodiY30 { get; set; }
        public string? CountMojodiY35 { get; set; }
        public string? CountMojodiY40 { get; set; }

        public string? averold { get; set; }
        public string? sumold { get; set; }

        //public string? CountMojodiPayvar { get; set; }
        //public string? CountMojodiVazifeh { get; set; }

        /// <summary>
        ///مأمور به عده
        /// </summary>

        public string? CountMamorBe { get; set; }

        /// <summary>
        ///مأمور از عده
        /// </summary>

        public string? CountMamorAz { get; set; }

        /// <summary>
        ///عده کل
        /// </summary>

        public string? CountEdeKol { get; set; }

        /// <summary>
        ///مرخصی
        /// </summary>

        public string? CountMorakhasi { get; set; }

        /// <summary>
        ///مأمور دور
        /// </summary>

        public string? CountMamorDoor { get; set; }

        /// <summary>
        ///مأمور نزدیک
        /// </summary>

        public string? CountMamorNazdik { get; set; }



        /// <summary>
        ///نگهبان
        /// </summary>

        public string? CountNegahban { get; set; }

        /// <summary>
        ///استراحت کاری
        /// </summary>

        public string? CountEstarahatKari { get; set; }

        /// <summary>
        ///استراحت پزشکی
        /// </summary>

        public string? CountEstarahatPezashki { get; set; }

        /// <summary>
        ///استراحت نگهبانی
        /// </summary>

        public string? CountEstarahatNegahban { get; set; }

        /// <summary>
        ///نهست
        /// </summary>

        public string? CountNahast { get; set; }

        /// <summary>
        ///فرار
        /// </summary>

        public string? CountFarar { get; set; }

        /// <summary>
        ///اعزام بیمارستان
        /// </summary>

        public string? CountEzamBimarestan { get; set; }

        /// <summary>
        ///انتظار خدمت
        /// </summary>

        public string? CountEntezarKhedmat { get; set; }

        /// <summary>
        ///بدون کاری
        /// </summary>

        public string? CountBedonkari { get; set; }

        /// <summary>
        ///زندان
        /// </summary>

        public string? CountZendan { get; set; }

        /// <summary>
        ///جمع کل
        /// </summary>

        public string? CountSumMotafareghe { get; set; }

        /// <summary>
        ///جمع کل
        /// </summary>

        public string? CountSumHazer { get; set; }


        /// <summary>
        ///جمع کل
        /// </summary>

        //public string? CountSum { get; set; }







        ///// <summary>
        /////سازمانی
        ///// </summary>

        //public string? CountSazmaniAll { get; set; }

        ///// <summary>
        /////موجودی
        ///// </summary>

        //public string? CountMojodiAll { get; set; }

        ///// <summary>
        /////مأمور به عده
        ///// </summary>

        //public string? CountMamorBeAll { get; set; }

        ///// <summary>
        /////مأمور از عده
        ///// </summary>

        //public string? CountMamorAzAll { get; set; }

        ///// <summary>
        /////عده کل
        ///// </summary>

        //public string? CountEdeKolAll { get; set; }

        ///// <summary>
        /////مرخصی
        ///// </summary>

        //public string? CountMorakhasiAll { get; set; }

        ///// <summary>
        /////مأمور دور
        ///// </summary>

        //public string? CountMamorDoorAll { get; set; }

        ///// <summary>
        /////مأمور نزدیک
        ///// </summary>

        //public string? CountMamorNazdikAll { get; set; }



        ///// <summary>
        /////نگهبان
        ///// </summary>

        //public string? CountNegahbanAll { get; set; }

        ///// <summary>
        /////استراحت کاری
        ///// </summary>

        //public string? CountEstarahatKariAll { get; set; }

        ///// <summary>
        /////استراحت پزشکی
        ///// </summary>

        //public string? CountEstarahatPezashkiAll { get; set; }

        ///// <summary>
        /////استراحت نگهبانی
        ///// </summary>

        //public string? CountEstarahatNegahbanAll { get; set; }

        ///// <summary>
        /////نهست
        ///// </summary>

        //public string? CountNahastAll { get; set; }

        ///// <summary>
        /////فرار
        ///// </summary>

        //public string? CountFararAll { get; set; }

        ///// <summary>
        /////اعزام بیمارستان
        ///// </summary>

        //public string? CountEzamBimarestanAll { get; set; }

        ///// <summary>
        /////انتظار خدمت
        ///// </summary>

        //public string? CountEntezarKhedmatAll { get; set; }

        ///// <summary>
        /////بدون کاری
        ///// </summary>

        //public string? CountBedonkariAll { get; set; }

        ///// <summary>
        /////زندان
        ///// </summary>

        //public string? CountZendanAll { get; set; }

        ///// <summary>
        /////جمع کل
        ///// </summary>

        //public string? CountSumMotafaregheAll { get; set; }

        ///// <summary>
        /////جمع کل
        ///// </summary>

        //public string? CountSumHazerAll { get; set; }


        ///// <summary>
        /////جمع کل
        ///// </summary>

        //public string? CountSumAll { get; set; }















}
