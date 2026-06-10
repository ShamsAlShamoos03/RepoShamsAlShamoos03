using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class UserListViewModel
    {
        public UserListViewModel() { }

        public UserListViewModel(int? yeganUser, string yeganUserId, string yeganUserMelicode, string fstNamUser, string lstNamUser, string ooDrjcodUser)
        {
            YeganUser = yeganUser;
            YeganUserId = yeganUserId;
            YeganUserMelicode = yeganUserMelicode;
            FST_NAMUser = fstNamUser;
            LST_NAMUser = lstNamUser;
            ooDRJCODUser = ooDrjcodUser;
        }

        public int? YeganUser { get; set; }
        public string YeganUserId { get; set; }
        public string YeganUserMelicode { get; set; }
        public string FST_NAMUser { get; set; }
        public string LST_NAMUser { get; set; }
        public string ooDRJCODUser { get; set; }
    }



}
