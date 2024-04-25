namespace WinformApp
{
    partial class frmCargaArt
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
            Editar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(378, 121);
            label1.Name = "label1";
            label1.Size = new Size(348, 54);
            label1.TabIndex = 0;
            label1.Text = "Carga de Articulos";
            // 
            // Editar
            // 
            Editar.Location = new Point(232, 300);
            Editar.Name = "Editar";
            Editar.Size = new Size(75, 23);
            Editar.TabIndex = 1;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            // 
            // frmCargaArt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 612);
            Controls.Add(Editar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCargaArt";
            StartPosition = FormStartPosition.Manual;
            Text = "Form2";
            Load += frmCargaArt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Editar;
    }
}