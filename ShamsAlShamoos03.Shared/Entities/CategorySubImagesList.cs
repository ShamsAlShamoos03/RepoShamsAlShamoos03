using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
    public class CategorySubImagesList
    {
        [Key]
        public int CategorySubImagesId { get; set; }
        public string TitleCategorySub { get; set; }
        public DateTime NewsDate { get; set; }
        public DateTime NewsTime { get; set; }
        public string NewsDateSham { get; set; }
        public string DateTimestring { get; set; }
        

    }
 