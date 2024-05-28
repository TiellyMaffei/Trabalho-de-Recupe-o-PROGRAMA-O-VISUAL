
namespace Trabalho_de_Recupeção_PROGRAMAÇÃO_VISUAL
{
    partial class Form3
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
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbQuadrilatero = new System.Windows.Forms.RadioButton();
            this.txtDiametroA = new System.Windows.Forms.TextBox();
            this.txtDiametroB = new System.Windows.Forms.TextBox();
            this.txtDiametroC = new System.Windows.Forms.TextBox();
            this.txtDiametroD = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(166, 43);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(72, 17);
            this.rbCirculo.TabIndex = 0;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "CIRCULO";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(338, 43);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(88, 17);
            this.rbTriangulo.TabIndex = 1;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "TRIANGULO";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbQuadrilatero
            // 
            this.rbQuadrilatero.AutoSize = true;
            this.rbQuadrilatero.Location = new System.Drawing.Point(514, 43);
            this.rbQuadrilatero.Name = "rbQuadrilatero";
            this.rbQuadrilatero.Size = new System.Drawing.Size(110, 17);
            this.rbQuadrilatero.TabIndex = 2;
            this.rbQuadrilatero.TabStop = true;
            this.rbQuadrilatero.Text = "QUADRILATERO";
            this.rbQuadrilatero.UseVisualStyleBackColor = true;
            this.rbQuadrilatero.CheckedChanged += new System.EventHandler(this.rbQuadrilatero_CheckedChanged);
            // 
            // txtDiametroA
            // 
            this.txtDiametroA.Location = new System.Drawing.Point(297, 103);
            this.txtDiametroA.Name = "txtDiametroA";
            this.txtDiametroA.Size = new System.Drawing.Size(178, 20);
            this.txtDiametroA.TabIndex = 3;
            // 
            // txtDiametroB
            // 
            this.txtDiametroB.Location = new System.Drawing.Point(297, 138);
            this.txtDiametroB.Name = "txtDiametroB";
            this.txtDiametroB.Size = new System.Drawing.Size(178, 20);
            this.txtDiametroB.TabIndex = 4;
            // 
            // txtDiametroC
            // 
            this.txtDiametroC.Location = new System.Drawing.Point(297, 179);
            this.txtDiametroC.Name = "txtDiametroC";
            this.txtDiametroC.Size = new System.Drawing.Size(178, 20);
            this.txtDiametroC.TabIndex = 5;
            // 
            // txtDiametroD
            // 
            this.txtDiametroD.Location = new System.Drawing.Point(297, 220);
            this.txtDiametroD.Name = "txtDiametroD";
            this.txtDiametroD.Size = new System.Drawing.Size(178, 20);
            this.txtDiametroD.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(338, 268);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 33);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 318);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDiametroD);
            this.Controls.Add(this.txtDiametroC);
            this.Controls.Add(this.txtDiametroB);
            this.Controls.Add(this.txtDiametroA);
            this.Controls.Add(this.rbQuadrilatero);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.rbCirculo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbQuadrilatero;
        private System.Windows.Forms.TextBox txtDiametroA;
        private System.Windows.Forms.TextBox txtDiametroB;
        private System.Windows.Forms.TextBox txtDiametroC;
        private System.Windows.Forms.TextBox txtDiametroD;
        private System.Windows.Forms.Button btnCalcular;
    }
}