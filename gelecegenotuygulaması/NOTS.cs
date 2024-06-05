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
    public partial class NOTS : Form
    {
        int userid;
        string username;



        public NOTS(int userid, string username)
        {
            InitializeComponent();
            // Timer  ayarlarını yapıyoruz yapma
            timer1 = new Timer();
            timer1.Interval = 60000; // 1 dakika 
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start(); // Zamanlayıcıyı başlatıyoruz
            this.userid = userid;
            this.username = username;
            RefreshDataGridView();


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckNotesDisplayDate(); // Notları kontrol etme metodu
        }

        private void CheckNotesDisplayDate()
        {
            try
            {
                // Şu anki zamanı alıyoruz çünkü oluşturulma tarihi 
                var created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                // Veritabanından display_date'i geçen notları alıyoruz
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_NOTES WHERE userid = @userid  AND display_date = @created_at", connection);
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@created_at", created_at);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlCommand cmd2 = new SqlCommand("select * from TBL_MESSAGES where receiver=@username and display_date=@created_at", connection);
                cmd2.Parameters.AddWithValue("@username", username);
                cmd2.Parameters.AddWithValue("@created_at", created_at);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                connection.Close();

                // Notları gösteriyoruz
                foreach (DataRow row in dt.Rows)
                {
                    string message = row["message"].ToString();
                    string title = row["title"].ToString();
                    MessageBox.Show(message, title);
                    RefreshDataGridView();//not gösterildikten sonra datagrid'i yeniliyoruz
                }
                foreach (DataRow row in dt2.Rows)
                {
                    string messages = row["messages"].ToString();
                    string sender = row["sender"].ToString();
                    MessageBox.Show(messages, sender+" KULLANICISINDAN 1 YENİ MESAJ");
                    //burada başka bir kullanıcıdan gelen mesajları gösteriyoruz,kimden geldiğini gösterebilmek için veritabanında bir tablo daha açtım ve sender,receiver kullanıcıları ile bağlantı kurdum
                    //tasarım açısından hoş durması için sender+kullanıcıdan 1 yeni mesajınız var yaptım ki kimden geldiğini görebilelim.
                    RefreshDataGridView();//yine veritabanını yeniledik ama bu gelen kutusu adı altındaki datagride tekabül ediyor
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notları kontrol ederken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
        SqlConnection connection = new SqlConnection(@"Data Source=YAREN;Initial Catalog=DTOFutureMe;Integrated Security=True");
        private void btn_kaydetttt_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = datetimepickerdisplay.Value.Date;
            DateTime todayDate = DateTime.Today;
            // Tarih kontrolünü yapıyoruz
            if (selectedDate < todayDate)
            {
                MessageBox.Show("Geçmiş bir tarih seçtiniz. Lütfen ileri bir tarih seçiniz.");
                return; // Geçersiz tarih seçildiğinde işlemi sonlandırıyoruz
            }

            // Saat ve dakika girişini masked textbox ile aldım çünkü numericupdown dan saati tam olarak alamıyoruz ama bunu split ile bölerrek saat ve dakika cinsinden net bir şekilde alıyoruz.
            string[] saatDakika = txt_saat.Text.Split(':');
            int saat = int.Parse(saatDakika[0]);
            int dakika = int.Parse(saatDakika[1]);
            DateTime displayDate = selectedDate.AddHours(saat).AddMinutes(dakika);
            connection.Open();
            if (checkBox1.Checked && !string.IsNullOrEmpty(textBox1.Text))//burda başka bir form açıp kalabalık yapmak yerine checkbox kullanmayı tercih ettim
                //biri başkasına mesaj göndermek istiyorsa işaretlemesi gerekiyor ve sonrasında daha önceden visible olan textbox görünüyor ve kullanıcı adını alıyoruz burdan
            {

                SqlCommand cmd = new SqlCommand("select username from TBL_USERS where username=@username", connection);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);//dediğim visible textboxtan username alma işlemi 
                SqlDataReader reader = cmd.ExecuteReader();
                //YAREN ÖKTEN 222503212 GELECEGENOTUYGULAMASI PROJE ÖDEVİ
                if (reader.HasRows)
                {
                    reader.Close();
                    SqlCommand cmd2 = new SqlCommand("insert into tbl_messages (sender,receiver,messages,display_Date,created_at) values (@sender,@receiver,@messages,@display_date,@created_at)", connection);
                    cmd2.Parameters.Add(new SqlParameter("@sender", username));
                    cmd2.Parameters.Add(new SqlParameter("@receiver", textBox1.Text));
                    cmd2.Parameters.Add(new SqlParameter("@messages", txt_notes.Text));
                    cmd2.Parameters.Add(new SqlParameter("@display_date", displayDate));
                    cmd2.Parameters.Add(new SqlParameter("@created_at", DateTime.Now));
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("mesajınız başarıyla iletildi");
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı mevcut değil");
                }
              connection.Close();   
            }

            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_NOTES WHERE display_date = @display_date", connection);
                    cmd.Parameters.AddWithValue("@display_date", displayDate);
                    SqlDataReader reader = cmd.ExecuteReader();

                    bool messageShown = false; // Mesajın gösterilip gösterilmediğini takip ediyoruz

                    while (reader.Read())
                    {
                        string message = reader["message"].ToString();
                        string title = reader["title"].ToString();

                        if (!messageShown)
                        {
                            MessageBox.Show(message, title);

                            messageShown = true; // Mesajın gösterildiğini işaretliyoruz
                            reader.Close();//burda kapatmazsak mesajın gösterildiğini anlamıyor ve tekrar gösteriyor


                        }
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından mesajları alırken bir hata oluştu: " + ex.Message);
                   
                   
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                    
                    RefreshDataGridView();
                }
               
                try
                {
                    connection.Open();
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO TBL_NOTES(message, display_date, title, userid) VALUES (@message, @display_date, @title, @userid)", connection);
                    cmd3.Parameters.AddWithValue("@message", txt_notes.Text);
                    cmd3.Parameters.AddWithValue("@display_date", displayDate);
                    cmd3.Parameters.AddWithValue("@title", txt_title.Text);
                    cmd3.Parameters.AddWithValue("@userid", userid);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("MESAJINIZ BAŞARIYLA EKLENDİ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MESAJ İLETİLİRKEN  BİR HATA OLUŞTU " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                    RefreshDataGridView();

                }
            }
           
        }
        private void RefreshDataGridView()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT title,display_date,created_at FROM TBL_NOTES where userid=@userid ", connection);
                cmd.Parameters.AddWithValue("@userid", userid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagrid_notes.DataSource = dt;
                SqlCommand cmd2 = new SqlCommand("select display_date ,created_at,messages from TBL_MESSAGES where receiver=@username AND display_date < @now", connection);
                cmd2.Parameters.AddWithValue("@username", username);
                cmd2.Parameters.AddWithValue("@now", DateTime.Now);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                tbl_gelen.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri güncelleme işleminde bir hata oluştu: " + ex.Message);
            }
            finally
            {
                
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox1.Visible = true;
            else
                textBox1.Visible = false;//burada textbox ı görünmez yapıyoruz ki görüntü kirliliği olmasın
        }
    }
}