namespace app
{
    partial class frmVentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            this.dgvPanel = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbxArticuloLoad = new System.Windows.Forms.PictureBox();
            this.pbAñadirArt = new System.Windows.Forms.PictureBox();
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.tbFiltroNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cboFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.cboFiltroMarca = new System.Windows.Forms.ComboBox();
            this.cboFiltroCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroCriterio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAñadirArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPanel
            // 
            this.dgvPanel.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPanel.Location = new System.Drawing.Point(27, 103);
            this.dgvPanel.Name = "dgvPanel";
            this.dgvPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPanel.Size = new System.Drawing.Size(704, 350);
            this.dgvPanel.TabIndex = 0;
            this.dgvPanel.SelectionChanged += new System.EventHandler(this.dgvPanel_SelectionChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnActualizar.Location = new System.Drawing.Point(320, 476);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 35);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "    Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Location = new System.Drawing.Point(611, 476);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "       Añadir Articulo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(29, 476);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 35);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "     Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(171, 476);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 35);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "    Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pbxArticuloLoad
            // 
            this.pbxArticuloLoad.Location = new System.Drawing.Point(752, 103);
            this.pbxArticuloLoad.Name = "pbxArticuloLoad";
            this.pbxArticuloLoad.Size = new System.Drawing.Size(350, 350);
            this.pbxArticuloLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticuloLoad.TabIndex = 5;
            this.pbxArticuloLoad.TabStop = false;
            // 
            // pbAñadirArt
            // 
            this.pbAñadirArt.Image = ((System.Drawing.Image)(resources.GetObject("pbAñadirArt.Image")));
            this.pbAñadirArt.Location = new System.Drawing.Point(622, 484);
            this.pbAñadirArt.Name = "pbAñadirArt";
            this.pbAñadirArt.Size = new System.Drawing.Size(20, 20);
            this.pbAñadirArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAñadirArt.TabIndex = 6;
            this.pbAñadirArt.TabStop = false;
            // 
            // pbActualizar
            // 
            this.pbActualizar.Image = ((System.Drawing.Image)(resources.GetObject("pbActualizar.Image")));
            this.pbActualizar.Location = new System.Drawing.Point(331, 484);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(20, 20);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActualizar.TabIndex = 7;
            this.pbActualizar.TabStop = false;
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(182, 483);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(20, 20);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminar.TabIndex = 8;
            this.pbEliminar.TabStop = false;
            // 
            // pbEditar
            // 
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(42, 483);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(20, 20);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 9;
            this.pbEditar.TabStop = false;
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblFiltroNombre.Location = new System.Drawing.Point(27, 45);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(160, 17);
            this.lblFiltroNombre.TabIndex = 10;
            this.lblFiltroNombre.Text = "Nombre / Código artículo";
            // 
            // tbFiltroNombre
            // 
            this.tbFiltroNombre.Location = new System.Drawing.Point(30, 66);
            this.tbFiltroNombre.Name = "tbFiltroNombre";
            this.tbFiltroNombre.Size = new System.Drawing.Size(173, 20);
            this.tbFiltroNombre.TabIndex = 11;
            this.tbFiltroNombre.TextChanged += new System.EventHandler(this.tbFiltroNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "*NOTA: Para editar ó eliminar un artículo, se debe seleccionar desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "la grilla antes de oprimir el botón necesario.";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnFiltrar.Location = new System.Drawing.Point(752, 57);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(115, 34);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cboFiltroCategoria
            // 
            this.cboFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCategoria.FormattingEnabled = true;
            this.cboFiltroCategoria.Location = new System.Drawing.Point(320, 66);
            this.cboFiltroCategoria.Name = "cboFiltroCategoria";
            this.cboFiltroCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboFiltroCategoria.TabIndex = 15;
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblFiltroCategoria.Location = new System.Drawing.Point(346, 46);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblFiltroCategoria.TabIndex = 16;
            this.lblFiltroCategoria.Text = "Categoria";
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblFiltroMarca.Location = new System.Drawing.Point(503, 46);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(47, 17);
            this.lblFiltroMarca.TabIndex = 17;
            this.lblFiltroMarca.Text = "Marca";
            // 
            // cboFiltroMarca
            // 
            this.cboFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroMarca.FormattingEnabled = true;
            this.cboFiltroMarca.Location = new System.Drawing.Point(468, 66);
            this.cboFiltroMarca.Name = "cboFiltroMarca";
            this.cboFiltroMarca.Size = new System.Drawing.Size(121, 21);
            this.cboFiltroMarca.TabIndex = 18;
            this.cboFiltroMarca.SelectedIndexChanged += new System.EventHandler(this.cboFiltroMarca_SelectedIndexChanged);
            // 
            // cboFiltroCriterio
            // 
            this.cboFiltroCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCriterio.FormattingEnabled = true;
            this.cboFiltroCriterio.Location = new System.Drawing.Point(611, 66);
            this.cboFiltroCriterio.Name = "cboFiltroCriterio";
            this.cboFiltroCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboFiltroCriterio.TabIndex = 20;
            // 
            // lblFiltroCriterio
            // 
            this.lblFiltroCriterio.AutoSize = true;
            this.lblFiltroCriterio.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblFiltroCriterio.Location = new System.Drawing.Point(642, 46);
            this.lblFiltroCriterio.Name = "lblFiltroCriterio";
            this.lblFiltroCriterio.Size = new System.Drawing.Size(52, 17);
            this.lblFiltroCriterio.TabIndex = 19;
            this.lblFiltroCriterio.Text = "Criterio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.Location = new System.Drawing.Point(70, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filtro Rapido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(476, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Filtro Avanzado:";
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1114, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboFiltroCriterio);
            this.Controls.Add(this.lblFiltroCriterio);
            this.Controls.Add(this.cboFiltroMarca);
            this.Controls.Add(this.lblFiltroMarca);
            this.Controls.Add(this.lblFiltroCategoria);
            this.Controls.Add(this.cboFiltroCategoria);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFiltroNombre);
            this.Controls.Add(this.lblFiltroNombre);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.pbActualizar);
            this.Controls.Add(this.pbAñadirArt);
            this.Controls.Add(this.pbxArticuloLoad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAñadirArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPanel;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbxArticuloLoad;
        private System.Windows.Forms.PictureBox pbAñadirArt;
        private System.Windows.Forms.PictureBox pbActualizar;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.TextBox tbFiltroNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cboFiltroCategoria;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.ComboBox cboFiltroMarca;
        private System.Windows.Forms.ComboBox cboFiltroCriterio;
        private System.Windows.Forms.Label lblFiltroCriterio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}