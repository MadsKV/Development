using TaskManagerAPI.Models;
using TaskManagerAPI.ServiceResponse;
using TaskManagerAPI.Services.Interfaces;

namespace TaskManagerAPI.Services.TasksService
{
    public class TasksService : ITasksService
    {
        public Task<ServiceResponse<Tasks>> AddTaskAsync(Tasks tasks)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Tasks>> DeleteTaskAsync(Tasks id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Tasks>> EditTaskAsync(Tasks tasks)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Tasks>> GetTaskAsync(Tasks id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Tasks>>> GetTasksAsync()
        {
            throw new NotImplementedException();
        }
    }
}
