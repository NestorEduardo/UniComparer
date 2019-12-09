using System.Collections.Generic;
using UniComparer.Models;

namespace UniComparer.Repository.Abstract
{
    public interface ICampusRepository
    {
        public ICollection<Campus> GetCampusByUniversity(int universityId);
    }
}
