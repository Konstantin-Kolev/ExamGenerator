using ExamGenerator.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExamGenerator.Data.Seeding
{
    public class QuestionSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Questions.Any())
            {
                return;
            }

            string jsonFilePath = "../../Data/ExamGenerator.Data/Seeding/Data/questions.json";
            string json = File.ReadAllText(jsonFilePath);
            IEnumerable<Question> questions = JsonConvert.DeserializeObject<IEnumerable<Question>>(json);

            await dbContext.Questions.AddRangeAsync(questions);
        }
    }
}
