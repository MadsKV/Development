using TaskManagerAPI.Models;
using TaskManagerAPI.ServiceResponse;

namespace TaskManagerAPI.Services.Interfaces
{
    public interface ITasksService
    {
        Task<ServiceResponse<List<Tasks>>> GetTasksAsync();
        Task<ServiceResponse<Tasks>> GetTaskAsync(Tasks id);
        Task<ServiceResponse<Tasks>> AddTaskAsync(Tasks tasks);
        Task<ServiceResponse<Tasks>> EditTaskAsync(Tasks tasks);
        Task<ServiceResponse<Tasks>> DeleteTaskAsync(Tasks id);
    }
}
