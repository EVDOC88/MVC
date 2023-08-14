using Microsoft.EntityFrameworkCore;
using MVC.Models.DB;
using System;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class RequestRepository : IRequestRepository
    {
        private readonly BlogContext _context;

        public RequestRepository(BlogContext context)
        {
            _context = context;
        }

        // Метод для добавления запроса в бд
        public async Task AddRequest(Request request)
        {
            // Добавление запроса
            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
                await _context.Logs.AddAsync(request);

            // Сохранение изменений
            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetRequests()
        {
            // Получим всех осуществленные запросы страниц
            return await _context.Logs.ToArrayAsync();
        }

    }
}

