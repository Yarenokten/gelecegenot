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
    public partial class Form1 : Form
    {
        
        SqlConnection connection=new SqlConnection(@"Data Source=YAREN;Initial Catalog=DTOFutureMe;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

  // yaren ökten 222503212-> yönlendirme kodları(hangi sayfaya gidecek )

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_homepage.Text = lbl_homepage.Text.Substring(1) + lbl_homepage.Text.Substring(0, 1);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            loginandsign loginandsign = new loginandsign();
            loginandsign.Show();
            this.Hide();

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            loginandsign loginandsign = new loginandsign();
            loginandsign.Show();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void btn_comments_Click(object sender, EventArgs e)
        {
            Comments comments = new Comments();
            comments.Show();
            this.Hide();
        }
    }
}
