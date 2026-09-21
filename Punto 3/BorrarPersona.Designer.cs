namespace repaso_POO.Punto_3
{
    partial class BorrarPersona
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
            button1 = new Button();
            button2 = new Button();
            cmb_Personas = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 104);
            button1.Name = "button1";
            button1.Size = new Size(111, 80);
            button1.TabIndex = 0;
            button1.Text = "Borrar Persona";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(149, 104);
            button2.Name = "button2";
            button2.Size = new Size(116, 80);
            button2.TabIndex = 1;
            button2.Text = "Ver Lista";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmb_Personas
            // 
            cmb_Personas.FormattingEnabled = true;
            cmb_Personas.Location = new Point(91, 59);
            cmb_Personas.Name = "cmb_Personas";
            cmb_Personas.Size = new Size(121, 23);
            cmb_Personas.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 31);
            label5.Name = "label5";
            label5.Size = new Size(206, 15);
            label5.TabIndex = 24;
            label5.Text = "Ingrese el ID de la persona a actualizar";
            // 
            // BorrarPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 218);
            Controls.Add(cmb_Personas);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BorrarPersona";
            Text = "BorrarPersona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox cmb_Personas;
        private Label label5;
    }
}