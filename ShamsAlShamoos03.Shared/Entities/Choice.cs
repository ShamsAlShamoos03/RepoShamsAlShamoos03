using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Choice
    {
        public int ChoiceId { get; set; }
        public string ChoiceText { get; set; }
        public int QuestionId { get; set; }

        public virtual Question02 Question02 { get; set; }
    }

    //public ICollection<Option> Options { get; set; }
    //public string? Options { get; set; }
    //[ForeignKey("Options")]
    //public virtual Option oo_Options { get; set; }
 
