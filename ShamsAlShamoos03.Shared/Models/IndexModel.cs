
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    public class IndexModel
    {

        //List<CategoryImagesList> category = ViewBag.category;
        //List<CategorySubImagesList> brand = ViewBag.brand;
        //List<ImagesListCategoryImagesList> ImagesList = ViewBag.ImagesList;
        public string HaveNewsimages { get; set; }

        public List<CategoryImagesList> CategoryImagesList02show { get; set; }
        public List<CategorySubImagesList> CategorySubImagesList02show { get; set; }
        public List<ImagesListCategoryImagesList> ImagesListCategoryImagesList03show { get; set; }

        public List<ImagesListCategoryImagesListViewModel> ImagesListCategoryImagesList02show { get; set; }

        public List<NewsCategory> NewsCategoryshow { get; set; }
        //public List<IsActiveViewModel> IsActiveViewModelshow { get; set; }

        public byte IsActiveViewModelshow { get; set; }
        public int NewsIDViewModelshow { get; set; }
        public int PageID { get; set; }
        public int NewsId { get; set; }

         
        public List<News> SliderNews { get; set; }
        public List<News> SpecialNews { get; set; }
        public List<News> lastVideo { get; set; }

        public List<News> LastNews { get; set; }
        public List<News> InNews { get; set; }
        public List<News> OutNews { get; set; }
        public List<News> PrivateNews { get; set; }
        public List<News> NewslistAll { get; set; }

        public News NewsDetails { get; set; }

        public LoginViewModel LoginVM { get; set; }

        public List<Advertise> Adv { get; set; }

        public Poll PollModel { get; set; }
        //public List<News> searchmodel { get; set; }
        public List<NewsCategory> searchmodel { get; set; }
        //public List<NewsCategory> searchmodel1 { get; set; }
        public List<ApplicationUsers> usermodel { get; set; }

        public LoginViewModel NewsViewModel { get; set; }

        public List<News> Categoryshow { get; set; }
        public List<News> Categoryshowtest { get; set; }
        public List<Category> Categorysubshow { get; set; }
        public CategoryTitleViewModel CategoryTitle { get; set; }

        public List<CategoryReport> CategoryReportsubshow { get; set; }
        public List<CategoryGeneral> CategoryGeneralsubshow { get; set; }
        public List<GaurdPost> GaurdPostshow { get; set; }
        public List<PropertyDay> PropertyDayshow { get; set; }


        public List<UsersCategory> UsersCategoryshow { get; set; }
        public List<UsersCategorySub> UsersCategorysubshow { get; set; }



        public List<EvidencelImage> EvidencelImageshow { get; set; }
        public List<EvidencelImageV> EvidencelImageVshow { get; set; }


        public List<PersonnelVazife01> PersonnelVazife01show { get; set; }
        public List<CategoryGeneralSub> CategoryGeneralshow { get; set; }
        public List<NewsImagesList> NewsImagesListshow { get; set; }

        public List<CategoryImagesList> CategoryImagesListshow { get; set; }

        //public List<ImagesListCategoryImagesList> ImagesListCategoryImagesList { get; set; }

        public List<ImagesList> ImagesListshow { get; set; }

        public List<ImagesListCategoryImagesList> ImagesListCategoryImagesListshow { get; set; }



        public List<GuardboardVPG> GuardboardVPGshow { get; set; }


        //public List<News> Categoryshow { get; set; }

        //public List<Category> Categoryshow1 { get; set; }
        //public News Categoryshow2 { get; set; }




    }
}
