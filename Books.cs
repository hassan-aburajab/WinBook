using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Hassan AbuRajab\Documents\BookShopDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void Filter()
        {
            con.Open();
            string query = "select * from BookTbl where BCat='" + CatCbSearchCb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            con.Close();

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BautTb.Text == "" || QutTb.Text == "" || PriceTb.Text == "" || BCatacBt.SelectedIndex == -1)
            {
                MessageBox.Show("Missing info.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BookTbl values('" + BTitleTb.Text + "', '" + BautTb.Text + "','" + BCatacBt.SelectedItem.ToString() + "', " + QutTb.Text + ", " + PriceTb.Text + " )";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book saved successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void CarCbSearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            populate();
            CatCbSearchCb.SelectedIndex = -1;

        }
        private void Reset()
        {
            BTitleTb.Text = "";
            BautTb.Text = "";
            BCatacBt.SelectedIndex = -1;
            PriceTb.Text = "";
            QutTb.Text = "";

        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            BautTb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            BCatacBt.SelectedItem = BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            QutTb.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (BTitleTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());

            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("Missing info.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from BookTbl where BId =" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BautTb.Text == "" || QutTb.Text == "" || PriceTb.Text == "" || BCatacBt.SelectedIndex == -1)
            {
                MessageBox.Show("Missing info.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update BookTbl set BTitle='" +BTitleTb.Text + "',BAuthor ='"+BautTb.Text+"',BCat='"+BCatacBt.SelectedItem.ToString()+"',BQty ="+QutTb.Text+",BPrice="+PriceTb.Text+" where BId= "+key+";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated successfully");
                    con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    }
}   

