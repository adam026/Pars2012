using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pars2012GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var nevek = Program._versenyzok.Select(v => v.Nev);
            foreach (var nev in nevek)
            {
                cbVersenyzo.Items.Add(nev);
            }

            cbVersenyzo.SelectedItem = "Pars Krisztián";
        }

        private void VersenyzoBetoltes(string versenyzoNeve)
        {
            var versenyzo = Program._versenyzok.Single(x => x.Nev == versenyzoNeve);

            lblCsoport.Text = $"Csoport: {versenyzo.Csoport}";
            lblEredmeny.Text = $"Eredmény: {versenyzo.Eredmeny}";
            lblNemzet.Text = $"Nemzet: {versenyzo.Nemzet}";
            lblNemzetKod.Text = $"Nemzet kód: {versenyzo.Kod}";
            lblSorozat.Text = $"Sorozat: {versenyzo.Sorozat}";

            pbZaszlo.ImageLocation = @"..\..\Images\" + versenyzo.Kod + ".png";
        }

        private void cbVersenyzo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VersenyzoBetoltes(cbVersenyzo.SelectedItem.ToString());
        }
    }
}
