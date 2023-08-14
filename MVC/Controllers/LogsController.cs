using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Models;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class LogsCotroller : Controller
    {
        private readonly IRequestRepository _request;
       
        public LogsCotroller(IRequestRepository request)
        {
            _request = request;
        }


        public async Task<IActionResult> Index()
        {
            var logs = await _request.GetRequests();
            return View(logs);
        }


    }
}
