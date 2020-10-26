using PieShop.Models.HRTask;
using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Data.RepositoryInterface
{
    public interface ITaskRepository
    {
        IEnumerable<HRTask> GetAllTasks();
        HRTask GetTaskbyId(int taskId);
        HRTask AddTask(HRTask task);
    }
}
