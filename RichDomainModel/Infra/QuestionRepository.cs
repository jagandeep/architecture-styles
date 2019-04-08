using System.Collections.Generic;
using System.Linq;
using RichDomainModel.Domain;

namespace RichDomainModel.Infra
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly TriviaDbContext dbContext;

        public QuestionRepository(TriviaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Question> GetRandomForCategory(string categoryName, int nbQuestions)
        {
            return dbContext.Question.Take(nbQuestions).ToList();
        }
    }
}