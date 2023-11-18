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
    public partial class ReturnForm : Form
    {
        LMSAPPEntities context = new LMSAPPEntities();
        public ReturnForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bkreturnbtn_Click(object sender, EventArgs e)
        {
            var issuebookByStudent = context.IssueBooks.Where(x => x.ISBN == isbntxt.Text && x.issueReturn == true).FirstOrDefault();
            issuebookByStudent.issueReturn = false;
            var book = context.Books.Where(x => x.ISBN == isbntxt.Text).FirstOrDefault();
            book.Quantity += 1;
            context.SaveChanges();
            MessageBox.Show("Book Returned");
        }
    }
}
