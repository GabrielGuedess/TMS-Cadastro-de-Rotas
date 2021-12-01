
namespace TMS___Interface__Rotas_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label16;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Consult = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_Custo = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblCT = new System.Windows.Forms.Label();
            this.txtBox_ProxEnt = new System.Windows.Forms.TextBox();
            this.lblProxEnt = new System.Windows.Forms.Label();
            this.txtBox_DistTotal = new System.Windows.Forms.TextBox();
            this.lblDistTotal = new System.Windows.Forms.Label();
            this.cmbBox_Veiculo = new System.Windows.Forms.ComboBox();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.txtBox_Progresso = new System.Windows.Forms.TextBox();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.cmbBox_Moto = new System.Windows.Forms.ComboBox();
            this.lblMoto = new System.Windows.Forms.Label();
            this.txtBox_StatusVi = new System.Windows.Forms.TextBox();
            this.lblStatusVi = new System.Windows.Forms.Label();
            this.txtBox_IDRota = new System.Windows.Forms.TextBox();
            this.lblIDRota = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBox_Conhecimento = new System.Windows.Forms.TextBox();
            this.txtBox_Entrega = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(223)))));
            label16.Location = new System.Drawing.Point(269, 44);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(232, 24);
            label16.TabIndex = 9;
            label16.Text = "CADASTRO DE ROTAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Consult);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-4, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 457);
            this.panel1.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(445, 428);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Salvar";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Consult
            // 
            this.btn_Consult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consult.ForeColor = System.Drawing.Color.Black;
            this.btn_Consult.Location = new System.Drawing.Point(526, 428);
            this.btn_Consult.Name = "btn_Consult";
            this.btn_Consult.Size = new System.Drawing.Size(75, 23);
            this.btn_Consult.TabIndex = 8;
            this.btn_Consult.Text = "Consultar";
            this.btn_Consult.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.btn_Edit.Location = new System.Drawing.Point(607, 428);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "Alterar";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(688, 428);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Excluir";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(16, 428);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Sair";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_Entrega);
            this.groupBox1.Controls.Add(this.txtBox_Conhecimento);
            this.groupBox1.Controls.Add(this.txtBox_Custo);
            this.groupBox1.Controls.Add(this.lblCusto);
            this.groupBox1.Controls.Add(this.lblCT);
            this.groupBox1.Controls.Add(this.txtBox_ProxEnt);
            this.groupBox1.Controls.Add(this.lblProxEnt);
            this.groupBox1.Controls.Add(this.txtBox_DistTotal);
            this.groupBox1.Controls.Add(this.lblDistTotal);
            this.groupBox1.Controls.Add(this.cmbBox_Veiculo);
            this.groupBox1.Controls.Add(this.lblVeiculo);
            this.groupBox1.Controls.Add(this.txtBox_Progresso);
            this.groupBox1.Controls.Add(this.lblProgresso);
            this.groupBox1.Controls.Add(this.lblEntrega);
            this.groupBox1.Controls.Add(this.cmbBox_Moto);
            this.groupBox1.Controls.Add(this.lblMoto);
            this.groupBox1.Controls.Add(this.txtBox_StatusVi);
            this.groupBox1.Controls.Add(this.lblStatusVi);
            this.groupBox1.Controls.Add(this.txtBox_IDRota);
            this.groupBox1.Controls.Add(this.lblIDRota);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // txtBox_Custo
            // 
            this.txtBox_Custo.Location = new System.Drawing.Point(606, 106);
            this.txtBox_Custo.Name = "txtBox_Custo";
            this.txtBox_Custo.Size = new System.Drawing.Size(135, 20);
            this.txtBox_Custo.TabIndex = 55;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(517, 109);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(83, 13);
            this.lblCusto.TabIndex = 54;
            this.lblCusto.Text = "Custo Estimado:";
            // 
            // lblCT
            // 
            this.lblCT.AutoSize = true;
            this.lblCT.Location = new System.Drawing.Point(6, 151);
            this.lblCT.Name = "lblCT";
            this.lblCT.Size = new System.Drawing.Size(147, 13);
            this.lblCT.TabIndex = 52;
            this.lblCT.Text = "Conhecimento de Transporte:";
            // 
            // txtBox_ProxEnt
            // 
            this.txtBox_ProxEnt.Location = new System.Drawing.Point(350, 106);
            this.txtBox_ProxEnt.Name = "txtBox_ProxEnt";
            this.txtBox_ProxEnt.Size = new System.Drawing.Size(148, 20);
            this.txtBox_ProxEnt.TabIndex = 51;
            // 
            // lblProxEnt
            // 
            this.lblProxEnt.AutoSize = true;
            this.lblProxEnt.Location = new System.Drawing.Point(257, 109);
            this.lblProxEnt.Name = "lblProxEnt";
            this.lblProxEnt.Size = new System.Drawing.Size(87, 13);
            this.lblProxEnt.TabIndex = 50;
            this.lblProxEnt.Text = "Próxima Entrega:";
            // 
            // txtBox_DistTotal
            // 
            this.txtBox_DistTotal.Location = new System.Drawing.Point(93, 106);
            this.txtBox_DistTotal.Name = "txtBox_DistTotal";
            this.txtBox_DistTotal.Size = new System.Drawing.Size(135, 20);
            this.txtBox_DistTotal.TabIndex = 49;
            // 
            // lblDistTotal
            // 
            this.lblDistTotal.AutoSize = true;
            this.lblDistTotal.Location = new System.Drawing.Point(6, 109);
            this.lblDistTotal.Name = "lblDistTotal";
            this.lblDistTotal.Size = new System.Drawing.Size(81, 13);
            this.lblDistTotal.TabIndex = 48;
            this.lblDistTotal.Text = "Distância Total:";
            // 
            // cmbBox_Veiculo
            // 
            this.cmbBox_Veiculo.FormattingEnabled = true;
            this.cmbBox_Veiculo.Location = new System.Drawing.Point(586, 64);
            this.cmbBox_Veiculo.Name = "cmbBox_Veiculo";
            this.cmbBox_Veiculo.Size = new System.Drawing.Size(155, 21);
            this.cmbBox_Veiculo.TabIndex = 47;
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Location = new System.Drawing.Point(522, 67);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(58, 13);
            this.lblVeiculo.TabIndex = 46;
            this.lblVeiculo.Text = "Veículo(s):";
            // 
            // txtBox_Progresso
            // 
            this.txtBox_Progresso.Location = new System.Drawing.Point(326, 64);
            this.txtBox_Progresso.Name = "txtBox_Progresso";
            this.txtBox_Progresso.Size = new System.Drawing.Size(172, 20);
            this.txtBox_Progresso.TabIndex = 45;
            // 
            // lblProgresso
            // 
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.Location = new System.Drawing.Point(263, 67);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(57, 13);
            this.lblProgresso.TabIndex = 44;
            this.lblProgresso.Text = "Progresso:";
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Location = new System.Drawing.Point(6, 67);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(47, 13);
            this.lblEntrega.TabIndex = 42;
            this.lblEntrega.Text = "Entrega:";
            // 
            // cmbBox_Moto
            // 
            this.cmbBox_Moto.FormattingEnabled = true;
            this.cmbBox_Moto.Location = new System.Drawing.Point(592, 23);
            this.cmbBox_Moto.Name = "cmbBox_Moto";
            this.cmbBox_Moto.Size = new System.Drawing.Size(149, 21);
            this.cmbBox_Moto.TabIndex = 41;
            // 
            // lblMoto
            // 
            this.lblMoto.AutoSize = true;
            this.lblMoto.Location = new System.Drawing.Point(522, 26);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(64, 13);
            this.lblMoto.TabIndex = 40;
            this.lblMoto.Text = "Motorista(s):";
            // 
            // txtBox_StatusVi
            // 
            this.txtBox_StatusVi.Location = new System.Drawing.Point(353, 23);
            this.txtBox_StatusVi.Name = "txtBox_StatusVi";
            this.txtBox_StatusVi.Size = new System.Drawing.Size(145, 20);
            this.txtBox_StatusVi.TabIndex = 39;
            // 
            // lblStatusVi
            // 
            this.lblStatusVi.AutoSize = true;
            this.lblStatusVi.Location = new System.Drawing.Point(263, 26);
            this.lblStatusVi.Name = "lblStatusVi";
            this.lblStatusVi.Size = new System.Drawing.Size(84, 13);
            this.lblStatusVi.TabIndex = 38;
            this.lblStatusVi.Text = "Status (Viagem):";
            // 
            // txtBox_IDRota
            // 
            this.txtBox_IDRota.Location = new System.Drawing.Point(74, 23);
            this.txtBox_IDRota.Name = "txtBox_IDRota";
            this.txtBox_IDRota.Size = new System.Drawing.Size(154, 20);
            this.txtBox_IDRota.TabIndex = 37;
            // 
            // lblIDRota
            // 
            this.lblIDRota.AutoSize = true;
            this.lblIDRota.Location = new System.Drawing.Point(6, 26);
            this.lblIDRota.Name = "lblIDRota";
            this.lblIDRota.Size = new System.Drawing.Size(62, 13);
            this.lblIDRota.TabIndex = 36;
            this.lblIDRota.Text = "ID da Rota:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TMS___Interface__Rotas_.Properties.Resources.LOGOOFICIAL_2;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(12, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // txtBox_Conhecimento
            // 
            this.txtBox_Conhecimento.Location = new System.Drawing.Point(159, 148);
            this.txtBox_Conhecimento.Name = "txtBox_Conhecimento";
            this.txtBox_Conhecimento.Size = new System.Drawing.Size(198, 20);
            this.txtBox_Conhecimento.TabIndex = 11;
            // 
            // txtBox_Entrega
            // 
            this.txtBox_Entrega.Location = new System.Drawing.Point(64, 65);
            this.txtBox_Entrega.Name = "txtBox_Entrega";
            this.txtBox_Entrega.Size = new System.Drawing.Size(164, 20);
            this.txtBox_Entrega.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(4)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(771, 562);
            this.Controls.Add(label16);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Rotas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBox_Moto;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.TextBox txtBox_StatusVi;
        private System.Windows.Forms.Label lblStatusVi;
        private System.Windows.Forms.TextBox txtBox_IDRota;
        private System.Windows.Forms.Label lblIDRota;
        private System.Windows.Forms.TextBox txtBox_Custo;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblCT;
        private System.Windows.Forms.TextBox txtBox_ProxEnt;
        private System.Windows.Forms.Label lblProxEnt;
        private System.Windows.Forms.TextBox txtBox_DistTotal;
        private System.Windows.Forms.Label lblDistTotal;
        private System.Windows.Forms.ComboBox cmbBox_Veiculo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.TextBox txtBox_Progresso;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Consult;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txtBox_Conhecimento;
        private System.Windows.Forms.TextBox txtBox_Entrega;
    }
}

