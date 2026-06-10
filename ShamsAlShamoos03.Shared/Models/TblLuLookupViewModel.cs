using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShamsAlShamoos03.Shared.Models
{
    public class TblLuLookupView
    {
        public int CategoryGeneralId { get; set; }

        public string ID { get; set; }
        //[Key]

        public string Type { get; set; }
        public string? Title { get; set; }
        public string? TitleEn1 { get; set; }
        public int? AlphabeticSort { get; set; }
        public string? Cod_h { get; set; }

        public int? TblLuLookupSubbId { get; set; }





        //public int CategrySubId { get; set; }
        //[ForeignKey("CategrySubId")]

        //public virtual CategorySub CategorySub { get; set; }

        //public class TblLuLookupSub
        //{
        //    [Key]
        //    public int TblLuLookupSubbId { get; set; }


        //public string BlgCod { get; set; }
        //[ForeignKey("BlgCod")]
        //public virtual TblLuLookup? yBlgCod { get; set; }
        //public string BlgCod { get; set; }
        //[ForeignKey("BlgCod")]
        //public virtual TblLuLookup? yBlgCod { get; set; }

    }


}
