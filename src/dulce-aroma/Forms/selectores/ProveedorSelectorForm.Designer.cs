
namespace dulce_aroma.Forms.selectores
{
    partial class ProveedorSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorSelectorForm));
            this.dgvbase = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dgvSelectNoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvSelectNombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSelectEstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbuscar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lupa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbase
            // 
            this.dgvbase.AllowUserToAddRows = false;
            this.dgvbase.AllowUserToDeleteRows = false;
            this.dgvbase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSelectNoProveedor,
            this.dvSelectNombreProveedor,
            this.dgvSelectEstatus});
            this.dgvbase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbase.Location = new System.Drawing.Point(0, 42);
            this.dgvbase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvbase.Name = "dgvbase";
            this.dgvbase.ReadOnly = true;
            this.dgvbase.RowHeadersVisible = false;
            this.dgvbase.RowHeadersWidth = 51;
            this.dgvbase.RowTemplate.Height = 24;
            this.dgvbase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbase.Size = new System.Drawing.Size(682, 504);
            this.dgvbase.TabIndex = 4;
            this.dgvbase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbase_CellDoubleClick);
            // 
            // dgvSelectNoProveedor
            // 
            this.dgvSelectNoProveedor.HeaderText = "No. Proveedor";
            this.dgvSelectNoProveedor.MinimumWidth = 6;
            this.dgvSelectNoProveedor.Name = "dgvSelectNoProveedor";
            this.dgvSelectNoProveedor.ReadOnly = true;
            // 
            // dvSelectNombreProveedor
            // 
            this.dvSelectNombreProveedor.HeaderText = "Proveedor";
            this.dvSelectNombreProveedor.MinimumWidth = 6;
            this.dvSelectNombreProveedor.Name = "dvSelectNombreProveedor";
            this.dvSelectNombreProveedor.ReadOnly = true;
            // 
            // dgvSelectEstatus
            // 
            this.dgvSelectEstatus.HeaderText = "Estatus";
            this.dgvSelectEstatus.MinimumWidth = 6;
            this.dgvSelectEstatus.Name = "dgvSelectEstatus";
            this.dgvSelectEstatus.ReadOnly = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.lupa});
            this.txtbuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbuscar.Location = new System.Drawing.Point(0, 0);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(682, 42);
            this.txtbuscar.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 6, 2, 3);
            this.txtbuscar.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.TabIndex = 5;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // lupa
            // 
            this.lupa.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.lupa.Image = ((System.Drawing.Image)(resources.GetObject("lupa.Image")));
            this.lupa.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.lupa.UniqueName = "E448180152AC41CD62805BF627D2BF45";
            // 
            // ProveedorSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 546);
            this.Controls.Add(this.dgvbase);
            this.Controls.Add(this.txtbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProveedorSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un proveedor con doble clic";
            this.Load += new System.EventHandler(this.ProveedorSelectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvbase;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbuscar;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny lupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSelectNoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvSelectNombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSelectEstatus;
    }
}