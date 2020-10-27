using PieShop.Data.RepositoryInterface;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PieShop.Data.Implementation
{
    public class JobCategoryRepository : IJobCategoryRepository
    {
        public readonly AppDbContext _appDbContext;

        public JobCategoryRepository()
        {
        }

        public JobCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<JobCategory> GetAllJobCategories()
        {
            return _appDbContext.JobCategories.Select(j => j).ToList();
        }

        public JobCategory GetJobCategoryById(int jobCategoryId)
        {
            return _appDbContext.JobCategories.FirstOrDefault(c => c.JobCategoryId == jobCategoryId);
        }
    }
}
