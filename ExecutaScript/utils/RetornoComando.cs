using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutaScript.utils
{
    public class RetornoComando
    {
        public int Codigo { get; set; }
        public String Mensagem { get; set; }


        public String ToString()
        {
            return string.Format("{0} {1}", Codigo, Mensagem);
        }

    }
}
