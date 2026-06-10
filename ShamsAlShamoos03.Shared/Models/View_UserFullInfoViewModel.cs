
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class View_UserFullInfoViewModel01
    {
 


        [Display(Name = "UserID")]
        public string? UserID { get; set; }

        [Display(Name = "MelliCodeID")]
        public string? MelliCodeID { get; set; }


        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }

        [Display(Name = "LastName")]
        public string? LastName { get; set; }

        [Display(Name = "FST_NAM")]
        public string? FST_NAM { get; set; }

        [Display(Name = "LST_NAM")]
        public string? LST_NAM { get; set; }

        [Display(Name = "YeganUser")]
        public string? YeganUser { get; set; }

        [Display(Name = "Daraje")]
        public string? Daraje { get; set; }

        [Display(Name = "Roles")]
        public string? Roles { get; set; }

        [Display(Name = "Rolesdes")]
        public string? Rolesdes { get; set; }


        [Display(Name = "ListNameOfBirthdays")]
        public string? ListNameOfBirthdays { get; set; }


        [Display(Name = "ListNameOfMARdays")]
        public string? ListNameOfMARdays { get; set; }


        [Display(Name = "YeganFullname")]
        public string? YeganFullname { get; set; }


        [Display(Name = "YeganCount")]
        public string? YeganCount { get; set; }

        [Display(Name = "DateAmarActivity03")]
        public string? DateAmarActivity03 { get; set; }

        [Display(Name = "DateAmarActivity04")]
        public string? DateAmarActivity04 { get; set; }

        [Display(Name = "DateAmarActivity05")]
        public string? DateAmarActivity05 { get; set; }








    }


}



