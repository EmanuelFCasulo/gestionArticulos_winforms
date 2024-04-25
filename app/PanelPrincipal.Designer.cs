namespace app
{
    partial class frmPanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelPrincipal));
            this.dgvListadoPrincipal = new System.Windows.Forms.DataGridView();
            this.pbxArticuloPanelPrincipal = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloPanelPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoPrincipal
            // 
            this.dgvListadoPrincipal.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvListadoPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoPrincipal.Location = new System.Drawing.Point(12, 51);
            this.dgvListadoPrincipal.Name = "dgvListadoPrincipal";
            this.dgvListadoPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPrincipal.Size = new System.Drawing.Size(754, 350);
            this.dgvListadoPrincipal.TabIndex = 1;
            this.dgvListadoPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoPrincipal_CellContentClick);
            // 
            // pbxArticuloPanelPrincipal
            // 
            this.pbxArticuloPanelPrincipal.Location = new System.Drawing.Point(772, 51);
            this.pbxArticuloPanelPrincipal.Name = "pbxArticuloPanelPrincipal";
            this.pbxArticuloPanelPrincipal.Size = new System.Drawing.Size(350, 350);
            this.pbxArticuloPanelPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticuloPanelPrincipal.TabIndex = 6;
            this.pbxArticuloPanelPrincipal.TabStop = false;
            // 
            // pbxSalir
            // 
            this.pbxSalir.Image = ((System.Drawing.Image)(resources.GetObject("pbxSalir.Image")));
            this.pbxSalir.Location = new System.Drawing.Point(1070, 12);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(20, 20);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 7;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // frmPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1125, 438);
            this.Controls.Add(this.pbxSalir);
            this.Controls.Add(this.pbxArticuloPanelPrincipal);
            this.Controls.Add(this.dgvListadoPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPanelPrincipal";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panel_Principal";
            this.Load += new System.EventHandler(this.Panel_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloPanelPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoPrincipal;
        private System.Windows.Forms.PictureBox pbxArticuloPanelPrincipal;
        private System.Windows.Forms.PictureBox pbxSalir;
    }
}