using System.ComponentModel.DataAnnotations;

namespace KP.BD.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string Login { get; set; } 
        public string Password { get; set; }
        public byte AccountLevel { get; set; }
    }
}
