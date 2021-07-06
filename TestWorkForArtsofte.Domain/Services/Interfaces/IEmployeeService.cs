using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWorkForArtsofte.Domain.Models;

namespace TestWorkForArtsofte.Domain.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> Get();
    }
}
