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

namespace BookShop
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\先\Documents\WhiteBookShop.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from UserTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            userDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        /*private void Filler()
        {
            Con.Open();
            string query = "select * from BookTb1 where Bcat = '" + Bcattb2.SelectedItem + "'";
            //MessageBox.Show(query);
            //string query = "select * from BookTb1 where Bcat = 'B'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }*/
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = userDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = userDGV.SelectedRows[0].Cells[2].Value.ToString();
            
            textBox2.Text = userDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = userDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (textBox1.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(userDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==""|| textBox3.Text ==""||textBox2.Text ==""|| textBox4.Text =="")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();
                    //string query = "insert INTO BookTb1 value ('"+BtitleTb.Text+"', '"+BauthorTb.Text+"', '"+BcatTB.SelectedItem.ToString()+"', "+BqtyTb.Text+", "+Bprice.Text+");";
                    string query = "INSERT INTO  UserTb1(Uname,Uphone,Uadd,Upassword)VALUES('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', " + textBox4.Text +  ");";
                    //string query = "INSERT INTO  BookTb1(Btitle,Bauthor,Bcat,Bqty,Bprice)VALUES('QW','A','B',2,2);";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("用户信息保存成功！！");
                    Con.Close();
                    populate();
                    reset();
                }

                
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void reset()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();


                    //string query = "insert INTO BookTb1 value ('"+BtitleTb.Text+"', '"+BauthorTb.Text+"', '"+BcatTB.SelectedItem.ToString()+"', "+BqtyTb.Text+", "+Bprice.Text+");";
                    string query = "update UserTb1 set Uname = '" + textBox1.Text +
                        " ',Uphone = '" + textBox3.Text + "' ,Uadd = '" + textBox2.Text +
                        "' ,Upassword = '" + textBox4.Text + "'where Uid = " + key + ";";
                    //string query = "INSERT INTO  BookTb1(Btitle,Bauthor,Bcat,Bqty,Bprice)VALUES('QW','A','B',2,2);";


                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("用户信息更新成功！！");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();


                    //string query = "insert INTO BookTb1 value ('"+BtitleTb.Text+"', '"+BauthorTb.Text+"', '"+BcatTB.SelectedItem.ToString()+"', "+BqtyTb.Text+", "+Bprice.Text+");";
                    string query = "delete from  BookTb1 where Uid =" + key + "";
                    //string query = "INSERT INTO  BookTb1(Btitle,Bauthor,Bcat,Bqty,Bprice)VALUES('QW','A','B',2,2);";


                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("用户信息删除成功！！");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            populate();

            //BcatTB.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
