using AutoMapper;
using TestWorkForArtsofte.Domain.Data.ViewModels;
using TestWorkForArtsofte.Domain.Models;

namespace TestWorkForArtsofte.Domain.Data.DTOs.Mapping
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            //Model -> DTO
            CreateMap<Employee, EmployeeDto>();

            //DTO -> VM
            CreateMap<EmployeeDto, EmployeeDisplayViewModel>()
                .ForMember(vm => vm.Department, opt => opt.MapFrom(dto => dto.Department.Title))
                .ForMember(vm => vm.ProgrammingLanguage, opt => opt.MapFrom(dto => dto.ProgrammingLanguage.Title));

            CreateMap<EmployeeDto, EmployeeEditViewModel>();

            CreateMap<EmployeeEditViewModel, EmployeeDto>()
                .ForMember(dto => dto.Department, opt => opt.MapFrom(vm => new DepartmentDto { ID = vm.Department }))
                .ForMember(dto => dto.ProgrammingLanguage, opt => opt.MapFrom(vm => new ProgrammingLanguageDto { ID = vm.ProgrammingLanguage }));
        }
    }
}
