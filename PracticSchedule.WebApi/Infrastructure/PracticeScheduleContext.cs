using Microsoft.EntityFrameworkCore;
using PracticSchedule.WebApi.Infrastructure.Entities;

namespace PracticSchedule.WebApi.Infrastructure
{
    public class PracticeScheduleContext : DbContext
    {
        public PracticeScheduleContext(DbContextOptions<PracticeScheduleContext> options) : base(options) { }

        public DbSet<Room>? Rooms { get; set; }
        public DbSet<Schedule>? Schedules { get; set; }
        public DbSet<ScheduleOfStudent>? ScheduleOfStudents { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
        public DbSet<Teacher>? Teacchers { get; set; }
    }
}
