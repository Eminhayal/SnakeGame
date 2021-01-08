using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Form1 : Form
    {
        string kullanici = null, skor_dosya_yolu = @"C:\Users\rakio\Desktop\puan.txt", yardim_dosya_yolu = @"C:\Users\Acer\Desktop\denemeYardim.txt";
        public Thread thread;

        public enum Direction  //Yılanın hareketini yönlendirmek
        {
            Up,
            Down,
            Left,
            Right
        }

        public int x = 1, y = 1; // Kuyruk ve yılanın başlangıç konumunu ve kuyruğun oluşumun da kullanılan değişkenler.
        public int a; // Skoru tutma değişken.  
        
        public int score; // Skorun hesaplanması 

        public int time = 0; // Skorda kullanılan süre 
        public int cutTime; // Skorda iki yem yeme arasındaki tutulan zaman
        public int firstTime = 0; // Skorda oluşan ilk zaman

        public double minute = 0; // Sayaçta ekrana dakikayı yazmak için kullanılır.
        public double second = 0; // Sayaçta ekrana saniyeyi yazmak için kullanılır.
        public double timeGame = 0; // Sayaçta kullanılan süre

        public Direction direction = Direction.Right; // 

        public Location food = new Location(-1, -1);// Yemeğin oluşacağı konumu belirlemek için classdan çektiğimiz method.

        Random random = new Random(); // Random classından yeni bir random nesneni oluşturuyoruz.

        public List<Location> tales = new List<Location>(); // Kuyruk kısmını listede tutuyoruz .


        public Form1()
        {
            
            InitializeComponent();

            tales.Add(new main.Location(0, 0)); // Yeni kuyruk ekleme 

            GameTable();

            Control.CheckForIllegalCrossThreadCalls = false; // 
            timer_label.Text = "0";
            timer_score.Interval = 1000;
            timer_time.Interval = 1000;


            btnYardım.Enabled = true;
            btnSkorlarıGörüntüle.Enabled = true;
            btnKişiyikaydet.Enabled = true;

            thread = new Thread(new ThreadStart(new Action(() =>
            {
                while (true)
                {
                    if (direction == Direction.Right) x++;
                    if (direction == Direction.Down) y++;
                    if (direction == Direction.Left) x--;
                    if (direction == Direction.Up) y--;

                    

                    GameTable();
                    if(kolayRdb.Checked == true)
                    {
                        Thread.Sleep(200);
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }

            })));
            thread.Start();
            thread.Suspend(); // thread duraklatılır
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Down) direction = Direction.Down; 
            if (e.KeyCode==Keys.Left) direction = Direction.Left;
            if (e.KeyCode==Keys.Up) direction = Direction.Up;
            if (e.KeyCode==Keys.Right) direction = Direction.Right;
           
            if(e.KeyCode == Keys.B)
            {

                btnYardım.Enabled = false;
                btnSkorlarıGörüntüle.Enabled = false;
                btnKişiyikaydet.Enabled = false;

                zorRdb.Enabled = false;
                kolayRdb.Enabled = false;

                timer_score.Enabled = true;
                timer_time.Enabled = true;

                bilgiPanel.Visible = false;


                txtKişileriKaydet.Enabled = false;

                thread.Resume(); // Resume() metodu Suspend() metodundan sonra çalışabilir.
 
            }
            // D tuşuna basıldığında olacaklar
            if (e.KeyCode == Keys.D)
            {
                zorRdb.Enabled = true;
                kolayRdb.Enabled = true;

                thread.Suspend();

                bilgiPanel.Visible = true;
                timer_score.Enabled = false;
                timer_time.Enabled = false;


                btnYardım.Enabled = true;
                btnSkorlarıGörüntüle.Enabled = true;
                btnKişiyikaydet.Enabled = true;
            } 
        }
        public void GameTable()
        {
            // Yılanın kuyruğu üst üste geldiğinde yanması
            if (tales.Count != 1)
            {
                for (int i = 1; i < tales.Count; i++)
                {   
                    if (tales[i].x == x && tales[i].y == y)
                    {

                        DosyaIslemi();

                        GameOver();
                    }
                }
            }

            // Yemek oluşturma
            if (x == food.x && y == food.y)
            {
                tales.Add(new main.Location(food.x, food.y));
                food = new Location(-1, -1);

                //1,3 / 49,51 sol alt
                //49,51 / 1,3 sag ust
                // 49,51 / 49,51 sag alt 
                // 1,3 / 1,3 sol ust

                // Scoreların verilme yeri 
         
                if (x == 1 || y == 3 || x == 49 || y == 51) { Score(); }
                if (x == 49 || y == 51 || x == 1 || y == 3) { Score(); }
                if (x == 49 || y == 51 || x == 49 || y == 51) { Score(); }
                if (x == 1 || y == 3 || x == 1 || y == 3) { Score(); }
                else
                {
                    
                    cutTime = time - firstTime;
                    score = 100 / cutTime;
                    firstTime = cutTime;
                    if (cutTime > 40)
                    {
                        a += 0; 
                        score_label.Text = a.ToString();
                        
                    }
                    else 
                    {   
                        a += score;
                        score_label.Text = a.ToString();
                        
                    }
                    
                }
             }
            Bitmap bitmap = new Bitmap(500, 500); // 500 * 500 lük bir bitmap oluşumu.

            // köşelere çarptığında yanması 
            if (x == 51 || y == 51 || x ==51 || y == 51)
            {
                timer_score.Stop();
                DosyaIslemi();
             
                GameOver();
            }
            else if (x == 0 || y == 0 || x == 0 || y == 0)
            {
                timer_score.Stop();
                DosyaIslemi();
                GameOver();
            }
            else
            {

                // Yılanın baş kısmının oluşması
                for (int i = (x - 1) * 10; i < x * 10; i++)
                {
                    for (int j = (y - 1) * 10; j < y * 10; j++)
                    {

                        if (x > 510 || y > 510)
                        {
                            
                            i = 0;
                            j = 0;
                        }
                        else
                        {
                            bitmap.SetPixel(i, j, Color.Green);

                        }
                      
                        
                    }
                }
            }

            // Kuyruğun oluşumu 
            if (tales.Count != 1)
            {
                for (int k = 0; k < tales.Count; k++)
                {
                    for (int i = (tales[k].x - 1) * 10; i < tales[k].x * 10; i++)
                    {
                        for (int j = (tales[k].y - 1) * 10; j < tales[k].y * 10; j++)
                        {
                            if (i < 1 || i > 510 || j < 1 || j > 510 )
                            {
                                
                                i = 0;
                                j = 0;
                        }
                            else
                            {
                                bitmap.SetPixel(i, j, Color.Green);

                            }
                            

                        }
                    }
                }
            }

            tales[0] = new Location(x, y);
            for (int i = tales.Count - 1; i > 0; i--)
            {
                tales[i] = tales[i - 1];
            }

            // Yemek gittiginde yeniden olusan yem 
            if (food.x == -1)
            {
                food = new Location(random.Next(1, 51), random.Next(1, 51));
            }

            for (int i = (food.x - 1) * 10; i < food.x * 10; i++)
            {
                for (int j = (food.y - 1) * 10; j < food.y * 10; j++)
                {

                    bitmap.SetPixel(i, j, Color.Red);
                    
                }
            }
            game.Image = bitmap;
        }

        // Puanları tutmak için oluşturularn .txt dosyasının içeriği
        private void DosyaIslemi()
        {
            StreamWriter yazici = File.AppendText(skor_dosya_yolu);
            yazici.WriteLine(kullanici + " " + timer_label.Text.ToString() + " " + score_label.Text.ToString());
            yazici.Close();
        }

         // Puanı tutmak için tuttuğumuz zaman 
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            int a = 0;

            if (time >= 59)
            {
                a++;
              
            }
        }

         // Sayacı oluşturma ve ekrana yazdırma
        private void timer_time_Tick(object sender, EventArgs e)
        {

            timeGame++;
            second= timeGame;
            timer_label.Text = ((Convert.ToString(minute) + " : ") + (Convert.ToString(second)));
            if (second == 59)
            {
                timeGame = 0; 
                second = 0;
                minute = minute + 1;
            }

        }
        // Dosyaları kendi bilgisayarınız da uzantılarını yazarak tutmanız gerekir .txt dosyası 
        private void btnSkorlarıGörüntüle_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", skor_dosya_yolu);
        }

        private void btnYardım_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", yardim_dosya_yolu);
        }

        private void btnKişiyikaydet_Click(object sender, EventArgs e)
        {
            kullanici = txtKişileriKaydet.Text.ToString();
            MessageBox.Show("Kişi Kaydedildi!");
        }

        // Skoru hesaplamak için 
        public void Score()
        {
            if (cutTime != 0)
            {
                
                cutTime = time - firstTime;
                score = (100 / cutTime) + 10;
                firstTime = cutTime;
                if (cutTime > 10)
                {
                    a += 0;
                    score_label.Text = a.ToString();
                    
                }
                else
                {
                    a += score;
                    score_label.Text = a.ToString();
                    
                }
                
            }

        }
        // Oyunda yandığımızda gösterilen Mesaj 
        public void GameOver()
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Yeniden oynamak ister misiniz ? ", "Kaybettiniz", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                restart();
            }
            else
            {
                Application.Exit();
            }
        }
        // oyunun yeniden baslamasi 
        public void restart()
        {
            Form1 startForm = new Form1();
            this.Hide();
            startForm.Show();

            Application.Restart();
            
        }

    }
    
    // yemi ve kuyruğun konumunu tumak için
    public class Location
    {
        public int x, y;

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }
}
