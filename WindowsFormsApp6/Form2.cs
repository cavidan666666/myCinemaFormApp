using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        //yaradacaqim duymeleri yerkesdrmek ucun bir buton listi yaradiram
        public List<Button> butonlar = new List<Button>();
        public Form2()
        {
            InitializeComponent();
        }
        //1 - ci butonlari el ile yaradacaqiimz ucun top left deyisenleri teyin edirik
        int left = 150;
        int top = 100;
        //burada countu 1 e beraber edirik ki duymelerde 0 - ci index gorunmesin
        int count = 1;
        private void Form2_Load(object sender, EventArgs e)
        {

            //24 eded duyme yaradacaqimiz ucun for  - dan istifade edirik
            for (int i = 0; i < 24; i++)
            {
                //duymeler alt alta sira ile duzulmesi ucun 24 duymeni 4 yere bolub 6 , 6  yazmaq olar 
                //bunuu etmek ucunde sert qoyuruq
                if (i == 6)
                {
                    left = 150;
                    top = 150;
                }
                else if (i == 12)
                {
                    left = 150;
                    top = 200;
                }
                else if (i == 18)
                {
                    left = 150;
                    top = 250;
                }
                else if (i == 24)
                {
                    left = 150;
                    top = 300;
                }

                //Daha Sonra ise Duymemizi yaradmaqa baslayiriq
                Button menimDuymem = new Button();
                menimDuymem.Width = 80;
                menimDuymem.Height = 30;
                menimDuymem.BackColor = Color.White;
                menimDuymem.Font = new Font(menimDuymem.Font.Name, menimDuymem.Font.Size, FontStyle.Italic);
                menimDuymem.Left = left;
                menimDuymem.Top = top;
                menimDuymem.Text = count.ToString();
                Controls.Add(menimDuymem);
                left += 130;
                //countu hemise bir vahid artirirqki duymede bir vahid artsin
                count++;
                //klik metodu qurmaq ucun  menimDuymeme klik funksiyasi veririk
                menimDuymem.Click += new System.EventHandler(this.duymeye_bas);

            }

        }
        private void duymeye_bas(object sender, EventArgs arguments)
        {
            Button menimButonum = sender as Button;
            menimButonum.BackColor = Color.Yellow;
            //burada yaratdiqim duymeleri buton listine elave edirem
            butonlar.Add(menimButonum);

            //Daha sonra foreeach la duymeleri gosterirem
            foreach (var cavcav in butonlar)
            {
                //burada eyni duymeye tekrar basilarsa bas verecek hadiseni gostermek ucun duymeyetekararbas teyini edirem
                cavcav.Click += new System.EventHandler(this.duymeyeTekrarBasilarsa);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.BackColor = Color.LightBlue;
            label1.Text = "Your Places Selected";

            foreach (var cavcav2 in butonlar)
            {
                cavcav2.BackColor = Color.Orange;
            }
        }

        //duymeyetekrarbasilarsa burada metod kimi ise dusur
       private void duymeyeTekrarBasilarsa(object sender, EventArgs argumentss)
        {
            foreach (var Cav in butonlar)
            {
                label4.Text = "This Table Already Selected";
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
            button2.BackColor = Color.LightBlue;
            foreach (var CavCav in butonlar)
            {
                CavCav.BackColor = Color.OrangeRed;
            }

            label2.Text = " Your Select be Apply Succesfuly";
        }
    }
}
