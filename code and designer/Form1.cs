using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerribleRpgGame
{
    public partial class Form1 : Form
    {

        public int tur = 0;
        public int seviye = 1;
        public int denpuan = 0;
        public int yukseklik = 0;
        public int sayac = 0;
        public int yangınfiat = 40;
        public int kolafiat = 10;
        public int zırhfiat = 50;
        public int killcount = 0;
        int c = 0;
        int d = 0;
        int k = 0;
        int r = 0;
        int re = 0;
        int ne3 = 0;
        public int yangın = 2;
        public int zırh = 2;
        public int kola = 1;
        public double para = 0;
        public int yan = 0;
        int[,] grid = {
                        {1,0,0},
                        {0,0,0},
                        {0,0,0},
                        {0,0,0}
                       };
        Random rng = new Random();
        public int enerji = 4;






        public Form1()
        {
            InitializeComponent();

            seviyetxt.Text = seviye.ToString();
            turtxt.Text = tur.ToString();
            killcounttxt.Text = killcount.ToString();
            zaman.Start();
            sayac = tur;


        }

        private void yukarıbut_Click(object sender, EventArgs e)
        {
            if (yukseklik != 3)
            {
                int a = 0;
                int b = 0;
                yukseklik++;
                for (a = 0; a < 3; a++)
                {
                    for (b = 0; b < 3; b++)
                    {
                        if (grid[a, b] == 1)
                        {
                            if (grid[a + 1, b] == 2)
                            {
                                if (zırh == 0)
                                {
                                    MessageBox.Show("Öldün Tekrar dene!");
                                    Application.Restart();
                                }
                                else if (zırh > 0)
                                {
                                    zırh--;
                                    grid[a, b] = 0;
                                    grid[a + 1, b] = 1;
                                    c = 1;
                                }
                            }

                            else if (grid[a + 1, b] == 3)
                            {
                                if (enerji < 4)
                                {
                                    grid[a, b] = 0;
                                    grid[a + 1, b] = 1;
                                    c = 1;
                                    enerji++;
                                }
                                else if (enerji == 4)
                                {
                                    grid[a, b] = 0;
                                    grid[a + 1, b] = 1;
                                    c = 1;
                                    para++;
                                }
                            }

                            else if (grid[a + 1, b] == 4)
                            {
                                para += 10;
                                grid[a, b] = 0;
                                grid[a + 1, b] = 1;
                                c = 1;
                            }

                            else
                            {
                                grid[a, b] = 0;
                                grid[a + 1, b] = 1;
                                c = 1;
                            }

                        }
                        if (c == 1)
                        {
                            break;
                        }
                    }
                    if (c == 1)
                    {
                        break;
                    }
                }
                tur++;
            }
            c = 0;
        }

        private void aşabut_Click(object sender, EventArgs e)
        {
            if (yukseklik != 0)
            {
                int u = 0;
                int y = 0;
                yukseklik--;
                for (u = 0; u < 4; u++)
                {
                    for (y = 0; y < 3; y++)
                    {
                        if (grid[u, y] == 1)
                        {
                            if (grid[u - 1, y] == 2)
                            {
                                if (zırh == 0)
                                {
                                    MessageBox.Show("Öldün tekrar dene!");
                                    Application.Restart();
                                }
                                else if (zırh > 0)
                                {
                                    zırh--;
                                    grid[u, y] = 0;
                                    grid[u - 1, y] = 1;
                                    d = 1;
                                }
                            }

                            else if (grid[u - 1, y] == 3)
                            {
                                if (enerji < 4)
                                {
                                    grid[u, y] = 0;
                                    grid[u - 1, y] = 1;
                                    d = 1;
                                    enerji++;
                                }
                                else if (enerji == 4)
                                {
                                    grid[u, y] = 0;
                                    grid[u - 1, y] = 1;
                                    d = 1;
                                    para++;
                                }
                            }

                            else if (grid[u - 1, y] == 3)
                            {
                                para += 10;
                                grid[u, y] = 0;
                                grid[u - 1, y] = 1;
                                d = 1;
                            }

                            else
                            {
                                grid[u, y] = 0;
                                grid[u - 1, y] = 1;
                                d = 1;
                            }
                        }
                        if (d == 1)
                        {
                            break;
                        }
                    }
                    if (d == 1)
                    {
                        break;
                    }
                }
                tur++;
            }
            d = 0;
        }



        private void zaman_Tick(object sender, EventArgs e)
        {

            turtxt.Text = tur.ToString();
            paratxt.Text = para.ToString();
            seviyetxt.Text = seviye.ToString();
            yangıntxt.Text = yangın.ToString();
            kolatxt.Text = kola.ToString();
            kolafiyattxt.Text = kolafiat.ToString();
            zırhtxt.Text = zırh.ToString();
            zırhfiyattxt.Text = zırhfiat.ToString();
            ysfiyattxt.Text = yangınfiat.ToString();
            killcounttxt.Text = killcount.ToString();
            if (sayac != tur)
            {
                int dene = rng.Next(3);
                if (dene == 1)
                {
                    int satır = rng.Next(4);
                    int sutun = rng.Next(3);

                    if (grid[satır, sutun] == 0)
                    {
                        grid[satır, sutun] = 2;
                    }
                }

                if (enerji != 4)
                {
                    int enerjicark = rng.Next(2);
                    if (enerjicark == 1)
                    {
                        int satır2 = rng.Next(4);
                        int sutun2 = rng.Next(3);

                        if (grid[satır2, sutun2] == 0)
                        {
                            grid[satır2, sutun2] = 3;
                        }
                    }
                }

                if (tur >= 12 && tur < 81)
                {
                    int enerjidene = rng.Next(6);
                    if (enerjidene == 4)
                    {
                        int satır3 = rng.Next(4);
                        int sutun3 = rng.Next(3);
                        if (grid[satır3, sutun3] == 0)
                        {
                            grid[satır3, sutun3] = 4;
                        }
                    }
                }

                if (tur >= 89 && tur < 125)
                {
                    int randomevent1 = rng.Next(100);
                    if (randomevent1 == 54)
                    {
                        MessageBox.Show("yerde yangın söndürücü buldun!");
                        yangın++;
                    }
                }

                if (tur >= 30 && tur < 74)
                {
                    int randomevent2 = rng.Next(100);
                    if (randomevent2 == 5 || randomevent2 == 18)
                    {
                        if (zırh > 0)
                        {
                            MessageBox.Show("Çiviye Bastın!");
                            zırh--;
                        }
                        else
                        {
                            MessageBox.Show("Yerde çivi gördün ve satmaya karar verdin 5 altın kazandın!");
                            para += 5;
                        }
                    }
                }

                if (tur >= 200)
                {
                    int randomevent3 = rng.Next(50);
                    if (randomevent3 == 6 || randomevent3 == 7)
                    {
                        yangın++;
                        MessageBox.Show("Yangın söndürücü kiti buldun");
                    }
                    else if (randomevent3 == 1)
                    {
                        if (yangın > 1)
                        {
                            yangın--;
                            MessageBox.Show("Sahip olduğun yangın söndürücülerden biri bozuldu");
                        }
                    }
                }


                sayac = tur;
            }

            if (seviye > 0)
            {
                if (denpuan >= 18 && seviye == 1)
                {
                    seviye++;
                    para += 16;
                    denpuan = 0;
                }
                else if (denpuan >= 42 && seviye == 2)
                {
                    seviye++;
                    para += 20;
                    denpuan = 0;
                }
                else if (denpuan >= 54 && seviye == 3)
                {
                    seviye++;
                    yangın++;
                    para += 30;
                    denpuan = 0;
                }
                else if (denpuan >= 66 && seviye == 4)
                {
                    seviye++;
                    yangın++;
                    zırh++;
                    para += 35;
                    denpuan = 0;
                }
                else if (denpuan >= 84 && seviye == 5)
                {
                    seviye++;
                    yangın += 2;
                    zırh += 2;
                    para += 50;
                    denpuan = 0;
                }
                else if (denpuan >= 102 && seviye == 6)
                {
                    seviye++;
                    yangınfiat -= 10;
                    zırhfiat -= 5;
                    zırh++;
                    para += 15;
                    denpuan = 0;
                }
            }



            if (enerji >= 0)
            {
                if (enerji == 4)
                {
                    e1.BackColor = Color.Blue;
                    e2.BackColor = Color.Blue;
                    e3.BackColor = Color.Blue;
                    e4.BackColor = Color.Blue;
                }
                else if (enerji == 3)
                {
                    e1.BackColor = Color.DarkRed;
                    e2.BackColor = Color.Blue;
                    e3.BackColor = Color.Blue;
                    e4.BackColor = Color.Blue;
                }
                else if (enerji == 2)
                {
                    e1.BackColor = Color.DarkRed;
                    e2.BackColor = Color.DarkRed;
                    e3.BackColor = Color.Blue;
                    e4.BackColor = Color.Blue;
                }
                else if (enerji == 1)
                {
                    e1.BackColor = Color.DarkRed;
                    e2.BackColor = Color.DarkRed;
                    e3.BackColor = Color.DarkRed;
                    e4.BackColor = Color.Blue;
                }
                else if (enerji == 0)
                {
                    e1.BackColor = Color.DarkRed;
                    e2.BackColor = Color.DarkRed;
                    e3.BackColor = Color.DarkRed;
                    e4.BackColor = Color.DarkRed;
                }
            }

            if (grid[0, 0] == 1)
            {
                g00.BackColor = Color.Green;
            }
            if (grid[0, 1] == 1)
            {
                g01.BackColor = Color.Green;
            }
            if (grid[0, 2] == 1)
            {
                g02.BackColor = Color.Green;
            }
            if (grid[1, 0] == 1)
            {
                g10.BackColor = Color.Green;
            }
            if (grid[1, 1] == 1)
            {
                g11.BackColor = Color.Green;
            }
            if (grid[1, 2] == 1)
            {
                g12.BackColor = Color.Green;
            }
            if (grid[2, 0] == 1)
            {
                g20.BackColor = Color.Green;
            }
            if (grid[2, 1] == 1)
            {
                g21.BackColor = Color.Green;
            }
            if (grid[2, 2] == 1)
            {
                g22.BackColor = Color.Green;
            }
            if (grid[3, 0] == 1)
            {
                g30.BackColor = Color.Green;
            }
            if (grid[3, 1] == 1)
            {
                g31.BackColor = Color.Green;
            }
            if (grid[3, 2] == 1)
            {
                g32.BackColor = Color.Green;
            }


            if (grid[0, 0] == 2)
            {
                g00.BackColor = Color.Red;
            }
            if (grid[0, 1] == 2)
            {
                g01.BackColor = Color.Red;
            }
            if (grid[0, 2] == 2)
            {
                g02.BackColor = Color.Red;
            }
            if (grid[1, 0] == 2)
            {
                g10.BackColor = Color.Red;
            }
            if (grid[1, 1] == 2)
            {
                g11.BackColor = Color.Red;
            }
            if (grid[1, 2] == 2)
            {
                g12.BackColor = Color.Red;
            }
            if (grid[2, 0] == 2)
            {
                g20.BackColor = Color.Red;
            }
            if (grid[2, 1] == 2)
            {
                g21.BackColor = Color.Red;
            }
            if (grid[2, 2] == 2)
            {
                g22.BackColor = Color.Red;
            }
            if (grid[3, 0] == 2)
            {
                g30.BackColor = Color.Red;
            }
            if (grid[3, 1] == 2)
            {
                g31.BackColor = Color.Red;
            }
            if (grid[3, 2] == 2)
            {
                g32.BackColor = Color.Red;
            }


            if (grid[0, 0] == 0)
            {
                g00.BackColor = Color.White;
            }
            if (grid[0, 1] == 0)
            {
                g01.BackColor = Color.White;
            }
            if (grid[0, 2] == 0)
            {
                g02.BackColor = Color.White;
            }
            if (grid[1, 0] == 0)
            {
                g10.BackColor = Color.White;
            }
            if (grid[1, 1] == 0)
            {
                g11.BackColor = Color.White;
            }
            if (grid[1, 2] == 0)
            {
                g12.BackColor = Color.White;
            }
            if (grid[2, 0] == 0)
            {
                g20.BackColor = Color.White;
            }
            if (grid[2, 1] == 0)
            {
                g21.BackColor = Color.White;
            }
            if (grid[2, 2] == 0)
            {
                g22.BackColor = Color.White;
            }
            if (grid[3, 0] == 0)
            {
                g30.BackColor = Color.White;
            }
            if (grid[3, 1] == 0)
            {
                g31.BackColor = Color.White;
            }
            if (grid[3, 2] == 0)
            {
                g32.BackColor = Color.White;
            }


            if (grid[0, 0] == 3)
            {
                g00.BackColor = Color.DarkBlue;
            }
            if (grid[0, 1] == 3)
            {
                g01.BackColor = Color.DarkBlue;
            }
            if (grid[0, 2] == 3)
            {
                g02.BackColor = Color.DarkBlue;
            }
            if (grid[1, 0] == 3)
            {
                g10.BackColor = Color.DarkBlue;
            }
            if (grid[1, 1] == 3)
            {
                g11.BackColor = Color.DarkBlue;
            }
            if (grid[1, 2] == 3)
            {
                g12.BackColor = Color.DarkBlue;
            }
            if (grid[2, 0] == 3)
            {
                g20.BackColor = Color.DarkBlue;
            }
            if (grid[2, 1] == 3)
            {
                g21.BackColor = Color.DarkBlue;
            }
            if (grid[2, 2] == 3)
            {
                g22.BackColor = Color.DarkBlue;
            }
            if (grid[3, 0] == 3)
            {
                g30.BackColor = Color.DarkBlue;
            }
            if (grid[3, 1] == 3)
            {
                g31.BackColor = Color.DarkBlue;
            }
            if (grid[3, 2] == 3)
            {
                g32.BackColor = Color.DarkBlue;
            }

            if (grid[0, 0] == 4)
            {
                g00.BackColor = Color.Orange;
            }
            if (grid[0, 1] == 4)
            {
                g01.BackColor = Color.Orange;
            }
            if (grid[0, 2] == 4)
            {
                g02.BackColor = Color.Orange;
            }
            if (grid[1, 0] == 4)
            {
                g10.BackColor = Color.Orange;
            }
            if (grid[1, 1] == 4)
            {
                g11.BackColor = Color.Orange;
            }
            if (grid[1, 2] == 4)
            {
                g12.BackColor = Color.Orange;
            }
            if (grid[2, 0] == 4)
            {
                g20.BackColor = Color.Orange;
            }
            if (grid[2, 1] == 4)
            {
                g21.BackColor = Color.Orange;
            }
            if (grid[2, 2] == 4)
            {
                g22.BackColor = Color.Orange;
            }
            if (grid[3, 0] == 4)
            {
                g30.BackColor = Color.Orange;
            }
            if (grid[3, 1] == 4)
            {
                g31.BackColor = Color.Orange;
            }
            if (grid[3, 2] == 4)
            {
                g32.BackColor = Color.Orange;
            }
        }

        private void solbut_Click(object sender, EventArgs e)
        {
            if (yan != 0)
            {
                int u = 0;
                int y = 0;
                yan--;
                for (u = 0; u < 4; u++)
                {
                    for (y = 0; y < 3; y++)
                    {
                        if (grid[u, y] == 1)
                        {
                            if (grid[u, y - 1] == 2)
                            {
                                if (zırh == 0)
                                {
                                    MessageBox.Show("Öldün tekrar dene!");
                                    Application.Restart();
                                }
                                else if (zırh > 0)
                                {
                                    zırh--;
                                    grid[u, y] = 0;
                                    grid[u, y - 1] = 1;
                                    k = 1;
                                }
                            }

                            else if (grid[u, y - 1] == 3)
                            {
                                if (enerji < 4)
                                {
                                    grid[u, y] = 0;
                                    grid[u, y - 1] = 1;
                                    k = 1;
                                    enerji++;
                                }
                                else if (enerji == 4)
                                {
                                    grid[u, y] = 0;
                                    grid[u, y - 1] = 1;
                                    k = 1;
                                    para++;
                                }
                            }

                            else if (grid[u, y - 1] == 4)
                            {
                                para += 10;
                                grid[u, y] = 0;
                                grid[u, y - 1] = 1;
                                k = 1;
                            }

                            else
                            {
                                grid[u, y] = 0;
                                grid[u, y - 1] = 1;
                                k = 1;
                            }

                        }
                        if (k == 1)
                        {
                            break;
                        }
                    }
                    if (k == 1)
                    {
                        break;
                    }
                }
                tur++;
            }
            k = 0;
        }

        private void sağbut_Click(object sender, EventArgs e)
        {
            if (yan != 2)
            {
                int u = 0;
                int y = 0;
                yan++;
                for (u = 0; u < 4; u++)
                {
                    for (y = 0; y < 3; y++)
                    {
                        if (grid[u, y] == 1)
                        {
                            if (grid[u, y + 1] == 2)
                            {
                                if (zırh == 0)
                                {
                                    MessageBox.Show("Öldün tekrar dene!");
                                    Application.Restart();
                                }
                                else if (zırh > 0)
                                {
                                    zırh--;
                                    grid[u, y] = 0;
                                    grid[u, y + 1] = 1;
                                    r = 1;
                                }
                            }

                            else if (grid[u, y + 1] == 3)
                            {
                                if (enerji < 4)
                                {
                                    grid[u, y] = 0;
                                    grid[u, y + 1] = 1;
                                    r = 1;
                                    enerji++;
                                }
                                else if (enerji == 4)
                                {
                                    grid[u, y] = 0;
                                    grid[u, y + 1] = 1;
                                    r = 1;
                                    para++;
                                }
                            }

                            else if (grid[u, y + 1] == 4)
                            {
                                para += 10;
                                grid[u, y] = 0;
                                grid[u, y + 1] = 1;
                                r = 1;
                            }

                            else
                            {
                                grid[u, y] = 0;
                                grid[u, y + 1] = 1;
                                r = 1;
                            }

                        }
                        if (r == 1)
                        {
                            break;
                        }
                    }
                    if (r == 1)
                    {
                        break;
                    }
                }
                tur++;
            }
            r = 0;
        }

        private void saldır_Click(object sender, EventArgs e)
        {
            if (enerji != 0)
            {
                if (yukseklik != 3)
                {
                    int la = 0;
                    int le = 0;
                    for (la = 0; la < 4; la++)
                    {
                        for (le = 0; le < 3; le++)
                        {
                            if (grid[la, le] == 1)
                            {
                                if (grid[la + 1, le] == 2)
                                {
                                    grid[la + 1, le] = 0;
                                    re = 1;
                                    para += 2;
                                    denpuan += 6;
                                    enerji--;
                                }
                                else if (grid[la + 1, le] == 3)
                                {
                                    grid[la + 1, le] = 0;
                                    re = 1;
                                }
                                else
                                {
                                    grid[la + 1, le] = 0;
                                    re = 1;
                                    para += 2;
                                }

                            }
                            if (re == 1)
                            {
                                break;
                            }
                        }
                        if (re == 1)
                        {
                            break;
                        }
                    }
                    re = 0;
                }
            }
        }

        private void magzaac_Click(object sender, EventArgs e)
        {
            magaza.Visible = true;
            magzaac.Visible = false;
        }

        private void magzakapa_Click(object sender, EventArgs e)
        {
            magaza.Visible = false;
            magzaac.Visible = true;
        }

        private void ysal_Click(object sender, EventArgs e)
        {
            if (para >= yangınfiat)
            {
                yangın++;
                para -= yangınfiat;
            }
            else
            {
                MessageBox.Show("O kadar paran yok!");
            }
        }

        private void zırhal_Click(object sender, EventArgs e)
        {
            if (para >= zırhfiat)
            {
                zırh++;
                para -= zırhfiat;
            }
            else
            {
                MessageBox.Show("O kadar paran yok!");
            }
        }

        private void güçbut_Click(object sender, EventArgs e)
        {
            if (yangın > 0 && enerji > 0)
            {
                yangın--;
                enerji--;
                int ne1;
                int ne2;
                for (ne1 = 0; ne1 < 4; ne1++)
                {
                    for (ne2 = 0; ne2 < 3; ne2++)
                    {
                        if (grid[ne1, ne2] == 1)
                        {
                            if (ne1 + 1 > 3 && ne2 + 1 > 2)
                            {
                                grid[ne1 - 1, ne2] = 0;
                                grid[ne1, ne2 - 1] = 0;
                            }
                            else if (ne1 - 1 < 0 && ne2 - 1 < 0)
                            {
                                grid[ne1 + 1, ne2] = 0;
                                grid[ne1, ne2 + 1] = 0;
                            }
                            else if (ne1 - 1 < 0 && ne2 + 1 > 2)
                            {
                                grid[ne1 + 1, ne2] = 0;
                                grid[ne1, ne2 - 1] = 0;
                            }
                            else if (ne2 - 1 < 0)
                            {
                                if (ne1 + 1 > 3)
                                {
                                    grid[ne1 - 1, ne2] = 0;
                                    grid[ne1, ne2 + 1] = 0;
                                }
                                else
                                {
                                    grid[ne1 - 1, ne2] = 0;
                                    grid[ne1 + 1, ne2] = 0;
                                    grid[ne1, ne2 + 1] = 0;
                                }
                            }
                            else if (ne2 + 1 > 2)
                            {
                                grid[ne1 - 1, ne2] = 0;
                                grid[ne1 + 1, ne2] = 0;
                                grid[ne1, ne2 - 1] = 0;
                            }
                            else if (ne1 + 1 > 3 && ne2 + 1 > 2)
                            {
                                grid[ne1 - 1, ne2] = 0;
                                grid[ne1, ne2 - 1] = 0;
                            }
                            else if (ne1 - 1 < 0)
                            {
                                grid[ne1 + 1, ne2] = 0;
                                grid[ne1, ne2 - 1] = 0;
                                grid[ne1, ne2 + 1] = 0;
                            }
                            else if (ne1 + 1 > 3)
                            {
                                grid[ne1 - 1, ne2] = 0;
                                grid[ne1, ne2 - 1] = 0;
                                grid[ne1, ne2 + 1] = 0;
                            }
                            else
                            {
                                grid[ne1 - 1, ne2] = 0;
                                grid[ne1 + 1, ne2] = 0;
                                grid[ne1, ne2 - 1] = 0;
                                grid[ne1, ne2 + 1] = 0;
                            }
                            ne3 = 1;
                        }
                        if (ne3 == 1)
                        {
                            break;
                        }
                    }
                    if (ne3 == 1)
                    {
                        break;
                    }
                }
                ne3 = 0;
            }
            else
            {
                MessageBox.Show("Bunu şuan kullanamazsın!");
            }

        }

        private void kolaal_Click(object sender, EventArgs e)
        {
            if (para >= kolafiat)
            {
                kola++;
                para -= kolafiat;
            }
            else
            {
                MessageBox.Show("O kadar paran yok!");
            }
        }

        private void kolaicbut_Click(object sender, EventArgs e)
        {
            if (enerji != 4)
            {
                if (kola > 0)
                {
                    kola--;
                    enerji++;
                    int randomkola = rng.Next(10);
                    if (randomkola == 3)
                    {
                        denpuan += 5;
                    }
                }
                else if (kola == 0)
                {
                    MessageBox.Show("Kolan yok");
                }
            }
            else if (enerji == 4)
            {
                if (kola > 0)
                {
                    MessageBox.Show("Enerjin tam");
                }
                else if (kola == 0)
                {
                    MessageBox.Show("Enerjin tam ve kolan yok!");
                }
            }
        }
    }
}