namespace repaso_POO.Punto_3
{
    partial class ActualizarRegistros
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
            btn_VerLista = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Actualizar = new Button();
            txt_Numero = new TextBox();
            txt_DNI = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            label5 = new Label();
            cmb_Personas = new ComboBox();
            SuspendLayout();
            // 
            // btn_VerLista
            // 
            btn_VerLista.Location = new Point(72, 215);
            btn_VerLista.Name = "btn_VerLista";
            btn_VerLista.Size = new Size(108, 88);
            btn_VerLista.TabIndex = 21;
            btn_VerLista.Text = "Ver Lista";
            btn_VerLista.UseVisualStyleBackColor = true;
            btn_VerLista.Click += btn_VerLista_Click;
            // 
            // label4
            // 
            label4.Location = new Point(9, 153);
            label4.Name = "label4";
            label4.Size = new Size(183, 41);
            label4.TabIndex = 20;
            label4.Text = "Ingrese el numero telefonico de la persona";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 137);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 19;
            label3.Text = "Ingrese el DNI de la persona";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 105);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 18;
            label2.Text = "Ingrese el apellido de la persona";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 76);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 17;
            label1.Text = "Ingrese el nombre de la persona";
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(242, 215);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(108, 88);
            btn_Actualizar.TabIndex = 15;
            btn_Actualizar.Text = "Actualizar Persona";
            btn_Actualizar.UseVisualStyleBackColor = true;
            btn_Actualizar.Click += btn_Actualizar_Click_1;
            // 
            // txt_Numero
            // 
            txt_Numero.Location = new Point(198, 163);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(115, 23);
            txt_Numero.TabIndex = 14;
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(198, 134);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(115, 23);
            txt_DNI.TabIndex = 13;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(198, 105);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(115, 23);
            txt_Apellido.TabIndex = 12;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(198, 76);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(115, 23);
            txt_Nombre.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 45);
            label5.Name = "label5";
            label5.Size = new Size(206, 15);
            label5.TabIndex = 22;
            label5.Text = "Ingrese el ID de la persona a actualizar";
            // 
            // cmb_Personas
            // 
            cmb_Personas.FormattingEnabled = true;
            cmb_Personas.Location = new Point(229, 37);
            cmb_Personas.Name = "cmb_Personas";
            cmb_Personas.Size = new Size(121, 23);
            cmb_Personas.TabIndex = 23;
            cmb_Personas.SelectedIndexChanged += cmb_Personas_SelectedIndexChanged;
            // 
            // ActualizarRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 325);
            Controls.Add(cmb_Personas);
            Controls.Add(label5);
            Controls.Add(btn_VerLista);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Actualizar);
            Controls.Add(txt_Numero);
            Controls.Add(txt_DNI);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Name = "ActualizarRegistros";
            Text = "ActualizarRegistros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_VerLista;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Actualizar;
        private TextBox txt_Numero;
        private TextBox txt_DNI;
        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private Label label5;
        private ComboBox cmb_Personas;
    }
}