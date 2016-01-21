namespace ExecutaScript
{
    partial class frmExecutaScript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScript = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.tc = new System.Windows.Forms.TabControl();
            this.tpScript = new System.Windows.Forms.TabPage();
            this.tpResultado = new System.Windows.Forms.TabPage();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnGravar = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnSalvarComo = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.tc.SuspendLayout();
            this.tpScript.SuspendLayout();
            this.tpResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScript
            // 
            this.txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScript.Location = new System.Drawing.Point(3, 3);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtScript.Size = new System.Drawing.Size(940, 331);
            this.txtScript.TabIndex = 1;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutar.Location = new System.Drawing.Point(790, 7);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(173, 46);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(16, 431);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(799, 28);
            this.pb.TabIndex = 3;
            this.pb.Visible = false;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(16, 7);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(173, 46);
            this.btnCarregar.TabIndex = 4;
            this.btnCarregar.Text = "Abrir...";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // tc
            // 
            this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc.Controls.Add(this.tpScript);
            this.tc.Controls.Add(this.tpResultado);
            this.tc.Location = new System.Drawing.Point(16, 59);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(954, 366);
            this.tc.TabIndex = 5;
            // 
            // tpScript
            // 
            this.tpScript.Controls.Add(this.txtScript);
            this.tpScript.Location = new System.Drawing.Point(4, 25);
            this.tpScript.Name = "tpScript";
            this.tpScript.Padding = new System.Windows.Forms.Padding(3);
            this.tpScript.Size = new System.Drawing.Size(946, 337);
            this.tpScript.TabIndex = 0;
            this.tpScript.Text = "Script a executar";
            this.tpScript.UseVisualStyleBackColor = true;
            // 
            // tpResultado
            // 
            this.tpResultado.Controls.Add(this.txtResultados);
            this.tpResultado.Location = new System.Drawing.Point(4, 25);
            this.tpResultado.Name = "tpResultado";
            this.tpResultado.Padding = new System.Windows.Forms.Padding(3);
            this.tpResultado.Size = new System.Drawing.Size(723, 390);
            this.tpResultado.TabIndex = 1;
            this.tpResultado.Text = "Resultados";
            this.tpResultado.UseVisualStyleBackColor = true;
            // 
            // txtResultados
            // 
            this.txtResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultados.Location = new System.Drawing.Point(3, 3);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultados.Size = new System.Drawing.Size(717, 384);
            this.txtResultados.TabIndex = 2;
            // 
            // ofd
            // 
            this.ofd.Filter = "Todos os arquivos|*.*";
            this.ofd.Title = "Abrir script";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(195, 7);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(173, 46);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "Todos os arquivos|*.*";
            this.sfd.Title = "Salvar script como...";
            // 
            // btnSalvarComo
            // 
            this.btnSalvarComo.Location = new System.Drawing.Point(374, 7);
            this.btnSalvarComo.Name = "btnSalvarComo";
            this.btnSalvarComo.Size = new System.Drawing.Size(173, 46);
            this.btnSalvarComo.TabIndex = 7;
            this.btnSalvarComo.Text = "Salvar como...";
            this.btnSalvarComo.UseVisualStyleBackColor = true;
            this.btnSalvarComo.Click += new System.EventHandler(this.btnSalvarComo_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.Location = new System.Drawing.Point(821, 436);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(145, 23);
            this.lblVersao.TabIndex = 8;
            this.lblVersao.Text = "Versão 000.00.00.00";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmExecutaScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 471);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnSalvarComo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnExecutar);
            this.Name = "frmExecutaScript";
            this.Text = "ExecutaScript";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExecutaScript_FormClosing);
            this.Load += new System.EventHandler(this.frmExecutaScript_Load);
            this.tc.ResumeLayout(false);
            this.tpScript.ResumeLayout(false);
            this.tpScript.PerformLayout();
            this.tpResultado.ResumeLayout(false);
            this.tpResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Button btnCarregar;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tpScript;
        private System.Windows.Forms.TabPage tpResultado;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnSalvarComo;
        private System.Windows.Forms.Label lblVersao;
    }
}

