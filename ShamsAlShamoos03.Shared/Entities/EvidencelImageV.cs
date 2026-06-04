using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class EvidencelImageV

//.OnDelete(DeleteBehavior.Cascade);
//Restrict
//            مشکل شما Multiple cascade paths هست. به این معنی که یک اگر یک ردیف از جدول Provience حذف بشه همه ی ردیف های مرتبط با اون در جدول Candidator حذف میشه.

//شما می تونید با استفاده از کد زیر این مشکل رو حل کنید:
//            builder.Entity<Candidator>().HasOne(p => p.provienceID).WithMany(b => b.ProvienceID)
//        .OnDelete(DeleteBehavior.Restrict);


//      builder.Entity<NewsCategory>().HasOne(p => p.provienceID).WithMany(b => b.ProvienceID)
{
    [Key]
    public int EvidencelImageVID { get; set; }


    //public DateTime DateDay { get; set; }

    //public string DateDaySham { get; set; }

    //public string DateDayWeek { get; set; }



    public int VazifeID { get; set; }
    [ForeignKey("VazifeID")]
    public virtual PersonnelVazife01? tblVazifeID { get; set; }

    public string EvidencelImageV01 { get; set; }
    public string NameEvidence01 { get; set; }


    //public virtual CategoryGeneral? tblCategoryGeneralRank { get; set; }
    //public virtual CategoryGeneral? tblCategoryGeneralCult { get; set; }
    //public virtual CategoryGeneral? tblCategoryGeneralReligion { get; set; }
    //public virtual CategoryGeneral? tblCategoryGeneralFieldedu { get; set; }
    //public virtual CategoryGeneral? tblCategoryGeneralEducation { get; set; }
    //public virtual CategoryGeneral? tblCategoryGeneralBlood { get; set; }
    //public virtual CategoryGeneral? tblCategoryGeneralStatus { get; set; }
    //public virtual CategoryGeneral? tblCategoryGeneralMariage { get; set; }
    //public virtual CategoryGeneral? tblCategoryGeneralHealth { get; set; }
    //public virtual CategoryGeneral? tblCategoryGeneralUit { get; set; }

    //public virtual CategoryGeneral? tblCategoryGeneralRasteh { get; set; }

    //public virtual CategoryGeneral? tblCategoryGeneralCity { get; set; }


    //public int IRcalID { get; set; }
    //[ForeignKey("IRcalID")]
    //public virtual CategoryGeneral? tblIRcal { get; set; }


    //public int StatecalID { get; set; }
    //[ForeignKey("StatecalID")]
    //public virtual CategoryGeneral? tblStatecal { get; set; }



    //public int Sortable01Id { get; set; }
    //[ForeignKey("Sortable01Id")]

    //public virtual Sortable01 Sortable01 { get; set; }


    //public int Prop01ID { get; set; }
    //[ForeignKey("Prop01ID")]
    //public virtual CategoryGeneral? tblCategoryGeneralProp01 { get; set; }

    //public int Prop02ID { get; set; }
    //[ForeignKey("Prop02ID")]
    //public virtual CategoryGeneral? tblCategoryGeneralProp02 { get; set; }

    //public int Prop03ID { get; set; }
    //[ForeignKey("Prop03ID")]
    //public virtual CategoryGeneral? tblCategoryGeneralProp03 { get; set; }

    //public byte IsActive { get; set; }


    //public string Fname { get; set; }

    //public string Lname { get; set; }
    //public string Fathername { get; set; }
    //public string PersonelCode { get; set; }

    //public DateTime DispatchDate { get; set; }

    //public string DispatchDateSham { get; set; }
    //public DateTime BirthdayDate { get; set; }
    //public string BirthdayDateSham { get; set; }
    //public string NationalCode { get; set; }

    //public int UitID { get; set; }
    //[ForeignKey("UitID")]
    //public virtual CategoryGeneral? tblCategoryGeneralUit { get; set; }



    //public int HealthID { get; set; }
    //[ForeignKey("HealthID")]
    //public virtual CategoryGeneral? tblCategoryGeneralHealth { get; set; }

    //public int MariageID { get; set; }
    //[ForeignKey("MariageID")]
    //public virtual CategoryGeneral? tblCategoryGeneralMariage { get; set; }


    //public int NoChild { get; set; }


    //public int StatusID { get; set; }
    //[ForeignKey("StatusID")]
    //public virtual CategoryGeneral? tblCategoryGeneralStatus { get; set; }

    //public int BloodtypeID { get; set; }
    //[ForeignKey("BloodtypeID")]
    //public virtual CategoryGeneral? tblCategoryGeneralBlood { get; set; }

    //public int DegreeeducationID { get; set; }
    //[ForeignKey("DegreeeducationID")]
    //public virtual CategoryGeneral? tblCategoryGeneralEducation { get; set; }

    //public int FieldeducationID { get; set; }
    //[ForeignKey("FieldeducationID")]
    //public virtual CategoryGeneral? tblCategoryGeneralFieldedu { get; set; }

    //public int ReligionID { get; set; }
    //[ForeignKey("ReligionID")]
    //public virtual CategoryGeneral? tblCategoryGeneralReligion { get; set; }

    //public int CultID { get; set; }
    //[ForeignKey("CultID")]
    //public virtual CategoryGeneral? tblCategoryGeneralCult { get; set; }

    //public int CityID { get; set; }
    //[ForeignKey("CityID")]
    //public virtual CategoryGeneral? tblCategoryGeneralCity { get; set; }

    //public string Adress { get; set; }
    //public string Mobile { get; set; }
    //public string Phone { get; set; }



    //public string PersonelImage { get; set; }
    //public string EvidencelImageV01 { get; set; }
    //public string EvidencelImageV02 { get; set; }
    //public string EvidencelImageV03 { get; set; }
    //public string EvidencelImageV04 { get; set; }

    //public string Title01 { get; set; }
    //public string Title02 { get; set; }
    //public string Title03 { get; set; }
    //public string Title04 { get; set; }
    //public string Title05 { get; set; }
    //public string Title06 { get; set; }
    //public string Title07 { get; set; }
    //public string Title08 { get; set; }


    //public string Title { get; set; }
    //public string Content { get; set; }
    //public string Abstract { get; set; }
    //public int VisitCount { get; set; }
    //public DateTime NewsDate { get; set; }
    //public string NewsDateSham { get; set; }
    //public DateTime NewsTime { get; set; }

    //public string? IndexImage { get; set; }
    //public string IndexImage02 { get; set; }
    //public byte PlaceNewsID { get; set; }
    //public byte NewsType { get; set; }

    //public string MetaTag { get; set; }
    //public string MetaDescription { get; set; }

    //public string UserID { get; set; }
    //[ForeignKey("UserID")]
    //public virtual ApplicationUsers Users { get; set; }

    //public int CategoryID { get; set; }
    //[ForeignKey("CategoryID")]
    //public virtual Category tblCategory { get; set; }



    //public IList<NewsCategory> NewsCategorys { get; set; }


    //public IList<NewsImagesList> NewsImagesLists { get; set; }

}
