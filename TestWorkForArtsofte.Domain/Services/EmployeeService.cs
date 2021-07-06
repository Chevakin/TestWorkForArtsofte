using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWorkForArtsofte.Domain.Data.DB;
using TestWorkForArtsofte.Domain.Models;
using TestWorkForArtsofte.Domain.Services.Interfaces;

namespace TestWorkForArtsofte.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ArtsofteDbContext _context;

        public EmployeeService(ArtsofteDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> Get()
        {
            return(_context.Employees.ToList());
        }
    }
}
