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
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            LMSAPPEntities context = new LMSAPPEntities();
            Category category = new Category();
            category.Title = catgorytxt.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("New Cotegory added");
        }
    }
}
