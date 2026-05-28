 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
     public  class TblLuLookup
    {
        [Key]
        public string ID { get; set; }
        public string Type { get; set; }
        public string? Title { get; set; }
        public string? TitleEn1 { get; set; }
        public int? AlphabeticSort { get; set; }
        public string? Cod_h { get; set; }
        public int? TblLuLookupSubbId { get; set; }
        [ForeignKey("TblLuLookupSubbId")]
        public virtual TblLuLookupSub TblLuLookupSub { get; set; }
        public int? Sortable01Id { get; set; }
        [ForeignKey("Sortable01Id")]
        public virtual Sortable01 Sortable01 { get; set; }
    }
 