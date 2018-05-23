using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinMaksBeregner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int antallSkuddHold = radInnledende.Checked ? 6 : 12;

            try
            {
                int antallSkudd = Convert.ToInt32(txtAntallSkudd.Text);
                int antallTreff = Convert.ToInt32(txtAntallTreff.Text);
                int antallInnertreff = Convert.ToInt32(txtAntallInnertreff.Text);

                // TODO: Validering her
                if(antallSkudd < antallSkuddHold + 2)
                {
                    // for få skudd i skive
                    txtAntallSkudd.Text = "";
                    throw new Exception("For få skudd i skive for å beregne minimum og maksimum");
                }

                if(antallTreff > antallSkudd || antallTreff < 0)
                {
                    // flere treff enn skudd i skive eller treff mindre enn 0
                    txtAntallTreff.Text = "";
                    throw new Exception("Antall treff må være mellom 0 og antall skudd");
                }

                if(antallInnertreff > antallTreff || antallInnertreff < 0)
                {
                    // flere innertreff enn treff eller innertreff mindre enn 0
                    txtAntallInnertreff.Text = "";
                    throw new Exception("Antall innertreff må være mellom 0 og antall treff");
                }

                Beregner beregner = new Beregner(antallSkuddHold);
                lblMin.Text = beregner.BeregnMin(antallSkudd, antallTreff, antallInnertreff);
                lblMaks.Text = beregner.BeregnMaks(antallSkudd, antallTreff, antallInnertreff);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblMin.Text = "-/-";
                lblMaks.Text = "-/-";
            }
        }
    }
}
