namespace repaso_POO
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
            button1 = new Button();
            button2 = new Button();
            btn_FormPunto3 = new Button();
            btn_FormPunto4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 37);
            button1.Name = "button1";
            button1.Size = new Size(75, 53);
            button1.TabIndex = 0;
            button1.Text = "Punto 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(109, 37);
            button2.Name = "button2";
            button2.Size = new Size(75, 53);
            button2.TabIndex = 1;
            button2.Text = "Punto 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_FormPunto3
            // 
            btn_FormPunto3.Location = new Point(209, 37);
            btn_FormPunto3.Name = "btn_FormPunto3";
            btn_FormPunto3.Size = new Size(75, 53);
            btn_FormPunto3.TabIndex = 2;
            btn_FormPunto3.Text = "Punto 3";
            btn_FormPunto3.UseVisualStyleBackColor = true;
            btn_FormPunto3.Click += btn_FormPunto3_Click;
            // 
            // btn_FormPunto4
            // 
            btn_FormPunto4.Location = new Point(309, 37);
            btn_FormPunto4.Name = "btn_FormPunto4";
            btn_FormPunto4.Size = new Size(75, 53);
            btn_FormPunto4.TabIndex = 3;
            btn_FormPunto4.Text = "Punto 4";
            btn_FormPunto4.UseVisualStyleBackColor = true;
            btn_FormPunto4.Click += btn_FormPunto4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 151);
            Controls.Add(btn_FormPunto4);
            Controls.Add(btn_FormPunto3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btn_FormPunto3;
        private Button btn_FormPunto4;
    }
}
