using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Infrastructure.Repositories
{
    public class ProjectRepository
    {
        private readonly Context _context;
        public ProjectRepository(Context context)
        {
            _context = context;
        }
    }
}
