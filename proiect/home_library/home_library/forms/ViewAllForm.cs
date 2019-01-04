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
    public partial class ViewAllForm : Form
    {
        public ViewAllForm()
        {
            InitializeComponent();
        }

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
