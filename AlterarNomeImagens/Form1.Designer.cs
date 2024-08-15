namespace AlterarNomeImagens
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
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.txtIdsOld = new System.Windows.Forms.TextBox();
            this.txtIdsNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTargetFolderPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(12, 12);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(227, 20);
            this.txtFolderPath.TabIndex = 0;
            this.txtFolderPath.Text = "Caminho das Imagens";
            // 
            // txtIdsOld
            // 
            this.txtIdsOld.Location = new System.Drawing.Point(12, 94);
            this.txtIdsOld.MaxLength = 999999999;
            this.txtIdsOld.Multiline = true;
            this.txtIdsOld.Name = "txtIdsOld";
            this.txtIdsOld.Size = new System.Drawing.Size(227, 20);
            this.txtIdsOld.TabIndex = 1;
            this.txtIdsOld.Text = "Nome Atual";
            // 
            // txtIdsNew
            // 
            this.txtIdsNew.Location = new System.Drawing.Point(12, 146);
            this.txtIdsNew.MaxLength = 999999999;
            this.txtIdsNew.Multiline = true;
            this.txtIdsNew.Name = "txtIdsNew";
            this.txtIdsNew.Size = new System.Drawing.Size(227, 20);
            this.txtIdsNew.TabIndex = 2;
            this.txtIdsNew.Text = "Nome Novo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtTargetFolderPath
            // 
            this.txtTargetFolderPath.Location = new System.Drawing.Point(12, 51);
            this.txtTargetFolderPath.Name = "txtTargetFolderPath";
            this.txtTargetFolderPath.Size = new System.Drawing.Size(227, 20);
            this.txtTargetFolderPath.TabIndex = 5;
            this.txtTargetFolderPath.Text = "Caminho novo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Selecionar Caminho";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Selecionar caminho";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSelectTarget_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTargetFolderPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdsNew);
            this.Controls.Add(this.txtIdsOld);
            this.Controls.Add(this.txtFolderPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.TextBox txtIdsOld;
        private System.Windows.Forms.TextBox txtIdsNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTargetFolderPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

