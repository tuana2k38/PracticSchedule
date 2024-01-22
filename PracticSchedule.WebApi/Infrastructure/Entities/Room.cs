using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticSchedule.WebApi.Infrastructure.Entities
{
    public class Room
    {
        [Key]
        [Column(Order = 1)]
        public Guid RoomId { get; set; }
        [MaxLength(50, ErrorMessage = "Name can't be longer than 50 characters")]
        public string Name { get; set; } = string.Empty;
        [InverseProperty(nameof(Room))]
        public ICollection<Schedule>? Schedules { get; set; }
        public ICollection<ScheduleOfStudent>? ScheduleOfStudents { get; set; }
    }
}
