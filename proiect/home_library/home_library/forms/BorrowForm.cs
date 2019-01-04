using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_library.forms
{
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void RegisterBorrowBtn_Click(object sender, EventArgs e)
        {
            /** TO-DO => call the corresponding ViewModel
             *  e.g. registerBorrowing_viewModel => re-use this one
             */
        }

        //AKA Close Button
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            /**
            * TO-DO => call the Close methor
            * see above for more details
            */

            //delete these 3 lines, after the Close method works
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            /** TO-DO => call the corresponding ViewModel
             *  e.g. searchBook_viewModel => re-use this one
             *  
             *  Please verify the input data, if possible.
             *  Multumes! :D
             */
        }
    }
}
