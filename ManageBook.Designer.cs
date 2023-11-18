namespace LMSDemoTRS
{
    partial class ManageBook
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
            this.addnwbtn = new System.Windows.Forms.Button();
            this.catcombo = new System.Windows.Forms.ComboBox();
            this.addbktitletxt = new System.Windows.Forms.TextBox();
            this.addqtytxt = new System.Windows.Forms.TextBox();
            this.addISBNNumtxt = new System.Windows.Forms.TextBox();
            this.bktitlelbl = new System.Windows.Forms.Label();
            this.categorylbl = new System.Windows.Forms.Label();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.bkisbnlbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.removeqtytxt = new System.Windows.Forms.TextBox();
            this.categorytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.removebtn = new System.Windows.Forms.Button();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.avlqtytxt = new System.Windows.Forms.TextBox();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addnwbtn);
            this.groupBox1.Controls.Add(this.catcombo);
            this.groupBox1.Controls.Add(this.addbktitletxt);
            this.groupBox1.Controls.Add(this.addqtytxt);
            this.groupBox1.Controls.Add(this.addISBNNumtxt);
            this.groupBox1.Controls.Add(this.bktitlelbl);
            this.groupBox1.Controls.Add(this.categorylbl);
            this.groupBox1.Controls.Add(this.quantitylbl);
            this.groupBox1.Controls.Add(this.bkisbnlbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Books";
            // 
            // addnwbtn
            // 
            this.addnwbtn.Location = new System.Drawing.Point(197, 278);
            this.addnwbtn.Name = "addnwbtn";
            this.addnwbtn.Size = new System.Drawing.Size(152, 35);
            this.addnwbtn.TabIndex = 9;
            this.addnwbtn.Text = "Add New Book";
            this.addnwbtn.UseVisualStyleBackColor = true;
            this.addnwbtn.Click += new System.EventHandler(this.addnwbtn_Click);
            // 
            // catcombo
            // 
            this.catcombo.FormattingEnabled = true;
            this.catcombo.Location = new System.Drawing.Point(197, 148);
            this.catcombo.Name = "catcombo";
            this.catcombo.Size = new System.Drawing.Size(309, 24);
            this.catcombo.TabIndex = 8;
            this.catcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addbktitletxt
            // 
            this.addbktitletxt.Location = new System.Drawing.Point(197, 97);
            this.addbktitletxt.Name = "addbktitletxt";
            this.addbktitletxt.Size = new System.Drawing.Size(309, 22);
            this.addbktitletxt.TabIndex = 7;
            // 
            // addqtytxt
            // 
            this.addqtytxt.Location = new System.Drawing.Point(197, 200);
            this.addqtytxt.Name = "addqtytxt";
            this.addqtytxt.Size = new System.Drawing.Size(309, 22);
            this.addqtytxt.TabIndex = 6;
            // 
            // addISBNNumtxt
            // 
            this.addISBNNumtxt.Location = new System.Drawing.Point(197, 50);
            this.addISBNNumtxt.Name = "addISBNNumtxt";
            this.addISBNNumtxt.Size = new System.Drawing.Size(309, 22);
            this.addISBNNumtxt.TabIndex = 4;
            // 
            // bktitlelbl
            // 
            this.bktitlelbl.AutoSize = true;
            this.bktitlelbl.Location = new System.Drawing.Point(27, 103);
            this.bktitlelbl.Name = "bktitlelbl";
            this.bktitlelbl.Size = new System.Drawing.Size(68, 16);
            this.bktitlelbl.TabIndex = 3;
            this.bktitlelbl.Text = "Book Title";
            // 
            // categorylbl
            // 
            this.categorylbl.AutoSize = true;
            this.categorylbl.Location = new System.Drawing.Point(27, 156);
            this.categorylbl.Name = "categorylbl";
            this.categorylbl.Size = new System.Drawing.Size(62, 16);
            this.categorylbl.TabIndex = 2;
            this.categorylbl.Text = "Category";
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Location = new System.Drawing.Point(27, 206);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(55, 16);
            this.quantitylbl.TabIndex = 1;
            this.quantitylbl.Text = "Quantity";
            // 
            // bkisbnlbl
            // 
            this.bkisbnlbl.AutoSize = true;
            this.bkisbnlbl.Location = new System.Drawing.Point(27, 52);
            this.bkisbnlbl.Name = "bkisbnlbl";
            this.bkisbnlbl.Size = new System.Drawing.Size(124, 16);
            this.bkisbnlbl.TabIndex = 0;
            this.bkisbnlbl.Text = "Book ISBN Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchbtn);
            this.groupBox2.Controls.Add(this.removeqtytxt);
            this.groupBox2.Controls.Add(this.categorytxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.removebtn);
            this.groupBox2.Controls.Add(this.titletxt);
            this.groupBox2.Controls.Add(this.avlqtytxt);
            this.groupBox2.Controls.Add(this.isbntxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 358);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Books";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(559, 40);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(152, 35);
            this.searchbtn.TabIndex = 13;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // removeqtytxt
            // 
            this.removeqtytxt.Location = new System.Drawing.Point(197, 251);
            this.removeqtytxt.Name = "removeqtytxt";
            this.removeqtytxt.Size = new System.Drawing.Size(309, 22);
            this.removeqtytxt.TabIndex = 12;
            // 
            // categorytxt
            // 
            this.categorytxt.Location = new System.Drawing.Point(197, 156);
            this.categorytxt.Name = "categorytxt";
            this.categorytxt.Size = new System.Drawing.Size(309, 22);
            this.categorytxt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity To be Removed";
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(197, 306);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(152, 35);
            this.removebtn.TabIndex = 9;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(197, 97);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(309, 22);
            this.titletxt.TabIndex = 7;
            // 
            // avlqtytxt
            // 
            this.avlqtytxt.Location = new System.Drawing.Point(197, 200);
            this.avlqtytxt.Name = "avlqtytxt";
            this.avlqtytxt.Size = new System.Drawing.Size(309, 22);
            this.avlqtytxt.TabIndex = 6;
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(197, 46);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(309, 22);
            this.isbntxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Available Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book ISBN Number";
            // 
            // ManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 793);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageBook";
            this.Text = "Manage Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bktitlelbl;
        private System.Windows.Forms.Label categorylbl;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.Label bkisbnlbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button addnwbtn;
        private System.Windows.Forms.ComboBox catcombo;
        private System.Windows.Forms.TextBox addbktitletxt;
        private System.Windows.Forms.TextBox addqtytxt;
        private System.Windows.Forms.TextBox addISBNNumtxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox removeqtytxt;
        private System.Windows.Forms.TextBox categorytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.TextBox avlqtytxt;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}