
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamsAlShamoos03.Shared.Models
{
    //NewsId CategoryID

    
    public class WeatherEvidence01ViewModelcat
    {
        //public DateTime? TimeWeatherDateTime { get; set; }
        public DateTime? TimeWeatherDateTime { get; set; }
        public TimeSpan? TimeWeatherTimeSpan { get; set; }
 

        public string filename01 { get; set; }
        public string fileext01 { get; set; }

        public string filename02 { get; set; }
        public string fileext02 { get; set; }


        public string filename03 { get; set; }
        public string fileext03 { get; set; }

        public string filename04 { get; set; }
        public string fileext04 { get; set; }

        public string filename05 { get; set; }
        public string fileext05 { get; set; }

        public string filename06 { get; set; }
        public string fileext06 { get; set; }



        //public string UjobPesronel01IDstr { get; set; }

        [Display(Name = "دسته بندی")]
        public string WeatherEvidence01ID { get; set; }
        public string WeatherEvidence01IDstr { get; set; }

        public string WeatherEvidence01IDstr3 { get; set; }
        public string WeatherEvidence01IDstr4 { get; set; }
        public string WeatherEvidence01IDstr5 { get; set; }
        public string WeatherEvidence01IDstr6 { get; set; }
        public string ResaultStandCheckRamainDay01 { get; set; }



        //============================

        /// <summary>
        ///   
        /// </summary>
        //public string MelliCode { get; set; }


        ///// <summary>
        /////  سطح آزمون
        ///// </summary>
        //public int? LevelExam { get; set; }
        //public string? LevelExamstr { get; set; }





        ///// <summary>
        /////  شماره بالگرد 
        ///// </summary>
        //public string? TailHelicopter { get; set; }

        /// <summary>
        ///  ساعت اعلان هوا 
        /// </summary>
        //public TimeSpan? TimeWeather { get; set; }
        public string? TimeWeather { get; set; }
        //public TimeSpan? TimeWeather { get; set; }

        /// <summary>
        /// منطقه پروازی 
        /// </summary>
        public int? FLTAREA { get; set; }
        public string? FLTAREAstr { get; set; }


        /// <summary>
        ///  سریال بالگرد 
        /// </summary>
        public string? SeriakHelicopter { get; set; }

        /// <summary>
        ///  مدل بالگرد 
        /// </summary>
        //public int? TypeHelicopter { get; set; }
        //public string? TypeHelicopterstr { get; set; }


        /// <summary>
        /// WIND
        /// </summary>
        public string? WIND { get; set; }


        /// <summary>
        /// VIIBILITY
        /// </summary>
        public string? VIIBILITY { get; set; }


        /// <summary>
        /// P.W
        /// </summary>
        public string? PW { get; set; }


        /// <summary>
        /// TEMP
        /// </summary>
        public string? TEMP { get; set; }


        /// <summary>
        /// D.P
        /// </summary>
        public string? DP { get; set; }


        /// <summary>
        /// CLOUDS
        /// </summary>
        public string? CLOUDS { get; set; }


        /// <summary>
        /// ALT.SET
        /// </summary>
        public string? ALTSET { get; set; }


        /// <summary>
        /// D.A
        /// </summary>
        public string? DA { get; set; }


        /// <summary>
        /// SUN.RISE
        /// </summary>
        public string? SUNRISE { get; set; }


        /// <summary>
        /// SUN.SET
        /// </summary>
        public string? SUNSET { get; set; }











        ///// <summary>
        /////  گرید 
        ///// </summary>
        //public string? Grade { get; set; }

        ///// <summary>
        /////  عنوان مدرک
        ///// </summary>
        //public int? HealthEvidenceTitle { get; set; }
        //public string? HealthEvidenceTitlestr { get; set; }

        ///// <summary>
        ///// روز باقیمانده تا تاریخ شروع
        ///// </summary>
        //public string? FromDateWeatherEvidence01TitleRamainDay01 { get; set; }
        ///// <summary>
        /////  روز باقیمانده تا تاریخ خاتمه
        ///// </summary>
        //public string? ToDateWeatherEvidence01TitleRamainDay01 { get; set; }

        /// <summary>
        /// تاریخ شروع
        /// </summary>
        public string? FromDateWeatherEvidence01Title { get; set; }
        ///// <summary>
        /////  تاریخ خاتمه
        ///// </summary>
        //public string? ToDateWeatherEvidence01Title  { get; set; }


        /// <summary>
        ///  فعال غیر فعال
        /// </summary>
        public bool IsHaveJob { get; set; }
        public string IsHaveJobstring { get; set; }

        /// <summary>
        ///  ترتیب
        /// </summary>
        [Display(Name = "ترتیب")]
        public int? Sortable01Id { get; set; }
        public string SortableTitle01 { get; set; }

        /// <summary>
        ///  وضعیت هوا
        /// </summary>
        public int? StatusWeatherEvidence01 { get; set; }
        public string? StatusWeatherEvidence01str { get; set; }



    


        ///// <summary>
        /////  آزمون دهنده
        ///// </summary>
        //public string PersonImageMelliCodeExamer { get; set; }

 
        ///// <summary>
        /////  آزمون گیرنده
        ///// </summary>
        //public string? MelliCodeExamer { get; set; }
        ///// <summary>
        /////  تاریخ اخذ آزمون کتبی
        ///// </summary>
        //public string? DateExamWritten { get; set; }
        //public string? MelliCodeExamerstr { get; set; }

        ///// <summary>
        /////  گرید کتبی
        ///// </summary>
        //public string? WrittenGrade { get; set; }

        ///// <summary>
        /////  گرید کتبی آزمایشی
        ///// </summary>
        //public string? WrittenTPGrade { get; set; }


        ///// <summary>
        /////  گرید اضطراری
        ///// </summary>
        //public string? EmargencylimitationGrade { get; set; }
        ///// <summary>
        /////  گرید مقررات محلی پروازی
        ///// </summary>
        //public string? SOPLOPGrade { get; set; }
        ///// <summary>
        ///  قبول مردود
        /// </summary>
        //public int? Status01 { get; set; }
        ///// <summary>
        /////  ISSUE Revalidate
        /////  آزمون اولیه تمدید اعتبار
        ///// </summary>

        //public int? ISSUERevalidateID { get; set; }

        ///// <summary>
        /////  آزمون عادی یا تست
        ///// </summary>

        //public int? TPorNormalID { get; set; }

        //public string? Status01str { get; set; }
        //public string? ISSUERevalidateIDstr { get; set; }
        //public string? TPorNormalIDstr { get; set; }



        ///////////استندچک عملی/////استندچک عملی//////////استندچک عملی
        /////// <summary>
        ///////  نام استاد
        /////// </summary>
        ////public string? MelliCodeInstructor { get; set; }
        /////// <summary>
        ///////  تاریخ استندچک
        /////// </summary>
        ////public string? DateStandCheck { get; set; }


        ///// <summary>
        ///// گرید پروازی
        ///// </summary>
        //public string? GradeStatusFlight { get; set; }

        ///// <summary>
        /////  قبول مردود استندچک
        ///// </summary>
        //public int? Status01StandCheck { get; set; }

        ///// <summary>
        /////  تاریخ استندچک آزمایشی
        ///// </summary>
        //public string? DateStandCheckTP { get; set; }
        ///// <summary>
        ///// گرید خلبان آزمایشی
        ///// </summary>
        //public string? GradeStatusTP { get; set; }

        ///// <summary>
        /////  قبول مردود استندچک آزمایشی
        ///// </summary>
        //public int? Status01StandCheckTP { get; set; }

        /////////استندچک عملی/////استندچک عملی//////////استندچک عملی

        //public string? MelliCodeInstructorstr { get; set; }
        //public string? Status01StandCheckstr { get; set; }
        //public string? Status01StandCheckTPstr { get; set; }

    
        ///// <summary>
        ///// وضعیت نتیجه استند چک
        ///// </summary>
        //public int? ResaultStatus01StandCheck { get; set; }

        ///// <summary>
        ///// وضعیت نتیجه استند چک
        ///// </summary>
        //public string? ResaultStatus01StandCheckstr { get; set; }

        ///// <summary>
        ///// متن نتیجه استند چک
        ///// </summary>
        //public string? ResaultStandCheck { get; set; }




        ////=============================


        ////[Display(Name = "دسته بندی")]
        ////public string Title { get; set; }

        //////[Display(Name = "دسته بندی")]
        ////public string UserID { get; set; }
        //////[Display(Name = "دسته بندی")]
        ////public string FirstName { get; set; }
        //////[Display(Name = "دسته بندی")]
        ////public string LastName { get; set; }
        //////[Display(Name = "دسته بندی")]
        //public string Title { get; set; }
        //public string Darajee { get; set; }
        //public string DRJ_NAMGheshr1 { get; set; }
        //public string DRJ_NAMGheshr2  { get; set; }
        //public int DarajeeGheshrID { get; set; }
        //public string FName { get; set; }
        ////[Display(Name = "دسته بندی")]
        //public string LName { get; set; }

        ////[Display(Name = "دسته بندی")]
        //public string Rank01 { get; set; }

        //public string DarajeeEN { get; set; }
        //public string EMP_NUM { get; set; }
        //public string FstNamEN { get; set; }
        //public string LstNamEN { get; set; }

        

        ////public string FName { get; set; }
        //////[Display(Name = "دسته بندی")]
        ////public string LName { get; set; }

        //////[Display(Name = "دسته بندی")]
        ////public string Rank01 { get; set; }

        //[Display(Name = "عنوان مدرک")]
        //public int EvidenceFlightTitle { get; set; }
        //public string EvidenceFlightTitlestr { get; set; }

        //[Display(Name = "تاریخ شروع مدرک")]

        //public string DateSrartEvidenceFlightTitle { get; set; }
        //[Display(Name = "تاریخ خاتمه مدرک")]
        //public string DateEndEvidenceFlightTitle { get; set; }

        //[Display(Name = "دسته بندی")]
        //public int Rate { get; set; }
        //public string Ratestr { get; set; }
        //public string RatestrFa { get; set; }


        //[Display(Name = "دسته بندی")]
        //public int TypeRateID { get; set; }
        //public string TypeRatestr { get; set; }

        //public string TypeRatestrTypeRatestr { get; set; }


        //[Display(Name = "دسته بندی")]
        //public int TypeAC { get; set; }
        //public string TypeACstr { get; set; }
        //public string TypeACstrAll { get; set; }

 
        //[Display(Name = "دسته بندی")]
        //public string IsHaveJobFIsHaveJobF { get; set; }
 
        public string IsPortrait01 { get; set; }
        public string IsPortrait02 { get; set; }
        public string IsPortrait03 { get; set; }
        public string IsPortrait04 { get; set; }
        public string IsPortrait05 { get; set; }
        public string IsPortrait06 { get; set; }
        //public string Title01 { get; set; }

        //public string PersonImage { get; set; }


    }





}
