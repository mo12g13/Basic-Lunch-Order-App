using System;

using System.Windows.Forms;

/*
 This application calculates the sub-total, tax and order total of the lunch order by a 
 client.
 */

namespace Lunch_Order
{
    public partial class frmLunchOrderForm : Form

    {
        String value;
        String itemsAdd;
        double hamburger = 0, pizza, salad;
        double hamburgerAdd_On_Price = 0, pizzaAdd_On_Price = 0, salad_AddOn_Price = 0;

        public frmLunchOrderForm()
        {
            InitializeComponent();
        }

        //A event handler that adds the various add-on items price selected by the user
        private void addOnItems(object sender, EventArgs e)
        {
            //Converting the sender to a checkbox and then to a String
            CheckBox addOn = (CheckBox)sender;
            itemsAdd = addOn.Text;
            //Calling to various methods to calculate the add-on of each item selected by the user
            hamburgerAdd_On_Price = getAddOnPrice(chkHamburger, chkadd_On_OnOne, 0.75) + getAddOnPrice(chkHamburger, chkadd_On_Two, 0.75) +
                 getAddOnPrice(chkHamburger, chkAdd_On_Three, 0.75);

            pizzaAdd_On_Price = getAddOnPrice(chkPizza, chkadd_On_OnOne, 0.50) + getAddOnPrice(chkPizza, chkadd_On_Two, 0.50) +
                getAddOnPrice(chkPizza, chkAdd_On_Three, 0.50);
            salad_AddOn_Price = getAddOnPrice(chkSalad, chkadd_On_OnOne, 0.25) + getAddOnPrice(chkSalad, chkadd_On_Two, 0.25) +
                getAddOnPrice(chkSalad, chkAdd_On_Three, 0.25);
        }

        //An action event for the hamburger, pizza and salad checkbox
        private void itemSelected(object sender, EventArgs e)
        {
            bool chikcHamburger = chkHamburger.Checked;
            CheckBox button = (CheckBox)sender;
            value = button.Text;
            hamburger = getMainCoursePrice(chkHamburger, 6.95);
            pizza = getMainCoursePrice(chkPizza, 5.95);
            salad = getMainCoursePrice(chkSalad, 4.95);
            //Set the UIs to not visible
            setVisibilityUIs(false, false, false);
            //Uncheck various UIs if they are checked
            unCheckCheckBox();
            //set the Various UIs string to empty string
            setVisibleUIs("", "", "", "");


            //Setting the various checkbox add-Ons controls if the check hamburger, pizza or salad.
            if (chkHamburger.Checked)
            {
                //Setting the string value of various UIs using the setVisibleUIs method
                setVisibleUIs("Lettuce, tomato, and onions", "Mayonnaise and mustard", "French fries", "Add-on items $.75/each");
                setVisibilityUIs();//setting the visibility of the UIs using the setVisibilityUIs method
            }

           
            //If Pizza checkbox is checked set the string of each UIs controls
            if (chkPizza.Checked)
            {

                setVisibleUIs(" Pepperoni", "Sausage", " Olives", "Add-on items $.50/each");
                setVisibilityUIs();
            }
                       
            //If the salad checkbox is clicked display the UIs and set its visibility
            if (chkSalad.Checked)
            {
                setVisibleUIs("Croutons", "Bacon bits", " Bread sticks", "Add-on items $.25/each");
                setVisibilityUIs();
            }         
          }
        //A method that gets the total tax of the items being purchaseed
        private double getTax(double number, double taxNumber)
        {
            return number * taxNumber;
        }
        //A method that set the text of the various UIs.
        private void setVisibleUIs(String addOnOne, String addOnTwo, String addOnThree, String groupBoxHeader)
        {

            chkadd_On_OnOne.Text = addOnOne;
            chkadd_On_Two.Text = addOnTwo;
            chkAdd_On_Three.Text = addOnThree;
            grpBoxText.Text = groupBoxHeader;
            
        }
        //A Method that sets the visibility of various add-on check box
        private void setVisibilityUIs(bool a = true, bool b = true, bool c= true)
        {
            chkadd_On_OnOne.Visible = a;
            chkadd_On_Two.Visible = b;
            chkAdd_On_Three.Visible = c;
        }
        //A method tha clears the sub-Total, tax and order Total text box
        private void clear()
        {
            lblOrderTotal.Text = "";
            lblSubTotal.Text = "";
            lblTax.Text = "";
                     
        }
        //A Method that clears the various controls and variables when the new order button is clicked
        private void newOrders_Click(object sender, EventArgs e)
        {
            lblOrderTotal.Text = "";
            lblSubTotal.Text = "";
            lblTax.Text = "";
            lboxOrderSummary.Items.Clear();
            //Set the UIs to not visible
            setVisibilityUIs(false, false, false);
            //Uncheck various UIs if they are checked
            unCheckCheckBox();
            //set the Various UIs string to empty string
            setVisibleUIs("", "", "", "");
            hamburger = 0;
            pizza = 0;
            salad = 0;
            hamburgerAdd_On_Price = 0;
            pizzaAdd_On_Price = 0;
            salad_AddOn_Price = 0;
            unCheckCheckBox();
            unCheckMainCourse();
            

        }

