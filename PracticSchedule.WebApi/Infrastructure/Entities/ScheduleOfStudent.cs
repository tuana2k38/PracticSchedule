using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticSchedule.WebApi.Infrastructure.Entities
{
    public class ScheduleOfStudent
    {
        [Key]
        [Column(Order = 1)]
        public Guid ScheduleOfStudentId { get; set; }
        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set;}
        public Student? Student { get; set; }
        [ForeignKey(nameof(Room))]
        public Guid RoomId { get; set; }
        public Room? Room { get; set;}
    }
}
