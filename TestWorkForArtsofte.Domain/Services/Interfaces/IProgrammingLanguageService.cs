using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWorkForArtsofte.Domain.Data.DTOs;

namespace TestWorkForArtsofte.Domain.Services.Interfaces
{
    public interface IProgrammingLanguageService
    {
        IEnumerable<ProgrammingLanguageDto> Get();

        void Add(ProgrammingLanguageDto dto);

        bool IsUniqueTitle(string title);
    }
}
