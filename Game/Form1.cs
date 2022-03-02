using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Game
{
    public partial class Form1 : Form
    {
        ThuatToan g = new ThuatToan("test.txt");
        int thuyen = 0;
        int su = 3;
        int quy = 3;
       
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private Bitmap LoadBitMap(string file_name)
        {
            using (Bitmap bm = new Bitmap(Application.StartupPath + "\\Resource\\" + file_name))
            {
                return new Bitmap(bm);
            }
        }
        private void pictureSu1_Click(object sender, EventArgs e)
        {
            if (thuyen == 0)
            {
                pictureSu1.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensu.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su--;
            }
            else if(thuyen == 1 && su == 2)
            {
                pictureSu1.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensusu.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su--;
            }
            else
            {
                pictureSu1.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensuthit.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su--;
            }    
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(runn);
            Thread th = new Thread(ts);
            if (!th.IsAlive)
            {
                th.Start();
                BtnStart.Visible = false;
            }
            else
            {
                BtnStart.Visible = true;              
            }
        }
        private void runn()
        {
            g.BFS();
            for (int i = 0; i < g.DanhSach1().Count; i++)
            {
                if (g.DanhSach1()[i] == "2")
                {
                    pictureQuy1.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 406;
                    while (x > 230)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x -= 1;
                    }
                    Quy1.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;

                }
                else if (g.DanhSach1()[i] == "3")
                {
                    pictureQuy1.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureSu1.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyensuthit.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 406;
                    while (x > 230)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x -= 1;
                    }
                    Quy1.Visible = true;
                    Su1.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;

                }
                else if (g.DanhSach1()[i] == "4")
                {
                    pictureQuy1.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureQuy2.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthitthit.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 406;
                    while (x > 230)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x -= 1;
                    }
                    Quy1.Visible = true;
                    Quy2.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;

                }
                else if (g.DanhSach1()[i] == "5")
                {
                    Quy2.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 230;
                    while (x < 406)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x += 1;
                    }
                    pictureQuy2.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (g.DanhSach1()[i] == "6")
                {
                    pictureQuy3.Visible = false;
                    pictureQuy2.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthitthit.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 406;
                    while (x > 230)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x -= 1;
                    }
                    Quy3.Visible = true;
                    Quy2.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (g.DanhSach1()[i] == "7")
                {
                    Quy2.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 230;
                    while (x < 406)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x += 1;
                    }
                    pictureQuy2.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (g.DanhSach1()[i] == "8")
                {
                    pictureSu1.Visible = false;
                    pictureSu2.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyensusu.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 406;
                    while (x > 230)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x -= 1;
                    }
                    Su1.Visible = true;
                    Su2.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (g.DanhSach1()[i] == "9")
                {
                    Quy1.Visible = false;
                    Su1.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyensuthit.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 230;
                    while (x < 406)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x += 1;
                    }
                    pictureQuy1.Visible = true;
                    pictureSu1.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (g.DanhSach1()[i] == "10")
                {
                    pictureSu3.Visible = false;
                    pictureSu1.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyensusu.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 406;
                    while (x > 230)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x -= 1;
                    }
                    Su3.Visible = true;
                    Su1.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (g.DanhSach1()[i] == "11")
                {
                    Quy3.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 230;
                    while (x < 406)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x += 1;
                    }
                    pictureQuy3.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (g.DanhSach1()[i] == "12")
                {
                    pictureQuy1.Visible = false;
                    pictureQuy2.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthitthit.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 406;
                    while (x > 230)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x -= 1;
                    }
                    Quy1.Visible = true;
                    Quy2.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;

                }
                else if (g.DanhSach1()[i] == "13")
                {
                    Quy1.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 230;
                    while (x < 406)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x += 1;
                    }
                    pictureQuy1.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (g.DanhSach1()[i] == "14")
                {
                    pictureQuy1.Visible = false;
                    pictureQuy3.Visible = false;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyenthitthit.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    int x = 406;
                    while (x > 230)
                    {
                        pictureThuyen.Location = new Point(x, 237);
                        x -= 1;
                    }
                    Quy1.Visible = true;
                    Quy3.Visible = true;
                    pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                    pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                    label.Visible = true;
                }
            }    

        }
        private void pictureSu2_Click(object sender, EventArgs e)
        {
            if (thuyen == 0)
            {
                pictureSu2.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensu.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su--;
            }
            else if (thuyen == 1 && su == 2)
            {
                pictureSu2.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensusu.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su--;
            }
            else
            {
                pictureSu2.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensuthit.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su--;
            }
        }

        private void pictureSu3_Click(object sender, EventArgs e)
        {
            if (thuyen == 0)
            {
                pictureSu3.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensu.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su--;
            }
            else if (thuyen == 1 && su == 2)
            {
                pictureSu3.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensusu.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su--;
            }
            else
            {
                pictureSu3.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensuthit.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su--;
            }
        }

        private void pictureQuy1_Click(object sender, EventArgs e)
        {
            if (thuyen == 0)
            {
                pictureQuy1.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                quy--;
            }
            else if (thuyen == 1 && quy == 2)
            {
                pictureQuy1.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyenthitthit.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                quy--;
            }
            else
            {
                pictureQuy1.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensuthit.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                quy--;
            }
        }

        private void pictureQuy2_Click(object sender, EventArgs e)
        {
            if (thuyen == 0)
            {
                pictureQuy2.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                quy--;
            }
            else if (thuyen == 1 && quy == 2)
            {
                pictureQuy2.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyenthitthit.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                quy--;
            }
            else
            {
                pictureQuy2.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensuthit.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                quy--;
            }
        }

        private void pictureQuy3_Click(object sender, EventArgs e)
        {
            if (thuyen == 0)
            {
                pictureQuy3.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                quy--;
            }
            else if (thuyen == 1 && quy == 2)
            {
                pictureQuy3.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyenthitthit.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                quy--;
            }
            else
            {
                pictureQuy3.Visible = false;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensuthit.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                quy--;
            }
        }

        private void Su1_Click(object sender, EventArgs e)
        {

        }

        private void Su2_Click(object sender, EventArgs e)
        {

        }

        private void Su3_Click(object sender, EventArgs e)
        {

        }

        private void Quy1_Click(object sender, EventArgs e)
        {

        }

        private void Quy2_Click(object sender, EventArgs e)
        {

        }

        private void Quy3_Click(object sender, EventArgs e)
        {

        }

        private void pictureThuyen_Click(object sender, EventArgs e)
        {
            if (pictureSu1.Visible == false && pictureSu2.Visible == false)
            {
                pictureSu1.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensu.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen=1;
                su++;
            }
            else if (pictureSu1.Visible == false && pictureSu3.Visible == false)
            {
                pictureSu3.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensu.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen=1;
                su++;
            }
            else if (pictureSu2.Visible == false && pictureSu3.Visible==false)
            {
                pictureSu2.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyensu.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen=1;
                su++;
            }
            else if (pictureSu1.Visible == false && thuyen == 1)
            {
                pictureSu1.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 0;
                su++;
            }
            else if (pictureSu2.Visible == false && thuyen == 1)
            {
                pictureSu2.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen=0;
                su++;
            }
            else if (pictureSu3.Visible == false && thuyen == 1)
            {
                pictureSu3.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen=0;
                su++;
            }
            if (pictureQuy1.Visible == false && pictureQuy2.Visible == false)
            {
                pictureQuy1.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su++;
            }
            else if (pictureQuy1.Visible == false && pictureQuy3.Visible == false)
            {
                pictureQuy3.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su++;
            }
            else if (pictureQuy2.Visible == false && pictureQuy3.Visible == false)
            {
                pictureQuy2.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyenthit.jpg");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 1;
                su++;
            }
            else if (pictureQuy1.Visible == false && thuyen == 1)
            {
                pictureQuy1.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 0;
                su++;
            }
            else if (pictureQuy2.Visible == false && thuyen == 1)
            {
                pictureQuy2.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 0;
                su++;
            }
            else if (pictureQuy3.Visible == false && thuyen == 1)
            {
                pictureQuy3.Visible = true;
                pictureThuyen.BackgroundImage = LoadBitMap("thuyeno.png");
                pictureThuyen.BackgroundImageLayout = ImageLayout.Stretch;
                thuyen = 0;
                su++;
            }
        }

        private void FormLoading(object sender, EventArgs e)
        {
            Su1.Visible = false;
            Su2.Visible = false;
            Su3.Visible = false;
            Quy1.Visible = false;
            Quy2.Visible = false;
            Quy3.Visible = false;
            MaximizeBox = false;
            label.Visible = false;
            
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
