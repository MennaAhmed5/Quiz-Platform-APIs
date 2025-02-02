using Quiz_Platform.BL.Dtos;
using Quiz_Platform.DAL.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Platform.BL.Managers.Quizzes
{
    public class QuizManager : IQuizManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuizManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<QuizReadDto> GetLastXaddQuiz(int x)
        {
            var quizzes = _unitOfWork.QuizRepository.GetLastXAddQuizzes(x);
            return quizzes
                .Select(q => new QuizReadDto
                {
                    Id = q.Id,
                    Name = q.Name,
                    Description = q.Description,
                    Image = q.Image,
                    Date = q.Date
                });
        }
    }
}
