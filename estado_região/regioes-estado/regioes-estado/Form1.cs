using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regioes_estado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblTot.Text = CboTot.Items.Count.ToString();
        }

        private void Btninserir_Click(object sender, EventArgs e)
        {
            switch(CboTot.SelectedItem)
            {
                case "AM":
                case "AC":
                case "AP":
                case "PA":
                case "RO":
                case "RR":
                case "TO":
                    CboNort.Items.Add(CboTot.SelectedItem.ToString());
                    CboTot.Items.Remove(CboTot.SelectedItem);

                    LblTot.Text = CboTot.Items.Count.ToString();
                    LblNort.Text = CboNort.Items.Count.ToString();
                    break;

                case "AL":
                case "BA":
                case "CE":
                case "MA":
                case "PB":
                case "PE":
                case "PI":
                case "RN":
                case "SE":
                    CboNord.Items.Add(CboTot.SelectedItem.ToString());
                    CboTot.Items.Remove(CboTot.SelectedItem);

                    LblTot.Text = CboTot.Items.Count.ToString();
                    lblCent.Text = CboCent.Items.Count.ToString();

                    break;

                case "DF":
                case "GO":
                case "MT":
                case "MS":
                    CboCent.Items.Add(CboTot.SelectedItem.ToString());
                    CboTot.Items.Remove(CboTot.SelectedItem);

                    LblTot.Text = CboTot.Items.Count.ToString();
                    lblCent.Text = CboCent.Items.Count.ToString();
                    break;

                case "ES":
                case "MG":
                case "RJ":
                case "SP":

                    CboSud.Items.Add(CboTot.SelectedItem.ToString());
                    CboTot.Items.Remove(CboTot.SelectedItem);

                    LblTot.Text = CboTot.Items.Count.ToString();
                    lblSud.Text = CboSud.Items.Count.ToString();
                    break;

                case "PR":
                case "RS":
                case "SC":

                    CboSul.Items.Add(CboTot.SelectedItem.ToString());
                    CboTot.Items.Remove(CboTot.SelectedItem);

                    LblTot.Text = CboTot.Items.Count.ToString();
                    lblsul.Text = CboSul.Items.Count.ToString();
                    break;

            }


          

           
        }

        private void BtnremovNort_Click(object sender, EventArgs e)
        {
            
            CboTot.Items.Insert(2, CboNort.SelectedItem.ToString());
            CboNort.Items.Remove(CboNort.SelectedItem);

            LblTot.Text = CboTot.Items.Count.ToString();
            LblNort.Text = CboNort.Items.Count.ToString();
        }

        private void BtnRemoveNord_Click(object sender, EventArgs e)
        {

            CboTot.Items.Add(CboNord.SelectedItem.ToString());
            CboNord.Items.Remove(CboNord.SelectedItem);

            LblTot.Text = CboTot.Items.Count.ToString();
            lblNord.Text = CboNord.Items.Count.ToString();
        }

        private void BtnRemoveCent_Click(object sender, EventArgs e)
        {

            CboTot.Items.Add(CboCent.SelectedItem.ToString());
            CboCent.Items.Remove(CboCent.SelectedItem);

            LblTot.Text = CboTot.Items.Count.ToString();
            lblCent.Text = CboCent.Items.Count.ToString();
        }

        private void BtnRemoveSud_Click(object sender, EventArgs e)
        {

            CboTot.Items.Add(CboSud.SelectedItem.ToString());
            CboSud.Items.Remove(CboSud.SelectedItem);

            LblTot.Text = CboTot.Items.Count.ToString();
            lblSud.Text = CboSud.Items.Count.ToString();
        }

        private void BtnremoveSul_Click(object sender, EventArgs e)
        {
            CboTot.Items.Add(CboSul.SelectedItem.ToString());
            CboSul.Items.Remove(CboSul.SelectedItem);

            LblTot.Text = CboTot.Items.Count.ToString();
            lblsul.Text = CboSul.Items.Count.ToString();

        }

        private void CboTot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
