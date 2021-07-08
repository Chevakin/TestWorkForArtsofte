using System.Collections.Generic;
using TestWorkForArtsofte.Domain.Data.DTOs;

namespace TestWorkForArtsofte.Domain.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> Get();

        EmployeeDto Get(int id);

        void Add(EmployeeDto dto);

        void Edit(EmployeeDto dto);
    }
}
