using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoBuilder.Quizz
{
     public interface IQuizzBuilder
    {
        void SetIdCandidat(int id);
        void SetID(int id);
        void SetLibelle(string libelle);
        void SetIdTechno(int id);
        void SetQuestions(List<Question> question);

        Quizz GetQuizz();
    }
}
