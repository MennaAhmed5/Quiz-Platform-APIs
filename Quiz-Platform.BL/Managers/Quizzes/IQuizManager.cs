using Quiz_Platform.BL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Platform.BL.Managers.Quizzes
{
    public interface IQuizManager  
    {
        IEnumerable<QuizReadDto> GetLastXaddQuiz(int x);
    }
}
