using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimMilyonerOlmakIster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sorular soru = new Sorular();
        int sayac = 0;
        int zaman = 15;
        int baslangic=16;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tmrIlkGiris.Start(); 
        }

        void Soru(string soru, string a ,string b , string c , string d)
        {
            rtxtsoru.Text = soru;
            btnasikki.Text = a;
            btnbsikki.Text = b;
            btncsikki.Text = c;
            btndsikki.Text = d;

        }


        private void btnSonrakiSoru_Click(object sender, EventArgs e)
        {
            sayac++;
            btnSonrakiSoru.Visible = false;
            btnasikki.BackColor = Color.White;
            btnbsikki.BackColor = Color.White;
            btncsikki.BackColor = Color.White;
            btndsikki.BackColor = Color.White;
            btnasikki.Enabled = true;
            btnbsikki.Enabled = true;
            btncsikki.Enabled = true;
            btndsikki.Enabled = true;

            if (sayac == 1)
            {
                btnCekilmekIstiyorum.Visible = true;
                btn500.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
                zaman = 15;
                tmrPB.Start();
            }
            else if (sayac == 2)
            {
                btn1000.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
                zaman = 45;
                tmrPB.Start();
            }
            else if (sayac == 3)
            {
                btn2000.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
                zaman = 45;
                tmrPB.Start();
            }
            else if (sayac == 4)
            {
                btn3000.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
                zaman = 45;
                tmrPB.Start();
            }
            else if (sayac == 5)
            {
                btn5000.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
                zaman = 45;
                tmrPB.Start();
            }
            else if (sayac == 6)
            {
                btn7500.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
                zaman = 45;
                tmrPB.Start();
            }
                
            else if (sayac == 7)
            {
                btn15000.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
            }
            else if (sayac == 8)
            {
                btn30000.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
            }
                
            else if (sayac == 9)
            {
                btn60000.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
            }
            else if (sayac == 10)
            {
                btn125000.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
            }
               
            else if (sayac == 11)
            {
                btn250000.BackColor = Color.Green;
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
            }
            else if (sayac == soru.sorular.Length)
            {
                btn1000000.BackColor = Color.Green;
                if (MessageBox.Show("Yarışmamız bitmiştir ödülünüz " + btn1000000.Text + "'dir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                {
                    Application.Exit();
                }

            }
            else
                Soru(soru.sorular[sayac], soru.ASikki[sayac], soru.BSikki[sayac], soru.CSikki[sayac], soru.DSikki[sayac]);
            
        }

        private void btnasikki_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Sorular soru = new Sorular();
            if (MessageBox.Show("Son Kararınız mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tmrPB.Stop();
                if (btn.Text == soru.DogruCevap[sayac])
                {

                    btn.BackColor = Color.Green;
                    btnasikki.Enabled = false;
                    btnbsikki.Enabled = false;
                    btncsikki.Enabled = false;
                    btndsikki.Enabled = false;
                    btnSonrakiSoru.Visible = true;



                }
                else
                {

                    btnSonrakiSoru.Visible = false;
                    btn.BackColor = Color.Red;
                    if (btnasikki.Text == soru.DogruCevap[sayac])
                        btnasikki.BackColor = Color.Green;
                    else if (btnbsikki.Text == soru.DogruCevap[sayac])
                        btnbsikki.BackColor = Color.Green;
                    else if (btncsikki.Text == soru.DogruCevap[sayac])
                        btncsikki.BackColor = Color.Green;
                    else if (btndsikki.Text == soru.DogruCevap[sayac])
                        btndsikki.BackColor = Color.Green;
                    if (sayac < 2)
                    {
                        if (MessageBox.Show("Yarışmamız bitmiştir ödülünüz 0'dir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                        btn500.BackColor = Color.Sienna;
                        btn1000.BackColor = Color.Sienna;
                    }
                    else if (sayac >= 2 && sayac < 7)
                    {
                        if (MessageBox.Show("Yarışmamız bitmiştir ödülünüz " + btn1000.Text + "'dir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                        btn2000.BackColor = Color.Sienna;
                        btn3000.BackColor = Color.Sienna;
                        btn5000.BackColor = Color.Sienna;
                        btn7500.BackColor = Color.Sienna;
                        btn15000.BackColor = Color.Sienna;

                    }
                    else if (sayac >= 7 && sayac < soru.sorular.Length)
                    {
                        if (MessageBox.Show("Yarışmamız bitmiştir ödülünüz " + btn15000.Text + "'dir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                        btn30000.BackColor = Color.Sienna;
                        btn60000.BackColor = Color.Sienna;
                        btn125000.BackColor = Color.Sienna;
                        btn250000.BackColor = Color.Sienna;
                        btn1000000.BackColor = Color.Sienna;
                    }
                    else if (sayac == soru.sorular.Length)
                        if (MessageBox.Show("Yarışmamız bitmiştir ödülünüz " + btn1000000.Text + "'dir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                        {
                            Application.Exit();
                        }


                    btnSonrakiSoru.Visible = false;
                }
            }
            else
                tmrPB.Start();
        }

        private void tmrPB_Tick(object sender, EventArgs e)
        {

            Sorular soru = new Sorular();
            lblzaman.Text = zaman.ToString();
            zaman--;
            
            
            if(zaman == 0)
            {
                tmrPB.Enabled = false;
                if (MessageBox.Show("Yarışmamız bitmiştir ödülünüz 0'dir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                {
                    Application.Exit();
                }

                
            }
                


        }

        private void btnYuzdeElli_Click(object sender, EventArgs e)
        {
            btnYuzdeElli.Enabled = false;
        }

        private void btnSeyirci_Click(object sender, EventArgs e)
        {
            btnSeyirci.Enabled = false;
            int sayi1;
            int sayi2;
            do
            {
                sayi1 = rnd.Next(1, 5);
                sayi2 = rnd.Next(1, 5);

            } while (sayi1 == sayi2);

            if (sayi1 == 1 && sayi2==2 && soru.ASikki[sayac]!=soru.DogruCevap[sayac] && soru.ASikki[sayac] != soru.DogruCevap[sayac])
            {
                btnasikki.Text = "";
                btnbsikki.Text = "";
            }
        }

        private void btnTelefon_Click(object sender, EventArgs e)
        {
            btnTelefon.Enabled = false;
        }

        private void tmrIlkGiris_Tick(object sender, EventArgs e)
        {
            baslangic--;
            
            if(baslangic==15)
            {
                rtxtsoru.Text = "Yarışmamız bildiğiniz gibi 12 sorudan oluşuyor.";
                btn500.BackColor = Color.Green;
            }
            if (baslangic == 14)
            {
                btn1000.BackColor = Color.Green;
            }
            if (baslangic == 13)
            {
                btn2000.BackColor = Color.Green;
            }
            if (baslangic == 12)
            {
                btn3000.BackColor = Color.Green;
            }
            if (baslangic == 11)
            {
                btn5000.BackColor = Color.Green;
            }
            if (baslangic == 10)
            {
                btn7500.BackColor = Color.Green;
            }
            if (baslangic == 9)
            {
                btn15000.BackColor = Color.Green;
            }
            if (baslangic == 8)
            {
                btn30000.BackColor = Color.Green;
            }
            if (baslangic == 7)
            {
                btn60000.BackColor = Color.Green;
            }
            if (baslangic == 6)
            {
                btn125000.BackColor = Color.Green;
            }
            if (baslangic == 5)
            {
                btn250000.BackColor = Color.Green;
            }
            if (baslangic == 4)
            {
                btn1000000.BackColor = Color.Green;
                rtxtsoru.Text = "3 adet jokerimiz var bunlar";
            }
            if (baslangic == 3)
            {
                rtxtsoru.Text += "-Yarı yarıya";
                btnYuzdeElli.BackColor = Color.Green;
            }
            if (baslangic == 2)
            {
                rtxtsoru.Text += "- Seyirci joker hakkı"; 
                btnSeyirci.BackColor = Color.Green;
            }
            if (baslangic == 1)
            {
                rtxtsoru.Text += "- ve de telefonla joker hakkı";
                btnTelefon.BackColor = Color.Green;
            }
            if (baslangic==0)
            {
                btn500.BackColor = Color.Sienna;
                btn1000.BackColor = Color.Sienna;
                btn2000.BackColor = Color.Sienna;
                btn3000.BackColor = Color.Sienna;
                btn5000.BackColor = Color.Sienna;
                btn7500.BackColor = Color.Sienna;
                btn15000.BackColor = Color.Sienna;
                btn30000.BackColor = Color.Sienna;
                btn60000.BackColor = Color.Sienna;
                btn125000.BackColor = Color.Sienna;
                btn250000.BackColor = Color.Sienna;
                btn1000000.BackColor = Color.Sienna;
                btnYuzdeElli.BackColor = Color.Peru;
                btnSeyirci.BackColor = Color.Peru;
                btnTelefon.BackColor = Color.Peru;
                if (MessageBox.Show("Hazırsak Başlayalım", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tmrPB.Start();
                    Sorular soru = new Sorular();
                    Soru(soru.sorular[0], soru.ASikki[0], soru.BSikki[0], soru.CSikki[0], soru.DSikki[0]);
                }
                tmrIlkGiris.Stop();
            }
        }

        private void YuzdeEllliHesapla(string a, string b, string c , string d)
        {
            int sayi = rnd.Next(1, 5);
            


        }
    }

    class Sorular
    {
        public string[] sorular = { "bir yere gitmeyi ifade ederken cümlenin başında kullanılan söz hangisidir?", "2005 yılında türk lirasından kaç sıfır atılmıştır?", "sol anahtarı hangi mesleği yapan kişilerin kullandığı bir terimdir?", "bordo renkli pasaport almak isteyen türk vatandaşlarının nereye müracaat etmesi gerekir?", "türkiye büyük milet meclisi başka hangi adla anılır?", "hamaset ne demektir?", "senin dudakların pembe, ellerin beyaz... al tut ellerimi bebek... tut biraz!\nbenim doğduğum köylerde ceviz ağaçları yoktu, ben bu yüzden serinliğe hasretim okşa biraz!\nbenim doğduğum köylerde buğday tarlaları yoktu, dağıt saçlarını bebek savur biraz!\nokuduğunuz bu şiir hangi şaire aittir?", "hangi liderin tarihi suikasti için aynı anda görevlendirilen 6 kişi fırsatı kaçırmış ve sonra, içlerinden biri arabası arızalanan lideri tesadüfen görüp vurmuştur?", "hangi beyaz saray skandalında, dönemin abd başkanı, kamuoyuna yaptığı özür konuşmasında ömer hayyam’ın bir dörtlüğünü kullanmıştır?", "antik ve orta çağ yüksek eğitiminin temeli olan 7 özgür sanattan biri hangisidir?", "dünyada, gece aydınlatılan ilk cadde nerededir?", "herodot'un yazdığı, mısır firavununun dilin kökeni deneyinde, doğunca çobana verilerek kapatılan, o dahil kimseyle konuşturulmayan çocuğun söyledi ilk kelime nedir?" };

        public string[] ASikki = { "ver elini", "3", "çilingir", "turizm bakanlığı", "danıştay", "kahramanlık", "turgut uyar", "ernesto cheuevara", "ebu garib", "gökbilim", "istanbul", "ver" };

        public string[] BSikki = { "kır dizini", "4", "marangoz", "valilik", "baro", "umutsuzluk", "cahit külebi", "çar ii. nikola", "watergate", "politika", "roma", "anne" };

        public string[] CSikki = { "sık dişini", "6", "tamirci", "dışişleri bakanlığı", "parlamento", "düşmanlık", "aziz nesin", "benito mussolini", "irangate", "anatomi", "kudüs", "ekmek" };

        public string[] DSikki = { "yum gözünü", "5", "müzisyen", "emniyet müdürlüğü", "yüce divan", "kıskançlık", "ahmet haşim", "franz ferdinand", "monica lewinsky", "aşçılık", "antakya", "su" };

        public string[] DogruCevap = { "ver elini", "6", "müzisyen", "emniyet müdürlüğü", "parlamento", "kahramanlık", "cahit külebi", "franz ferdinand", "monica lewinsky", "gökbilim", "antakya", "ekmek" };
    }
}
