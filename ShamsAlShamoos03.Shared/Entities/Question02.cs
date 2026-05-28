using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
 

    public class Question02 { 

     [Key]
    public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int QuizId { get; set; }

        public virtual Quiz Quiz { get; set; }

        public virtual List<Choice> Choices { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }

 
