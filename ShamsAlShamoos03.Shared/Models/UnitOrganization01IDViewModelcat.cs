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
    public class UnitOrganization01ViewModelcat
    {
        /// <summary>
        ///  تاریخ شمسی
        /// </summary>
        public string UnitOrganization01ID { get; set; }
        public string DrjDailyPLookupSubId { get; set; }
        public string TitleDaraje { get; set; }

        /// <summary>
        ///یگان
        /// </summary>
        public int? YearsOFWorks { get; set; }

        public int? YearsOFOld { get; set; }

        public int? UitID01 { get; set; }
        public string? strUitID01 { get; set; }
        public int? SortstrUitID01 { get; set; }

        /// <summary>
        ///قشر
        /// </summary>

        public int? TblLuLookupSubbId { get; set; }
        public string? TitleTblLuLookupSubbId { get; set; }
        public string? DescriptionstrTblLuLookupSubbId { get; set; }
        public int? SortTblLuLookupSubbId { get; set; }

        /// <summary>
        ///
        /// </summary>

        public int? Sortable01Id { get; set; }
        //public string? strSortable01Id { get; set; }


        /// <summary>
        ///سازمانی
        /// </summary>
  

        public double? sumoldMojodi { get; set; }
        public double? sumoldMojodiAll { get; set; }
        public double? sumoldMojodiPayvarAll { get; set; }
        public double? sumoldMojodiVazifehAll { get; set; }

        public decimal? averoldMojodi { get; set; }
        public decimal? averoldMojodiAll { get; set; }
        public decimal? averoldMojodiPayvarAll { get; set; }
        public decimal? averoldMojodiVazifehAll { get; set; }


         
        //public   var? filteredItems { get; set; }



        /// <summary>
        ///سازمانی
        /// </summary>

        public string? CountSazmani { get; set; }

        /// <summary>
        ///موجودی
        /// </summary>

        public string? CountMojodi { get; set; }

        public string? CountMojodiY5 { get; set; }
        public string? CountMojodiY10 { get; set; }
        public string? CountMojodiY15 { get; set; }
        public string? CountMojodiY20 { get; set; }
        public string? CountMojodiY25 { get; set; }
        public string? CountMojodiY30 { get; set; }
        public string? CountMojodiY35 { get; set; }
        public string? CountMojodiY40 { get; set; }

        public string? CountMojodiAllY5 { get; set; }
        public string? CountMojodiAllY10 { get; set; }
        public string? CountMojodiAllY15 { get; set; }
        public string? CountMojodiAllY20 { get; set; }
        public string? CountMojodiAllY25 { get; set; }
        public string? CountMojodiAllY30 { get; set; }
        public string? CountMojodiAllY35 { get; set; }
        public string? CountMojodiAllY40 { get; set; }



        public string? CountMojodiPayvarY5 { get; set; }
        public string? CountMojodiPayvarY10 { get; set; }
        public string? CountMojodiPayvarY15 { get; set; }
        public string? CountMojodiPayvarY20 { get; set; }
        public string? CountMojodiPayvarY25 { get; set; }
        public string? CountMojodiPayvarY30 { get; set; }
        public string? CountMojodiPayvarY35 { get; set; }
        public string? CountMojodiPayvarY40 { get; set; }




        public string? CountMojodiVazifehY5 { get; set; }
        public string? CountMojodiVazifehY10 { get; set; }
        public string? CountMojodiVazifehY15 { get; set; }
        public string? CountMojodiVazifehY20 { get; set; }
        public string? CountMojodiVazifehY25 { get; set; }
        public string? CountMojodiVazifehY30 { get; set; }
        public string? CountMojodiVazifehY35 { get; set; }
        public string? CountMojodiVazifehY40 { get; set; }


        public string? CountMojodiPayvar { get; set; }
        public string? CountMojodiVazifeh { get; set; }

        /// <summary>
        ///مأمور به عده
        /// </summary>

        public string? CountMamorBe { get; set; }

        /// <summary>
        ///مأمور از عده
        /// </summary>

        public string? CountMamorAz { get; set; }

        /// <summary>
        ///عده کل
        /// </summary>

        public string? CountEdeKol { get; set; }

        /// <summary>
        ///مرخصی
        /// </summary>

        public string? CountMorakhasi { get; set; }

        /// <summary>
        ///مأمور دور
        /// </summary>

        public string? CountMamorDoor { get; set; }

        /// <summary>
        ///مأمور نزدیک
        /// </summary>

        public string? CountMamorNazdik { get; set; }

       

        /// <summary>
        ///نگهبان
        /// </summary>

        public string? CountNegahban { get; set; }

        /// <summary>
        ///استراحت کاری
        /// </summary>

        public string? CountEstarahatKari { get; set; }

        /// <summary>
        ///استراحت پزشکی
        /// </summary>

        public string? CountEstarahatPezashki { get; set; }

        /// <summary>
        ///استراحت نگهبانی
        /// </summary>

        public string? CountEstarahatNegahban { get; set; }

        /// <summary>
        ///نهست
        /// </summary>

        public string? CountNahast { get; set; }

        /// <summary>
        ///فرار
        /// </summary>

        public string? CountFarar { get; set; }

        /// <summary>
        ///اعزام بیمارستان
        /// </summary>

        public string? CountEzamBimarestan { get; set; }

        /// <summary>
        ///انتظار خدمت
        /// </summary>

        public string? CountEntezarKhedmat { get; set; }

        /// <summary>
        ///بدون کاری
        /// </summary>

        public string? CountBedonkari { get; set; }

        /// <summary>
        ///زندان
        /// </summary>

        public string? CountZendan { get; set; }

        /// <summary>
        ///جمع کل
        /// </summary>

        public string? CountSumMotafareghe { get; set; }

        /// <summary>
        ///جمع کل
        /// </summary>

        public string? CountSumHazer { get; set; }


        /// <summary>
        ///جمع کل
        /// </summary>

        public string? CountSum { get; set; }







        /// <summary>
        ///سازمانی
        /// </summary>

        public string? CountSazmaniAll { get; set; }

        /// <summary>
        ///موجودی
        /// </summary>

        public string? CountMojodiAll { get; set; }

        /// <summary>
        ///مأمور به عده
        /// </summary>

        public string? CountMamorBeAll { get; set; }

        /// <summary>
        ///مأمور از عده
        /// </summary>

        public string? CountMamorAzAll { get; set; }

        /// <summary>
        ///عده کل
        /// </summary>

        public string? CountEdeKolAll { get; set; }

        /// <summary>
        ///مرخصی
        /// </summary>

        public string? CountMorakhasiAll { get; set; }

        /// <summary>
        ///مأمور دور
        /// </summary>

        public string? CountMamorDoorAll { get; set; }

        /// <summary>
        ///مأمور نزدیک
        /// </summary>

        public string? CountMamorNazdikAll { get; set; }



        /// <summary>
        ///نگهبان
        /// </summary>

        public string? CountNegahbanAll { get; set; }

        /// <summary>
        ///استراحت کاری
        /// </summary>

        public string? CountEstarahatKariAll { get; set; }

        /// <summary>
        ///استراحت پزشکی
        /// </summary>

        public string? CountEstarahatPezashkiAll { get; set; }

        /// <summary>
        ///استراحت نگهبانی
        /// </summary>

        public string? CountEstarahatNegahbanAll { get; set; }

        /// <summary>
        ///نهست
        /// </summary>

        public string? CountNahastAll { get; set; }

        /// <summary>
        ///فرار
        /// </summary>

        public string? CountFararAll { get; set; }

        /// <summary>
        ///اعزام بیمارستان
        /// </summary>

        public string? CountEzamBimarestanAll { get; set; }

        /// <summary>
        ///انتظار خدمت
        /// </summary>

        public string? CountEntezarKhedmatAll { get; set; }

        /// <summary>
        ///بدون کاری
        /// </summary>

        public string? CountBedonkariAll { get; set; }

        /// <summary>
        ///زندان
        /// </summary>

        public string? CountZendanAll { get; set; }

        /// <summary>
        ///جمع کل
        /// </summary>

        public string? CountSumMotafaregheAll { get; set; }

        /// <summary>
        ///جمع کل
        /// </summary>

        public string? CountSumHazerAll { get; set; }


        /// <summary>
        ///جمع کل
        /// </summary>

        public string? CountSumAll { get; set; }
















    }
}
