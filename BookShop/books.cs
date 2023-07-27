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
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\先\Documents\WhiteBookShop.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from BookTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Filler()
        {
            Con.Open();
            string query = "select * from BookTb1 where Bcat = '"+ Bcattb2.SelectedItem+"'";
            //MessageBox.Show(query);
            //string query = "select * from BookTb1 where Bcat = 'B'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void baoc_Click(object sender, EventArgs e)
        {
            if (BtitleTb.Text==""||BauthorTb.Text ==""||BcatTB.SelectedIndex==-1||BqtyTb.Text==""|| PriceTb.Text=="")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();


                    //string query = "insert INTO BookTb1 value ('"+BtitleTb.Text+"', '"+BauthorTb.Text+"', '"+BcatTB.SelectedItem.ToString()+"', "+BqtyTb.Text+", "+Bprice.Text+");";
                    string query = "INSERT INTO  BookTb1(Btitle,Bauthor,Bcat,Bqty,Bprice)VALUES('" + BtitleTb.Text + "', '" + BauthorTb.Text + "', '" + BcatTB.SelectedItem + "', " + BqtyTb.Text + ", " + PriceTb.Text + ");";
                    //string query = "INSERT INTO  BookTb1(Btitle,Bauthor,Bcat,Bqty,Bprice)VALUES('QW','A','B',2,2);";


                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("书籍信息保存成功！！");
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

        private void catcbsearchcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            populate();

            BcatTB.SelectedIndex = -1;

        }
        private void reset()
        {
            BtitleTb.Text = "";
            BauthorTb.Text = "";
            BcatTB.SelectedIndex = -1;
            BqtyTb.Text = "";
            PriceTb.Text = "";

        }
        private void re_Click(object sender, EventArgs e)
        {
            reset();
        }
        int key = 0;
        private void BookDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BtitleTb.Text = BookDGV.SelectedRows[0].Cells[1].Value.ToString();
            BauthorTb.Text = BookDGV.SelectedRows[0].Cells[2].Value.ToString();
            BcatTB.SelectedItem= BookDGV.SelectedRows[0].Cells[3].Value.ToString();
            BqtyTb.Text = BookDGV.SelectedRows[0].Cells[4].Value.ToString();
            PriceTb.Text = BookDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (BtitleTb.Text=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BookDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void catcbsearchcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();


                    //string query = "insert INTO BookTb1 value ('"+BtitleTb.Text+"', '"+BauthorTb.Text+"', '"+BcatTB.SelectedItem.ToString()+"', "+BqtyTb.Text+", "+Bprice.Text+");";
                    string query = "delete from  BookTb1 where Bid =" + key + "";
                    //string query = "INSERT INTO  BookTb1(Btitle,Bauthor,Bcat,Bqty,Bprice)VALUES('QW','A','B',2,2);";


                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("书籍信息删除成功！！");
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

        private void bianji_Click(object sender, EventArgs e)
        {
            if (BtitleTb.Text == "" || BauthorTb.Text == "" || BcatTB.SelectedIndex == -1 || BqtyTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();
                    //string query = "insert INTO BookTb1 value ('"+BtitleTb.Text+"', '"+BauthorTb.Text+"', '"+BcatTB.SelectedItem.ToString()+"', "+BqtyTb.Text+", "+Bprice.Text+");";
                    string query = "update BookTb1 set Btitle = '" + BtitleTb.Text + 
                        " ',Bauthor = '" + BauthorTb.Text + "' ,Bcat = '" + BcatTB.SelectedItem + 
                        "' ,Bqty = '" + BqtyTb.Text + "' ,Bprice =  '" + PriceTb.Text + "'where Bid = "+key+";";
                    //string query = "INSERT INTO  BookTb1(Btitle,Bauthor,Bcat,Bqty,Bprice)VALUES('QW','A','B',2,2);";


                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("书籍信息更新成功！！");
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
    }
}
