using System.ComponentModel.DataAnnotations;

namespace server_prog_blazer_app.models
{
    public class Hashed
    {
        [Key] public int Id { get; set; }
        public string ?UserEmailId { get; set; }
        public string ?HashedData { get; set; }
    }
}
