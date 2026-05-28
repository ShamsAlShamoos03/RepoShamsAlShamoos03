using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }

        // کلید خارجی در کلاس Option قرار می‌گیرد، پس نیازی به رشته Options نیست
        public virtual ICollection<Option> Options { get; set; }
        //public List<Option> Options1 { get; set; }

    }
 