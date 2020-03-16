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

        public PizzaBaseForm()
        {
            InitializeComponent();
            ResetGroupBoxColours();
        }

        /* Sets all of our group boxes to their default desired unchosen colour - this could be done manually in the editor but this would be slower. */
        private void ResetGroupBoxColours()
        {
            foreach (Control groupbox in pizzaBaseLayoutPanel.Controls)
            {
                if (groupbox.GetType() == typeof(GroupBox))
                {
                    groupbox.BackColor = Color.LightGray;
                }
            }

            foreach(Control groupbox in toppingLayoutPanel.Controls)
            {
                if(groupbox.GetType() == typeof(GroupBox))
                {
                    groupbox.BackColor = Color.LightGray;
                }
            }

            foreach(Control groupbox in starterLayoutPanel.Controls)
            {
                if (groupbox.GetType() == typeof(GroupBox))
                {
                    groupbox.BackColor = Color.LightGray;
                }
            }

            foreach (Control groupbox in sweetLayoutPanel.Controls)
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

        private void ChangeSelectedStarter(Control control)
        {
            foreach (Control groupbox in starterLayoutPanel.Controls)
            {
                if (groupbox.GetType() == typeof(GroupBox))
                {
                    groupbox.BackColor = Color.LightGray;
                }
            }
            control.BackColor = Color.FloralWhite;
        }

        private void ChangeSelectedSweet(Control control)
        {
            foreach (Control groupbox in sweetLayoutPanel.Controls)
            {
                if (groupbox.GetType() == typeof(GroupBox))
                {
                    groupbox.BackColor = Color.LightGray;
                }
            }
            control.BackColor = Color.FloralWhite;
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

        private void btnPepperoni_Click(object sender, EventArgs e)
        {
            if (SelectedBase != null)
            {
                if (UserData.order.ContainsItem("Pepperoni Topping"))
                {
                    btnPepperoni.Parent.BackColor = Color.LightGray;
                    UserData.order.RemoveItem("Pepperoni Topping");
                }
                else
                {
                    UserData.order.Items.Add(new Item("Pepperoni Topping", Item.Type.Topping));
                    btnPepperoni.Parent.BackColor = Color.FloralWhite;
                }
                BasketManager.UpdateBasketDisplay(orderList);
            }
            else
            {
                MessageBox.Show("Select a pizza base before choosing your toppings!");
            }
        }

        private void btnOlives_Click(object sender, EventArgs e)
        {
            if (SelectedBase != null)
            {
                if (UserData.order.ContainsItem("Olive Topping"))
                {
                    btnOlives.Parent.BackColor = Color.LightGray;
                    UserData.order.RemoveItem("Olive Topping");
                }
                else
                {
                    UserData.order.Items.Add(new Item("Olive Topping", Item.Type.Topping));
                    btnOlives.Parent.BackColor = Color.FloralWhite;
                }
                BasketManager.UpdateBasketDisplay(orderList);
            }
            else
            {
                MessageBox.Show("Select a pizza base before choosing your toppings!");
            }
        }

        private void btnPeppers_Click(object sender, EventArgs e)
        {
            if (SelectedBase != null)
            {
                if (UserData.order.ContainsItem("Pepper Topping"))
                {
                    btnPeppers.Parent.BackColor = Color.LightGray;
                    UserData.order.RemoveItem("Pepper Topping");
                }
                else
                {
                    UserData.order.Items.Add(new Item("Pepper Topping", Item.Type.Topping));
                    btnPeppers.Parent.BackColor = Color.FloralWhite;
                }
                BasketManager.UpdateBasketDisplay(orderList);
            }
            else
            {
                MessageBox.Show("Select a pizza base before choosing your toppings!");
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            if (SelectedBase != null)
            {
                if (UserData.order.ContainsItem("Ham Topping"))
                {
                    btnHam.Parent.BackColor = Color.LightGray;
                    UserData.order.RemoveItem("Ham Topping");
                }
                else
                {
                    UserData.order.Items.Add(new Item("Ham Topping", Item.Type.Topping));
                    btnHam.Parent.BackColor = Color.FloralWhite;
                }
                BasketManager.UpdateBasketDisplay(orderList);
            }
            else
            {
                MessageBox.Show("Select a pizza base before choosing your toppings!");
            }
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            if (SelectedBase != null)
            {
                if (UserData.order.ContainsItem("Mushroom Topping"))
                {
                    btnMushroom.Parent.BackColor = Color.LightGray;
                    UserData.order.RemoveItem("Mushroom Topping");
                }
                else
                {
                    UserData.order.Items.Add(new Item("Mushroom Topping", Item.Type.Topping));
                    btnMushroom.Parent.BackColor = Color.FloralWhite;
                }
                BasketManager.UpdateBasketDisplay(orderList);
            }
            else
            {
                MessageBox.Show("Select a pizza base before choosing your toppings!");
            }
        }

        private void btnExtraCheese_Click(object sender, EventArgs e)
        {
            if (SelectedBase != null)
            {
                if (UserData.order.ContainsItem("Extra Cheese Topping"))
                {
                    btnExtraCheese.Parent.BackColor = Color.LightGray;
                    UserData.order.RemoveItem("Extra Cheese Topping");
                }
                else
                {
                    UserData.order.Items.Add(new Item("Extra Cheese Topping", Item.Type.Topping));
                    btnExtraCheese.Parent.BackColor = Color.FloralWhite;
                }
                BasketManager.UpdateBasketDisplay(orderList);
            }
            else
            {
                MessageBox.Show("Select a pizza base before choosing your toppings!");
            }
        }

        private void btnBacon_Click(object sender, EventArgs e)
        {
            if (SelectedBase != null)
            {
                if (UserData.order.ContainsItem("Bacon Topping"))
                {
                    btnBacon.Parent.BackColor = Color.LightGray;
                    UserData.order.RemoveItem("Bacon Topping");
                }
                else
                {
                    UserData.order.Items.Add(new Item("Bacon Topping", Item.Type.Topping));
                    btnBacon.Parent.BackColor = Color.FloralWhite;
                }
                BasketManager.UpdateBasketDisplay(orderList);
            }
            else
            {
                MessageBox.Show("Select a pizza base before choosing your toppings!");
            }
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            if (SelectedBase != null)
            {
                if (UserData.order.ContainsItem("Chicken Topping"))
                {
                    btnChicken.Parent.BackColor = Color.LightGray;
                    UserData.order.RemoveItem("Chicken Topping");
                }
                else
                {
                    UserData.order.Items.Add(new Item("Chicken Topping", Item.Type.Topping));
                    btnChicken.Parent.BackColor = Color.FloralWhite;
                }
                BasketManager.UpdateBasketDisplay(orderList);
            }
            else
            {
                MessageBox.Show("Select a pizza base before choosing your toppings!");
            }
        }

        private void btnChickenWing_Click(object sender, EventArgs e)
        {
            /* Similarly repeated logic for the pizza base */
            if (SelectedStarter == null || SelectedStarter.ItemName != "Chicken Wings")
            {
                if (SelectedStarter != null && UserData.order.Items.Contains(SelectedStarter)) UserData.order.Items.Remove(SelectedStarter);
                SelectedStarter = new Item("Chicken Wings", Item.Type.Starter);
                UserData.order.Items.Add(SelectedStarter);
                BasketManager.UpdateBasketDisplay(orderList);
                ChangeSelectedStarter(chickenwingGroupBox);
            }
        }

        private void btnMozzarellaSticks_Click(object sender, EventArgs e)
        {
            if (SelectedStarter == null || SelectedStarter.ItemName != "Mozzarella Sticks")
            {
                if (SelectedStarter != null && UserData.order.Items.Contains(SelectedStarter)) UserData.order.Items.Remove(SelectedStarter);
                SelectedStarter = new Item("Mozzarella Sticks", Item.Type.Starter);
                UserData.order.Items.Add(SelectedStarter);
                BasketManager.UpdateBasketDisplay(orderList);
                ChangeSelectedStarter(mozzarellaGroupBox);
            }
        }

        private void btnSalad_Click(object sender, EventArgs e)
        {
            if(SelectedStarter == null || SelectedStarter.ItemName != "Salad")
            {
                if (SelectedStarter != null && UserData.order.Items.Contains(SelectedStarter)) UserData.order.Items.Remove(SelectedStarter);
                SelectedStarter = new Item("Salad", Item.Type.Starter);
                UserData.order.Items.Add(SelectedStarter);
                BasketManager.UpdateBasketDisplay(orderList);
                ChangeSelectedStarter(saladGroupBox);
            }
        }

        private void btnIceCream_Click(object sender, EventArgs e)
        {
            if (SelectedSweet == null || SelectedSweet.ItemName != "Ice Cream")
            {
                if (SelectedSweet != null && UserData.order.Items.Contains(SelectedSweet)) UserData.order.Items.Remove(SelectedSweet);
                SelectedSweet = new Item("Ice Cream", Item.Type.Sweet);
                UserData.order.Items.Add(SelectedSweet);
                BasketManager.UpdateBasketDisplay(orderList);
                ChangeSelectedSweet(icecreamGroupBox);
            }
        }

        private void btnChocolateCake_Click(object sender, EventArgs e)
        {
            if (SelectedSweet == null || SelectedSweet.ItemName != "Chocolate Cake")
            {
                if (SelectedSweet != null && UserData.order.Items.Contains(SelectedSweet)) UserData.order.Items.Remove(SelectedSweet);
                SelectedSweet = new Item("Chocolate Cake", Item.Type.Sweet);
                UserData.order.Items.Add(SelectedSweet);
                BasketManager.UpdateBasketDisplay(orderList);
                ChangeSelectedSweet(chocolatecakeGroupBox);
            }
        }

        private void btnCheesecake_Click(object sender, EventArgs e)
        {
            if (SelectedSweet == null || SelectedSweet.ItemName != "Cheese Cake")
            {
                if (SelectedSweet != null && UserData.order.Items.Contains(SelectedSweet)) UserData.order.Items.Remove(SelectedSweet);
                SelectedSweet = new Item("Cheese Cake", Item.Type.Sweet);
                UserData.order.Items.Add(SelectedSweet);
                BasketManager.UpdateBasketDisplay(orderList);
                ChangeSelectedSweet(cheesecakeGroupBox);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (UserData.order.Items.Count == 0) MessageBox.Show("You need to have items in your order to proceed.", "Error");

            DialogResult dialogResult = MessageBox.Show("Pressing yes will confirm your order and close the application, continue?", "Confirm", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mainTabControl.SelectedTab.Text == "Confirm Order")
            {
                finalOrderListBox.Items.Clear();
                foreach(Item item in UserData.order.Items)
                {
                    finalOrderListBox.Items.Add($"{item.ItemName} ({item.ItemType})");
                }
            }
        }
    }
}
