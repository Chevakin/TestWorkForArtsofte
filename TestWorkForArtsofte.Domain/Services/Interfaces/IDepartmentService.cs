using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWorkForArtsofte.Domain.Data.DTOs;

namespace TestWorkForArtsofte.Domain.Services.Interfaces
{
    public interface IDepartmentService
    {
        IEnumerable<DepartmentDto> Get();
    }
}
