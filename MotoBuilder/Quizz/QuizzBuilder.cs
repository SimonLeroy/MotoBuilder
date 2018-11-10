using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoBuilder.Quizz
{
    public class QuizzBuilder : IQuizzBuilder
    {
        Quizz objQuizz = new Quizz();

        Quizz IQuizzBuilder.GetQuizz()
        {
            return objQuizz;
        }

        void IQuizzBuilder.SetID(int id)
        {
            objQuizz.Id = id;
        }

        void IQuizzBuilder.SetIdCandidat(int id)
        {
            objQuizz.Id_candidat = id;
        }

        void IQuizzBuilder.SetIdTechno(int id)
        {
            objQuizz.Id_techno = id;
        }

        void IQuizzBuilder.SetLibelle(string libelle)
        {
            objQuizz.Libelle = libelle;
        }

        void IQuizzBuilder.SetQuestions(List<Question>questions)
        {
            objQuizz.Questions.AddRange(questions);
        }
    }
}
