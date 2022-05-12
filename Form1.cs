using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebHook;

namespace Discord_web_hook_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void sendWebHook(string url, string msg, string username)
        {
            Https.Post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    username
                },
                {
                    "content",
                    msg
                }
            });
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            sendWebHook(loginwebhook.Text, msgbox.Text, webhookname.Text);
            MessageBox.Show("送信しました");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
               panel1.Visible = true;
            }
            else
            {
                webhookname.Text = String.Empty;
                panel1.Visible = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者:Ptki_uo");
        }

        private void button3_Click(object sender, EventArgs e)
        {






            panel2.Visible = false;
            tabControl1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ログアウトしますか?", "Discord Webhook Tool", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                loginwebhook.Text = String.Empty;
                panel2.Visible = true;
                tabControl1.Visible = false;
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {

            }
        }
    }
}
