
namespace dulce_aroma.Forms.ventas
{
    partial class FormVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonDockableNavigator1 = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbuscar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lupa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeader3 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvbase = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dgvNoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader4 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnfinalizarventa = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txtimportetotal = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).BeginInit();
            this.kryptonDockableNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDockableNavigator1
            // 
            this.kryptonDockableNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonDockableNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableNavigator1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonDockableNavigator1.Name = "kryptonDockableNavigator1";
            this.kryptonDockableNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1});
            this.kryptonDockableNavigator1.SelectedIndex = 0;
            this.kryptonDockableNavigator1.Size = new System.Drawing.Size(1578, 858);
            this.kryptonDockableNavigator1.TabIndex = 2;
            this.kryptonDockableNavigator1.Text = "kryptonDockableNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.panel1);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(67, 62);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(1576, 827);
            this.kryptonPage1.Text = "Mostrador";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "7FDF732A32374EAC4E99B544A532879B";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1576, 827);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.txtbuscar);
            this.splitContainer1.Panel1.Controls.Add(this.kryptonHeader3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1576, 827);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1576, 278);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1576, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.lupa});
            this.txtbuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtbuscar.Location = new System.Drawing.Point(0, 36);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.MaxLength = 30;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(1576, 42);
            this.txtbuscar.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtbuscar.StateCommon.Back.Color1 = System.Drawing.Color.PeachPuff;
            this.txtbuscar.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 6, 2, 3);
            this.txtbuscar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
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
            this.lupa.Click += new System.EventHandler(this.lupa_Click);
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader3.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(1576, 36);
            this.kryptonHeader3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonHeader3.TabIndex = 4;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "Producto";
            this.kryptonHeader3.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader3.Values.Image")));
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvbase);
            this.splitContainer2.Panel1.Controls.Add(this.kryptonHeader1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.kryptonHeader4);
            this.splitContainer2.Panel2.Controls.Add(this.txtimportetotal);
            this.splitContainer2.Panel2.Controls.Add(this.kryptonHeader2);
            this.splitContainer2.Size = new System.Drawing.Size(1576, 467);
            this.splitContainer2.SplitterDistance = 621;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvbase
            // 
            this.dgvbase.AllowUserToAddRows = false;
            this.dgvbase.AllowUserToDeleteRows = false;
            this.dgvbase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNoProducto,
            this.dgvProducto,
            this.dgvCantidad,
            this.dgvPrecio,
            this.dgvImporte,
            this.dgvExistencias});
            this.dgvbase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvbase.Location = new System.Drawing.Point(0, 37);
            this.dgvbase.MultiSelect = false;
            this.dgvbase.Name = "dgvbase";
            this.dgvbase.ReadOnly = true;
            this.dgvbase.RowHeadersVisible = false;
            this.dgvbase.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvbase.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbase.RowTemplate.Height = 24;
            this.dgvbase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbase.Size = new System.Drawing.Size(621, 430);
            this.dgvbase.TabIndex = 1;
            this.dgvbase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbase_CellDoubleClick);
            this.dgvbase.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvbase_MouseDoubleClick);
            // 
            // dgvNoProducto
            // 
            this.dgvNoProducto.HeaderText = "dgvIdProducto";
            this.dgvNoProducto.MinimumWidth = 6;
            this.dgvNoProducto.Name = "dgvNoProducto";
            this.dgvNoProducto.ReadOnly = true;
            this.dgvNoProducto.Visible = false;
            // 
            // dgvProducto
            // 
            this.dgvProducto.HeaderText = "Producto";
            this.dgvProducto.MinimumWidth = 6;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.HeaderText = "Cantidad";
            this.dgvCantidad.MinimumWidth = 6;
            this.dgvCantidad.Name = "dgvCantidad";
            this.dgvCantidad.ReadOnly = true;
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.HeaderText = "Precio";
            this.dgvPrecio.MinimumWidth = 6;
            this.dgvPrecio.Name = "dgvPrecio";
            this.dgvPrecio.ReadOnly = true;
            // 
            // dgvImporte
            // 
            this.dgvImporte.HeaderText = "Importe";
            this.dgvImporte.MinimumWidth = 6;
            this.dgvImporte.Name = "dgvImporte";
            this.dgvImporte.ReadOnly = true;
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.HeaderText = "Existencias";
            this.dgvExistencias.MinimumWidth = 6;
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.ReadOnly = true;
            this.dgvExistencias.Visible = false;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(621, 37);
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Productos en la venta";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // kryptonHeader4
            // 
            this.kryptonHeader4.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnfinalizarventa});
            this.kryptonHeader4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeader4.Location = new System.Drawing.Point(0, 391);
            this.kryptonHeader4.Name = "kryptonHeader4";
            this.kryptonHeader4.Size = new System.Drawing.Size(951, 76);
            this.kryptonHeader4.TabIndex = 18;
            this.kryptonHeader4.Values.Description = "";
            this.kryptonHeader4.Values.Heading = "";
            this.kryptonHeader4.Values.Image = null;
            // 
            // btnfinalizarventa
            // 
            this.btnfinalizarventa.Image = ((System.Drawing.Image)(resources.GetObject("btnfinalizarventa.Image")));
            this.btnfinalizarventa.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnfinalizarventa.Text = "FINALIZAR VENTA";
            this.btnfinalizarventa.UniqueName = "B746E16229BA452019A13079CABA82CB";
            this.btnfinalizarventa.Click += new System.EventHandler(this.btnfinalizarventa_Click);
            // 
            // txtimportetotal
            // 
            this.txtimportetotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtimportetotal.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.txtimportetotal.Location = new System.Drawing.Point(0, 37);
            this.txtimportetotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtimportetotal.Name = "txtimportetotal";
            this.txtimportetotal.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.txtimportetotal.Size = new System.Drawing.Size(951, 49);
            this.txtimportetotal.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimportetotal.TabIndex = 15;
            this.txtimportetotal.Values.Description = "";
            this.txtimportetotal.Values.Heading = "TOTAL A PAGAR $ 0.00";
            this.txtimportetotal.Values.Image = null;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(951, 37);
            this.kryptonHeader2.TabIndex = 1;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Datos generales";
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 858);
            this.Controls.Add(this.kryptonDockableNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DULCE AROMA - PUNTO DE VENTA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVenta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).EndInit();
            this.kryptonDockableNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator kryptonDockableNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbuscar;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny lupa;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvbase;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader txtimportetotal;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader4;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnfinalizarventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExistencias;
    }
}