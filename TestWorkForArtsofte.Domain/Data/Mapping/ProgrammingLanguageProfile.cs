using AutoMapper;
using TestWorkForArtsofte.Domain.Data.ViewModels;
using TestWorkForArtsofte.Domain.Models;

namespace TestWorkForArtsofte.Domain.Data.DTOs.Mapping
{
    public class ProgrammingLanguageProfile : Profile
    {
        public ProgrammingLanguageProfile()
        {
            //Model <-> Dto
            CreateMap<ProgrammingLanguage, ProgrammingLanguageDto>();

            //Dto <-> VM
            CreateMap<ProgrammingLanguageDto, ProgrammingLanguageSimpleViewModel>();

            CreateMap<ProgrammingLanguageDto, SimpleSelectViewModel>()
                .ForMember(vm => vm.Info, opt => opt.MapFrom(dto => dto.Title));

            CreateMap<ProgrammingLanguageSimpleViewModel, ProgrammingLanguageDto>();
        }
    }
}
