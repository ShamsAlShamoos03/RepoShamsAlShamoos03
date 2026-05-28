

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;


     public class BorhanEntesabat02
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
