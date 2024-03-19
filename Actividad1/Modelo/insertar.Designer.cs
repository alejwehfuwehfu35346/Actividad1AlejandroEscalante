namespace Modelo
{
    partial class insertar
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
            Isertar = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            actualizar = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Isertar
            // 
            Isertar.AutoSize = true;
            Isertar.Location = new Point(135, 97);
            Isertar.Name = "Isertar";
            Isertar.Size = new Size(46, 15);
            Isertar.TabIndex = 0;
            Isertar.Text = "Insertar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 147);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "OptenerID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 246);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Eliminar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 23);
            textBox2.TabIndex = 4;
            // 
            // actualizar
            // 
            actualizar.AutoSize = true;
            actualizar.Location = new Point(135, 198);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(57, 15);
            actualizar.TabIndex = 5;
            actualizar.Text = "actualizar";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(260, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(260, 243);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 23);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(306, 293);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(387, 293);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // insertar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(actualizar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Isertar);
            Name = "insertar";
            Text = "insertar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Isertar;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label actualizar;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}