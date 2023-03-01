using Microsoft.EntityFrameworkCore;
using server_prog_blazer_app.Data;
using server_prog_blazer_app.models;
namespace server_prog_blazer_app.Repo
{
    public class TodoRepo
    {
        private readonly DatabaseContext _context;
        public TodoRepo(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<Todo>> getAll(string UserId)
        {
            List<Todo> TodoList = await _context.Todos.Where(s => s.UserEmailId == UserId).ToListAsync();
            return TodoList;
        }
    }
}
