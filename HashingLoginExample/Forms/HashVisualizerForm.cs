using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashingLoginExample
{
    public partial class Form1 : Form
    {
        private List<string> supportedHashAlgorithms = new List<string>();
        public Form1()
        {
            InitializeComponent();

            WireUpDropDown();
        }

        private void WireUpDropDown()
        {
            supportedHashAlgorithms.Add("SHA256");
            supportedHashAlgorithms.Add("SHA384");
            supportedHashAlgorithms.Add("SHA512");

            hashAlgorithmComboBox.DataSource = supportedHashAlgorithms;
        }


        private void hashButton_Click(object sender, EventArgs e)
        {
            switch (hashAlgorithmComboBox.Text)
            {
                case "SHA256":
                    hashTextBox.Text = Hashing.ComputeHash(originalTextBox.Text, Supported_HA.SHA256, null);
                    break;
                case "SHA384":
                    hashTextBox.Text = Hashing.ComputeHash(originalTextBox.Text, Supported_HA.SHA384, null);
                    break;
                case "SHA512":
                    hashTextBox.Text = Hashing.ComputeHash(originalTextBox.Text, Supported_HA.SHA512, null);
                    break;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            switch (hashAlgorithmComboBox.Text)
            {
                case "SHA256":
                    statusLabel.Text = (Hashing.Confirm(originalTextBox.Text, hashTextBox.Text, Supported_HA.SHA256)) ? "Status: Correct" : "Status: Incorrect";
                    break;
                case "SHA384":
                    statusLabel.Text = (Hashing.Confirm(originalTextBox.Text, hashTextBox.Text, Supported_HA.SHA384)) ? "Status: Correct" : "Status: Incorrect";
                    break;
                case "SHA512":
                    statusLabel.Text = (Hashing.Confirm(originalTextBox.Text, hashTextBox.Text, Supported_HA.SHA512)) ? "Status: Correct" : "Status: Incorrect";
                    break;
            }
        }
    }
}
