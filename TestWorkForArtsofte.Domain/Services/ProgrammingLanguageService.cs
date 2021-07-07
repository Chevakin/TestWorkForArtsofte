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
    public class ProgrammingLanguageService : IProgrammingLanguageService
    {
        private readonly ArtsofteDbContext _context;
        private readonly IMapper _mapper;

        public ProgrammingLanguageService(ArtsofteDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(ProgrammingLanguageDto dto)
        {
            var model = new ProgrammingLanguage(dto.Title);

            _context.ProgrammingLanguages.Add(model);

            _context.SaveChanges();
        }

        public IEnumerable<ProgrammingLanguageDto> Get()
        {
            return _context.ProgrammingLanguages
                .ProjectTo<ProgrammingLanguageDto>(_mapper.ConfigurationProvider)
                .ToList();
        }

        public bool IsUniqueTitle(string title)
        {
            return _context.ProgrammingLanguages
                .Any(d => d.Title == title) == false;
        }
    }
}
