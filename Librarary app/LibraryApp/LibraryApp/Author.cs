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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                List<Modelss.Author> authorr = db.Authors.ToList();

                Modelss.Author auth = new Modelss.Author();
                auth.Name = autname.Text;
                auth.Surname = authSurname.Text;

                db.Authors.Add(auth);
                db.SaveChanges();

                authorDVG.Rows.Add(autname.Text , authSurname.Text);
            }
        }
    }
}
