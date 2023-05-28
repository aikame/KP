using System.ComponentModel.DataAnnotations;

namespace KP.BD.Models
{
    public class RequestModel
    {
        [Key]
        public int RequestId {  get; set; }
        [Required]
        public int UserId { get; set; }
        public string Article { set; get; }
        public string Description { set; get; }
        public bool? Status { set; get; }
    }
}
