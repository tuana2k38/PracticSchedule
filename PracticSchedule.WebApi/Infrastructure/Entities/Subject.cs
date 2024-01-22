using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticSchedule.WebApi.Infrastructure.Entities
{
    [Table("subject")]
    public class Subject
    {
        [Key]
        [Column(Order = 1)]
        public Guid SubjectId { get; set; }
        [Required]
        [MaxLength(100)]
        public string SubjectName { get; set; } = string.Empty;
        public ICollection<Schedule>? Schedules { get; set; }
    }
}
