namespace Project.WinUI
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.cmbSaloon = new System.Windows.Forms.ComboBox();
            this.lblSaloon = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lstAvailableStands = new System.Windows.Forms.ListBox();
            this.lstIssue = new System.Windows.Forms.ListBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.cmbIssue = new System.Windows.Forms.ComboBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaxNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(512, 665);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(85, 32);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnDecline
            // 
            this.btnDecline.Enabled = false;
            this.btnDecline.Location = new System.Drawing.Point(631, 665);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(84, 32);
            this.btnDecline.TabIndex = 0;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            // 
            // cmbSaloon
            // 
            this.cmbSaloon.FormattingEnabled = true;
            this.cmbSaloon.Location = new System.Drawing.Point(288, 90);
            this.cmbSaloon.Name = "cmbSaloon";
            this.cmbSaloon.Size = new System.Drawing.Size(122, 24);
            this.cmbSaloon.TabIndex = 1;
            // 
            // lblSaloon
            // 
            this.lblSaloon.Location = new System.Drawing.Point(288, 26);
            this.lblSaloon.Name = "lblSaloon";
            this.lblSaloon.Size = new System.Drawing.Size(122, 23);
            this.lblSaloon.TabIndex = 2;
            this.lblSaloon.Text = "Select Saloon";
            this.lblSaloon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbActivity
            // 
            this.cmbActivity.Enabled = false;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(593, 90);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(122, 24);
            this.cmbActivity.TabIndex = 1;
            // 
            // lblActivity
            // 
            this.lblActivity.Location = new System.Drawing.Point(593, 26);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(122, 29);
            this.lblActivity.TabIndex = 2;
            this.lblActivity.Text = "Select Activity";
            this.lblActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstAvailableStands
            // 
            this.lstAvailableStands.FormattingEnabled = true;
            this.lstAvailableStands.ItemHeight = 16;
            this.lstAvailableStands.Location = new System.Drawing.Point(288, 108);
            this.lstAvailableStands.Name = "lstAvailableStands";
            this.lstAvailableStands.Size = new System.Drawing.Size(427, 164);
            this.lstAvailableStands.TabIndex = 3;
            // 
            // lstIssue
            // 
            this.lstIssue.FormattingEnabled = true;
            this.lstIssue.ItemHeight = 16;
            this.lstIssue.Location = new System.Drawing.Point(1283, 141);
            this.lstIssue.Name = "lstIssue";
            this.lstIssue.Size = new System.Drawing.Size(366, 404);
            this.lstIssue.TabIndex = 3;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(941, 92);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(227, 22);
            this.txtDetails.TabIndex = 4;
            // 
            // cmbIssue
            // 
            this.cmbIssue.Enabled = false;
            this.cmbIssue.FormattingEnabled = true;
            this.cmbIssue.Location = new System.Drawing.Point(802, 90);
            this.cmbIssue.Name = "cmbIssue";
            this.cmbIssue.Size = new System.Drawing.Size(122, 24);
            this.cmbIssue.TabIndex = 1;
            // 
            // lblIssue
            // 
            this.lblIssue.Location = new System.Drawing.Point(1280, 58);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(122, 29);
            this.lblIssue.TabIndex = 2;
            this.lblIssue.Text = "Select Issue";
            this.lblIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.Location = new System.Drawing.Point(1483, 584);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(166, 28);
            this.btnIssue.TabIndex = 0;
            this.btnIssue.Text = "Add Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1419, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCheck
            // 
            this.lblCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCheck.Location = new System.Drawing.Point(288, 584);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(427, 68);
            this.lblCheck.TabIndex = 2;
            this.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tax Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaxNumber
            // 
            this.txtTaxNumber.Enabled = false;
            this.txtTaxNumber.Location = new System.Drawing.Point(29, 272);
            this.txtTaxNumber.Name = "txtTaxNumber";
            this.txtTaxNumber.Size = new System.Drawing.Size(227, 22);
            this.txtTaxNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(29, 375);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(227, 22);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(86, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(86, 166);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(102, 30);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 735);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtTaxNumber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lstIssue);
            this.Controls.Add(this.lstAvailableStands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.cmbIssue);
            this.Controls.Add(this.lblSaloon);
            this.Controls.Add(this.cmbActivity);
            this.Controls.Add(this.cmbSaloon);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnAccept);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.ComboBox cmbSaloon;
        private System.Windows.Forms.Label lblSaloon;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.ListBox lstAvailableStands;
        private System.Windows.Forms.ListBox lstIssue;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ComboBox cmbIssue;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnContinue;
    }
}

