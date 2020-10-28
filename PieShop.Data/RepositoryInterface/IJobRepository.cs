using System;
using System.Collections.Generic;
using System.Text;
using PieShop.Models.Job;

namespace PieShop.Data.RepositoryInterface
{
    public interface IJobRepository
    {
        Job AddJob(Job newjob);
        void DeleteJob(int jobId);
        IEnumerable<Job> GetAllJob();
        Job UpdateJob(Job job);
    }
}
