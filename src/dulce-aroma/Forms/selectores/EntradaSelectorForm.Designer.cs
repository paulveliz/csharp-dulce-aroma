
namespace dulce_aroma.Forms.selectores
{
    partial class EntradaSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaSelectorForm));
            this.dgvexistentes = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dgvExistentesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfecha2 = new System.Windows.Forms.DateTimePicker();
            this.txtfecha1 = new System.Windows.Forms.DateTimePicker();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnfiltrar = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvexistentes
            // 
            this.dgvexistentes.AllowUserToAddRows = false;
            this.dgvexistentes.AllowUserToDeleteRows = false;
            this.dgvexistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvexistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvExistentesId,
            this.dgvExEmpleado,
            this.dgvExProveedor,
            this.dgvExFecha,
            this.dgvExImporte,
            this.dgvExEstatus});
            this.dgvexistentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvexistentes.Location = new System.Drawing.Point(0, 112);
            this.dgvexistentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvexistentes.Name = "dgvexistentes";
            this.dgvexistentes.ReadOnly = true;
            this.dgvexistentes.RowHeadersVisible = false;
            this.dgvexistentes.RowHeadersWidth = 51;
            this.dgvexistentes.RowTemplate.Height = 24;
            this.dgvexistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvexistentes.Size = new System.Drawing.Size(744, 386);
            this.dgvexistentes.TabIndex = 2;
            this.dgvexistentes.TabStop = false;
            this.dgvexistentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvexistentes_CellDoubleClick);
            // 
            // dgvExistentesId
            // 
            this.dgvExistentesId.HeaderText = "Id";
            this.dgvExistentesId.MinimumWidth = 6;
            this.dgvExistentesId.Name = "dgvExistentesId";
            this.dgvExistentesId.ReadOnly = true;
            this.dgvExistentesId.Visible = false;
            // 
            // dgvExEmpleado
            // 
            this.dgvExEmpleado.HeaderText = "Empleado";
            this.dgvExEmpleado.MinimumWidth = 6;
            this.dgvExEmpleado.Name = "dgvExEmpleado";
            this.dgvExEmpleado.ReadOnly = true;
            // 
            // dgvExProveedor
            // 
            this.dgvExProveedor.HeaderText = "Proveedor";
            this.dgvExProveedor.MinimumWidth = 6;
            this.dgvExProveedor.Name = "dgvExProveedor";
            this.dgvExProveedor.ReadOnly = true;
            // 
            // dgvExFecha
            // 
            this.dgvExFecha.HeaderText = "Fecha";
            this.dgvExFecha.MinimumWidth = 6;
            this.dgvExFecha.Name = "dgvExFecha";
            this.dgvExFecha.ReadOnly = true;
            // 
            // dgvExImporte
            // 
            this.dgvExImporte.HeaderText = "Importe";
            this.dgvExImporte.MinimumWidth = 6;
            this.dgvExImporte.Name = "dgvExImporte";
            this.dgvExImporte.ReadOnly = true;
            // 
            // dgvExEstatus
            // 
            this.dgvExEstatus.HeaderText = "Estatus";
            this.dgvExEstatus.MinimumWidth = 6;
            this.dgvExEstatus.Name = "dgvExEstatus";
            this.dgvExEstatus.ReadOnly = true;
            // 
            // txtfecha2
            // 
            this.txtfecha2.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtfecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha2.Location = new System.Drawing.Point(0, 78);
            this.txtfecha2.Name = "txtfecha2";
            this.txtfecha2.Size = new System.Drawing.Size(744, 34);
            this.txtfecha2.TabIndex = 3;
            // 
            // txtfecha1
            // 
            this.txtfecha1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtfecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha1.Location = new System.Drawing.Point(0, 44);
            this.txtfecha1.Name = "txtfecha1";
            this.txtfecha1.Size = new System.Drawing.Size(744, 34);
            this.txtfecha1.TabIndex = 4;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnfiltrar});
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(744, 44);
            this.kryptonHeader2.TabIndex = 5;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Seleccione un lapso de fechas para filtrar";
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnfiltrar.Image")));
            this.btnfiltrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UniqueName = "2E805CB4A5B34058ED9C74B6A0B9FBC9";
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // EntradaSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 498);
            this.Controls.Add(this.dgvexistentes);
            this.Controls.Add(this.txtfecha2);
            this.Controls.Add(this.txtfecha1);
            this.Controls.Add(this.kryptonHeader2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EntradaSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione una entrada";
            this.Load += new System.EventHandler(this.EntradaSelectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvexistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExistentesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExEstatus;
        private System.Windows.Forms.DateTimePicker txtfecha2;
        private System.Windows.Forms.DateTimePicker txtfecha1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnfiltrar;
    }
}