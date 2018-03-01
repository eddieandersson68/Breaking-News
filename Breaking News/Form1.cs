using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breaking_News
{
    public partial class Form1 : Form
    {
        private string _aftonbladet = "https://aftonbladet.se";
        private string _expressen = "https://www.expressen.se/";
        private string _dN = "https://www.dn.se/";

        public string Korea = "Korea";
        public string Bostad = "Bostad";
        public string Ekonomi = "Ekonomi";
        public string Polis = "Polis";

        WebHandler wh = new WebHandler();
        private IWebCollector _myIWebCollector;
        private IWebCalculator _myIWebCalculator;

        public Form1()
        {
            InitializeComponent();
            _myIWebCollector = new WebHandler();
            _myIWebCalculator = new WebHandler();
        }

        private async Task ResultsLoading()
        {
            lblProgress.ForeColor = Color.Black;
            lblProgress.Text = "Please wait loading....";
            await Task.Delay(1500);
            lblProgress.Text = " ";
        }

        private async void _btnGetStas_Click(object sender, EventArgs e)
        {

            bool isAnySearchWordRadioButtonChecked = false;
            foreach (RadioButton rdo in grpBxSearchWords.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnySearchWordRadioButtonChecked = true;
                    break;
                }
            }

            bool isAnySiteRadioButtonChecked = false;
            foreach (RadioButton rdo in grpBxSites.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    isAnySiteRadioButtonChecked = true;
                    break;
                }
            }

            if (isAnySearchWordRadioButtonChecked)
            {
                if (isAnySiteRadioButtonChecked)
                {
                    if (rdbAftonbladet.Checked)
                    {
                        switch (grpBxSearchWords.SelectedRadioButton().Text)
                        {
                            case "Korea":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_aftonbladet));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbKorea.Text.ToLower()).ToString();
                                return;

                            case "Bostad":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_aftonbladet));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbBostad.Text.ToLower()).ToString();
                                return;

                            case "Ekonomi":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_aftonbladet));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbEkonomi.Text.ToLower()).ToString();
                                return;

                            case "Polis":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_aftonbladet));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbPolis.Text.ToLower()).ToString();
                                return;
                        }
                    }

                }

                else
                {
                    NositeSelected();
                }

                if (rdbEpressen.Checked)
                {

                    if (isAnySiteRadioButtonChecked)
                    {
                        switch (grpBxSearchWords.SelectedRadioButton().Text)
                        {
                            case "Korea":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_expressen));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbKorea.Text.ToLower()).ToString();
                                return;

                            case "Bostad":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_expressen));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbBostad.Text.ToLower()).ToString();
                                return;

                            case "Ekonomi":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_expressen));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbEkonomi.Text.ToLower()).ToString();
                                return;

                            case "Polis":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_expressen));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbPolis.Text.ToLower()).ToString();
                                return;
                        }
                    }
                    else
                    {
                        NositeSelected();
                    }
                }

                if (rdbDN.Checked)
                {
                    if (isAnySiteRadioButtonChecked)
                    {
                        switch (grpBxSearchWords.SelectedRadioButton().Text)
                        {
                            case "Korea":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_dN));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbKorea.Text.ToLower()).ToString();
                                return;

                            case "Bostad":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_dN));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbBostad.Text.ToLower()).ToString();
                                return;

                            case "Ekonomi":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_dN));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbEkonomi.Text.ToLower()).ToString();
                                return;

                            case "Polis":
                                await ResultsLoading();
                                await Task.Run(() => _myIWebCollector.GetHTMLFromUrl(_dN));
                                txBxResult.Text = _myIWebCalculator
                                    .CalculateNumberOfHits(_myIWebCollector, rdbPolis.Text.ToLower()).ToString();
                                return;
                        }
                    }
                }

                else
                {
                    NositeSelected();
                }
            }

            else if (isAnySearchWordRadioButtonChecked == false && isAnySiteRadioButtonChecked == false)
            {
                //if (txBxKeyWord.Text == "")
                //{

                lblProgress.ForeColor = Color.Red;
                lblProgress.Text = "No radio button selected";
                // }
            }

            else
            {
                //if (txBxKeyWord.Text == "")
                //{
                lblProgress.ForeColor = Color.Red;
                lblProgress.Text = "No keyword button selected";

                // }
            }

        }

        public void NositeSelected()
        {
            lblProgress.ForeColor = Color.Red;
            lblProgress.Text = "No site button selected";
        }
    }
}