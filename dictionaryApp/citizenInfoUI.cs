using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionaryApp
{
    public partial class citizenInfoUI : Form
    {
        Dictionary<string, string> citizenInfo = new Dictionary<string, string>();
        string citizenId, citizenDetails;
        public citizenInfoUI()
        {
            InitializeComponent();
        }

        

        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            citizenId = (string)citizenIdAddTextBox.Text;
            citizenDetails = (string)citizenDetailsTextBox.Text;
            if (!citizenInfo.ContainsKey(citizenId))
            {
                citizenInfo.Add(citizenId, citizenDetails);
                MessageBox.Show("Your information is saved.");
                citizenIdAddTextBox.Text = string.Empty;
                citizenDetailsTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("This data is already in the list.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string citizenIdSearch = (string) citizenIdSearchTextBox.Text;
            if (citizenInfo.ContainsKey(citizenIdSearch))
            {
                citizenDetailsTextBox.Text = citizenInfo[citizenIdSearch];
            }
            else
            {
                MessageBox.Show("Data does not exist!");
            }
        }

        string allInfo;
        private void showAllCitizenDetailsButton_Click(object sender, EventArgs e)
        {
            
            foreach (KeyValuePair<string, string> allPair in citizenInfo)
            {
                allInfo += allPair.Key + ", " + allPair.Value + "\n";
            }
            MessageBox.Show(allInfo);
        }
    }
}
