using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


    public class Answer
    {
        [Key]

        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int ChoiceId { get; set; }

        public string AnswerText { get; set; }


        public virtual Question02 Question02 { get; set; }
        //public Choice Choice { get; set; }
        public virtual Choice Choice { get; set; }

    }

    //public ICollection<Option> Options { get; set; }
    //public string? Options { get; set; }
    //[ForeignKey("Options")]
    //public virtual Option oo_Options { get; set; }
 
