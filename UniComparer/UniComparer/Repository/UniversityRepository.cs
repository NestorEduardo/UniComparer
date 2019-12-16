using System.Linq;
using UniComparer.Repository.Abstract;

namespace UniComparer.Repository
{
    public class UniversityRepository  : IUniversityRepository
    {
        private readonly ApplicationDbContext context;
        public UniversityRepository(ApplicationDbContext context) => this.context = context;
        public int GetUniversitiesCount() => context.Universities.Count();
    }
}
