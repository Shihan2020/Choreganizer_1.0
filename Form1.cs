using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // CREATED 7/22/20 
            // added code based on ProgrammingKnowledge: https://www.youtube.com/watch?v=sSBx9_eddmo

            string conString = "Data Source=choreganizerdb.cg1zijglf85b.us-east-2.rds.amazonaws.com,1433;Initial Catalog=choreganizer_AR;" +
                "Persist Security Info=True;User ID=shihan2020;Password=Psycobetabuckdown";
            string Query = "INSERT INTO [dbo].[history] (chore_id, user_id) VALUES ('" + this.comboBox2.Text + "'," +
                "'" + this.comboBox1.Text + "'); ";
            SqlConnection conSaveChore = new SqlConnection(conString);
            SqlCommand cmdSaveChore = new SqlCommand(Query, conSaveChore);
            SqlDataReader myReader;
            try
            {
                conSaveChore.Open();
                myReader = cmdSaveChore.ExecuteReader();
                MessageBox.Show("Saved!!");
                while (myReader.Read()) { }
            } 
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
