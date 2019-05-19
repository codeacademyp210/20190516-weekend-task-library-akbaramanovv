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
    public partial class CAtegories : Form
    {
        public CAtegories()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                Modelss.Category ctgr = new Modelss.Category();

                ctgr.Name = ctgrtxt.Text;
                db.Categories.Add(ctgr);
                db.SaveChanges();
            }
            ctgDVG.Rows.Add(ctgrtxt.Text);
          
        }
      
    }
}
