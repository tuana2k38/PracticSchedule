using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticSchedule.WebApi.Infrastructure.Entities
{
    public class Schedule
    {
        [Key]
        [Column(Order = 1)]
        public Guid ScheduleId { get; set; }
        [Range(0, 2359)]
        public int StartTime { get; set; }
        [Range(0, 2359)]
        public int EndTime { get; set; }
        [ForeignKey(nameof(Room))]
        public Guid RoomId { get; set; }
        public Room? Room { get; set; }
        [ForeignKey(nameof(Teacher))]
        public Guid TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        [ForeignKey(nameof(Subject))]
        public Guid SubjectId { get; set; }
        public Subject? Subject { get; set; }
    }
}
