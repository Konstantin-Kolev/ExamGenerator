using ExamGenerator.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ExamGenerator.Data.Seeding
{
    public class QuestionTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if(dbContext.QuestionTypes.Any())
            {
                return;
            }

            string[] questionTypes = new string[] { "Правопис", "Граматика", "Пунктуация", "Лексика" };

            foreach (string questionType in questionTypes)
            {
                await dbContext.QuestionTypes.AddAsync(new QuestionType
                {
                    SubjectId = SubjectSeeder.SubjectId,
                    Type = questionType
                });
            }
        }
    }
}
