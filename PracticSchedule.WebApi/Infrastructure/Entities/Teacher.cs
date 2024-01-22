using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticSchedule.WebApi.Infrastructure.Entities
{
    public class Teacher
    {
        [Key]
        [Column(Order = 1)]
        public Guid TeacherId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public ICollection<Schedule>? Schedules { get; set; }
    }
}
