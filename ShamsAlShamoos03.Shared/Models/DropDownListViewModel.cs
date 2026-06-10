using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class DropDownListViewModel
    {

        public DropDownListViewModel( )
        {

        }
        public DropDownListViewModel(int value, string Title, string Description)
        {
            this.Value = value;
            this.Title = Title;
            this.Description = Description;
        }
        public int Value { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        








    }



}
