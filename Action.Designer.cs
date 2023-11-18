namespace LMSDemoTRS
{
    partial class Action
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.searchRadio = new System.Windows.Forms.RadioButton();
            this.changepwdRadio = new System.Windows.Forms.RadioButton();
            this.addRadio = new System.Windows.Forms.RadioButton();
            this.manageRadio = new System.Windows.Forms.RadioButton();
            this.returnRadio = new System.Windows.Forms.RadioButton();
            this.submitbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.returnRadio);
            this.groupBox1.Controls.Add(this.manageRadio);
            this.groupBox1.Controls.Add(this.addRadio);
            this.groupBox1.Controls.Add(this.changepwdRadio);
            this.groupBox1.Controls.Add(this.searchRadio);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searchRadio
            // 
            this.searchRadio.AutoSize = true;
            this.searchRadio.Location = new System.Drawing.Point(48, 53);
            this.searchRadio.Name = "searchRadio";
            this.searchRadio.Size = new System.Drawing.Size(142, 20);
            this.searchRadio.TabIndex = 0;
            this.searchRadio.TabStop = true;
            this.searchRadio.Text = "Search/Issue Book";
            this.searchRadio.UseVisualStyleBackColor = true;
            // 
            // changepwdRadio
            // 
            this.changepwdRadio.AutoSize = true;
            this.changepwdRadio.Location = new System.Drawing.Point(48, 244);
            this.changepwdRadio.Name = "changepwdRadio";
            this.changepwdRadio.Size = new System.Drawing.Size(138, 20);
            this.changepwdRadio.TabIndex = 2;
            this.changepwdRadio.TabStop = true;
            this.changepwdRadio.Text = "Change Password";
            this.changepwdRadio.UseVisualStyleBackColor = true;
            // 
            // addRadio
            // 
            this.addRadio.AutoSize = true;
            this.addRadio.Location = new System.Drawing.Point(48, 197);
            this.addRadio.Name = "addRadio";
            this.addRadio.Size = new System.Drawing.Size(151, 20);
            this.addRadio.TabIndex = 3;
            this.addRadio.TabStop = true;
            this.addRadio.Text = "Add/Remove Books";
            this.addRadio.UseVisualStyleBackColor = true;
            // 
            // manageRadio
            // 
            this.manageRadio.AutoSize = true;
            this.manageRadio.Location = new System.Drawing.Point(48, 153);
            this.manageRadio.Name = "manageRadio";
            this.manageRadio.Size = new System.Drawing.Size(147, 20);
            this.manageRadio.TabIndex = 4;
            this.manageRadio.TabStop = true;
            this.manageRadio.Text = "Manage Categories";
            this.manageRadio.UseVisualStyleBackColor = true;
            // 
            // returnRadio
            // 
            this.returnRadio.AutoSize = true;
            this.returnRadio.Location = new System.Drawing.Point(48, 107);
            this.returnRadio.Name = "returnRadio";
            this.returnRadio.Size = new System.Drawing.Size(102, 20);
            this.returnRadio.TabIndex = 5;
            this.returnRadio.TabStop = true;
            this.returnRadio.Text = "Return Book";
            this.returnRadio.UseVisualStyleBackColor = true;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(183, 369);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(180, 40);
            this.submitbtn.TabIndex = 1;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            // 
            // Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Action";
            this.Text = "Action Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton searchRadio;
        private System.Windows.Forms.RadioButton returnRadio;
        private System.Windows.Forms.RadioButton manageRadio;
        private System.Windows.Forms.RadioButton addRadio;
        private System.Windows.Forms.RadioButton changepwdRadio;
        private System.Windows.Forms.Button submitbtn;
    }
}