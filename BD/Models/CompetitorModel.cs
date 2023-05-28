using System.ComponentModel.DataAnnotations;
namespace KP.BD.Models
{
    public class CompetitorModel
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public bool IsCompetite { get; set; }
    }
}
