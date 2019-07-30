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
    public partial class Form2_purchase : Form
    {
        string connect = "Provider = Microsoft.ACE.OLEDB.12.0; Data source = D:\\Database11.accdb";
        public static string customerid;
        public static string fn;
        public static string ln;
        public static string telephone;
        public static string flight;
        public static string IDcustomer;
        public static string address;

        string tempNum;
        string countFirst;
        string countCoach;
        string departure;
        string destination;

        public Form2_purchase()
        {
            InitializeComponent();
            flight = Form1_reserve.flightID;
            departure = Form1_reserve.x;
            destination = Form1_reserve.y;
        }

        private void updateCoach()
        {
            string connect1 = "Provider = Microsoft.ACE.OLEDB.12.0; Data source = D:\\Database11.accdb";
            OleDbConnection connection1 = new OleDbConnection(connect1);
            connection1.Open();
            tempNum = Form1_reserve.number;
            calculatec();
            string sqlfirst = "UPDATE [flight information] SET coach_seats_sold=('" + tempNum + "'), coach_seats_available = ('" + countCoach + "') WHERE city_of_departure='" + departure + "' AND city_of_destination='" + destination + "'";
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.InsertCommand = new OleDbCommand(sqlfirst, connection1);
            da.InsertCommand.ExecuteNonQuery();
        }

        private void updateFirst()
        {
            string connect2 = "Provider = Microsoft.ACE.OLEDB.12.0; Data source = D:\\Database11.accdb";
            OleDbConnection connection2 = new OleDbConnection(connect2);
            connection2.Open();
            tempNum = Form1_reserve.number;
            calculatef();
            string sqlfirst = "UPDATE [flight information] SET firstclass_seats_sold = ('" + tempNum + "'), firstclass_seats_available = ('" + countFirst + "') WHERE city_of_departure='" + departure + "' AND city_of_destination='" + destination + "'";
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.InsertCommand = new OleDbCommand(sqlfirst, connection2);
            da.InsertCommand.ExecuteNonQuery();
        }

        private void calculatef()
        {
            double h;
            countFirst = Form1_reserve.countf;
            h = Convert.ToDouble(countFirst);
            h = h - Convert.ToDouble(tempNum);
            countFirst = Convert.ToString(h);
        }

        private void calculatec()
        {
            double w;
            w = Convert.ToDouble(countCoach);
            w = w - Convert.ToDouble(tempNum);
            countCoach = Convert.ToString(w);
        }

        private void purchase()
        {
            try
            { 
                OleDbConnection connection = new OleDbConnection(connect);
                connection.Open();
                IDcustomer = textBox1_ID.Text;
                string sqladd1 = "INSERT INTO[customer information](FirstName,LastName,telephone,address,CustomerID)VALUES('" + textBox2_fn.Text + "','" + textBox1_ln.Text + "','" + telephone + "','" + textBox2_address.Text + "','" + IDcustomer + "')";
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.InsertCommand = new OleDbCommand(sqladd1, connection);
                da.InsertCommand.ExecuteNonQuery();
                connection.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Type a different information for purchase");
            }
        }

        private void insertID() //insert the flightID and customerID 
        {
            try
            {
                OleDbConnection connection3 = new OleDbConnection(connect);
                connection3.Open();
                IDcustomer = textBox1_ID.Text;
                string sqladd2 = "INSERT INTO[purchase information](CustomerID,FlightID)VALUES('" + IDcustomer + "','" + flight + "')";
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.InsertCommand = new OleDbCommand(sqladd2, connection3);
                da.InsertCommand.ExecuteNonQuery();
                connection3.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can not insert into purchase information.");
            }
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            purchase();
            insertID();
            if (Form1_reserve.t == false)
            {
                updateFirst();
            }
            else if (Form1_reserve.t == true) 
            {
                updateCoach();
            }
            Form3_receipt f3 = new Form3_receipt();
            this.Hide();
            f3.ShowDialog();
        }

        private void textBox1_ln_TextChanged(object sender, EventArgs e)
        {
            ln = textBox1_ln.Text;
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            Form1_reserve f1 = new Form1_reserve();
            this.Hide();
            f1.ShowDialog();
        }

        private void textBox1_ID_TextChanged(object sender, EventArgs e)
        {
            customerid = textBox1_ID.Text;
        }

        private void textBox2_fn_TextChanged(object sender, EventArgs e)
        {
            fn = textBox2_fn.Text;
        }

        private void textBox2_tele_TextChanged(object sender, EventArgs e)
        {
            telephone = textBox2_tele.Text;
        }

        private void Form2_purchase_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_address_TextChanged(object sender, EventArgs e)
        {
            address = textBox2_address.Text;
        }
    }
}
