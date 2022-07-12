using SalesWebMvc.Models;
using SalesWebMvc.Data;
using System.Linq;
using System.Collections.Generic;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FinAll()
        {
           return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
