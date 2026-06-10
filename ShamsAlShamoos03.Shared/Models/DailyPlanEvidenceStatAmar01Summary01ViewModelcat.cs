using GemBox.Document;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShamsAlShamoos03.Shared.Models
{
    public class DailyPlanEvidenceStatAmar01Summary01ViewModelcat
    {
        /// <summary>
        ///  ای دی
        /// </summary>
        [Key]
        public string? DailyPlanEvidenceStatAmar01Summary01ID { get; set; }

        /// <summary>
        ///ای دی فعالیت پروازی 
        /// </summary>
        public string? DailyPlanEvidence01ID { get; set; }
 
        /// <summary>
        /// کد ملی
        /// </summary>
        public string? MelliCode { get; set; }
        /// <summary>
        /// وضعیت آماز
        /// </summary>
        public string? StatAmar01 { get; set; }

        /// <summary>
        /// تاریخ شروع
        /// </summary>
        public string? StartDate01 { get; set; }

        /// <summary>
        /// تاریخ خاتمه
        /// </summary>
        public string? EndDate01 { get; set; }

        /// <summary>
        /// تعداد روز
        /// </summary>
        public string? DurationDays { get; set; }

        /// <summary>
        /// تعداد روز تعطیلی
        /// </summary>
        public string? HolidayDaysCount { get; set; }

        /// <summary>
        /// تعداد روز تعطیلی
        /// </summary>
        public string? MaxContinuityHolidayDays { get; set; }
        public int? Sortable01Id { get; set; }



        public string? PersianYear { get; set; }
        public string? strStatAmar01 { get; set; }
        public string? CombinedTotal { get; set; }
        public string? TotalSumStatAmar01VNoHolidayPerMelliCode { get; set; }
        public string?  TotalSumStatAmar01333VNoHolidayPerMelliCodeAndStatAmar  { get; set; }
        public string? SumStatAmar01VNoHoliday { get; set; }


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

         public string? DUS_COD { get; set; }
        public string? DUS_NAM { get; set; }

        public int? UitID01 { get; set; }
        public string? strUitID01 { get; set; }
        public int? SortstrUitID01 { get; set; }


        public string? SortStatAmar01 { get; set; }
        public string? RewardDaysCount { get; set; }
        public string? DayUseVactionWithReward { get; set; }


        /// <summary>
        /// تعداد روز مرخصی مانده
        /// </summary>
        public string? RemainDaysVacationCount { get; set; }

        /// <summary>
        /// تعداد روز مرخصی سهمیه
        /// </summary>
        public string? TotalVacationDaysCount { get; set; }










    }
}
