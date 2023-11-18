using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSDemoTRS
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBook book = new ManageBook();
            book.MdiParent = this;
            book.Show();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategory category = new ManageCategory();
            category.MdiParent = this;
            category.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchIssueBook issueBook = new SearchIssueBook();
            issueBook.MdiParent = this;
            issueBook.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnForm issueBook = new ReturnForm();
            issueBook.MdiParent = this;
            issueBook.Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mainform mainForm = new Mainform();
            mainForm.MdiParent = this;
            mainForm.Show();
        }
    }
}
