using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoBuilder.Quizz
{
    public class Quizz
    {
        private int id_candidat;
        private List<Question>questions;
        private int id;
        private string libelle;
        private int id_techno;

        public int Id_candidat { get => id_candidat; set => id_candidat = value; }
        public List<Question> Questions { get => questions; set => questions = value; }
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int Id_techno { get => id_techno; set => id_techno = value; }

        public Quizz()
        {
            Questions = new List<Question>();
        }

        public void ShowInfo()
        {
            Console.WriteLine("Idcandidat: {0}", Id_candidat);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Libelle: {0}", Libelle);
            Console.WriteLine("Idtechno: {0}", Id_techno);
            Console.WriteLine("Questions:");
            foreach (var question in Questions)
            {
                Console.WriteLine("\t{0}", question);
            }
        }
    }
}
