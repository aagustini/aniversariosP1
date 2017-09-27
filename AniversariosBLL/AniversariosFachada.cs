using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniversariosBLL
{
    public class AniversariosFachada
    {
        private DAOAniversario dados = new DAOAniversarioEF();

        public List<Aniversario> buscarAniversarios() {
            return dados.buscarAniversarios(); }

        public Boolean cadastarAniversario(String nome, DateTime data) {
            dados.cadastarAniversario(new Aniversario { Nome = nome, DataAniversario = data });
            return true;
        }

    }
}
