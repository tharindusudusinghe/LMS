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
    public partial class SearchIssueBook : Form
    {
        LMSAPPEntities context = new LMSAPPEntities();
        public SearchIssueBook()
        {
            InitializeComponent();
            bcatCombo.DataSource = context.Categories.ToList();
            bcatCombo.DisplayMember = "Title";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            resultgrid.AutoGenerateColumns = false;
            var books = context.Books.Where(x => x.Title == btitletxt.Text || x.Category == bcatCombo.SelectedText).ToList();
            resultgrid.DataSource = books;
        }

        private void bkcatgorylbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bcatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bktitletxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void resultgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void resultgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var title = resultgrid.Rows[e.RowIndex].Cells[2].Value;
            var Quantity = resultgrid.Rows[e.RowIndex].Cells[4].Value;
            var category = resultgrid.Rows[e.RowIndex].Cells[3].Value;
            var isbn = resultgrid.Rows[e.RowIndex].Cells[1].Value;
            bktitletxt.Text = title.ToString();
            availabletxt.Text = Quantity.ToString();
            bkcatgorytxt.Text = category.ToString();
            isbntxt.Text = isbn.ToString();

        }

        private void issuebkbtn_Click(object sender, EventArgs e)
        {
            IssueBook book = new IssueBook();
            book.ISBN = isbntxt.Text;
            book.Enrollment = entrollnumtxt.Text;
            book.issueReturn = true;
            var singleBook = context.Books.Where(x => x.ISBN == isbntxt.Text).FirstOrDefault();
            singleBook.Quantity -= 1;
            context.IssueBooks.Add(book);
            context.SaveChanges();
        }
    }
}
