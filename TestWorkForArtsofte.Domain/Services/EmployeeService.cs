using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Collections.Generic;
using System.Linq;
using TestWorkForArtsofte.Domain.Data.DB;
using TestWorkForArtsofte.Domain.Data.DTOs;
using TestWorkForArtsofte.Domain.Models;
using TestWorkForArtsofte.Domain.Services.Interfaces;

namespace TestWorkForArtsofte.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ArtsofteDbContext _context;
        private readonly IMapper _mapper;

        public EmployeeService(ArtsofteDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(EmployeeDto dto)
        {
            var department = _context.Departments.Find(dto.Department.ID);
            var pl = _context.ProgrammingLanguages.Find(dto.ProgrammingLanguage.ID);

            var model = new Employee(dto.Name, dto.Surname, dto.Age, dto.Gender, department, pl);

            _context.Employees.Add(model);

            _context.SaveChanges();
        }

        public IEnumerable<EmployeeDto> Get()
        {
            return _context.Employees
                .ProjectTo<EmployeeDto>(_mapper.ConfigurationProvider)
                .ToArray();
        }
    }
}
