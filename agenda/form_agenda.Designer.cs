namespace agenda
{
    partial class form_agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_agenda));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textinsta = new System.Windows.Forms.TextBox();
            this.textendereco = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textcelular = new System.Windows.Forms.TextBox();
            this.texttelefone = new System.Windows.Forms.TextBox();
            this.textsobrenome = new System.Windows.Forms.TextBox();
            this.textnome = new System.Windows.Forms.TextBox();
            this.buttonatualizar = new System.Windows.Forms.Button();
            this.buttonexcluir = new System.Windows.Forms.Button();
            this.buttonsalvar = new System.Windows.Forms.Button();
            this.dataGridlista = new System.Windows.Forms.DataGridView();
            this.textBoxPESQUISA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonbUSCAR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Instagram:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.textinsta);
            this.panel1.Controls.Add(this.textendereco);
            this.panel1.Controls.Add(this.textemail);
            this.panel1.Controls.Add(this.textcelular);
            this.panel1.Controls.Add(this.texttelefone);
            this.panel1.Controls.Add(this.textsobrenome);
            this.panel1.Controls.Add(this.textnome);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 403);
            this.panel1.TabIndex = 1;
            // 
            // textinsta
            // 
            this.textinsta.Location = new System.Drawing.Point(86, 167);
            this.textinsta.MaxLength = 45;
            this.textinsta.Name = "textinsta";
            this.textinsta.Size = new System.Drawing.Size(248, 20);
            this.textinsta.TabIndex = 5;
            // 
            // textendereco
            // 
            this.textendereco.Location = new System.Drawing.Point(86, 201);
            this.textendereco.MaxLength = 250;
            this.textendereco.Multiline = true;
            this.textendereco.Name = "textendereco";
            this.textendereco.Size = new System.Drawing.Size(248, 118);
            this.textendereco.TabIndex = 6;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(86, 136);
            this.textemail.MaxLength = 45;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(248, 20);
            this.textemail.TabIndex = 4;
            // 
            // textcelular
            // 
            this.textcelular.Location = new System.Drawing.Point(86, 106);
            this.textcelular.MaxLength = 45;
            this.textcelular.Name = "textcelular";
            this.textcelular.Size = new System.Drawing.Size(248, 20);
            this.textcelular.TabIndex = 3;
            // 
            // texttelefone
            // 
            this.texttelefone.Location = new System.Drawing.Point(86, 76);
            this.texttelefone.MaxLength = 45;
            this.texttelefone.Name = "texttelefone";
            this.texttelefone.Size = new System.Drawing.Size(248, 20);
            this.texttelefone.TabIndex = 2;
            // 
            // textsobrenome
            // 
            this.textsobrenome.Location = new System.Drawing.Point(86, 46);
            this.textsobrenome.MaxLength = 100;
            this.textsobrenome.Name = "textsobrenome";
            this.textsobrenome.Size = new System.Drawing.Size(248, 20);
            this.textsobrenome.TabIndex = 1;
            // 
            // textnome
            // 
            this.textnome.Location = new System.Drawing.Point(86, 15);
            this.textnome.MaxLength = 45;
            this.textnome.Name = "textnome";
            this.textnome.Size = new System.Drawing.Size(248, 20);
            this.textnome.TabIndex = 0;
            // 
            // buttonatualizar
            // 
            this.buttonatualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonatualizar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonatualizar.Image = global::agenda.Properties.Resources.alterar;
            this.buttonatualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonatualizar.Location = new System.Drawing.Point(133, 420);
            this.buttonatualizar.Name = "buttonatualizar";
            this.buttonatualizar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonatualizar.Size = new System.Drawing.Size(127, 51);
            this.buttonatualizar.TabIndex = 5;
            this.buttonatualizar.Text = "Atualizar";
            this.buttonatualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonatualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonatualizar.UseVisualStyleBackColor = false;
            this.buttonatualizar.Click += new System.EventHandler(this.buttonatualizar_Click);
            // 
            // buttonexcluir
            // 
            this.buttonexcluir.BackColor = System.Drawing.Color.IndianRed;
            this.buttonexcluir.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonexcluir.Image = global::agenda.Properties.Resources.delete_user;
            this.buttonexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonexcluir.Location = new System.Drawing.Point(265, 420);
            this.buttonexcluir.Name = "buttonexcluir";
            this.buttonexcluir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonexcluir.Size = new System.Drawing.Size(118, 51);
            this.buttonexcluir.TabIndex = 4;
            this.buttonexcluir.Text = "Excluir";
            this.buttonexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonexcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonexcluir.UseVisualStyleBackColor = false;
            this.buttonexcluir.Click += new System.EventHandler(this.buttonexcluir_Click);
            // 
            // buttonsalvar
            // 
            this.buttonsalvar.BackColor = System.Drawing.SystemColors.Info;
            this.buttonsalvar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalvar.Image = global::agenda.Properties.Resources.add_contact;
            this.buttonsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonsalvar.Location = new System.Drawing.Point(13, 420);
            this.buttonsalvar.Name = "buttonsalvar";
            this.buttonsalvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonsalvar.Size = new System.Drawing.Size(115, 51);
            this.buttonsalvar.TabIndex = 2;
            this.buttonsalvar.Text = "Salvar";
            this.buttonsalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonsalvar.UseVisualStyleBackColor = false;
            this.buttonsalvar.Click += new System.EventHandler(this.buttonsalvar_Click);
            // 
            // dataGridlista
            // 
            this.dataGridlista.AllowUserToAddRows = false;
            this.dataGridlista.AllowUserToDeleteRows = false;
            this.dataGridlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridlista.Location = new System.Drawing.Point(405, 57);
            this.dataGridlista.Name = "dataGridlista";
            this.dataGridlista.ReadOnly = true;
            this.dataGridlista.Size = new System.Drawing.Size(844, 414);
            this.dataGridlista.TabIndex = 6;
            this.dataGridlista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridlista_MouseDoubleClick);
            // 
            // textBoxPESQUISA
            // 
            this.textBoxPESQUISA.Location = new System.Drawing.Point(487, 21);
            this.textBoxPESQUISA.Name = "textBoxPESQUISA";
            this.textBoxPESQUISA.Size = new System.Drawing.Size(185, 20);
            this.textBoxPESQUISA.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Pesquisar:";
            // 
            // buttonbUSCAR
            // 
            this.buttonbUSCAR.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonbUSCAR.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonbUSCAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonbUSCAR.Location = new System.Drawing.Point(678, 12);
            this.buttonbUSCAR.Name = "buttonbUSCAR";
            this.buttonbUSCAR.Size = new System.Drawing.Size(139, 35);
            this.buttonbUSCAR.TabIndex = 9;
            this.buttonbUSCAR.Text = "Pesquisar";
            this.buttonbUSCAR.UseVisualStyleBackColor = false;
            this.buttonbUSCAR.Click += new System.EventHandler(this.buttonbUSCAR_Click);
            // 
            // form_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 480);
            this.Controls.Add(this.buttonbUSCAR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPESQUISA);
            this.Controls.Add(this.dataGridlista);
            this.Controls.Add(this.buttonatualizar);
            this.Controls.Add(this.buttonexcluir);
            this.Controls.Add(this.buttonsalvar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_agenda";
            this.Text = "Agenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textinsta;
        private System.Windows.Forms.TextBox textendereco;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textcelular;
        private System.Windows.Forms.TextBox texttelefone;
        private System.Windows.Forms.TextBox textsobrenome;
        private System.Windows.Forms.TextBox textnome;
        private System.Windows.Forms.Button buttonsalvar;
        private System.Windows.Forms.Button buttonexcluir;
        private System.Windows.Forms.Button buttonatualizar;
        private System.Windows.Forms.DataGridView dataGridlista;
        private System.Windows.Forms.TextBox textBoxPESQUISA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonbUSCAR;
    }
}

