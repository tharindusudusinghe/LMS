namespace LMSDemoTRS
{
    partial class ManageCategory
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
            this.addnewcatlbl = new System.Windows.Forms.Label();
            this.catgorytxt = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addnewcatlbl
            // 
            this.addnewcatlbl.AutoSize = true;
            this.addnewcatlbl.Location = new System.Drawing.Point(29, 46);
            this.addnewcatlbl.Name = "addnewcatlbl";
            this.addnewcatlbl.Size = new System.Drawing.Size(120, 16);
            this.addnewcatlbl.TabIndex = 0;
            this.addnewcatlbl.Text = "Add New Category";
            // 
            // catgorytxt
            // 
            this.catgorytxt.Location = new System.Drawing.Point(189, 46);
            this.catgorytxt.Name = "catgorytxt";
            this.catgorytxt.Size = new System.Drawing.Size(272, 22);
            this.catgorytxt.TabIndex = 1;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(150, 121);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(156, 48);
            this.submitbtn.TabIndex = 2;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 221);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.catgorytxt);
            this.Controls.Add(this.addnewcatlbl);
            this.Name = "ManageCategory";
            this.Text = "ManageCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addnewcatlbl;
        private System.Windows.Forms.TextBox catgorytxt;
        private System.Windows.Forms.Button submitbtn;
    }
}