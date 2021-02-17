
namespace dulce_aroma.Forms.selectores
{
    partial class TurnoGeneralSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnoGeneralSelector));
            this.txtfecha2 = new System.Windows.Forms.DateTimePicker();
            this.txtfecha1 = new System.Windows.Forms.DateTimePicker();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnfiltrar = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dgvbase = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dgvIdTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfecha2
            // 
            this.txtfecha2.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtfecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha2.Location = new System.Drawing.Point(0, 78);
            this.txtfecha2.Name = "txtfecha2";
            this.txtfecha2.Size = new System.Drawing.Size(800, 34);
            this.txtfecha2.TabIndex = 7;
            // 
            // txtfecha1
            // 
            this.txtfecha1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtfecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha1.Location = new System.Drawing.Point(0, 44);
            this.txtfecha1.Name = "txtfecha1";
            this.txtfecha1.Size = new System.Drawing.Size(800, 34);
            this.txtfecha1.TabIndex = 8;
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnfiltrar});
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(800, 44);
            this.kryptonHeader2.TabIndex = 9;
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
            // dgvbase
            // 
            this.dgvbase.AllowUserToAddRows = false;
            this.dgvbase.AllowUserToDeleteRows = false;
            this.dgvbase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdTurno,
            this.dgvEmpleado,
            this.dgvFechaApertura,
            this.dgvFechaCierre});
            this.dgvbase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbase.Location = new System.Drawing.Point(0, 112);
            this.dgvbase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvbase.Name = "dgvbase";
            this.dgvbase.ReadOnly = true;
            this.dgvbase.RowHeadersVisible = false;
            this.dgvbase.RowHeadersWidth = 51;
            this.dgvbase.RowTemplate.Height = 24;
            this.dgvbase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbase.Size = new System.Drawing.Size(800, 338);
            this.dgvbase.TabIndex = 10;
            this.dgvbase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbase_CellDoubleClick);
            // 
            // dgvIdTurno
            // 
            this.dgvIdTurno.HeaderText = "Folio";
            this.dgvIdTurno.MinimumWidth = 6;
            this.dgvIdTurno.Name = "dgvIdTurno";
            this.dgvIdTurno.ReadOnly = true;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.HeaderText = "Empleado";
            this.dgvEmpleado.MinimumWidth = 6;
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            // 
            // dgvFechaApertura
            // 
            this.dgvFechaApertura.HeaderText = "Fecha de apertura";
            this.dgvFechaApertura.MinimumWidth = 6;
            this.dgvFechaApertura.Name = "dgvFechaApertura";
            this.dgvFechaApertura.ReadOnly = true;
            // 
            // dgvFechaCierre
            // 
            this.dgvFechaCierre.HeaderText = "Fecha de cierre";
            this.dgvFechaCierre.MinimumWidth = 6;
            this.dgvFechaCierre.Name = "dgvFechaCierre";
            this.dgvFechaCierre.ReadOnly = true;
            // 
            // TurnoGeneralSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvbase);
            this.Controls.Add(this.txtfecha2);
            this.Controls.Add(this.txtfecha1);
            this.Controls.Add(this.kryptonHeader2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TurnoGeneralSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un turno";
            this.Load += new System.EventHandler(this.TurnoGeneralSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker txtfecha2;
        private System.Windows.Forms.DateTimePicker txtfecha1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnfiltrar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvbase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCierre;
    }
}