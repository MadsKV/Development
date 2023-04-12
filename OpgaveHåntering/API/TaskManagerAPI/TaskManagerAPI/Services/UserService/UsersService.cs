using TaskManagerAPI.Models;
using TaskManagerAPI.ServiceResponse;
using TaskManagerAPI.Services.Interfaces;

namespace TaskManagerAPI.Services.UserService
{
    public class UsersService : IUsersService
    {
        public Task<ServiceResponse<Users>> AddTaskAsync(Users users)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Users>> DeleteTaskAsync(Users id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Users>> EditTaskAsync(Users users)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Users>> GetTaskAsync(Users id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Users>>> GetTasksAsync()
        {
            throw new NotImplementedException();
        }
    }
}
