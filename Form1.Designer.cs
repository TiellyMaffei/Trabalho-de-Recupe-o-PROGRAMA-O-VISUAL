
namespace Trabalho_de_Recupeção_PROGRAMAÇÃO_VISUAL
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
            this.btnAtividade1 = new System.Windows.Forms.Button();
            this.btnAtividade2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtividade1
            // 
            this.btnAtividade1.Location = new System.Drawing.Point(178, 117);
            this.btnAtividade1.Name = "btnAtividade1";
            this.btnAtividade1.Size = new System.Drawing.Size(165, 50);
            this.btnAtividade1.TabIndex = 0;
            this.btnAtividade1.Text = "CALCULADORA DE IMC";
            this.btnAtividade1.UseVisualStyleBackColor = true;
            this.btnAtividade1.Click += new System.EventHandler(this.btnAtividade1_Click);
            // 
            // btnAtividade2
            // 
            this.btnAtividade2.Location = new System.Drawing.Point(378, 117);
            this.btnAtividade2.Name = "btnAtividade2";
            this.btnAtividade2.Size = new System.Drawing.Size(181, 50);
            this.btnAtividade2.TabIndex = 1;
            this.btnAtividade2.Text = "FORMA GEOMETRICA";
            this.btnAtividade2.UseVisualStyleBackColor = true;
            this.btnAtividade2.Click += new System.EventHandler(this.btnAtividade2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 323);
            this.Controls.Add(this.btnAtividade2);
            this.Controls.Add(this.btnAtividade1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtividade1;
        private System.Windows.Forms.Button btnAtividade2;
    }
}

