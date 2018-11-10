using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoBuilder.Quizz
{
    public class Process
    {
        public QuizzResponseRequest initResponseRequest()
        {
            QuizzResponseRequest quizzResponse = new QuizzResponseRequest();

            quizzResponse.Id = 1;
            quizzResponse.Id_candidat = 2;
            quizzResponse.Id_techno = 4;
            quizzResponse.Libelle = "Questionnaire C#";
            quizzResponse.Questions = GetQuestions();
            return quizzResponse;
        }
        private List<Question> GetQuestions()
        {
            var listQuestions = new List<Question>();
            listQuestions.Add(new Question(1, "Qu'est ce qu'une classe privée?"));
            listQuestions.Add(new Question(2, "Qu'est ce qu'une classe public?"));
            listQuestions.Add(new Question(3, "Qu'est ce qu'une classe internal?"));
            listQuestions.Add(new Question(4, "Qu'est ce qu'une interface?"));
            listQuestions.Add(new Question(5, "Qu'est ce qu'un objet?"));
            listQuestions.Add(new Question(6, "Comment instancie t on un objet?"));
            listQuestions.Add(new Question(7, "Qu'est ce qu'une classe?"));
            listQuestions.Add(new Question(8, "Qu'est ce qu'une expression lambda?"));
            listQuestions.Add(new Question(9, "Qu'est ce qu'un design pattern?"));
            listQuestions.Add(new Question(10, "Citer deux design pattern?"));
            listQuestions.Add(new Question(11, "qu'est ce qu'une propriete?"));


            return listQuestions;
        }

    }
}
