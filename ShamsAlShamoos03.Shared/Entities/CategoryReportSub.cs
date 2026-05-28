using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class CategoryReportSub
    {
        [Key]
        public int CategoryReportSubId { get; set; }
        public string TitleS { get; set; }
        public string DescriptionS { get; set; }
        public string Section_S01 { get; set; }
        public string Section_S02 { get; set; }
        public string Seed_S01 { get; set; }
        public string Seed_S02 { get; set; }

        //public IList<UsersCategorySub> UsersCategorySubs { get; set; }

        //public int CategoryID { get; set; }
        //[ForeignKey("CategoryID")]

        //public virtual Category Category { get; set; }

        //public virtual ICollection<NewsCategory01> NewsCategory01 { get; set; }
        //public IList<NewsCategory> NewsCategorys { get; set; }
}
