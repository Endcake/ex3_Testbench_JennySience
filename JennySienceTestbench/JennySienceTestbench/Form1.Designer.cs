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
            this.btn_connect_jenny_X = new System.Windows.Forms.Button();
            this.txtBox_communication = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.txtBx_command = new System.Windows.Forms.TextBox();
            this.btn_send_message = new System.Windows.Forms.Button();
            this.btn_send2 = new System.Windows.Forms.Button();
            this.txtBx_command2 = new System.Windows.Forms.TextBox();
            this.btn_disconnect2 = new System.Windows.Forms.Button();
            this.btn_connect_jenny_Y = new System.Windows.Forms.Button();
            this.txtBx_ip2 = new System.Windows.Forms.TextBox();
            this.txtBx_port2 = new System.Windows.Forms.TextBox();
            this.btn_get_postion = new System.Windows.Forms.Button();
            this.btn_connect_ps90 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBx_port1
            // 
            this.txtBx_port1.Location = new System.Drawing.Point(6, 63);
            this.txtBx_port1.Name = "txtBx_port1";
            this.txtBx_port1.Size = new System.Drawing.Size(100, 20);
            this.txtBx_port1.TabIndex = 0;
            this.txtBx_port1.Text = "10001";
            // 
            // txtBx_ip1
            // 
            this.txtBx_ip1.Location = new System.Drawing.Point(6, 32);
            this.txtBx_ip1.Name = "txtBx_ip1";
            this.txtBx_ip1.Size = new System.Drawing.Size(100, 20);
            this.txtBx_ip1.TabIndex = 1;
            this.txtBx_ip1.Text = "192.168.2.100";
            // 
            // btn_connect_jenny_X
            // 
            this.btn_connect_jenny_X.Location = new System.Drawing.Point(112, 32);
            this.btn_connect_jenny_X.Name = "btn_connect_jenny_X";
            this.btn_connect_jenny_X.Size = new System.Drawing.Size(75, 23);
            this.btn_connect_jenny_X.TabIndex = 2;
            this.btn_connect_jenny_X.Text = "connect";
            this.btn_connect_jenny_X.UseVisualStyleBackColor = true;
            this.btn_connect_jenny_X.Click += new System.EventHandler(this.btn_connect_jenny_X_Click);
            // 
            // txtBox_communication
            // 
            this.txtBox_communication.Location = new System.Drawing.Point(10, 267);
            this.txtBox_communication.Multiline = true;
            this.txtBox_communication.Name = "txtBox_communication";
            this.txtBox_communication.Size = new System.Drawing.Size(443, 91);
            this.txtBox_communication.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(7, 422);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(485, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(112, 61);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 5;
            this.btn_disconnect.Text = "disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_jenny_X_Click);
            // 
            // txtBx_command
            // 
            this.txtBx_command.Location = new System.Drawing.Point(6, 98);
            this.txtBx_command.Name = "txtBx_command";
            this.txtBx_command.Size = new System.Drawing.Size(100, 20);
            this.txtBx_command.TabIndex = 6;
            // 
            // btn_send_message
            // 
            this.btn_send_message.Location = new System.Drawing.Point(112, 95);
            this.btn_send_message.Name = "btn_send_message";
            this.btn_send_message.Size = new System.Drawing.Size(75, 23);
            this.btn_send_message.TabIndex = 7;
            this.btn_send_message.Text = "send";
            this.btn_send_message.UseVisualStyleBackColor = true;
            this.btn_send_message.Click += new System.EventHandler(this.btn_send_message_Click);
            // 
            // btn_send2
            // 
            this.btn_send2.Location = new System.Drawing.Point(378, 96);
            this.btn_send2.Name = "btn_send2";
            this.btn_send2.Size = new System.Drawing.Size(75, 23);
            this.btn_send2.TabIndex = 13;
            this.btn_send2.Text = "send";
            this.btn_send2.UseVisualStyleBackColor = true;
            this.btn_send2.Click += new System.EventHandler(this.btn_send2_Click);
            // 
            // txtBx_command2
            // 
            this.txtBx_command2.Location = new System.Drawing.Point(272, 98);
            this.txtBx_command2.Name = "txtBx_command2";
            this.txtBx_command2.Size = new System.Drawing.Size(100, 20);
            this.txtBx_command2.TabIndex = 12;
            // 
            // btn_disconnect2
            // 
            this.btn_disconnect2.Location = new System.Drawing.Point(378, 58);
            this.btn_disconnect2.Name = "btn_disconnect2";
            this.btn_disconnect2.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect2.TabIndex = 11;
            this.btn_disconnect2.Text = "disconnect";
            this.btn_disconnect2.UseVisualStyleBackColor = true;
            this.btn_disconnect2.Click += new System.EventHandler(this.btn_disconnectjenny_Y_Click);
            // 
            // btn_connect_jenny_Y
            // 
            this.btn_connect_jenny_Y.Location = new System.Drawing.Point(378, 30);
            this.btn_connect_jenny_Y.Name = "btn_connect_jenny_Y";
            this.btn_connect_jenny_Y.Size = new System.Drawing.Size(75, 23);
            this.btn_connect_jenny_Y.TabIndex = 10;
            this.btn_connect_jenny_Y.Text = "connect";
            this.btn_connect_jenny_Y.UseVisualStyleBackColor = true;
            this.btn_connect_jenny_Y.Click += new System.EventHandler(this.btn_connect_jenny_Y_Click);
            // 
            // txtBx_ip2
            // 
            this.txtBx_ip2.Location = new System.Drawing.Point(272, 32);
            this.txtBx_ip2.Name = "txtBx_ip2";
            this.txtBx_ip2.Size = new System.Drawing.Size(100, 20);
            this.txtBx_ip2.TabIndex = 9;
            this.txtBx_ip2.Text = "192.168.2.101";
            // 
            // txtBx_port2
            // 
            this.txtBx_port2.Location = new System.Drawing.Point(272, 61);
            this.txtBx_port2.Name = "txtBx_port2";
            this.txtBx_port2.Size = new System.Drawing.Size(100, 20);
            this.txtBx_port2.TabIndex = 8;
            this.txtBx_port2.Text = "1001";
            // 
            // btn_get_postion
            // 
            this.btn_get_postion.Location = new System.Drawing.Point(112, 127);
            this.btn_get_postion.Name = "btn_get_postion";
            this.btn_get_postion.Size = new System.Drawing.Size(75, 23);
            this.btn_get_postion.TabIndex = 14;
            this.btn_get_postion.Text = "get Position";
            this.btn_get_postion.UseVisualStyleBackColor = true;
            this.btn_get_postion.Click += new System.EventHandler(this.btn_get_postion_Click);
            // 
            // btn_connect_ps90
            // 
            this.btn_connect_ps90.Location = new System.Drawing.Point(3, 6);
            this.btn_connect_ps90.Name = "btn_connect_ps90";
            this.btn_connect_ps90.Size = new System.Drawing.Size(117, 23);
            this.btn_connect_ps90.TabIndex = 15;
            this.btn_connect_ps90.Text = "btn_connect_ps90";
            this.btn_connect_ps90.UseVisualStyleBackColor = true;
            this.btn_connect_ps90.Click += new System.EventHandler(this.btn_connect_ps90_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 404);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_get_postion);
            this.tabPage1.Controls.Add(this.btn_connect_jenny_X);
            this.tabPage1.Controls.Add(this.btn_send2);
            this.tabPage1.Controls.Add(this.txtBox_communication);
            this.tabPage1.Controls.Add(this.txtBx_ip1);
            this.tabPage1.Controls.Add(this.txtBx_command2);
            this.tabPage1.Controls.Add(this.btn_disconnect);
            this.tabPage1.Controls.Add(this.btn_disconnect2);
            this.tabPage1.Controls.Add(this.txtBx_port1);
            this.tabPage1.Controls.Add(this.btn_connect_jenny_Y);
            this.tabPage1.Controls.Add(this.txtBx_command);
            this.tabPage1.Controls.Add(this.txtBx_port2);
            this.tabPage1.Controls.Add(this.txtBx_ip2);
            this.tabPage1.Controls.Add(this.btn_send_message);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "JennySAxis";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "JennySience Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "JennySience X";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_connect_ps90);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_exit);
            this.Name = "Form1";
            this.Text = "Jenny Sience Testbench";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_port1;
        private System.Windows.Forms.TextBox txtBx_ip1;
        private System.Windows.Forms.Button btn_connect_jenny_X;
        private System.Windows.Forms.TextBox txtBox_communication;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TextBox txtBx_command;
        private System.Windows.Forms.Button btn_send_message;
        private System.Windows.Forms.Button btn_send2;
        private System.Windows.Forms.TextBox txtBx_command2;
        private System.Windows.Forms.Button btn_disconnect2;
        private System.Windows.Forms.Button btn_connect_jenny_Y;
        private System.Windows.Forms.TextBox txtBx_ip2;
        private System.Windows.Forms.TextBox txtBx_port2;
        private System.Windows.Forms.Button btn_get_postion;
        private System.Windows.Forms.Button btn_connect_ps90;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

