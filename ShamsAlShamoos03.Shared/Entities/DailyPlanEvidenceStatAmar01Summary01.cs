using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class DailyPlanEvidenceStatAmar01Summary01
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
    [ForeignKey("DailyPlanEvidence01ID")]
    public virtual DailyPlanEvidence01 oo_DailyPlanEvidence01ID { get; set; }

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
    public string? StartDate { get; set; }

    /// <summary>
    /// تاریخ خاتمه
    /// </summary>
    public string? EndDate { get; set; }

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


    /// <summary>
    /// تعداد روز تشویقی
    /// </summary>
    public string? RewardDaysCount { get; set; }

    /// <summary>
    /// تعداد روز مرخصی مانده
    /// </summary>
    public string? RemainDaysVacationCount { get; set; }

    /// <summary>
    /// تعداد روز مرخصی سهمیه
    /// </summary>
    public string? TotalVacationDaysCount { get; set; }


    public int? Sortable01Id { get; set; }
    [ForeignKey("Sortable01Id")]
    public virtual Sortable01 Sortable01 { get; set; }

}
