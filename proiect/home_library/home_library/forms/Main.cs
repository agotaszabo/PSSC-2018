using home_library.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //ADD_NEW_BOOK_BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm form = new AddForm(); // Instantiate a Form3 object.
            form.Show();
        }

        //BORROW_BOOK_BUTTON
        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowForm form = new BorrowForm(); // Instantiate a Form3 object.
            form.Show();
        }

        //SEARCH_BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm form = new SearchForm(); // Instantiate a Form3 object.
            form.Show();
        }

        //VIEW_ALL_BOOKS_BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllForm form = new ViewAllForm(); // Instantiate a Form3 object.
            form.Show();
        }

        //VIEW_BORROWED_BOOKS_BUTTON
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBorroweForm form = new ViewBorroweForm(); // Instantiate a Form3 object.
            form.Show();
        }

        //REMOVE_BORROWED_BOOKS_BUTTON
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveForm form = new RemoveForm(); // Instantiate a Form3 object.
            form.Show();
        }
    }
}
