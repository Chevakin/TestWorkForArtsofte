using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWorkForArtsofte.Domain.Data.DB;
using TestWorkForArtsofte.Domain.Data.DTOs;
using TestWorkForArtsofte.Domain.Services.Interfaces;

namespace TestWorkForArtsofte.Domain.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ArtsofteDbContext _context;
        private readonly IMapper _mapper;

        public DepartmentService(ArtsofteDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<DepartmentDto> Get()
        {
            return _context.Departments
                .ProjectTo<DepartmentDto>(_mapper.ConfigurationProvider)
                .ToList();
        }
    }
}
