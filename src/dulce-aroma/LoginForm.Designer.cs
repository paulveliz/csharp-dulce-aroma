
namespace dulce_aroma
{
    partial class LoginForm
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
            this.cboxempleados = new System.Windows.Forms.ComboBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnacceso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxempleados
            // 
            this.cboxempleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxempleados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxempleados.FormattingEnabled = true;
            this.cboxempleados.Location = new System.Drawing.Point(12, 51);
            this.cboxempleados.Name = "cboxempleados";
            this.cboxempleados.Size = new System.Drawing.Size(383, 32);
            this.cboxempleados.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(12, 116);
            this.txtpass.MaxLength = 18;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(383, 30);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // btnacceso
            // 
            this.btnacceso.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacceso.Location = new System.Drawing.Point(292, 167);
            this.btnacceso.Name = "btnacceso";
            this.btnacceso.Size = new System.Drawing.Size(103, 40);
            this.btnacceso.TabIndex = 2;
            this.btnacceso.Text = "Acceder";
            this.btnacceso.UseVisualStyleBackColor = true;
            this.btnacceso.Click += new System.EventHandler(this.btnacceso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio de sesión";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnacceso);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.cboxempleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al sistema";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxempleados;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnacceso;
        private System.Windows.Forms.Label label1;
    }
}