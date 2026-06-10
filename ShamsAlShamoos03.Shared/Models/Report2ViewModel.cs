using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShamsAlShamoos03.Shared.Models
{
    public class Report2ViewModel
    {
        public int NewsId { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Abstract { get; set; }

        public string NewsDateSham { get; set; }
        public string TitleCategories { get; set; }
        public string TitleSection { get; set; }
        public string TitleDescription { get; set; }
        public string TitleCategoriesSub { get; set; }

        public string NewsImages01 { get; set; }
        public string NewsImages02 { get; set; }
        public string NewsImages03 { get; set; }
        public string NewsImages04 { get; set; }


        //public string idNewsImages01 { get; set; }
        //public string idNewsImages02 { get; set; }
        //public string idNewsImages03 { get; set; }
        //public string idNewsImages04 { get; set; }


         
        //public string TitleDescription { get; set; }
        //public string TitleDescription { get; set; }
        //[Display(Name = "مرتب کردن")]
        public int Sortable01Id { get; set; } = 1;
        //public byte IsActive { get; set; } = 1;

         
    }

    //فرامین 5 محوری
    public class ReportFaraminViewModel
    {
        public int NewsId { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string[] TitleArray { get; set; }
        public string[] TitleArrayq { get; set; }
        public List<string> list = new List<string>();

        public string Content { get; set; }

        public string Abstract { get; set; }

        public string NewsDateSham { get; set; }
        public string TitleCategories { get; set; }
        public string TitleSection { get; set; }
        public string TitleDescription { get; set; }
        public string TitleCategoriesSub { get; set; }

        public string NewsImages01 { get; set; }
        public string NewsImages02 { get; set; }
        public string NewsImages03 { get; set; }
        public string NewsImages04 { get; set; }
        public string NewsImages05 { get; set; }
        //public string TitleDescription { get; set; }
        //public string TitleDescription { get; set; }
    }

    public class Report3ViewModel
    {
        public int NewsId { get; set; }

        public int ImagesListId { get; set; }

        public string sort01 { get; set; }

        public string sort02 { get; set; }
        public string des01 { get; set; }
        public string des02 { get; set; }
        public int Sortable01Id { get; set; }
        public string NewsImagesID { get; set; }

        public string Title { get; set; }
        public string ImagesListDateSham { get; set; }
        public string Imagessource01 { get; set; }

        //public string NewsImages02 { get; set; }
        //public string NewsImages03 { get; set; }
        //public string NewsImages04 { get; set; }
        //public string TitleDescription { get; set; }
        //public string TitleDescription { get; set; }
    }
}
