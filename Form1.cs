using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cable_Storage_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Opens the add form
            AddCable Form = new AddCable();
            Form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Opens the edit form
            EditCable Form = new EditCable();
            Form.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
