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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                List<Modelss.Author> aut = db.Authors.ToList();

               

                List<Modelss.Order> ord = db.Orders.ToList();

                List<Modelss.Client> cll = db.Clients.ToList();
                string ad,ad2;
               
                string soyad ,soyad2;
                DateTime order, returndate;
                foreach (var item in cll)
                {
                    dgvOrder.Rows.Add(item.Name);
                  ad =  db.Clients.Select(g => g.Name).ToString();
                    soyad = db.Clients.Select(g => g.Surname).ToString();
                }
                foreach (var item in aut)
                {
                    dgvOrder.Rows.Add(item.Name);
                    ad2 = db.Authors.Select(g => g.Name).ToString();
                    soyad2 = db.Authors.Select(g => g.Surname).ToString();
                }

               
            }
        }
    }
}
