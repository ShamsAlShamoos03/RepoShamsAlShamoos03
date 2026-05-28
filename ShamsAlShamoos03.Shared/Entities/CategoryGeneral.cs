using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CategoryGeneral
    {
        [Key]
        public int CategoryGeneralId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public string Section_01 { get; set; }
        //public string Section_02 { get; set; }
        //public string Seed_01 { get; set; }
        //public string Seed_02 { get; set; }


        public int CategoryGeneralSubId { get; set; }
        [ForeignKey("CategoryGeneralSubId")]

        public virtual CategoryGeneralSub CategoryGeneralSub { get; set; }


        public int? ooCategoryGeneralSubId { get; set; }
        [ForeignKey("ooCategoryGeneralSubId")]

        public virtual CategoryGeneralSub ooCategoryGeneralSub { get; set; }


        public int Sortable01Id { get; set; }
        [ForeignKey("Sortable01Id")]

        public virtual Sortable01 Sortable01 { get; set; }

        public byte IsActive { get; set; }



        //public virtual ICollection<NewsCategory01> NewsCategory01 { get; set; }
        //public IList<NewsCategory> NewsCategorys { get; set; }
        //public IList<UsersCategory> UsersCategorys { get; set; }


    }

 