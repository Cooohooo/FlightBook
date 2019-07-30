using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PRG455_PROJECT
{
    public partial class Form1_reserve : Form
    {
        string userQuery;
        string first = null;
        public static bool t;
        public static string x;
        public static string y;
        public static double total;
        public static string temp;
        public static string number;
        public static string countf;
        public static string countc;
        public static string flightID;
        bool checkf = true;
        bool checkc = true;


        public Form1_reserve()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_reserve_Load(object sender, EventArgs e)
        {
            dataGridView1_show.Visible = false;
            textBox1_from.Clear();
            textBox2_to.Clear();
            textBox1_numbers.Clear();
        }

        public void dbfun(string str)
        {
            try
            {
                DataTable vt = new DataTable();
                string constr = "Provider = Microsoft.ACE.OLEDB.12.0; Data source = D:\\Database11.accdb";
                OleDbDataAdapter da = new OleDbDataAdapter(str, constr);
                da.Fill(vt);
                dataGridView1_show.DataSource = vt;
                if (dataGridView1_show.RowCount == 0)
                {
                    MessageBox.Show("No flight is found");
                    textBox1_from.Clear();
                    textBox2_to.Clear();
                    textBox1_from.Focus();
                }
                else
                {
                    dataGridView1_show.Visible = true;
                    dataGridView1_show.Columns[0].Visible = false;
                    dataGridView1_show.Columns[7].Visible = false;
                    dataGridView1_show.Columns[9].Visible = false;
                }
                da.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("database is disconnected");
            } 
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            userQuery = textBox2_to.Text;
            string sqlstr = " SELECT * FROM [flight information] WHERE city_of_destination LIKE '" + userQuery + "'";
            dbfun(sqlstr);
            dataGridView1_show.Columns[10].DisplayIndex = 1;
        }

        private void btn_checkFrom_Click_1(object sender, EventArgs e)
        {
            userQuery = textBox1_from.Text;
            string sqlstr = " SELECT * FROM [flight information] WHERE city_of_departure LIKE '" + userQuery + "'";
            dbfun(sqlstr);
            dataGridView1_show.Columns[10].DisplayIndex = 1;

        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            try
            {
                countf = this.dataGridView1_show.CurrentRow.Cells[6].Value.ToString();
                countc = this.dataGridView1_show.CurrentRow.Cells[8].Value.ToString();
                flightID = this.dataGridView1_show.CurrentRow.Cells[10].Value.ToString();
                x = this.dataGridView1_show.CurrentRow.Cells[1].Value.ToString();
                y = this.dataGridView1_show.CurrentRow.Cells[2].Value.ToString();
                temp = this.dataGridView1_show.CurrentRow.Cells[5].Value.ToString();
                total = 1.13 * (Convert.ToDouble(temp));
            }
            catch (Exception a)
            {
                MessageBox.Show("type in the destination first.");
            }        
            if (first == null)
            {
                MessageBox.Show("Choose a type of seat first.");
            }
            else
            {
                if (t == false)
                {
                    if (first == "Aclass" && checkf == true)
                    {
                        Form2_purchase f2 = new Form2_purchase();
                        this.Hide();
                        f2.ShowDialog();
                    }
                    else 
                    {
                        MessageBox.Show("You can not select more than total firstclass seats.");
                    }
                }
                else if (t == true)
                {
                    if (first == "Coachclass" && checkc == true)
                    {
                        Form2_purchase f2 = new Form2_purchase();
                        this.Hide();
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("You can not select more than total coach seats.");
                    }
                }
            }
        }

        private void radioButton1_coach_CheckedChanged(object sender, EventArgs e)
        {
            first = "Coachclass";
            t = true;
        }

        private void radioButton1_fc_CheckedChanged(object sender, EventArgs e)
        {
            first = "Aclass";
            t = false;
        }

        private void dataGridView1_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_numbers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                number = textBox1_numbers.Text;
                double i = Convert.ToDouble(textBox1_numbers.Text);
                double first_avail = Convert.ToDouble(countf);
                double coach_avail = Convert.ToDouble(countc);
                if (i > first_avail)
                {
                    checkf = false;
                }
                else if (i > coach_avail)
                {
                    checkc = false;
                }
                if (i < first_avail)
                {
                    checkf = true;
                }
                else if (i < coach_avail)
                {
                    checkc = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("type in the right number in the textbox.");
            }
        }


    }
}
