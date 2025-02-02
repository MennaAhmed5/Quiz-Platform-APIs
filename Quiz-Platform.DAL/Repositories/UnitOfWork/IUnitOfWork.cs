using Quiz_Platform.DAL.Repositories.QuizRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Platform.DAL.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IQuizRepository QuizRepository { get; }
        void SaveChanges();
    }
}
