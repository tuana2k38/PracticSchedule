using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticSchedule.WebApi.Infrastructure.Entities
{
    public class Student
    {
        [Key]
        [Column(Order = 1)]
        public Guid StudentId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public ICollection<ScheduleOfStudent>? ScheduleOfStudents { get; set; }
    }
}
