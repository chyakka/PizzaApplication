using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            /* Ensures each text box isn't empty before we do specific text box validation */
            foreach(TextBox txtBox in Controls.OfType<TextBox>())
            {
                if(txtBox.Text.Length == 0)
                {
                    MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButtons.OK);
                    /* Return statement ensures any code below this won't be executed */
                    return;
                }
            }

            /* Post code Regex expression as provied by British Gov - source: https://assets.publishing.service.gov.uk/government/uploads/system/uploads/attachment_data/file/488478/Bulk_Data_Transfer_-_additional_validation_valid_from_12_November_2015.pdf */
            if(!Regex.IsMatch(txtPostCode.Text, "^([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z])))) [0-9][A-Za-z]{2})$"))
            {
                MessageBox.Show("Invalid post code provided.", "Error", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
