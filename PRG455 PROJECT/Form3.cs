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
    public partial class Form3_receipt : Form
    {
        string connect = "Provider = Microsoft.ACE.OLEDB.12.0; Data source = D:\\Database11.accdb";
        string flight1;
        string id;
        string dep;
        string des;
        string firstname;
        string lastname;
        string telephone;
        string addr;

        public Form3_receipt()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_receipt_Load(object sender, EventArgs e)
        {
            label1_infor.Text = Form2_purchase.customerid;
            label1_infor2.Text = Form2_purchase.fn + Form2_purchase.ln;
            label1_infor3.Text = Form2_purchase.telephone;
            label1_infor4.Text = "$" + Convert.ToString(Form1_reserve.total);
            telephone = Form2_purchase.telephone;
            lastname = Form2_purchase.ln;
            firstname = Form2_purchase.fn;
            addr = Form2_purchase.address;
            flight1 = Form1_reserve.flightID;
            id = Form2_purchase.IDcustomer;
            dep = Form1_reserve.x;
            des = Form1_reserve.y;
        }

        private void label1_infor4_Click(object sender, EventArgs e)
        {

        }

        private void button1_done_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Your order is purchased. ");
            Form1_reserve f1 = new Form1_reserve();
            this.Hide();
            f1.ShowDialog();
        }

        private void cancleCoach()
        {
            try
            {
                OleDbConnection connection2 = new OleDbConnection(connect);
                connection2.Open();
                string Coach;
                Coach = Form1_reserve.countc;
                string sqldelete = "UPDATE [flight information] SET coach_seats_sold=('0'), coach_seats_available = ('" + Coach + "') WHERE city_of_departure='" + dep + "' AND city_of_destination='" + des + "'";
                OleDbDataAdapter da2 = new OleDbDataAdapter();
                da2.InsertCommand = new OleDbCommand(sqldelete, connection2);
                da2.InsertCommand.ExecuteNonQuery();
                connection2.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show("command update is failed.");
            }
        }

        private void cancleFirst()
        {
            try
            {
                OleDbConnection connection3 = new OleDbConnection(connect);
                connection3.Open();
                string First;
                First = Form1_reserve.countf;
                string sqlfirst = "UPDATE [flight information] SET firstclass_seats_sold = ('0'), firstclass_seats_available = ('" + First + "') WHERE city_of_departure='" + dep + "' AND city_of_destination='" + des + "'";
                OleDbDataAdapter da2 = new OleDbDataAdapter();
                da2.InsertCommand = new OleDbCommand(sqlfirst, connection3);
                da2.InsertCommand.ExecuteNonQuery();
                connection3.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show("command update is failed.");
            }
        }

        private void cancleID()
        {
            OleDbConnection connection4 = new OleDbConnection(connect);
            connection4.Open();
            string sqldelete = "DELETE FROM [purchase information] WHERE (FlightID = '"+ flight1 +"' AND CustomerID = '" + id + "')";
            OleDbDataAdapter da2 = new OleDbDataAdapter();
            da2.InsertCommand = new OleDbCommand(sqldelete, connection4);
            da2.InsertCommand.ExecuteNonQuery();
            connection4.Close();
        }
        private void cancleCustomer()
        {
            OleDbConnection connection = new OleDbConnection(connect);
            connection.Open();
            string sqladd1 = "DELETE FROM [customer information] WHERE (FirstName = '" + firstname + "' AND LastName = '"+ lastname +"' AND telephone = '"+ telephone +"' AND address = '"+ addr +"' AND CustomerID = '" + id + "')";
            OleDbDataAdapter da2 = new OleDbDataAdapter();
            da2.InsertCommand = new OleDbCommand(sqladd1, connection);
            da2.InsertCommand.ExecuteNonQuery();
            connection.Close();
            try
            {
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Delete is failed.");
            }
        }
            
        private void button1_cancle_Click(object sender, EventArgs e)
        {
            cancleID();
            cancleCustomer();
            if (Form1_reserve.t == true)
            {
                cancleCoach();
                
            }
            else if (Form1_reserve.t == false)
            {
                cancleFirst();
            }
            MessageBox.Show(" Order has be cancled.");
            Form1_reserve f1 = new Form1_reserve();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
