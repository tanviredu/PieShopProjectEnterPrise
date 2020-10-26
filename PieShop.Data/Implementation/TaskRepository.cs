using PieShop.Data.RepositoryInterface;
using PieShop.Models.HRTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PieShop.Data.Implementation
{
    public class TaskRepository : ITaskRepository
    {
        public readonly AppDbContext _appDbContext;

        public TaskRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public HRTask AddTask(HRTask task)
        {
            var addEntity = _appDbContext.Tasks.Add(task);
            _appDbContext.SaveChanges();
            return addEntity.Entity;
        }

        public IEnumerable<HRTask> GetAllTasks()
        {
            return _appDbContext.Tasks.Select(t => t).ToList();
        }

        public HRTask GetTaskbyId(int taskId)
        {
            return _appDbContext.Tasks.FirstOrDefault(t => t.HRTaskId == taskId);
        }
    }
}
