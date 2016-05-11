namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.nombresito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ContV = new System.Windows.Forms.Label();
            this.ContM = new System.Windows.Forms.Label();
            this.contador = new System.Windows.Forms.TextBox();
            this.Dimension = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nombresito
            // 
            this.nombresito.AutoSize = true;
            this.nombresito.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nombresito.Location = new System.Drawing.Point(65, 64);
            this.nombresito.Name = "nombresito";
            this.nombresito.Size = new System.Drawing.Size(118, 13);
            this.nombresito.TabIndex = 8;
            this.nombresito.Text = "AQUI VA TU NOMBRE";
            this.nombresito.Click += new System.EventHandler(this.nombresito_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(229, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "GAME OF LIFE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(613, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(529, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "CELULAS VIVAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(646, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "CELULAS MUERTAS";
            // 
            // ContV
            // 
            this.ContV.AutoSize = true;
            this.ContV.BackColor = System.Drawing.SystemColors.Info;
            this.ContV.Location = new System.Drawing.Point(565, 119);
            this.ContV.Name = "ContV";
            this.ContV.Size = new System.Drawing.Size(16, 13);
            this.ContV.TabIndex = 16;
            this.ContV.Text = "...";
            // 
            // ContM
            // 
            this.ContM.AutoSize = true;
            this.ContM.BackColor = System.Drawing.SystemColors.Info;
            this.ContM.Location = new System.Drawing.Point(698, 119);
            this.ContM.Name = "ContM";
            this.ContM.Size = new System.Drawing.Size(16, 13);
            this.ContM.TabIndex = 15;
            this.ContM.Text = "...";
            // 
            // contador
            // 
            this.contador.Location = new System.Drawing.Point(600, 325);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(100, 20);
            this.contador.TabIndex = 14;
            // 
            // Dimension
            // 
            this.Dimension.BackColor = System.Drawing.Color.Red;
            this.Dimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dimension.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Dimension.FormattingEnabled = true;
            this.Dimension.Items.AddRange(new object[] {
            "  5 X 5",
            "  6 X 6",
            "  7 X 7",
            "  8 X 8",
            "  9 X 9",
            "10 X10"});
            this.Dimension.Location = new System.Drawing.Point(546, 32);
            this.Dimension.Name = "Dimension";
            this.Dimension.Size = new System.Drawing.Size(180, 21);
            this.Dimension.TabIndex = 20;
            this.Dimension.Text = "DIMENSION DE LA TABLA";
            this.Dimension.SelectedIndexChanged += new System.EventHandler(this.Dimension_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(769, 464);
            this.Controls.Add(this.Dimension);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContV);
            this.Controls.Add(this.ContM);
            this.Controls.Add(this.contador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombresito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombresito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ContV;
        private System.Windows.Forms.Label ContM;
        private System.Windows.Forms.TextBox contador;
        private System.Windows.Forms.ComboBox Dimension;
    }
}


