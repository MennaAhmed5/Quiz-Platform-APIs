using Quiz_Platform.DAL.Models;
using Quiz_Platform.DAL.Repositories.Generic_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Platform.DAL.Repositories.QuizRepository
{
    public class QuizRepository : GenericRepository<Quize>, IQuizRepository
    {
        private readonly QuizSystemContext _context;
        public QuizRepository(QuizSystemContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Quize> GetLastXAddQuizzes(int x)
        {
            return _context.Set<Quize>().OrderByDescending(q => q.Id).Take(x);
        }
    }
}
