namespace pryApellidoControlesBasicos
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkKet = new System.Windows.Forms.CheckBox();
            this.chkmayo = new System.Windows.Forms.CheckBox();
            this.chkpicante = new System.Windows.Forms.CheckBox();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.lblEscribirTexto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.optRed = new System.Windows.Forms.RadioButton();
            this.optBlue = new System.Windows.Forms.RadioButton();
            this.cboAdicional = new System.Windows.Forms.ComboBox();
            this.cmdElegir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkKet);
            this.groupBox1.Controls.Add(this.chkmayo);
            this.groupBox1.Controls.Add(this.chkpicante);
            this.groupBox1.Location = new System.Drawing.Point(21, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkKet
            // 
            this.chkKet.AutoSize = true;
            this.chkKet.Location = new System.Drawing.Point(27, 102);
            this.chkKet.Name = "chkKet";
            this.chkKet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkKet.Size = new System.Drawing.Size(32, 17);
            this.chkKet.TabIndex = 2;
            this.chkKet.Text = "k";
            this.chkKet.UseVisualStyleBackColor = true;
            // 
            // chkmayo
            // 
            this.chkmayo.AutoSize = true;
            this.chkmayo.Location = new System.Drawing.Point(27, 65);
            this.chkmayo.Name = "chkmayo";
            this.chkmayo.Size = new System.Drawing.Size(51, 17);
            this.chkmayo.TabIndex = 1;
            this.chkmayo.Text = "mayo";
            this.chkmayo.UseVisualStyleBackColor = true;
            // 
            // chkpicante
            // 
            this.chkpicante.AutoSize = true;
            this.chkpicante.Location = new System.Drawing.Point(27, 30);
            this.chkpicante.Name = "chkpicante";
            this.chkpicante.Size = new System.Drawing.Size(61, 17);
            this.chkpicante.TabIndex = 0;
            this.chkpicante.Text = "picante";
            this.chkpicante.UseVisualStyleBackColor = true;
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Location = new System.Drawing.Point(34, 362);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(75, 23);
            this.cmdAsignar.TabIndex = 1;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEscribirTexto
            // 
            this.lblEscribirTexto.AutoSize = true;
            this.lblEscribirTexto.Location = new System.Drawing.Point(257, 197);
            this.lblEscribirTexto.Name = "lblEscribirTexto";
            this.lblEscribirTexto.Size = new System.Drawing.Size(35, 13);
            this.lblEscribirTexto.TabIndex = 2;
            this.lblEscribirTexto.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 3;
            // 
            // optRed
            // 
            this.optRed.AutoSize = true;
            this.optRed.Location = new System.Drawing.Point(245, 135);
            this.optRed.Name = "optRed";
            this.optRed.Size = new System.Drawing.Size(47, 17);
            this.optRed.TabIndex = 4;
            this.optRed.TabStop = true;
            this.optRed.Text = "Rojo";
            this.optRed.UseVisualStyleBackColor = true;
            this.optRed.CheckedChanged += new System.EventHandler(this.optRed_CheckedChanged);
            // 
            // optBlue
            // 
            this.optBlue.AutoSize = true;
            this.optBlue.Location = new System.Drawing.Point(336, 135);
            this.optBlue.Name = "optBlue";
            this.optBlue.Size = new System.Drawing.Size(45, 17);
            this.optBlue.TabIndex = 5;
            this.optBlue.TabStop = true;
            this.optBlue.Text = "Azul";
            this.optBlue.UseVisualStyleBackColor = true;
            // 
            // cboAdicional
            // 
            this.cboAdicional.FormattingEnabled = true;
            this.cboAdicional.Location = new System.Drawing.Point(245, 362);
            this.cboAdicional.Name = "cboAdicional";
            this.cboAdicional.Size = new System.Drawing.Size(121, 21);
            this.cboAdicional.TabIndex = 7;
            this.cboAdicional.SelectedIndexChanged += new System.EventHandler(this.cboAdicional_SelectedIndexChanged);
            // 
            // cmdElegir
            // 
            this.cmdElegir.Location = new System.Drawing.Point(446, 135);
            this.cmdElegir.Name = "cmdElegir";
            this.cmdElegir.Size = new System.Drawing.Size(75, 23);
            this.cmdElegir.TabIndex = 8;
            this.cmdElegir.Text = "Elegir";
            this.cmdElegir.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdElegir);
            this.Controls.Add(this.cboAdicional);
            this.Controls.Add(this.optBlue);
            this.Controls.Add(this.optRed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEscribirTexto);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkKet;
        private System.Windows.Forms.CheckBox chkmayo;
        private System.Windows.Forms.CheckBox chkpicante;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.Label lblEscribirTexto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton optRed;
        private System.Windows.Forms.RadioButton optBlue;
        private System.Windows.Forms.ComboBox cboAdicional;
        private System.Windows.Forms.Button cmdElegir;
    }
}