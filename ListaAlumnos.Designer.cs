namespace repaso_POO
{
    partial class ListaAlumnos
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
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 9);
            label1.Name = "label1";
            label1.Size = new Size(391, 47);
            label1.TabIndex = 1;
            label1.Text = "Lista de Alumnos";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Menu;
            listBox1.Font = new Font("Sitka Banner", 14.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(26, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(608, 391);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(266, 574);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListaAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 636);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "ListaAlumnos";
            Text = "ListaAlumnos";
            Load += ListaAlumnos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
    }
}