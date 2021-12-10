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
            this.txtBx_port1 = new System.Windows.Forms.TextBox();
            this.txtBx_ip1 = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txtBox_communication = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.txtBx_command = new System.Windows.Forms.TextBox();
            this.btn_send_message = new System.Windows.Forms.Button();
            this.btn_send2 = new System.Windows.Forms.Button();
            this.txtBx_command2 = new System.Windows.Forms.TextBox();
            this.btn_disconnect2 = new System.Windows.Forms.Button();
            this.btn_connect2 = new System.Windows.Forms.Button();
            this.txtBx_ip2 = new System.Windows.Forms.TextBox();
            this.txtBx_port2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBx_port1
            // 
            this.txtBx_port1.Location = new System.Drawing.Point(12, 38);
            this.txtBx_port1.Name = "txtBx_port1";
            this.txtBx_port1.Size = new System.Drawing.Size(100, 20);
            this.txtBx_port1.TabIndex = 0;
            this.txtBx_port1.Text = "1302";
            // 
            // txtBx_ip1
            // 
            this.txtBx_ip1.Location = new System.Drawing.Point(12, 12);
            this.txtBx_ip1.Name = "txtBx_ip1";
            this.txtBx_ip1.Size = new System.Drawing.Size(100, 20);
            this.txtBx_ip1.TabIndex = 1;
            this.txtBx_ip1.Text = "127.0.0.1";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(118, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txtBox_communication
            // 
            this.txtBox_communication.Location = new System.Drawing.Point(12, 141);
            this.txtBox_communication.Multiline = true;
            this.txtBox_communication.Name = "txtBox_communication";
            this.txtBox_communication.Size = new System.Drawing.Size(403, 228);
            this.txtBox_communication.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(62, 394);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(376, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(199, 12);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 5;
            this.btn_disconnect.Text = "disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // txtBx_command
            // 
            this.txtBx_command.Location = new System.Drawing.Point(289, 12);
            this.txtBx_command.Name = "txtBx_command";
            this.txtBx_command.Size = new System.Drawing.Size(100, 20);
            this.txtBx_command.TabIndex = 6;
            // 
            // btn_send_message
            // 
            this.btn_send_message.Location = new System.Drawing.Point(406, 12);
            this.btn_send_message.Name = "btn_send_message";
            this.btn_send_message.Size = new System.Drawing.Size(75, 23);
            this.btn_send_message.TabIndex = 7;
            this.btn_send_message.Text = "send";
            this.btn_send_message.UseVisualStyleBackColor = true;
            this.btn_send_message.Click += new System.EventHandler(this.btn_send_message_Click);
            // 
            // btn_send2
            // 
            this.btn_send2.Location = new System.Drawing.Point(406, 81);
            this.btn_send2.Name = "btn_send2";
            this.btn_send2.Size = new System.Drawing.Size(75, 23);
            this.btn_send2.TabIndex = 13;
            this.btn_send2.Text = "send";
            this.btn_send2.UseVisualStyleBackColor = true;
            this.btn_send2.Click += new System.EventHandler(this.btn_send2_Click);
            // 
            // txtBx_command2
            // 
            this.txtBx_command2.Location = new System.Drawing.Point(289, 81);
            this.txtBx_command2.Name = "txtBx_command2";
            this.txtBx_command2.Size = new System.Drawing.Size(100, 20);
            this.txtBx_command2.TabIndex = 12;
            // 
            // btn_disconnect2
            // 
            this.btn_disconnect2.Location = new System.Drawing.Point(199, 81);
            this.btn_disconnect2.Name = "btn_disconnect2";
            this.btn_disconnect2.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect2.TabIndex = 11;
            this.btn_disconnect2.Text = "disconnect";
            this.btn_disconnect2.UseVisualStyleBackColor = true;
            this.btn_disconnect2.Click += new System.EventHandler(this.btn_disconnect2_Click);
            // 
            // btn_connect2
            // 
            this.btn_connect2.Location = new System.Drawing.Point(118, 81);
            this.btn_connect2.Name = "btn_connect2";
            this.btn_connect2.Size = new System.Drawing.Size(75, 23);
            this.btn_connect2.TabIndex = 10;
            this.btn_connect2.Text = "connect";
            this.btn_connect2.UseVisualStyleBackColor = true;
            this.btn_connect2.Click += new System.EventHandler(this.btn_connect2_Click);
            // 
            // txtBx_ip2
            // 
            this.txtBx_ip2.Location = new System.Drawing.Point(12, 81);
            this.txtBx_ip2.Name = "txtBx_ip2";
            this.txtBx_ip2.Size = new System.Drawing.Size(100, 20);
            this.txtBx_ip2.TabIndex = 9;
            this.txtBx_ip2.Text = "127.0.0.1";
            // 
            // txtBx_port2
            // 
            this.txtBx_port2.Location = new System.Drawing.Point(12, 107);
            this.txtBx_port2.Name = "txtBx_port2";
            this.txtBx_port2.Size = new System.Drawing.Size(100, 20);
            this.txtBx_port2.TabIndex = 8;
            this.txtBx_port2.Text = "1303";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send2);
            this.Controls.Add(this.txtBx_command2);
            this.Controls.Add(this.btn_disconnect2);
            this.Controls.Add(this.btn_connect2);
            this.Controls.Add(this.txtBx_ip2);
            this.Controls.Add(this.txtBx_port2);
            this.Controls.Add(this.btn_send_message);
            this.Controls.Add(this.txtBx_command);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txtBox_communication);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txtBx_ip1);
            this.Controls.Add(this.txtBx_port1);
            this.Name = "Form1";
            this.Text = "Jenny Sience Testbench";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_port1;
        private System.Windows.Forms.TextBox txtBx_ip1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txtBox_communication;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox txtBx_command;
        private System.Windows.Forms.Button btn_send_message;
        private System.Windows.Forms.Button btn_send2;
        private System.Windows.Forms.TextBox txtBx_command2;
        private System.Windows.Forms.Button btn_disconnect2;
        private System.Windows.Forms.Button btn_connect2;
        private System.Windows.Forms.TextBox txtBx_ip2;
        private System.Windows.Forms.TextBox txtBx_port2;
    }
}

