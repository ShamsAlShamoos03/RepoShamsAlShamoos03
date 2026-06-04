using AutoMapper;
using ShamsAlShamoos03.Shared.Models;

namespace ShamsAlShamoos03.Application.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            AllowNullCollections = true;
            CreateMap<HistoryRegisterKala01, HistoryRegisterKala01ViewModelcat>().ReverseMap();
            CreateMap<HistoryRegisterKala01, HistoryRegisterKala01ViewModel_Update>().ReverseMap();


        }
    }

}
