
namespace dulce_aroma.Forms.helpers
{
    partial class CambiarPassHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarPassHelper));
            this.txtpass1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass2 = new System.Windows.Forms.TextBox();
            this.btnchange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpass1
            // 
            this.txtpass1.Location = new System.Drawing.Point(12, 44);
            this.txtpass1.MaxLength = 18;
            this.txtpass1.Name = "txtpass1";
            this.txtpass1.Size = new System.Drawing.Size(303, 22);
            this.txtpass1.TabIndex = 0;
            this.txtpass1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nueva contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repetir contraseña";
            // 
            // txtpass2
            // 
            this.txtpass2.Location = new System.Drawing.Point(12, 103);
            this.txtpass2.MaxLength = 18;
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.Size = new System.Drawing.Size(303, 22);
            this.txtpass2.TabIndex = 2;
            this.txtpass2.UseSystemPasswordChar = true;
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(195, 131);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(124, 33);
            this.btnchange.TabIndex = 4;
            this.btnchange.Text = "Cambiar";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // CambiarPassHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 167);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpass2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarPassHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass2;
        private System.Windows.Forms.Button btnchange;
    }
}