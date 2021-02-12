
namespace dulce_aroma.Forms.turnos
{
    partial class TurnoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnabrir = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btncerrar = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txtestatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtempleado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtestatus);
            this.panel1.Controls.Add(this.kryptonHeader2);
            this.panel1.Controls.Add(this.kryptonHeader1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 524);
            this.panel1.TabIndex = 0;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 28);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(666, 37);
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Turno actual";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnabrir,
            this.btncerrar});
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 480);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(666, 44);
            this.kryptonHeader2.TabIndex = 1;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "";
            this.kryptonHeader2.Values.Image = null;
            // 
            // btnabrir
            // 
            this.btnabrir.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False;
            this.btnabrir.Image = ((System.Drawing.Image)(resources.GetObject("btnabrir.Image")));
            this.btnabrir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btnabrir.Text = "ABRIR TURNO";
            this.btnabrir.UniqueName = "14B8848278C64CD35CA3E28E5AF46CAF";
            // 
            // btncerrar
            // 
            this.btncerrar.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btncerrar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone;
            this.btncerrar.Text = "CERRAR TURNO";
            this.btncerrar.UniqueName = "8EBBF10A71B04413E9958A44566EE6D2";
            // 
            // txtestatus
            // 
            this.txtestatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtestatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestatus.Location = new System.Drawing.Point(12, 156);
            this.txtestatus.Multiline = true;
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.ReadOnly = true;
            this.txtestatus.Size = new System.Drawing.Size(642, 149);
            this.txtestatus.TabIndex = 3;
            this.txtestatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empleado actual:";
            // 
            // txtempleado
            // 
            this.txtempleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtempleado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempleado.Location = new System.Drawing.Point(12, 336);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.ReadOnly = true;
            this.txtempleado.Size = new System.Drawing.Size(642, 30);
            this.txtempleado.TabIndex = 5;
            this.txtempleado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masOpcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masOpcionesToolStripMenuItem
            // 
            this.masOpcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verListaDeTurnosToolStripMenuItem});
            this.masOpcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("masOpcionesToolStripMenuItem.Image")));
            this.masOpcionesToolStripMenuItem.Name = "masOpcionesToolStripMenuItem";
            this.masOpcionesToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.masOpcionesToolStripMenuItem.Text = "Mas opciones";
            // 
            // verListaDeTurnosToolStripMenuItem
            // 
            this.verListaDeTurnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verListaDeTurnosToolStripMenuItem.Image")));
            this.verListaDeTurnosToolStripMenuItem.Name = "verListaDeTurnosToolStripMenuItem";
            this.verListaDeTurnosToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.verListaDeTurnosToolStripMenuItem.Text = "Ver lista de los ultimos turnos";
            this.verListaDeTurnosToolStripMenuItem.Click += new System.EventHandler(this.verListaDeTurnosToolStripMenuItem_Click);
            // 
            // TurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TurnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema dulce aroma - Turnos";
            this.Load += new System.EventHandler(this.TurnoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnabrir;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btncerrar;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtestatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaDeTurnosToolStripMenuItem;
    }
}