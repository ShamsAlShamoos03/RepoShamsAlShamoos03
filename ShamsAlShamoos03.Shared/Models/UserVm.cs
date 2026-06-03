using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace ShamsAlShamoos03.Shared.Models;


public class UserVm
{
    public string ID { get; set; }
    public string Title { get; set; }
    public string TitleEn1 { get; set; }
}


//try
//{
//    UserPersonnelList = _context.userManagerUW.Get(u => u.MelliCodeID != null).Select(mt => new selectViewModel { ID = mt.UserName, Title = mt.FirstName + " " + mt.LastName + " " + mt.tblMelicodeID.ooDRJCOD.Title + " " + mt.tblMelicodeID.FST_NAM + " " + mt.tblMelicodeID.LST_NAM, TitleEn1 = Url.Content("~/PersonelImage1/" + mt.tblMelicodeID.MelliCode + ".png") }).ToList();
//    // بازیابی وضعیت از TempData در صورت وجود
//    //if (TempData.TryGetValue("ForcePasswordChange", out var forceChange))
//    //{
//    //    ForcePasswordChange = (bool)forceChange;
//    //    TempData.Keep("ForcePasswordChange");
//    //}
//    //UserPersonnelList = await _httpClient.GetFromJsonAsync<List<selectViewModel>>(
//    //    "api/BlazorMainLogin01Area/BlazorMainLogin01API/userPersonellist_02") ?? new();
//}
//catch (Exception ex)
//{
//    ErrorMessage = $"خطا در بارگذاری کاربران: {ex.Message}";
//}