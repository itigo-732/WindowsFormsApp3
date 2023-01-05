using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using System.Web;
using System.Net;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        int height = 480;
        int width = 680;
        Mat frame;
        DateTime date = DateTime.Now;
        Graphics graphic;
        VideoCapture capture;
        bool flag;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture(0);
            if (!capture.IsOpened())
            {
                MessageBox.Show("camera was not found!!");
                this.Close();
            }
            else
            {
                graphic = pictureBox1.CreateGraphics();
            }

            capture.FrameWidth = 640;
            capture.FrameHeight = 480;

            
        }
        //Webカメラの読み込み
        public void Read_camera()
        {
            using (frame = new Mat(height, width, MatType.CV_8UC3))
            {
                capture.Read(frame);
                capture.Read(frame);
                Read_Barcode();
                using (Bitmap bit = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame))
                {
                    graphic.DrawImage(bit, 0, 0, frame.Cols, frame.Rows);
                }

            }
        }

        //バーコードの読み取り
        public void Read_Barcode()
        {
            ZXing.BarcodeReader reader = new ZXing.BarcodeReader();
            reader.Options = new DecodingOptions
            {
                TryHarder = true,
                PossibleFormats = new[] { BarcodeFormat.CODABAR }.ToList()
            };
            Result result = reader.Decode(frame.ToBitmap());
            if (result != null)
            {
                serch_csv(result);
            }
            


        }

        private bool notice(bool flag)
        {
            StreamReader file = new StreamReader(date.Month.ToString() + "月入退室記録");
            file.ReadLine();
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] vals = line.Split(',');


                if(flag == false)
                {

                    if (vals[3].Split(' ')[0] == date.ToShortDateString())
                    {
                        string msg = "部室の鍵が開きました";
                        string url = "https://notify-api.line.me/api/notify";
                        Encoding enc = Encoding.UTF8;
                        string payload = "message=" + HttpUtility.UrlEncode(msg, enc);
                        string token = "x39dLfCvmTaB19AIfdDLb5W8ygig3afIVEM5zF2rsT7";
                        using (WebClient client = new WebClient())
                        {
                            client.Encoding = enc;
                            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                            client.Headers.Add("Authorization", "Bearer" + token);
                            client.UploadString(url, msg);
                        }
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }

        private void serch_csv(Result result)
        {
            string line;
            string[] vals;
            string filename = date.Month.ToString() + "月入退出記録.csv";
            StreamReader file_r = new StreamReader(@"test.csv");
            StreamWriter file_w;


            file_r.ReadLine();
            while (!file_r.EndOfStream)
            {
                line = file_r.ReadLine();
                vals = line.Split(',');



                    if (result.Text == vals[0])
                    {

                        file_w = new StreamWriter(filename, true, Encoding.UTF8);
                        // ヘッダ部につき、コメントアウト。

                        file_w.WriteLine(string.Format("{0},{1},退室,{2}", vals[0], vals[1], date.ToShortDateString() +"  " +  date.ToLongTimeString()));
                        timer1.Stop();
                        file_w.Close();    

                        capture.Dispose();
                        MessageBox.Show(string.Format("{0}さんお疲れ様でした！", vals[1]));
                        break;
                    }



            }
            file_r.Close();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Read_camera();
            flag = false;
            if(!flag)
            {
                flag = notice(flag);
            }


        }
        
    }
}
