using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoBuilder.Quizz
{
    public class QuizzCreator
    {
        private readonly IQuizzBuilder quizzBuilder;

        public QuizzCreator(IQuizzBuilder builder)
        {
            quizzBuilder = builder;
        }

        public void CreateQuizz(QuizzResponseRequest responseRequest)
        {
            quizzBuilder.SetID(responseRequest.Id);
            quizzBuilder.SetIdCandidat(responseRequest.Id_candidat);
            quizzBuilder.SetIdTechno(responseRequest.Id_techno);
            quizzBuilder.SetLibelle(responseRequest.Libelle);
            quizzBuilder.SetQuestions(responseRequest.Questions);
        }
        public Quizz GetQuizz()
        {
            return quizzBuilder.GetQuizz();
        }

    }
}
