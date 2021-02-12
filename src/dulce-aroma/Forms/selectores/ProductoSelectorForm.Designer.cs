
namespace dulce_aroma.Forms.selectores
{
    partial class ProductoSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoSelectorForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvbase = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtbuscar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lupa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.dgvNoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvbase);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(931, 430);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar un producto (f2)";
            // 
            // dgvbase
            // 
            this.dgvbase.AllowUserToAddRows = false;
            this.dgvbase.AllowUserToDeleteRows = false;
            this.dgvbase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNoProducto,
            this.dgvNombre,
            this.dgvProveedor,
            this.dgvExistencias,
            this.dgvEstatus});
            this.dgvbase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbase.Location = new System.Drawing.Point(3, 64);
            this.dgvbase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvbase.Name = "dgvbase";
            this.dgvbase.ReadOnly = true;
            this.dgvbase.RowHeadersVisible = false;
            this.dgvbase.RowHeadersWidth = 51;
            this.dgvbase.RowTemplate.Height = 24;
            this.dgvbase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbase.Size = new System.Drawing.Size(925, 364);
            this.dgvbase.TabIndex = 0;
            this.dgvbase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbase_CellDoubleClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.lupa});
            this.txtbuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbuscar.Location = new System.Drawing.Point(3, 22);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(925, 42);
            this.txtbuscar.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 6, 2, 3);
            this.txtbuscar.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // lupa
            // 
            this.lupa.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.lupa.Image = ((System.Drawing.Image)(resources.GetObject("lupa.Image")));
            this.lupa.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.lupa.UniqueName = "E448180152AC41CD62805BF627D2BF45";
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(931, 37);
            this.kryptonHeader2.TabIndex = 5;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Productos actuales";
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // dgvNoProducto
            // 
            this.dgvNoProducto.HeaderText = "No. Producto";
            this.dgvNoProducto.MinimumWidth = 6;
            this.dgvNoProducto.Name = "dgvNoProducto";
            this.dgvNoProducto.ReadOnly = true;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Producto";
            this.dgvNombre.MinimumWidth = 6;
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.HeaderText = "Proveedor";
            this.dgvProveedor.MinimumWidth = 6;
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.HeaderText = "Existencias";
            this.dgvExistencias.MinimumWidth = 6;
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.ReadOnly = true;
            // 
            // dgvEstatus
            // 
            this.dgvEstatus.HeaderText = "Precio";
            this.dgvEstatus.MinimumWidth = 6;
            this.dgvEstatus.Name = "dgvEstatus";
            this.dgvEstatus.ReadOnly = true;
            // 
            // ProductoSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.kryptonHeader2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductoSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un producto haciendo doble clic";
            this.Load += new System.EventHandler(this.ProductoSelectorForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvbase;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbuscar;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny lupa;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstatus;
    }
}