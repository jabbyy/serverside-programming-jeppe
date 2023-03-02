using Microsoft.EntityFrameworkCore;
using server_prog_blazer_app.Data;
using server_prog_blazer_app.models;
using System.ComponentModel;
using System.Diagnostics;

namespace server_prog_blazer_app.Repo
{
    public class HashRepo
    {
        private readonly DatabaseContext _context;
        public HashRepo(DatabaseContext context) { _context = context; }

        public async Task<Hashed> GetHashed(string UserEmailId)
        {
            return await _context.Set<Hashed>().FirstOrDefaultAsync(i => i.UserEmailId == UserEmailId);
        }
        public async Task<Hashed> Create(Hashed _hashed)
        {
            _context.hasheds.Add(_hashed);
            await _context.SaveChangesAsync();
            return _hashed;
        }
        public async Task<Hashed> Update(Hashed _hashed)
        {
            _context.Entry(_hashed).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return null;
        }
        public int CheckifEmpty(string UserEmailId)
        {
           return _context.hasheds.Where(c => c.UserEmailId == UserEmailId).Count();
        }
    }
}
