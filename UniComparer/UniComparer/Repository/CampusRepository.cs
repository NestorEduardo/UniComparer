using System.Collections.Generic;
using System.Linq;
using UniComparer.Models;
using UniComparer.Repository.Abstract;

namespace UniComparer.Repository
{
    public class CampusRepository : ICampusRepository
    {
        private readonly ApplicationDbContext context;
        public CampusRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public ICollection<Campus> GetCampusByUniversity(int universityId) => context.Campus.Where(c => c.IsActive && c.UniversityId == universityId).OrderByDescending(c => c.IsPrincipal).ToList();
    }
}