        //A method that changes the fonts of the listbox text. Extra features added by me
        private void btnTexFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lboxOrderSummary.Font = fontDialog1.Font;
            }
        }
        //A method that exits the form when the yes button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //A method that return the add-0ns item price when  both checkboxes are checked, return zero if non are checked
        private double getAddOnPrice(CheckBox checkbox1, CheckBox checkBox2, double price) 
        {
            if (checkbox1.Checked && checkBox2.Checked == false)
            {
                return 0;
            }
            if (checkbox1.Checked && checkBox2.Checked)
            {
                return price;
            }
            return 0;
        }
        //A method that get the main course item price, return zero when non is clicked
        private double getMainCoursePrice(CheckBox checkBox, double price)
        {
            if (checkBox.Checked == false)
            {
                return 0;
            }
            if (checkBox.Checked)
            {

                return price;
            }
            return 0;

        }
        //A method that unchecks the mainCourse of the menu
        private void unCheckMainCourse(bool a = false, bool b = false, bool c = false)
        {
            chkHamburger.Checked = a;
            chkPizza.Checked = b;
            chkSalad.Checked = c;
        }
        //A method that unchecks the checkbox of the add on items
        private void unCheckCheckBox(bool a = false, bool b = false, bool c = false)

        {
                chkadd_On_OnOne.Checked = a;
                chkadd_On_Two.Checked = b;
                chkAdd_On_Three.Checked = c;
                   
        }

        //An Event handler that calculates the subtotal, tax and order total when clicked. Returns zeor if non of the checkboxs are clicked
        private void placeOrder_Click(object sender, EventArgs e)
        {
            clear();
           //Calculating of the total order when the placeOder button is clicked
            double totalOrder = hamburger + pizza + salad + hamburgerAdd_On_Price + pizzaAdd_On_Price + salad_AddOn_Price;
            //If the user didn't select any main course, prompt the user to make a selection
            if (totalOrder == 0)
            {
                DialogResult result = MessageBox.Show("Please make a valid Main Course selection", "Error Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    clear();
                }
            }
            else if (totalOrder > 0)
            {
                //Setting of the various calculated amount in the listOrderSummary listbox
                //Calculating the total tax by using the getTax method
                lblTax.Text = getTax(totalOrder, 0.0770).ToString("c2");
                //Setting the subtal total in the sub total label
                lblSubTotal.Text = (totalOrder.ToString("c2"));
                //Calculating and setting the order total amount in the order total label
                lblOrderTotal.Text = (totalOrder + getTax(totalOrder, 0.0770)).ToString("c2");
                //Adding the various calculated amount to the lisb-box
                lboxOrderSummary.Items.Add(lblSubTo.Text + " " + lblSubTotal.Text);
                lboxOrderSummary.Items.Add(lbltX.Text + " " + lblTax.Text);
                lboxOrderSummary.Items.Add(lblOrToal.Text + " " + lblOrderTotal.Text);
                lboxOrderSummary.Items.Add("");
                lboxOrderSummary.Items.Add("***************************************");
            }

                      
        }
                        
    }
}
