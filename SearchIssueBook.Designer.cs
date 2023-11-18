namespace LMSDemoTRS
{
    partial class SearchIssueBook
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
            this.bcatCombo = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.btitletxt = new System.Windows.Forms.TextBox();
            this.bkcatgorylbl = new System.Windows.Forms.Label();
            this.booktitlelbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultgrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.isbnlbl = new System.Windows.Forms.Label();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.entrollnumtxt = new System.Windows.Forms.TextBox();
            this.availabletxt = new System.Windows.Forms.TextBox();
            this.bkcatgorytxt = new System.Windows.Forms.TextBox();
            this.issuebkbtn = new System.Windows.Forms.Button();
            this.bktitletxt = new System.Windows.Forms.TextBox();
            this.entrollbl = new System.Windows.Forms.Label();
            this.catgorylbl = new System.Windows.Forms.Label();
            this.avlquantitylbl = new System.Windows.Forms.Label();
            this.bktitlelbl = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bcatCombo);
            this.groupBox1.Controls.Add(this.searchbtn);
            this.groupBox1.Controls.Add(this.btitletxt);
            this.groupBox1.Controls.Add(this.bkcatgorylbl);
            this.groupBox1.Controls.Add(this.booktitlelbl);
            this.groupBox1.Location = new System.Drawing.Point(29, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria - Enter Atleast one";
            // 
            // bcatCombo
            // 
            this.bcatCombo.FormattingEnabled = true;
            this.bcatCombo.Location = new System.Drawing.Point(187, 99);
            this.bcatCombo.Name = "bcatCombo";
            this.bcatCombo.Size = new System.Drawing.Size(270, 24);
            this.bcatCombo.TabIndex = 5;
            this.bcatCombo.SelectedIndexChanged += new System.EventHandler(this.bcatCombo_SelectedIndexChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(268, 195);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(189, 51);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // btitletxt
            // 
            this.btitletxt.Location = new System.Drawing.Point(187, 50);
            this.btitletxt.Name = "btitletxt";
            this.btitletxt.Size = new System.Drawing.Size(270, 22);
            this.btitletxt.TabIndex = 2;
            // 
            // bkcatgorylbl
            // 
            this.bkcatgorylbl.AutoSize = true;
            this.bkcatgorylbl.Location = new System.Drawing.Point(45, 102);
            this.bkcatgorylbl.Name = "bkcatgorylbl";
            this.bkcatgorylbl.Size = new System.Drawing.Size(97, 16);
            this.bkcatgorylbl.TabIndex = 1;
            this.bkcatgorylbl.Text = "Book Category";
            this.bkcatgorylbl.Click += new System.EventHandler(this.bkcatgorylbl_Click);
            // 
            // booktitlelbl
            // 
            this.booktitlelbl.AutoSize = true;
            this.booktitlelbl.Location = new System.Drawing.Point(45, 50);
            this.booktitlelbl.Name = "booktitlelbl";
            this.booktitlelbl.Size = new System.Drawing.Size(68, 16);
            this.booktitlelbl.TabIndex = 0;
            this.booktitlelbl.Text = "Book Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultgrid);
            this.groupBox2.Location = new System.Drawing.Point(612, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Results";
            // 
            // resultgrid
            // 
            this.resultgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ISBN,
            this.Title,
            this.Category,
            this.Quantity});
            this.resultgrid.Location = new System.Drawing.Point(20, 30);
            this.resultgrid.Name = "resultgrid";
            this.resultgrid.RowHeadersWidth = 51;
            this.resultgrid.RowTemplate.Height = 24;
            this.resultgrid.Size = new System.Drawing.Size(579, 253);
            this.resultgrid.TabIndex = 0;
            this.resultgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultgrid_CellClick);
            this.resultgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultgrid_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.isbnlbl);
            this.groupBox3.Controls.Add(this.isbntxt);
            this.groupBox3.Controls.Add(this.entrollnumtxt);
            this.groupBox3.Controls.Add(this.availabletxt);
            this.groupBox3.Controls.Add(this.bkcatgorytxt);
            this.groupBox3.Controls.Add(this.issuebkbtn);
            this.groupBox3.Controls.Add(this.bktitletxt);
            this.groupBox3.Controls.Add(this.entrollbl);
            this.groupBox3.Controls.Add(this.catgorylbl);
            this.groupBox3.Controls.Add(this.avlquantitylbl);
            this.groupBox3.Controls.Add(this.bktitlelbl);
            this.groupBox3.Location = new System.Drawing.Point(29, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1202, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Issue Book";
            // 
            // isbnlbl
            // 
            this.isbnlbl.AutoSize = true;
            this.isbnlbl.Location = new System.Drawing.Point(612, 107);
            this.isbnlbl.Name = "isbnlbl";
            this.isbnlbl.Size = new System.Drawing.Size(124, 16);
            this.isbnlbl.TabIndex = 12;
            this.isbnlbl.Text = "Book ISBN Number";
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(814, 107);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(270, 22);
            this.isbntxt.TabIndex = 11;
            // 
            // entrollnumtxt
            // 
            this.entrollnumtxt.Location = new System.Drawing.Point(814, 28);
            this.entrollnumtxt.Name = "entrollnumtxt";
            this.entrollnumtxt.Size = new System.Drawing.Size(270, 22);
            this.entrollnumtxt.TabIndex = 10;
            // 
            // availabletxt
            // 
            this.availabletxt.Location = new System.Drawing.Point(187, 107);
            this.availabletxt.Name = "availabletxt";
            this.availabletxt.Size = new System.Drawing.Size(270, 22);
            this.availabletxt.TabIndex = 8;
            // 
            // bkcatgorytxt
            // 
            this.bkcatgorytxt.Location = new System.Drawing.Point(187, 176);
            this.bkcatgorytxt.Name = "bkcatgorytxt";
            this.bkcatgorytxt.Size = new System.Drawing.Size(270, 22);
            this.bkcatgorytxt.TabIndex = 7;
            // 
            // issuebkbtn
            // 
            this.issuebkbtn.Location = new System.Drawing.Point(584, 214);
            this.issuebkbtn.Name = "issuebkbtn";
            this.issuebkbtn.Size = new System.Drawing.Size(226, 46);
            this.issuebkbtn.TabIndex = 6;
            this.issuebkbtn.Text = "Issue Book";
            this.issuebkbtn.UseVisualStyleBackColor = true;
            this.issuebkbtn.Click += new System.EventHandler(this.issuebkbtn_Click);
            // 
            // bktitletxt
            // 
            this.bktitletxt.Location = new System.Drawing.Point(187, 33);
            this.bktitletxt.Name = "bktitletxt";
            this.bktitletxt.Size = new System.Drawing.Size(270, 22);
            this.bktitletxt.TabIndex = 5;
            this.bktitletxt.TextChanged += new System.EventHandler(this.bktitletxt_TextChanged);
            // 
            // entrollbl
            // 
            this.entrollbl.AutoSize = true;
            this.entrollbl.Location = new System.Drawing.Point(612, 31);
            this.entrollbl.Name = "entrollbl";
            this.entrollbl.Size = new System.Drawing.Size(172, 16);
            this.entrollbl.TabIndex = 4;
            this.entrollbl.Text = "Student Entrollment Number";
            // 
            // catgorylbl
            // 
            this.catgorylbl.AutoSize = true;
            this.catgorylbl.Location = new System.Drawing.Point(45, 176);
            this.catgorylbl.Name = "catgorylbl";
            this.catgorylbl.Size = new System.Drawing.Size(97, 16);
            this.catgorylbl.TabIndex = 3;
            this.catgorylbl.Text = "Book Category";
            // 
            // avlquantitylbl
            // 
            this.avlquantitylbl.AutoSize = true;
            this.avlquantitylbl.Location = new System.Drawing.Point(45, 107);
            this.avlquantitylbl.Name = "avlquantitylbl";
            this.avlquantitylbl.Size = new System.Drawing.Size(115, 16);
            this.avlquantitylbl.TabIndex = 2;
            this.avlquantitylbl.Text = "Available Quantity";
            // 
            // bktitlelbl
            // 
            this.bktitlelbl.AutoSize = true;
            this.bktitlelbl.Location = new System.Drawing.Point(45, 39);
            this.bktitlelbl.Name = "bktitlelbl";
            this.bktitlelbl.Size = new System.Drawing.Size(68, 16);
            this.bktitlelbl.TabIndex = 0;
            this.bktitlelbl.Text = "Book Title";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 125;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // SearchIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 669);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchIssueBook";
            this.Text = "Search Issue Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultgrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox bcatCombo;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox btitletxt;
        private System.Windows.Forms.Label bkcatgorylbl;
        private System.Windows.Forms.Label booktitlelbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView resultgrid;
        private System.Windows.Forms.Label entrollbl;
        private System.Windows.Forms.Label catgorylbl;
        private System.Windows.Forms.Label avlquantitylbl;
        private System.Windows.Forms.Label bktitlelbl;
        private System.Windows.Forms.Button issuebkbtn;
        private System.Windows.Forms.TextBox bktitletxt;
        private System.Windows.Forms.TextBox entrollnumtxt;
        private System.Windows.Forms.TextBox availabletxt;
        private System.Windows.Forms.TextBox bkcatgorytxt;
        private System.Windows.Forms.Label isbnlbl;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}