using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prosjek_ocjena
{
    public partial class Form1 : Form
    {
        int ocjena, brojOcjena = 0, zbroj;
        double prosjek;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {
            try
            {
                ocjena = Convert.ToInt32(txtunosOcjene.Text);
                if (ocjena == 1)
                {
                    MessageBox.Show("imas negativnu ocjenu, ispravi je prije nego" + "ides racunati prosjek!", "NEGATIVNO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else if (ocjena == 0) 
                {
                    MessageBox.Show("ocjena ne moze biti nula", "pogresan unos!", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
                

                else
                {
                    brojOcjena++;
                    zbroj += ocjena;
                    DialogResult odgovor = MessageBox.Show("zelis li upisati jos ocjena?", "upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (odgovor)
                    {
                        case DialogResult.Yes:
                            txtunosOcjene.Clear();
                            break;
                        case DialogResult.No:
                            prosjek = (double)zbroj / brojOcjena;
                            txtProsjekOcjene.Text = prosjek.ToString();
                            break;
                    }
                }
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "greska unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
