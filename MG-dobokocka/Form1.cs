using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_dobokocka
{
    public partial class Főablak : Form
    {
       
        public List<int> bendeguzlista = new List<int>();
        public List<int> aladarlista = new List<int>();

        Random rnd = new Random();
        

        public Főablak()
        {
            InitializeComponent();
        }

        

        private void szamitas_Click(object sender, EventArgs e)
        {
            int szam = rnd.Next(1, 7);
            timer1.Enabled = true;

        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("A játék véget ért");
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            bendeguzlista.Clear();
            aladarlista.Clear();
            aladardobasai2.Text = "";
            aladargyozelmekszama2.Text = "";
            aladarhatosdobas2.Text = "";
            aladarnyero2.Text = "";
            bendeguzdobasai2.Text = "";
            bendeguzgyozelmekszama2.Text = "";
            bendeguzhatosdobas2.Text = "";
            bendeguznyeroszeria2.Text = "";
            kigyozott.Text = "";
            List<bool> bendeguzdobasok = new List<bool>();
            List<bool> aladardobasok = new List<bool>();
            int bendeguzhatosdobasok = 0;
            int aladarhatosdobasok = 0;
            int aladargyozelmek = 0;
            int bendeguzgyozelmek = 0;
            bool bendeguznyeroszeria = false;
            bool aladarnyeroszeria = false;
            for (int i = 0; i < 20; i++)
            {
                aladarlista.Add(rnd.Next(1, 7));
                bendeguzlista.Add(rnd.Next(1, 7));
            }
            for (int i = 0; i < bendeguzlista.Count; i++)
            {
                if (aladarlista[i] > bendeguzlista[i])
                {
                    aladardobasok.Add(true);
                    aladargyozelmek++;
                    bendeguzdobasok.Add(false);
                }
                else if (bendeguzlista[i] > aladarlista[i])
                {
                    bendeguzdobasok.Add(true);
                    bendeguzgyozelmek++;
                    aladardobasok.Add(false);
                }
                if (Convert.ToInt32(aladarlista[i]) == 6)
                {
                    aladarhatosdobasok++;
                }
                if (Convert.ToInt32(bendeguzlista[i]) == 6)
                {
                    bendeguzhatosdobasok++;
                }
            }
            for (int i = 0; i < bendeguzdobasok.Count-3; i++)
            {
                if (bendeguzdobasok[i] == true && bendeguzdobasok[i+1] == true && bendeguzdobasok[i+2] == true && bendeguzdobasok[i+3] == true)
                {
                    bendeguznyeroszeria = true;
                }
            }
            for (int i = 0; i < aladardobasok.Count-3; i++)
            {
                if (aladardobasok[i] == true && aladardobasok[i + 1] == true && aladardobasok[i + 2] == true && aladardobasok[i + 3] == true)
                {
                    aladarnyeroszeria = true;
                }
            }

            for (int i = 0; i < bendeguzlista.Count-1; i++)
            {
                
                if (i == bendeguzlista.Count-2)
                    bendeguzdobasai2.Text += (bendeguzlista[i]);
                else
                    bendeguzdobasai2.Text += (bendeguzlista[i] + ",");
            }
            
            for (int i = 0; i < aladarlista.Count-1; i++)
            {
                
                if (i == aladarlista.Count-2)
                    aladardobasai2.Text += (aladarlista[i]);
                else
                    aladardobasai2.Text += (aladarlista[i] + ",");
            }

            aladargyozelmekszama2.Text = Convert.ToString(aladargyozelmek);
            bendeguzgyozelmekszama2.Text = Convert.ToString(bendeguzgyozelmek);

            aladarhatosdobas2.Text = Convert.ToString(aladarhatosdobasok);
            bendeguzhatosdobas2.Text = Convert.ToString(bendeguzhatosdobasok);

            if (aladarnyeroszeria == true)
                aladarnyero2.Text = "volt";
            else
                aladarnyero2.Text = "nem volt";

            if (bendeguznyeroszeria == true)
                bendeguznyeroszeria2.Text = "volt";
            else
                bendeguznyeroszeria2.Text = "nem volt";

            if(bendeguzlista.Sum() == aladarlista.Sum())
            {
                kigyozott.Text = $"Döntetlen lett az eredmény {aladarlista.Sum()}:{bendeguzlista.Sum()} ponttal.";
                
            }
            else if(aladarlista.Sum() > bendeguzlista.Sum())
            {
                kigyozott.Text = $"Aladár győzött {aladarlista.Sum()}:{bendeguzlista.Sum()} ponttal.";
            }
            else
            {
                kigyozott.Text = $"Bendegúz győzött {bendeguzlista.Sum()}:{aladarlista.Sum()} ponttal.";
            }


            timer1.Enabled = false;
        }

    }
}
