namespace GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butOn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butSend = new System.Windows.Forms.Button();
            this.textSendData = new System.Windows.Forms.TextBox();
            this.lbxRx_Data = new System.Windows.Forms.ListBox();
            this.serCom = new System.IO.Ports.SerialPort(this.components);
            this.butConnect = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butOn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(370, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 123);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CALIB";
            // 
            // butOn
            // 
            this.butOn.BackColor = System.Drawing.Color.PaleGreen;
            this.butOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOn.ForeColor = System.Drawing.Color.Blue;
            this.butOn.Location = new System.Drawing.Point(97, 41);
            this.butOn.Name = "butOn";
            this.butOn.Size = new System.Drawing.Size(81, 36);
            this.butOn.TabIndex = 3;
            this.butOn.Text = "Reset";
            this.butOn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxRx_Data);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 208);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboBaudrate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboComPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(370, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 146);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication ";
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(155, 70);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(121, 28);
            this.cboBaudrate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "BAUDRATE:";
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(155, 24);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 28);
            this.cboComPort.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CỔNG COM:";
            // 
            // butSend
            // 
            this.butSend.BackColor = System.Drawing.Color.LightGray;
            this.butSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSend.Location = new System.Drawing.Point(27, 32);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(100, 39);
            this.butSend.TabIndex = 30;
            this.butSend.Text = "Send:";
            this.butSend.UseVisualStyleBackColor = false;
            // 
            // textSendData
            // 
            this.textSendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSendData.Location = new System.Drawing.Point(139, 32);
            this.textSendData.Name = "textSendData";
            this.textSendData.Size = new System.Drawing.Size(201, 39);
            this.textSendData.TabIndex = 29;
            // 
            // lbxRx_Data
            // 
            this.lbxRx_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRx_Data.FormattingEnabled = true;
            this.lbxRx_Data.ItemHeight = 20;
            this.lbxRx_Data.Location = new System.Drawing.Point(12, 34);
            this.lbxRx_Data.Name = "lbxRx_Data";
            this.lbxRx_Data.Size = new System.Drawing.Size(301, 164);
            this.lbxRx_Data.TabIndex = 10;
            // 
            // butConnect
            // 
            this.butConnect.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConnect.ForeColor = System.Drawing.Color.SpringGreen;
            this.butConnect.Location = new System.Drawing.Point(370, 327);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(171, 54);
            this.butConnect.TabIndex = 34;
            this.butConnect.Text = "CONNECT";
            this.butConnect.UseVisualStyleBackColor = true;
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.ForeColor = System.Drawing.Color.Crimson;
            this.butExit.Location = new System.Drawing.Point(547, 327);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(121, 55);
            this.butExit.TabIndex = 35;
            this.butExit.Text = "EXIT";
            this.butExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.textSendData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butOn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.TextBox textSendData;
        private System.Windows.Forms.ListBox lbxRx_Data;
        private System.IO.Ports.SerialPort serCom;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butExit;
    }
}

