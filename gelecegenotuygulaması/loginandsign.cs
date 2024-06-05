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
    public partial class loginandsign : Form
    {
        int userid;
        //int username;
 //yaren ökten 222503212-> giriş yapma işlemi ve kaydolma işlemleri bu sayfada yapılıyor.kaydolan kullanıcılar veri tabanına kaydedilip bu bilgileri giriş yap kısmında veritabanından çekerek giriş yapılıyor
      
        public loginandsign()
        {
            InitializeComponent();
           // this.userid = userid;
        }

        SqlConnection connection=new SqlConnection(@"Data Source=YAREN;Initial Catalog=DTOFutureMe;Integrated Security=True");
        private void btn_signupsc_Click(object sender, EventArgs e)
        {
            txt_sifresign.PasswordChar = '*'; //şifreyi gizliyoruz
            txt_tekrar.PasswordChar = '*';

            if (txt_sifresign.Text != txt_tekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen doğru şifreleri girin.");
                return;
            }
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TBL_USERS(email, password,username) VALUES(@email, @password,@username)", connection);
                cmd.Parameters.AddWithValue("@email", txt_epostasign.Text);
                cmd.Parameters.AddWithValue("@password", txt_sifresign.PasswordChar);
                cmd.Parameters.AddWithValue("@username",txt_username.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("KAYIT İŞLEMİ TAMAMLANDI");
                txt_epostasign.Clear();
                txt_sifresign.Clear();
                txt_tekrar.Clear();
                txt_username.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void btn_loginsc_Click(object sender, EventArgs e)
        {
            string email = txt_epostalogin.Text;

            char password = txt_sifrelogin.PasswordChar;
            txt_sifrelogin.PasswordChar = '*';
            string username = txt_username.Text;
            string query = "select userid,username from TBL_USERS where email=@email and password=@password";
            using (SqlConnection connection = new SqlConnection(@"Data Source=YAREN;Initial Catalog=DTOFutureMe;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@username", username);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int userid = reader.GetInt32(reader.GetOrdinal("userid"));
                        string username2 = reader.GetString(reader.GetOrdinal("username"));
                        MessageBox.Show("Giriş başarılı, yönlendiriliyorsunuz.");
                        NOTS nots = new NOTS(userid, username2);
                        nots.Show();
                        this.Hide();
                        txt_epostalogin.Clear();
                        txt_sifrelogin.Clear();
                    }
                    else
                    {

                        MessageBox.Show("Giriş bilgilerinizi kontrol ediniz.");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            //yaren ökten 222503212
        }
        private void btn_kaydetttt_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
