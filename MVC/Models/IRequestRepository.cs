using MVC.Models.DB;
using System.Threading.Tasks;

namespace MVC.Models
{
    public interface IRequestRepository
        {
        Task AddRequest(Request request);

        Task<Request[]> GetRequests();
    }
    
}
