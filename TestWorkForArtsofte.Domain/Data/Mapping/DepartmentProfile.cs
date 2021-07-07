using AutoMapper;
using TestWorkForArtsofte.Domain.Data.ViewModels;
using TestWorkForArtsofte.Domain.Models;

namespace TestWorkForArtsofte.Domain.Data.DTOs.Mapping
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            //Model <-> DTO
            CreateMap<Department, DepartmentDto>();

            //DTO <-> VM
            CreateMap<DepartmentDto, DepartmentSimpleViewModel>();

            CreateMap<DepartmentSimpleViewModel, DepartmentDto>();
        }
    }
}
