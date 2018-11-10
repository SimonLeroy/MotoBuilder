using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoBuilder.Quizz
{

    public class Question
    {
        private int id;
        private string libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public Question() { }
        public Question(int id, string libelle)
        {
            Id = id;
            Libelle = libelle;

        }
        public override string ToString()
        {
            return Libelle;
        }
    }
}
