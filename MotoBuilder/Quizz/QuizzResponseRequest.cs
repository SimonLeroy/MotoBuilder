using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoBuilder.Quizz
{
     public class QuizzResponseRequest
    {
        private int id_candidat;
        private List<Question> questions;
        private int id;
        private string libelle;
        private int id_techno;

        public int Id_candidat { get => id_candidat; set => id_candidat = value; }
        public List<Question> Questions { get => questions; set => questions = value; }
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int Id_techno { get => id_techno; set => id_techno = value; }

        public QuizzResponseRequest()
        {
            Questions = new List<Question>();
        }

    }
}
