using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutaScript.utils
{
    class Msg
    {
        public static bool Confirmacao(String titulo, String mensagem)
        {
            return (MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo) == DialogResult.Yes);
        }

        public static void Informacao(String titulo, String mensagem)
        {
            MessageBox.Show(mensagem, titulo);
        }

        public static void Erro(String titulo, String mensagem)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
