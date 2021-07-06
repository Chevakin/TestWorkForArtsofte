using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Collections.Generic;
using System.Linq;
using TestWorkForArtsofte.Domain.Data.DB;
using TestWorkForArtsofte.Domain.Data.DTOs;
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

        public IEnumerable<EmployeeDto> Get()
        {
            return _context.Employees
                .ProjectTo<EmployeeDto>(_mapper.ConfigurationProvider)
                .ToArray();
        }
    }
}
