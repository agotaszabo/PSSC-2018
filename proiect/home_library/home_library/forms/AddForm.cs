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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        //ADD_NEW_BOOK_BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            /**
             * TO-DO => create a Close methor
             * which closes the current form, and re-shows the main form
             * see code bellow (you may create a new folder with methods (e.g Helpers):
             *       //this.Close();
             *       //Form1 f = new Form1();
             *       //f.Show();
             */

        }

        //CANCEL_BUTTON AKA CLOSE
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
    }
}
