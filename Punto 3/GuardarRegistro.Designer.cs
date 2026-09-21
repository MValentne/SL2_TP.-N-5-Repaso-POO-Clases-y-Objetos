namespace repaso_POO.Punto_3
{
    partial class GuardarRegistro
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
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            txt_DNI = new TextBox();
            txt_Numero = new TextBox();
            btn_Guardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_VerLista = new Button();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(201, 45);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(115, 23);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(201, 74);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(115, 23);
            txt_Apellido.TabIndex = 1;
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(201, 103);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(115, 23);
            txt_DNI.TabIndex = 2;
            // 
            // txt_Numero
            // 
            txt_Numero.Location = new Point(201, 132);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(115, 23);
            txt_Numero.TabIndex = 3;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(192, 184);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(108, 88);
            btn_Guardar.TabIndex = 4;
            btn_Guardar.Text = "Guardar persona ";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingrese el nombre de la persona";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 74);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 7;
            label2.Text = "Ingrese el apellido de la persona";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 106);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 8;
            label3.Text = "Ingrese el DNI de la persona";
            // 
            // label4
            // 
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(183, 41);
            label4.TabIndex = 9;
            label4.Text = "Ingrese el numero telefonico de la persona";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_VerLista
            // 
            btn_VerLista.Location = new Point(56, 184);
            btn_VerLista.Name = "btn_VerLista";
            btn_VerLista.Size = new Size(108, 88);
            btn_VerLista.TabIndex = 10;
            btn_VerLista.Text = "Ver Lista";
            btn_VerLista.UseVisualStyleBackColor = true;
            btn_VerLista.Click += btn_VerLista_Click;
            // 
            // GuardarRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 284);
            Controls.Add(btn_VerLista);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Guardar);
            Controls.Add(txt_Numero);
            Controls.Add(txt_DNI);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Name = "GuardarRegistro";
            Text = "GuardarRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_DNI;
        private TextBox txt_Numero;
        private Button btn_Guardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_VerLista;
    }
}