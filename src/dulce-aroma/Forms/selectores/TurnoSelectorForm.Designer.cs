
namespace dulce_aroma.Forms.selectores
{
    partial class TurnoSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnoSelectorForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvbase = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.dgvIdTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvbase);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(936, 423);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
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
            this.dgvbase.Location = new System.Drawing.Point(3, 22);
            this.dgvbase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvbase.Name = "dgvbase";
            this.dgvbase.ReadOnly = true;
            this.dgvbase.RowHeadersVisible = false;
            this.dgvbase.RowHeadersWidth = 51;
            this.dgvbase.RowTemplate.Height = 24;
            this.dgvbase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbase.Size = new System.Drawing.Size(930, 399);
            this.dgvbase.TabIndex = 0;
            this.dgvbase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbase_CellDoubleClick);
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(936, 37);
            this.kryptonHeader2.TabIndex = 7;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Ultimos 100 turnos concluidos";
            this.kryptonHeader2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader2.Values.Image")));
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
            // TurnoSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.kryptonHeader2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TurnoSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione turno a imprimir";
            this.Load += new System.EventHandler(this.TurnoSelectorForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvbase;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCierre;
    }
}