using System.ComponentModel.DataAnnotations;

namespace server_prog_blazer_app.models
{
    public class Todo
    {
       [Key] public int Id { get; set; }
        public string UserEmailId { get; set; }
        public string TodoTitle { get; set; }
        public int StackSize { get; set; }
        public float price { get; set; }
    }
}
