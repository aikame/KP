using System.ComponentModel.DataAnnotations;

namespace KP.BD.Models
{
    public class EventModel
    {
        [Key]
        public int EventId { set; get; }
        [Required]
        public string UserId { set; get; }
        public string Article { set; get; }
        public string Description { set; get; }
    }
}
