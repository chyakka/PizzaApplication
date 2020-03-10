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
using PizzaApplication.Managers;

namespace PizzaApplication
{
    public partial class PizzaBaseForm : Form
    {
        public Item SelectedBase { get; set; }
        public Item SelectedStarter { get; set; }
        public Item SelectedSweet { get; set; }
        public List<Item> SelectedToppings { get; set; }

        public PizzaBaseForm()
        {
            InitializeComponent();
            ResetGroupBoxColours();
        }

        /* Sets all of our group boxes to their default desired unchosen colour */
        private void ResetGroupBoxColours()
        {
            foreach (Control groupbox in pizzaBaseLayoutPanel.Controls)
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
                if (SelectedBase != null && UserData.order.Items.Contains(SelectedBase)) UserData.order.Items.Remove(SelectedBase);
                SelectedBase = new Item("Thin Pizza Base", Item.Type.Base);
                UserData.order.Items.Add(SelectedBase);
                BasketManager.UpdateBasketDisplay(orderList);
                ChangeSelectedBase(btnThin);
            }
        }

        private void BtnThick_Click(object sender, EventArgs e)
        {
            /* Repeated code for each button */
            if (SelectedBase == null || SelectedBase.ItemName != "Thick Pizza Base")
            {
                if (SelectedBase != null && UserData.order.Items.Contains(SelectedBase)) UserData.order.Items.Remove(SelectedBase);
                SelectedBase = new Item("Thick Pizza Base", Item.Type.Base);
                UserData.order.Items.Add(SelectedBase);
                BasketManager.UpdateBasketDisplay(orderList);
                ChangeSelectedBase(btnThick);
            }
        }

        private void BtnDeep_Click(object sender, EventArgs e)
        {
            if (SelectedBase == null || SelectedBase.ItemName != "Chicago Base")
            {
                if (SelectedBase != null && UserData.order.Items.Contains(SelectedBase)) UserData.order.Items.Remove(SelectedBase);
                SelectedBase = new Item("Chicago Base", Item.Type.Base);
                UserData.order.Items.Add(SelectedBase);
                BasketManager.UpdateBasketDisplay(orderList);
                ChangeSelectedBase(btnDeep);
            }
        }

        /* Visually updates the controls when a new selection is done */
        private void ChangeSelectedBase(Control control)
        {
            foreach(Control groupbox in pizzaBaseLayoutPanel.Controls)
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
                DialogResult result = MessageBox.Show($"Ensure you have reviewed your order before continuing!", "Confirm", MessageBoxButtons.YesNo);
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

        private void LblOrder_Enter(object sender, EventArgs e)
        {
            orderList.Visible = true;
        }

        private void LblOrder_Leave(object sender, EventArgs e)
        {
            orderList.Visible = false;
        }

        private void LblOrder_MouseEnter(object sender, EventArgs e)
        {
            orderList.Visible = true;
        }

        private void LblOrder_MouseLeave(object sender, EventArgs e)
        {
            orderList.Visible = false;
        }

        private void PizzaBaseForm_Load(object sender, EventArgs e)
        {
        }
    }
}
