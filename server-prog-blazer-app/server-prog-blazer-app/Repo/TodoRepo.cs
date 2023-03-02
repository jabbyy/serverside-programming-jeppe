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
        public async Task<Todo> GetSingle(int Id)
        {
            return await _context.Todos.FindAsync(Id);
        }
        public async Task<Todo> DeleteItem(int Id)
        {
            var item = _context.Todos.Find(Id);
            if(item != null) {_context.Todos.Remove(item); await _context.SaveChangesAsync();} return item;
        }
        public async Task<Todo> CreateItem(Todo todo)
        {
            try
            {
                _context.Todos.Add(todo);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                string messsage = ex.Message;
            }


            return todo;
        }
        public async Task<Todo> UpdateItem(int Id, Todo todo)
        {
            
            _context.Entry(todo).State = EntityState.Modified;
            await _context.SaveChangesAsync();  
            return todo;
        }
    }
}
