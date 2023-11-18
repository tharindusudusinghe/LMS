namespace LMSDemoTRS
{
    partial class ChangePassword
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
            this.oldpwdlbl = new System.Windows.Forms.Label();
            this.newpwdlbl = new System.Windows.Forms.Label();
            this.confirmpwdlbl = new System.Windows.Forms.Label();
            this.oldpwdtxt = new System.Windows.Forms.TextBox();
            this.conpwdtxt = new System.Windows.Forms.TextBox();
            this.nwpwdtxt = new System.Windows.Forms.TextBox();
            this.changepwdbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldpwdlbl
            // 
            this.oldpwdlbl.AutoSize = true;
            this.oldpwdlbl.Location = new System.Drawing.Point(40, 50);
            this.oldpwdlbl.Name = "oldpwdlbl";
            this.oldpwdlbl.Size = new System.Drawing.Size(91, 16);
            this.oldpwdlbl.TabIndex = 0;
            this.oldpwdlbl.Text = "Old Password";
            // 
            // newpwdlbl
            // 
            this.newpwdlbl.AutoSize = true;
            this.newpwdlbl.Location = new System.Drawing.Point(40, 102);
            this.newpwdlbl.Name = "newpwdlbl";
            this.newpwdlbl.Size = new System.Drawing.Size(97, 16);
            this.newpwdlbl.TabIndex = 1;
            this.newpwdlbl.Text = "New Password";
            // 
            // confirmpwdlbl
            // 
            this.confirmpwdlbl.AutoSize = true;
            this.confirmpwdlbl.Location = new System.Drawing.Point(40, 155);
            this.confirmpwdlbl.Name = "confirmpwdlbl";
            this.confirmpwdlbl.Size = new System.Drawing.Size(115, 16);
            this.confirmpwdlbl.TabIndex = 2;
            this.confirmpwdlbl.Text = "Confirm Password";
            this.confirmpwdlbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // oldpwdtxt
            // 
            this.oldpwdtxt.Location = new System.Drawing.Point(199, 47);
            this.oldpwdtxt.Name = "oldpwdtxt";
            this.oldpwdtxt.Size = new System.Drawing.Size(319, 22);
            this.oldpwdtxt.TabIndex = 3;
            // 
            // conpwdtxt
            // 
            this.conpwdtxt.Location = new System.Drawing.Point(199, 155);
            this.conpwdtxt.Name = "conpwdtxt";
            this.conpwdtxt.Size = new System.Drawing.Size(319, 22);
            this.conpwdtxt.TabIndex = 4;
            // 
            // nwpwdtxt
            // 
            this.nwpwdtxt.Location = new System.Drawing.Point(199, 96);
            this.nwpwdtxt.Name = "nwpwdtxt";
            this.nwpwdtxt.Size = new System.Drawing.Size(319, 22);
            this.nwpwdtxt.TabIndex = 5;
            // 
            // changepwdbtn
            // 
            this.changepwdbtn.Location = new System.Drawing.Point(113, 225);
            this.changepwdbtn.Name = "changepwdbtn";
            this.changepwdbtn.Size = new System.Drawing.Size(233, 46);
            this.changepwdbtn.TabIndex = 6;
            this.changepwdbtn.Text = "Change Password";
            this.changepwdbtn.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 325);
            this.Controls.Add(this.changepwdbtn);
            this.Controls.Add(this.nwpwdtxt);
            this.Controls.Add(this.conpwdtxt);
            this.Controls.Add(this.oldpwdtxt);
            this.Controls.Add(this.confirmpwdlbl);
            this.Controls.Add(this.newpwdlbl);
            this.Controls.Add(this.oldpwdlbl);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldpwdlbl;
        private System.Windows.Forms.Label newpwdlbl;
        private System.Windows.Forms.Label confirmpwdlbl;
        private System.Windows.Forms.TextBox oldpwdtxt;
        private System.Windows.Forms.TextBox conpwdtxt;
        private System.Windows.Forms.TextBox nwpwdtxt;
        private System.Windows.Forms.Button changepwdbtn;
    }
}