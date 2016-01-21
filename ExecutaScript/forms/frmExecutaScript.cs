using ExecutaScript.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecutaScript
{
    public partial class frmExecutaScript : Form
    {
        public String NomeArquivo { get; set; }

        public delegate void DelegateAdicionaResultado(String resultado);

        public DelegateAdicionaResultado dar;
        public frmExecutaScript()
        {
            InitializeComponent();
        }

        private void frmExecutaScript_Load(object sender, EventArgs e)
        {
            AjustaTitulo();

            btnExecutar.Tag = 0;
            AjustarTela();
            dar = new DelegateAdicionaResultado(AdicionaResultado);
            lblVersao.Text = "Versão " + Geral.getAssemblyVersion();
        }

        private void AjustaTitulo()
        {
            this.Text = String.Format("ExecutaScript - {0}", NomeArquivo);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if ((int)btnExecutar.Tag == 0)
            {


                if (txtScript.Text.Length <= 0)
                {
                    Msg.Informacao("Execução script", "Não há script para ser executado");
                    return;
                }
                if (!Msg.Confirmacao("Confirmação", "Confirmar execução do script ?"))
                    return;

                btnExecutar.Tag = 1;
                txtResultados.Clear();
                pb.Maximum = 100;
                pb.Value = 1;
                pb.Visible = true;

                bw.RunWorkerAsync();

            }
            else
            {
                if (bw.IsBusy)
                {
                    if (Msg.Confirmacao("Execução script", "Deseja realmente cancelar execução ???"))
                    {
                        bw.CancelAsync();
                        btnExecutar.Tag = 0;
                    }
                }
            }
            AjustarTela();
        }

        private void AjustarTela()
        {
            bool executando = (int)btnExecutar.Tag == 1;

            txtScript.Enabled = !executando;
            btnCarregar.Enabled = !executando;
            btnSalvarComo.Enabled = !executando;
            btnGravar.Enabled = !executando;
            btnExecutar.Text = (executando ? "Parar" : "Executar");
            pb.Visible = executando;

        }

        private void frmExecutaScript_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bw.IsBusy)
            {
                e.Cancel = true;
                Msg.Erro("Execução de script", "Para sair, pare a execução do script primeiro!");
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            int qtde = txtScript.Lines.Count();
            for (int pos = 0; pos <= qtde - 1; pos++)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    int progress = (int)((pos + 1.00) / qtde * 100.0);
                    RetornoComando result = ExecutarComando.ParseComando(txtScript.Lines[pos]);
                    this.Invoke(dar, new object[] { result.ToString() });
                    bw.ReportProgress(progress);
                }
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb.Value = e.ProgressPercentage;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnExecutar.Tag = 0;
            if (!e.Cancelled)
            {
                Msg.Informacao("Execução script", "Execução de script concluída");
            }
            else
            {
                Msg.Informacao("Execução script", "Execução de script foi CANCELADA pelo usuário");
            }
         
            AjustarTela();
        }

        public void AdicionaResultado(string resultado)
        {
            txtResultados.Text += String.Format("{0}{1}", resultado, Environment.NewLine);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtScript.Text = File.ReadAllText(ofd.FileName);
                NomeArquivo = ofd.FileName;
                AjustaTitulo();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(NomeArquivo))
            {
                SalvarComo();
            }
            else
            {
                SalvarScript(NomeArquivo);
            }
        }

        

        public bool SalvarComo()
        {
            bool ret = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ret = SalvarScript(sfd.FileName);
                NomeArquivo = sfd.FileName;
                AjustaTitulo();
            }
            return ret;
        }

        public bool SalvarScript(String arquivo)
        {
            bool ret = false;
            try {
                File.WriteAllText(arquivo, txtScript.Text);
                ret = true;
            } catch (Exception e)
            {
                Msg.Erro("Salvar script", "Erro gravando script!!!\n" + e.Message);
                ret = false;
            }
            

            return ret;
        }

        private void btnSalvarComo_Click(object sender, EventArgs e)
        {
            SalvarComo();
        }
    }

    


}
