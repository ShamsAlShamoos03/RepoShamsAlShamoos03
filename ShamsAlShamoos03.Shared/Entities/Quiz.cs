using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


    public class Quiz
    {
        [Key]

        public int QuizId { get; set; }
        public string QuizName { get; set; }

        public virtual List<Question02> Questions02 { get; set; }
    }

 