using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaApplication.Classes;

namespace PizzaApplication
{
    public partial class PizzaBaseForm : Form
    {
        public Item SelectedBase { get; set; }

        public PizzaBaseForm()
        {
            InitializeComponent();
            ResetGroupBoxColours();
        }

        /* Sets all of our group boxes to their default desired unchosen colour */
        private void ResetGroupBoxColours()
        {
            foreach (Control groupbox in Controls)
            {
                if (groupbox.GetType() == typeof(GroupBox))
                {
                    groupbox.BackColor = Color.LightGray;
                }
            }
        }

        private void BtnThin_Click(object sender, EventArgs e)
        {
            /* Basic logic; checks if the base is equal to null i.e. not selected yet or if it's equal to what they are choosing, preventing redundant code */
            if (SelectedBase == null || SelectedBase.ItemName != "Thin Pizza Base")
            {
                SelectedBase = new Item("Thin Pizza Base", 3.99f, Item.Type.Base);
                ChangeSelectedBase(btnThin);
            }
        }

        private void BtnThick_Click(object sender, EventArgs e)
        {
            /* Repeated code for each button */
            if (SelectedBase == null || SelectedBase.ItemName != "Thick Pizza Base")
            {
                SelectedBase = new Item("Thick Pizza Base", 5.99f, Item.Type.Base);
                ChangeSelectedBase(btnThick);
            }
        }

        private void BtnDeep_Click(object sender, EventArgs e)
        {
            if (SelectedBase == null || SelectedBase.ItemName != "Deep Dish Base (Chicago)" )
            {
                SelectedBase = new Item("Deep Dish Base (Chicago)", 6.99f, Item.Type.Base);
                ChangeSelectedBase(btnDeep);
            }
        }

        /* Visually updates the controls when a new selection is done */
        private void ChangeSelectedBase(Control control)
        {
            foreach(Control groupbox in Controls)
            {
                if(groupbox.GetType() == typeof(GroupBox))
                {
                    groupbox.BackColor = Color.LightGray;
                }
            }
            control.Parent.BackColor = Color.FloralWhite;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            if(SelectedBase == null)
            {
                MessageBox.Show("You can't proceed without choosing a base!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show($"You have chosen {SelectedBase.ItemName} as your pizza base, continue?", "Confirm", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    //continue
                }
                else
                {
                    /* Abort from function, putting them back in control of the form. */
                    return;
                }
            }
        }
    }
}
