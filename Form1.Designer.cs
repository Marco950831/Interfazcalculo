
namespace InterfazSolar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Calcular = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox7 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox8 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox9 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // Calcular
            // 
            Calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Calcular.Location = new System.Drawing.Point(31, 317);
            Calcular.Name = "Calcular";
            Calcular.Size = new System.Drawing.Size(75, 23);
            Calcular.TabIndex = 0;
            Calcular.Text = "Calcular ";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.HighlightText;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(40, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 19);
            label1.TabIndex = 1;
            label1.Text = "Tarifa";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Info;
            textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            textBox1.Location = new System.Drawing.Point(40, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(40, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(40, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(40, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(40, 221);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(100, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(40, 250);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(100, 23);
            textBox6.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(411, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 15);
            label2.TabIndex = 8;
            label2.Text = "Hps";
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(468, 54);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(100, 23);
            textBox7.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(600, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 15);
            label3.TabIndex = 10;
            label3.Text = "P/mes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label4.Location = new System.Drawing.Point(365, 117);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 15);
            label4.TabIndex = 11;
            label4.Text = "Potencia/Panel";
            // 
            // textBox8
            // 
            textBox8.Location = new System.Drawing.Point(468, 114);
            textBox8.Name = "textBox8";
            textBox8.Size = new System.Drawing.Size(100, 23);
            textBox8.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(365, 290);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(110, 15);
            label5.TabIndex = 13;
            label5.Text = "Numero de Paneles";
            label5.Click += label5_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new System.Drawing.Point(506, 287);
            textBox9.Name = "textBox9";
            textBox9.Size = new System.Drawing.Size(100, 23);
            textBox9.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ControlText;
            label6.Location = new System.Drawing.Point(40, 74);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(108, 15);
            label6.TabIndex = 15;
            label6.Text = "Consumo Bimestre";
            label6.Click += label6_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "01", "DAC", "PDBT" });
            listBox1.Location = new System.Drawing.Point(163, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(120, 34);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(821, 450);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(textBox9);
            Controls.Add(label5);
            Controls.Add(textBox8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox7);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Calcular);
            ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
    }
}

