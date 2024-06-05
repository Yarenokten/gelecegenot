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


namespace gelecegenotuygulaması
{
    public partial class Comments : Form
    {
        public Comments()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=YAREN;Initial Catalog=DTOFutureMe;Integrated Security=True");
        private void btn_cmmnt_Click(object sender, EventArgs e)
        {
            int userid = GetUserID();
            try
            {
                connection.Open();
                SqlCommand cmd3 = new SqlCommand("INSERT INTO TBL_COMMENTS(comments,commentdate,username) VALUES ( @comments, @commentdate,@username) ", connection);
                cmd3.Parameters.AddWithValue("@username", txt_epostacmmnt.Text);
                cmd3.Parameters.AddWithValue("@comments", txt_comments.Text);
                cmd3.Parameters.AddWithValue("@commentdate", DateTime.Now);


                cmd3.ExecuteNonQuery();
                MessageBox.Show("YORUMUNUZ BAŞARIYLA EKLENDİ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("YORUM YAPILIRKEN BİR HATA OLUŞTU " + ex.Message);
            }
            finally
            {
                connection.Close();
                RefreshDataGridView();
            }
        }
        private int GetUserID()
        {
            connection.Open();
            int userid = 0; // Varsayılan değer

            //  email göre userid alınması
            string query = "SELECT userid FROM TBL_USERS WHERE email=@email";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@email", "yaren.yk28@gmail.com"); // deneme amaçlı kendi oluşturduğum kaydı kullandım ama kullanıcı kontrolü yapmadım yine de ekliyor :)
                // deneme amaçlı kendi mailimi kaydettim ama tabbi bunun maillerle alakası yok herhangi bir mail olabilir 
                object result = cmd.ExecuteScalar();
                connection.Close();

                if (result != null)
                {
                    userid = Convert.ToInt32(result);
                }
                
            }
            return userid;
        }
        private void RefreshDataGridView()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_COMMENTS", connection);//yorumların hepsini getiriyoruz.
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);//datagrid'e dolduruyoruz.
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri güncelleme işleminde bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void Comments_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshDataGridView();//datagrid'in yenilenmesini sağlıyoruz.
        }
        private void btn_kaydetttt_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}