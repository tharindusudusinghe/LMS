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
    public partial class ManageBook : Form
    {
        LMSAPPEntities context = new LMSAPPEntities();
        public ManageBook()
        {
            InitializeComponent();
            catcombo.DataSource = context.Categories.ToList();
            catcombo.DisplayMember = "Title";
        }

        private void addnwbtn_Click(object sender, EventArgs e)
        {
            LMSAPPEntities context = new LMSAPPEntities();
            Book book = new Book();
            book.ISBN = addISBNNumtxt.Text;
            book.Title = addbktitletxt.Text;
            book.Category = catcombo.SelectedText;
            book.Quantity = Convert.ToInt32(addqtytxt.Text);
            context.Books.Add(book);
            context.SaveChanges();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            LMSAPPEntities context = new LMSAPPEntities();
            var book = context.Books.Where(x => x.ISBN == isbntxt.Text).FirstOrDefault();
            titletxt.Text = book.Title;
            categorytxt.Text = book.Category;
            avlqtytxt.Text = Convert.ToString(book.Quantity);
            titletxt.ReadOnly = true;
            categorytxt.ReadOnly = true;
            avlqtytxt.ReadOnly = true;
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            LMSAPPEntities context = new LMSAPPEntities();
            var book = context.Books.Where(x => x.ISBN == isbntxt.Text).FirstOrDefault();
            var bookQty = book.Quantity - Convert.ToInt32(removeqtytxt.Text);
            book.Quantity = bookQty;
            context.SaveChanges();
            MessageBox.Show($"Book {removeqtytxt.Text} Removed");

        }
    }
}
