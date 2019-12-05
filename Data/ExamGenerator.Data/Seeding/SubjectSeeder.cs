using System;
using System.Linq;
using System.Threading.Tasks;
using ExamGenerator.Data.Models;

namespace ExamGenerator.Data.Seeding
{
    public class SubjectSeeder : ISeeder
    {
        public const int SubjectId = 1;
        public const string SubjectName = "Български език";

        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Subjects.Any())
            {
                return;
            }

            var subject = new Subject
            {
                Id = SubjectId,
                Name = SubjectName
            };
            await dbContext.Subjects.AddAsync(subject);
        }
    }
}
