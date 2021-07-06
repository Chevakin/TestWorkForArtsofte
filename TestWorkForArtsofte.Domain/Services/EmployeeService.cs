using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWorkForArtsofte.Domain.Models;
using TestWorkForArtsofte.Domain.Services.Interfaces;

namespace TestWorkForArtsofte.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IEnumerable<Employee> Get()
        {
            return(Array.Empty<Employee>());
        }
    }
}
