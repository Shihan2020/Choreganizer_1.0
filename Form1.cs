using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choreganizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void choresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.choresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.choreganizer_ARDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'choreganizer_ARDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.choreganizer_ARDataSet.users);
            // TODO: This line of code loads data into the 'choreganizer_ARDataSet.chores' table. You can move, or remove it, as needed.
            this.choresTableAdapter.Fill(this.choreganizer_ARDataSet.chores);

        }
    }
}
