using LibraryApp.Modelss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryApp
{
    public partial class Books : Form
    {
      
      
        public Books()
        {
            InitializeComponent();
        }

      

        private void Books_Load(object sender, EventArgs e)
        {
            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                cbAuthor.DataSource = db.Authors.Select(g => g.Name).ToList();
                categoryCB.DataSource = db.Categories.Select(g => g.Name).ToList();
               
            }
        }

        private void SaveBook_Click(object sender, EventArgs e)
        {
            Modelss.Book bok = new Modelss.Book();

            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
           
            }
            Modelss.Category ct = new Modelss.Category();

            string bookN = bookname.Text.ToString();
            string autor = cbAuthor.SelectedItem.ToString();
            string pricee = bookprice.Text.ToString();
            string ctg = categoryCB.SelectedItem.ToString();
            string countt = bookcount.Text.ToString();
            decimal dbprice = Convert.ToDecimal(bookprice.Text);
            dgvBooks.Rows.Add(bookN, autor, pricee, ctg, countt);
            bok.CategoryID =2 ;
            bok.Name = bookN;
            bok.Price = dbprice;
            bok.Count = Convert.ToInt32(countt);
            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                db.Books.Add(bok);
                db.SaveChanges();
            }
           

        }

        private void Books_FormClosed(object sender, FormClosedEventArgs e)
        {
            Txtclient frm = new Txtclient();
            frm.refreshDataGridView1();
        }
    }
}
