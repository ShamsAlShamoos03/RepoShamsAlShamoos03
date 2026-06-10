using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    [Serializable]

    public class DropDownListSTRViewModel
    {

        public DropDownListSTRViewModel()
        {

        }
        public DropDownListSTRViewModel(string value, string Title, string TitleEn1)
        {
            this.Value = value;
            this.Title = Title; 
            this.TitleEn1 = TitleEn1;  
        }
        public string Value { get; set; }
        public string Title { get; set; }
        public string TitleEn1 { get; set; }











    }



}
