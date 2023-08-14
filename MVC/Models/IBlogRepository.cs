using MVC.Models.DB;
using System.Threading.Tasks;

namespace MVC.Models
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}
