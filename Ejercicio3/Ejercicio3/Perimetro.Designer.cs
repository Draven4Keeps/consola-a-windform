namespace Ejercicio3
{
    partial class Perimetro
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lados1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Longitud1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero de lados del poligono";
            // 
            // Lados1
            // 
            this.Lados1.Location = new System.Drawing.Point(131, 64);
            this.Lados1.Name = "Lados1";
            this.Lados1.Size = new System.Drawing.Size(184, 22);
            this.Lados1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la longitud de un lado del poligono";
            // 
            // Longitud1
            // 
            this.Longitud1.Location = new System.Drawing.Point(131, 201);
            this.Longitud1.Name = "Longitud1";
            this.Longitud1.Size = new System.Drawing.Size(184, 22);
            this.Longitud1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular Perimetro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Perimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Longitud1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lados1);
            this.Controls.Add(this.label1);
            this.Name = "Perimetro";
            this.Text = "Perimetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lados1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Longitud1;
        private System.Windows.Forms.Button button1;
    }
}