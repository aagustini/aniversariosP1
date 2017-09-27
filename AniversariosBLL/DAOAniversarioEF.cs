using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniversariosBLL
{
    class DAOAniversarioEF : DAOAniversario
    {

        private AniversariosContext db = new AniversariosContext();

        public List<Aniversario> buscarAniversarios()
        {
            return db.Aniversarios.ToList();
        }

        public bool cadastarAniversario(Aniversario aniversario)
        {
            db.Aniversarios.Add(aniversario);
            db.SaveChanges();
            return true;
        }
    }
}
