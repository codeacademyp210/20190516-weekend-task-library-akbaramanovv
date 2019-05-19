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
    public partial class Txtclient : Form
    {


        public Txtclient()
        {
            InitializeComponent();
        }

        public void SearchUser()
        {
            string SearchKey = clSearch.Text.Trim().ToLower();
            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                List<Client> findClients = db.Clients.Where(c => c.Name.ToLower().Contains(SearchKey) || c.Email.ToLower().Contains(SearchKey) || c.Phone.ToLower().Contains(SearchKey) || c.Surname.ToLower().Contains(SearchKey)).ToList();

                ClientsData.Rows.Clear();
                foreach (var item in findClients)
                {
                    ClientsData.Rows.Add(item.ID, item.Name, item.Surname, item.Email, item.Phone);
                }
            }
        }

        public void SearchBook()
        {

            string SearchKey2 = txtBook.Text.Trim().ToLower();
            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                List<Book> findBooks = db.Books.Where(c => c.Name.ToLower().Contains(SearchKey2)).ToList();

                booksData.Rows.Clear();
                foreach (var item2 in findBooks)
                {
                    booksData.Rows.Add(item2.ID, item2.Name, item2.AuthorsBooks, item2.Price, item2.CategoryID, item2.Count);
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            SearchUser();

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SearchBook();
        }


        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.ShowDialog();
        }

        private void CategoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CAtegories ctg = new CAtegories();
            ctg.ShowDialog();
        }

        private void AuthorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.ShowDialog();
        }

        private void ClientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientss client = new Clientss();
            client.ShowDialog();
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
        }
        public void CreateDVG()
        {
            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {

                List<Client> clients = db.Clients.ToList();
                foreach (var client in clients)
                {
                    ClientsData.Rows.Add(client.ID, client.Name, client.Surname, client.Email, client.Phone);
                }

                List<Book> books = db.Books.ToList();


                List<AuthorsBook> authorB = db.AuthorsBooks.ToList();
                List<Modelss.Author> authors = db.Authors.ToList();


                foreach (var book in books)
                {
                    booksData.Rows.Add(book.ID, book.Name, book.AuthorsBooks, book.Price, book.CategoryID, book.Count);

                }

            }
        }
        private void Txtclient_Load(object sender, EventArgs e)
        {

            CreateDVG();
        }

        private void Orderbtn_Click(object sender, EventArgs e)
        {
            Modelss.Order ord = new Modelss.Order();

            DateTime orderDate = DateTime.Now;
            DateTime nextMonth = orderDate.AddDays(1).AddMonths(1).AddDays(-1);
            int customerID = Convert.ToInt32(ClientsData.CurrentRow.Cells[0].Value);
            int bookid = Convert.ToInt32(booksData.CurrentRow.Cells[0].Value);
            ord.ClientID = customerID;
            ord.BookID = bookid;
            ord.OrderDate = orderDate;
            ord.ReturnDate = nextMonth;

            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                MessageBox.Show("Created Order");
                db.Orders.Add(ord);
                db.SaveChanges();
            }
        }
        public void refreshDataGridView1()
        {
            MessageBox.Show("salam");

            using (Modelss.KITABXANADB db = new Modelss.KITABXANADB())
            {
                booksData.Rows.Clear();
                List<Modelss.Book> books = db.Books.ToList();

                foreach (var book in books)
                {
                    booksData.Rows.Add(book.ID, book.Name, book.AuthorsBooks, book.Price, book.CategoryID, book.Count);

                }
            }
        }
    }
    }
