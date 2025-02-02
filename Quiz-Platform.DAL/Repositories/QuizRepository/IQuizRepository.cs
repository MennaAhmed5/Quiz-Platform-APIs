using Quiz_Platform.DAL.Models;
using Quiz_Platform.DAL.Repositories.Generic_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Platform.DAL.Repositories.QuizRepository
{
    public interface IQuizRepository : IGenericRepository<Quize>
    {

        IEnumerable<Quize> GetLastXAddQuizzes(int x);
         
    }
}
