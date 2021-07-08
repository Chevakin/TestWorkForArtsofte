using System.Collections.Generic;
using TestWorkForArtsofte.Domain.Data.DTOs;

namespace TestWorkForArtsofte.Domain.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> Get();

        void Add(EmployeeDto dto);
    }
}
