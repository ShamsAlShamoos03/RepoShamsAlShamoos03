using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class CategoryReport
    {
        [Key]
        public int CategoryReportId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Section_01 { get; set; }
        public string Section_02 { get; set; }
        public string Seed_01 { get; set; }
        public string Seed_02 { get; set; }


        public int CategoryReportSubId { get; set; }
        [ForeignKey("CategoryReportSubId")]

        public virtual CategoryReportSub CategoryReportSub { get; set; }





        //public virtual ICollection<NewsCategory01> NewsCategory01 { get; set; }
        //public IList<NewsCategory> NewsCategorys { get; set; }
        //public IList<UsersCategory> UsersCategorys { get; set; }


    }

 