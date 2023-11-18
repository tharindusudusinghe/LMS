namespace LMSDemoTRS
{
    partial class ReturnForm
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
            this.entISBNlbl = new System.Windows.Forms.Label();
            this.enterentnumlbl = new System.Windows.Forms.Label();
            this.bkreturnbtn = new System.Windows.Forms.Button();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.entroltxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entISBNlbl
            // 
            this.entISBNlbl.AutoSize = true;
            this.entISBNlbl.Location = new System.Drawing.Point(38, 48);
            this.entISBNlbl.Name = "entISBNlbl";
            this.entISBNlbl.Size = new System.Drawing.Size(123, 16);
            this.entISBNlbl.TabIndex = 0;
            this.entISBNlbl.Text = "Enter ISBN Number";
            this.entISBNlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // enterentnumlbl
            // 
            this.enterentnumlbl.AutoSize = true;
            this.enterentnumlbl.Location = new System.Drawing.Point(38, 107);
            this.enterentnumlbl.Name = "enterentnumlbl";
            this.enterentnumlbl.Size = new System.Drawing.Size(206, 16);
            this.enterentnumlbl.TabIndex = 1;
            this.enterentnumlbl.Text = "Enter Student Entrollment Number";
            // 
            // bkreturnbtn
            // 
            this.bkreturnbtn.Location = new System.Drawing.Point(250, 216);
            this.bkreturnbtn.Name = "bkreturnbtn";
            this.bkreturnbtn.Size = new System.Drawing.Size(229, 42);
            this.bkreturnbtn.TabIndex = 2;
            this.bkreturnbtn.Text = "Book Return";
            this.bkreturnbtn.UseVisualStyleBackColor = true;
            this.bkreturnbtn.Click += new System.EventHandler(this.bkreturnbtn_Click);
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(290, 42);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(342, 22);
            this.isbntxt.TabIndex = 3;
            // 
            // entroltxt
            // 
            this.entroltxt.Location = new System.Drawing.Point(290, 107);
            this.entroltxt.Name = "entroltxt";
            this.entroltxt.Size = new System.Drawing.Size(342, 22);
            this.entroltxt.TabIndex = 4;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 331);
            this.Controls.Add(this.entroltxt);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.bkreturnbtn);
            this.Controls.Add(this.enterentnumlbl);
            this.Controls.Add(this.entISBNlbl);
            this.Name = "ReturnForm";
            this.Text = "Return Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entISBNlbl;
        private System.Windows.Forms.Label enterentnumlbl;
        private System.Windows.Forms.Button bkreturnbtn;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.TextBox entroltxt;
    }
}