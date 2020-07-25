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
            // TODO: This line of code loads data into the 'choreganizer_ARDataSet.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.choreganizer_ARDataSet.history);
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
            // get values from the controls and add to SQL query
            // "Date"
            string choreDate = this.dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string choreDate1 = "";
            string choreDate2 = "";
            if (choreDate != "")
            {
                choreDate1 = ", chore_date";
                choreDate2 = ", '" + choreDate + "'";
            }
            // "Completed"
            string choreComplete1 = "";
            string choreComplete2 = "";
            if (this.checkBox1.Checked)
            {
                choreComplete1 = ", completed";
                choreComplete2 = ", 'yes'";
            }
            // "Points"
            string chorePoints = this.pointsTextBox.Text;
            string chorePoints1 = "";
            string chorePoints2 = "";
            if (chorePoints != "")
            {
                chorePoints1 = ", points";
                chorePoints2 = ", " + chorePoints;
            }

            // Send to database
            string Query = "INSERT INTO [dbo].[history] (chore_id, user_id" + choreDate1 + choreComplete1 + chorePoints1 + ") " +
                "VALUES ('" + this.comboBox2.Text + "', '" + this.comboBox1.Text + "'"+ choreDate2 + choreComplete2 + chorePoints2 + "); ";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
