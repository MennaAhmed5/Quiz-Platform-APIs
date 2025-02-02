using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quiz_Platform.BL.Dtos;
using Quiz_Platform.BL.Managers.Quizzes;

namespace QuizPlatform.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizzesController : ControllerBase
    {
        private readonly IQuizManager _quizManager;
 
        public QuizzesController(IQuizManager quizManager)
        {
            _quizManager = quizManager;
           
        }
        [HttpGet]
        [Route("{x}")]
        public ActionResult<IEnumerable<QuizReadDto>> GetLastXAddQuiz(int x)
        {
            var lastQuizzes = _quizManager.GetLastXaddQuiz(x);
            if (lastQuizzes is null)
            {
                return NotFound();
            }
            return lastQuizzes.ToList();
        }
    }
}
