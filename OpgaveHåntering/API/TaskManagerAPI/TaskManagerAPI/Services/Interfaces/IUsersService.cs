using TaskManagerAPI.Models;
using TaskManagerAPI.ServiceResponse;

namespace TaskManagerAPI.Services.Interfaces
{
    public interface IUsersService
    {
        Task<ServiceResponse<List<Users>>> GetTasksAsync();
        Task<ServiceResponse<Users>> GetTaskAsync(Users id);
        Task<ServiceResponse<Users>> AddTaskAsync(Users users);
        Task<ServiceResponse<Users>> EditTaskAsync(Users users);
        Task<ServiceResponse<Users>> DeleteTaskAsync(Users id);
    }
}
