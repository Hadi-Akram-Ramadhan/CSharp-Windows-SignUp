namespace VpApp2
{
    partial class SignUp
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
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.Services = new System.Windows.Forms.GroupBox();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.chkReport = new System.Windows.Forms.CheckBox();
            this.chkTR = new System.Windows.Forms.CheckBox();
            this.lblSMS = new System.Windows.Forms.Label();
            this.lblTR = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.Services.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(232, 81);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(608, 20);
            this.txbFirstName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(232, 124);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(608, 20);
            this.txbLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(232, 166);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(608, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // Services
            // 
            this.Services.Controls.Add(this.lblTR);
            this.Services.Controls.Add(this.lblSMS);
            this.Services.Controls.Add(this.chkTR);
            this.Services.Controls.Add(this.chkReport);
            this.Services.Controls.Add(this.chkSMS);
            this.Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Location = new System.Drawing.Point(91, 236);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(749, 189);
            this.Services.TabIndex = 7;
            this.Services.TabStop = false;
            this.Services.Text = "Services";
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSMS.Location = new System.Drawing.Point(141, 39);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(177, 26);
            this.chkSMS.TabIndex = 0;
            this.chkSMS.Text = "SMS Notification";
            this.chkSMS.UseVisualStyleBackColor = true;
            this.chkSMS.CheckedChanged += new System.EventHandler(this.chkSMS_CheckedChanged);
            // 
            // chkReport
            // 
            this.chkReport.AutoSize = true;
            this.chkReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReport.Location = new System.Drawing.Point(141, 74);
            this.chkReport.Name = "chkReport";
            this.chkReport.Size = new System.Drawing.Size(89, 26);
            this.chkReport.TabIndex = 1;
            this.chkReport.Text = "Report";
            this.chkReport.UseVisualStyleBackColor = true;
            this.chkReport.CheckedChanged += new System.EventHandler(this.chkReport_CheckedChanged);
            // 
            // chkTR
            // 
            this.chkTR.AutoSize = true;
            this.chkTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTR.Location = new System.Drawing.Point(141, 109);
            this.chkTR.Name = "chkTR";
            this.chkTR.Size = new System.Drawing.Size(201, 26);
            this.chkTR.TabIndex = 2;
            this.chkTR.Text = "Transaction Report";
            this.chkTR.UseVisualStyleBackColor = true;
            this.chkTR.CheckedChanged += new System.EventHandler(this.chkTR_CheckedChanged);
            // 
            // lblSMS
            // 
            this.lblSMS.AutoSize = true;
            this.lblSMS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMS.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSMS.Location = new System.Drawing.Point(415, 40);
            this.lblSMS.Name = "lblSMS";
            this.lblSMS.Size = new System.Drawing.Size(42, 25);
            this.lblSMS.TabIndex = 3;
            this.lblSMS.Text = ".....";
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTR.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTR.Location = new System.Drawing.Point(415, 108);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(42, 25);
            this.lblTR.TabIndex = 4;
            this.lblTR.Text = ".....";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(644, 462);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(195, 42);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 533);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbFirstName);
            this.Name = "SignUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.Label lblSMS;
        private System.Windows.Forms.CheckBox chkTR;
        private System.Windows.Forms.CheckBox chkReport;
        private System.Windows.Forms.CheckBox chkSMS;
        private System.Windows.Forms.Button btnSignUp;
    }
}

