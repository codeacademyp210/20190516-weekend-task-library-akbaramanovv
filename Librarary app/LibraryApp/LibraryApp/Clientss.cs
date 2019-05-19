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
    public partial class Clientss : Form
    {
        Txtclient txt = new Txtclient();
        public Clientss()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string clName = CLname.Text;
            string ClSurname = Clsurname.Text;
            string email = mail.Text;
            string phonee = tel.Text;

            DVGclient.Rows.Add(clName, ClSurname, email, email, phonee);

            Modelss.Client cl = new Modelss.Client();
            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                cl.Name = CLname.Text;
                cl.Surname = Clsurname.Text;
                cl.Email = mail.Text;
                cl.Phone = tel.Text;
                db.Clients.Add(cl);
                cl.Status = true;
                db.SaveChanges();
            }
        }
        private void Clientss_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
