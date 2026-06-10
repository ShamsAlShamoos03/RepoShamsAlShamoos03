using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class DropDownList1STRViewModel
    {

        public DropDownList1STRViewModel( )
        {

        }
        public DropDownList1STRViewModel(string Title)
        {
            this.Title = Title;
        }
        public string Title { get; set; }

 


    }



}
