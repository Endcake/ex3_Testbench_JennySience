namespace JennySienceTestbench
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBx_host = new System.Windows.Forms.TextBox();
            this.txtBx_port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBx_host
            // 
            this.txtBx_host.Location = new System.Drawing.Point(62, 28);
            this.txtBx_host.Name = "txtBx_host";
            this.txtBx_host.Size = new System.Drawing.Size(100, 20);
            this.txtBx_host.TabIndex = 0;
            // 
            // txtBx_port
            // 
            this.txtBx_port.Location = new System.Drawing.Point(212, 28);
            this.txtBx_port.Name = "txtBx_port";
            this.txtBx_port.Size = new System.Drawing.Size(100, 20);
            this.txtBx_port.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBx_port);
            this.Controls.Add(this.txtBx_host);
            this.Name = "Form1";
            this.Text = "Jenny Sience Testbench";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_host;
        private System.Windows.Forms.TextBox txtBx_port;
    }
}

