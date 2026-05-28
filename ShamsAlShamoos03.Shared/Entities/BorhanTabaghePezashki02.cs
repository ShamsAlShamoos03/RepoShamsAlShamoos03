

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;


     public class BorhanTabaghePezashki02
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
