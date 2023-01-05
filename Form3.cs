using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(TxtBox1.Text) || string.IsNullOrWhiteSpace(TxtBox2.Text))
            {
                MessageBox.Show("学籍番号か氏名の欄が入力されていません。");
            }
            else
            {
                int num = int.Parse(TxtBox1.Text);
                string name = TxtBox2.Text;
                try
                {
                    StreamWriter file;
                    if (!File.Exists("test.csv"))
                    {
                        file = new StreamWriter("test.csv", true, Encoding.UTF8);
                        // ヘッダ部につき、コメントアウト。
                        file.WriteLine("学籍番号, 氏名");
                        file.WriteLine(string.Format("{0}, {1}", num, name));
                    }
                    else
                    {
                        file = new StreamWriter("test.csv", true, Encoding.UTF8);
                        file.WriteLine(string.Format("{0}, {1}", num, name));
                    }

                    file.Close();
                    MessageBox.Show("登録しました");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                return;
            }

            if((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
