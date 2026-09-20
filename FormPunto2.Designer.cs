namespace repaso_POO
{
    partial class FormPunto2
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textLegajo = new TextBox();
            textNota = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 47);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Alumnos";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(140, 351);
            button1.Name = "button1";
            button1.Size = new Size(215, 52);
            button1.TabIndex = 1;
            button1.Text = "Registrar Alumno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(143, 463);
            button2.Name = "button2";
            button2.Size = new Size(215, 36);
            button2.TabIndex = 2;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(143, 409);
            button3.Name = "button3";
            button3.Size = new Size(212, 48);
            button3.TabIndex = 3;
            button3.Text = "Lista de Alumnos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 56);
            label2.Name = "label2";
            label2.Size = new Size(338, 35);
            label2.TabIndex = 4;
            label2.Text = "Complete con los datos del alumno.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 115);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 5;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 159);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 6;
            label4.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 206);
            label5.Name = "label5";
            label5.Size = new Size(74, 32);
            label5.TabIndex = 7;
            label5.Text = "Legajo:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 252);
            label6.Name = "label6";
            label6.Size = new Size(59, 32);
            label6.TabIndex = 8;
            label6.Text = "Nota:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(106, 117);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(364, 31);
            textNombre.TabIndex = 9;
            textNombre.TextChanged += textBox1_TextChanged;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(106, 161);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(364, 31);
            textApellido.TabIndex = 10;
            // 
            // textLegajo
            // 
            textLegajo.Location = new Point(106, 208);
            textLegajo.Name = "textLegajo";
            textLegajo.Size = new Size(364, 31);
            textLegajo.TabIndex = 11;
            // 
            // textNota
            // 
            textNota.Location = new Point(106, 254);
            textNota.Name = "textNota";
            textNota.Size = new Size(364, 31);
            textNota.TabIndex = 12;
            // 
            // FormPunto2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 525);
            Controls.Add(textNota);
            Controls.Add(textLegajo);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FormPunto2";
            Text = "FormPunto2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textLegajo;
        private TextBox textNota;
        private Label label7;
    }
}