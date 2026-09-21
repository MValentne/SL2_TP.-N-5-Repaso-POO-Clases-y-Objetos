namespace repaso_POO
{
    partial class FormPunto3
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
            btn_GuardarRegistro = new Button();
            btn_ActualizarRegistro = new Button();
            btn_BorrarRegistro = new Button();
            btn_CerrarForm = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_GuardarRegistro
            // 
            btn_GuardarRegistro.Location = new Point(12, 101);
            btn_GuardarRegistro.Name = "btn_GuardarRegistro";
            btn_GuardarRegistro.Size = new Size(96, 57);
            btn_GuardarRegistro.TabIndex = 0;
            btn_GuardarRegistro.Text = "Guardar Registro";
            btn_GuardarRegistro.UseVisualStyleBackColor = true;
            btn_GuardarRegistro.Click += btn_GuardarRegistro_Click;
            // 
            // btn_ActualizarRegistro
            // 
            btn_ActualizarRegistro.Location = new Point(114, 101);
            btn_ActualizarRegistro.Name = "btn_ActualizarRegistro";
            btn_ActualizarRegistro.Size = new Size(96, 57);
            btn_ActualizarRegistro.TabIndex = 1;
            btn_ActualizarRegistro.Text = "Actualizar Registro";
            btn_ActualizarRegistro.UseVisualStyleBackColor = true;
            btn_ActualizarRegistro.Click += btn_ActualizarRegistro_Click;
            // 
            // btn_BorrarRegistro
            // 
            btn_BorrarRegistro.Location = new Point(216, 101);
            btn_BorrarRegistro.Name = "btn_BorrarRegistro";
            btn_BorrarRegistro.Size = new Size(96, 57);
            btn_BorrarRegistro.TabIndex = 2;
            btn_BorrarRegistro.Text = "Borrar Registro";
            btn_BorrarRegistro.UseVisualStyleBackColor = true;
            btn_BorrarRegistro.Click += btn_BorrarRegistro_Click;
            // 
            // btn_CerrarForm
            // 
            btn_CerrarForm.Location = new Point(318, 101);
            btn_CerrarForm.Name = "btn_CerrarForm";
            btn_CerrarForm.Size = new Size(96, 57);
            btn_CerrarForm.TabIndex = 3;
            btn_CerrarForm.Text = "CerrarForm";
            btn_CerrarForm.UseVisualStyleBackColor = true;
            btn_CerrarForm.Click += btn_CerrarForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(54, 20);
            label1.Name = "label1";
            label1.Size = new Size(324, 46);
            label1.TabIndex = 4;
            label1.Text = "Agenda de Personas";
            // 
            // FormPunto3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 206);
            Controls.Add(label1);
            Controls.Add(btn_CerrarForm);
            Controls.Add(btn_BorrarRegistro);
            Controls.Add(btn_ActualizarRegistro);
            Controls.Add(btn_GuardarRegistro);
            Name = "FormPunto3";
            Text = "FormPunto3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_GuardarRegistro;
        private Button btn_ActualizarRegistro;
        private Button btn_BorrarRegistro;
        private Button btn_CerrarForm;
        private Label label1;
    }
}