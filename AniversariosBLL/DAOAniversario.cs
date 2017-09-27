using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniversariosBLL
{
    public interface DAOAniversario
    {
        List<Aniversario> buscarAniversarios();
        Boolean cadastarAniversario(Aniversario aniversario);
    }
}
