
namespace dulce_aroma.Forms.helpers
{
    partial class CambioHelper
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
            this.txtpagoCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtpagoCon
            // 
            this.txtpagoCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpagoCon.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagoCon.ForeColor = System.Drawing.Color.Red;
            this.txtpagoCon.Location = new System.Drawing.Point(12, 85);
            this.txtpagoCon.MaxLength = 4;
            this.txtpagoCon.Name = "txtpagoCon";
            this.txtpagoCon.Size = new System.Drawing.Size(457, 61);
            this.txtpagoCon.TabIndex = 0;
            this.txtpagoCon.TextChanged += new System.EventHandler(this.txtpagoCon_TextChanged);
            this.txtpagoCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagoCon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "PAGÓ CON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "SU CAMBIO";
            // 
            // txtcambio
            // 
            this.txtcambio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcambio.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtcambio.Location = new System.Drawing.Point(12, 256);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(457, 61);
            this.txtcambio.TabIndex = 3;
            this.txtcambio.Text = "0";
            // 
            // CambioHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 381);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpagoCon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambioHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIO DEL IMPORTE";
            this.Load += new System.EventHandler(this.CambioHelper_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CambioHelper_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpagoCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcambio;
    }
}