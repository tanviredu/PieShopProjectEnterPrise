using PieShop.Data.RepositoryInterface;
using PieShop.Models.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PieShop.Data.Implementation
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext appDbContext;

        public JobRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Job AddJob(Job newjob)
        {
            var AddEntity = appDbContext.Jobs.Add(newjob);
            appDbContext.SaveChanges();
            return AddEntity.Entity;
        }

        public void DeleteJob(int jobId)
        {
            var foundJob = appDbContext.Jobs.FirstOrDefault(j => j.Id == jobId);
            appDbContext.Jobs.Remove(foundJob);
            appDbContext.SaveChanges();
        }

        public IEnumerable<Job> GetAllJob()
        {
            return appDbContext.Jobs.Select(x => x).ToList();
        }

        public Job UpdateJob(Job job)
        {
            var foundJob = appDbContext.Jobs.FirstOrDefault(j => j.Id == job.Id);
            foundJob.Title = job.Title;
            foundJob.Description = job.Description;
            foundJob.Salary = job.Salary;
            foundJob.StartDate = job.StartDate;
            foundJob.RequiredSkills = job.RequiredSkills;
            foundJob.DegreeRequirements = job.DegreeRequirements;
            foundJob.ContactNumber = job.ContactNumber;

            appDbContext.SaveChanges();
            return foundJob;
        }
    }
}
